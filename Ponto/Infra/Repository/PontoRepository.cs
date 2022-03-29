using Dapper;
using Ponto.Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Infra.Repository
{
    public class PontoRepository : RepositoryBase
    {
        public PontoRepository(IRepositoryBase pRepositoryBase) : base(pRepositoryBase)
        {
        }

        public DateTime RetonarHoraServidor()
        {
            string SQL = "SELECT CURRENT_TIMESTAMP AS Hora";
            var Hora = _CN.Query<DateTime>(SQL, null, _Trans).SingleOrDefault();

            return Hora;
        }

        public PontoViewModel RetornarSeJaFoiLancado(string Codigo)
        {
            var DadosUsuario = new UsuarioRepository(this).RetornarDadosUsuario(Codigo);

            string SQL = "SELECT * FROM Ponto WHERE UsuarioId = @Codigo AND DATE(DataEntrada) = @DataEntrada";

            var data = _CN.Query<PontoViewModel>(SQL, new { Codigo = DadosUsuario.Id, DataEntrada = DateTime.Now.Date }).SingleOrDefault();

            return data;
        }

        public void LancarPonto(string pCodigo, string pJustificativa)
        {
            var DadosUsuario = new UsuarioRepository(this).RetornarDadosUsuario(pCodigo.ToString());
            var DadosPonto = new PontoRepository(this).RetornarSeJaFoiLancado(pCodigo.ToString());

            if (DadosPonto == null)
            {
                string SQL = "INSERT INTO Ponto (Nome, UsuarioId, DataEntrada, DataSaidaAlmoco, DataEntradaAlmoco, DataSaida, " +
                    "JustificativaEntrada, JustificativaSaidaAlmoco, JustificativaEntradaAlmoco, JustificativaSaida, NomeMaquina, IP)" +
                    " VALUES (@Nome, @UsuarioId, CURRENT_TIMESTAMP, @DataSaidaAlmoco, @DataEntradaAlmoco, @DataSaida, " +
                    "@JustificativaEntrada, @JustificativaSaidaAlmoco, @JustificativaEntradaAlmoco, @JustificativaSaida, @NomeMaquina, @IP)";

                var Dadosponto = new PontoViewModel();

                Dadosponto.UsuarioId = DadosUsuario.Id;
                Dadosponto.Nome = DadosUsuario.Nome;
                //Dadosponto.Ip = Util.RetonarIP();
                //Dadosponto.NomeMaquina = Util.RetornarNomeMaquina();
                Dadosponto.DataEntrada = RetonarHoraServidor();
                Dadosponto.DataSaidaAlmoco = Dadosponto.DataSaidaAlmoco;
                Dadosponto.DataEntradaAlmoco = Dadosponto.DataEntradaAlmoco;
                Dadosponto.DataSaida = Dadosponto.DataSaida;
                Dadosponto.JustificativaEntrada = pJustificativa;
                Dadosponto.JustificativaEntradaAlmoco = Dadosponto.JustificativaSaidaAlmoco;
                Dadosponto.JustificativaEntradaAlmoco = Dadosponto.JustificativaEntradaAlmoco;
                Dadosponto.JustificativaSaida = Dadosponto.JustificativaSaida;

                Ambiente.CN.Execute(SQL, Dadosponto);
            }

            if (DadosPonto != null && DadosPonto.DataSaidaAlmoco == null)
            {
                string SQL = "UPDATE Ponto SET DataSaidaAlmoco = CURRENT_TIMESTAMP, JustificativaSaidaAlmoco = @JustificativaSaidaAlmoco " +
                              "WHERE Id = @Id";

                DateTime HoraAtualServidor = this.RetonarHoraServidor();

                Ambiente.CN.Execute(SQL, new { DataSaidaAlmoco = HoraAtualServidor, JustificativaSaidaAlmoco = pJustificativa, Id = DadosPonto.Id });
            }

            if (DadosPonto != null && DadosPonto.DataSaidaAlmoco != null && DadosPonto.DataEntradaAlmoco == null)
            {
                string SQL = "UPDATE Ponto SET DataEntradaAlmoco = CURRENT_TIMESTAMP, JustificativaEntradaAlmoco = @JustificativaEntradaAlmoco " +
                              "WHERE Id = @Id";

                DateTime HoraAtualServidor = this.RetonarHoraServidor();

                Ambiente.CN.Execute(SQL, new { DataEntradaAlmoco = HoraAtualServidor, JustificativaEntradaAlmoco = pJustificativa, Id = DadosPonto.Id });
            }

            if (DadosPonto != null && DadosPonto.DataSaidaAlmoco != null && DadosPonto.DataEntradaAlmoco != null && DadosPonto.DataSaida == null)
            {
                string SQL = "UPDATE Ponto SET DataSaida = CURRENT_TIMESTAMP, JustificativaSaida = @JustificativaSaida " +
                              "WHERE Id = @Id";

                DateTime HoraAtualServidor = this.RetonarHoraServidor();

                Ambiente.CN.Execute(SQL, new { DataSaida = HoraAtualServidor, JustificativaSaida = pJustificativa, Id = DadosPonto.Id });
            }
        }

        public List<PontoViewModel> RetornarLancamentoPonto(PontoViewModel pDados)
        {
            var SQL = "SELECT * FROM Ponto WHERE DATE(DataEntrada) BETWEEN @DataInicial AND @DataFinal";

            if (!string.IsNullOrWhiteSpace(pDados.Nome))
                SQL += " AND Nome = @Nome";

            var Data = Ambiente.CN.Query<PontoViewModel>(SQL, new { DataInicial = pDados.DataInicial.Date, DataFinal = pDados.DataFinal.Date, Nome = pDados.Nome }).ToList();

            return Data;
        }

        public List<PontoImpressaoViewModel> RetornarLancamentoPontoRelatorio(int pAno, int pMes)
        {
            var SQL = "SELECT * FROM Ponto P INNER JOIN Usuario U ON U.Id = P.UsuarioId WHERE YEAR(P.DataEntrada) = @Ano AND MONTH(P.DataEntrada) = @Mes " +
                " ORDER BY P.UsuarioId, P.DataEntrada";

            var Retorno = new List<PontoImpressaoViewModel>();

            int DiasMes = DateTime.DaysInMonth(pAno, pMes);

            var Data = Ambiente.CN.Query<PontoImpressaoViewModel>(SQL, new { Ano = pAno, Mes = pMes }).ToList();

            var ListaUsuarios = Data.Select(d => d.UsuarioId).Distinct().ToList();

            var PrimeiroDiaMes = new DateTime(pAno, pMes, 1);
            var UltimoDiaMes = PrimeiroDiaMes.AddMonths(1).AddDays(-1);

            foreach (var IdUsuario in ListaUsuarios)
            {
                var ListaPonto = Data.Where(d => d.UsuarioId == IdUsuario).ToList();
                var DadosUsuarioPonto = new UsuarioRepository(this).RetornarDadosUsuarioPorId(IdUsuario);

                for (int I = 1; I <= DiasMes; I++)
                {
                    var DadosDiaPontoLancado = ListaPonto.Where(d => d.DataEntrada.Day == I).SingleOrDefault();
                    if (DadosDiaPontoLancado == null)
                        DadosDiaPontoLancado = new ViewModel.PontoImpressaoViewModel()
                        {
                            DataEntrada = new DateTime(pAno, pMes, I),
                            UsuarioId = IdUsuario,
                            Codigo = DadosUsuarioPonto.Codigo.ToString(),
                            Nome = DadosUsuarioPonto.Nome,
                            Funcao = DadosUsuarioPonto.Funcao,
                            DataAdmissao = DadosUsuarioPonto.DataAdmissao,
                            CTPS = DadosUsuarioPonto.CTPS,
                            Entrada = DadosUsuarioPonto.Entrada,
                            Saida = DadosUsuarioPonto.Saida,
                            EntradaAlmoco = DadosUsuarioPonto.EntradaAlmoco,
                            SaidaAlmoco = DadosUsuarioPonto.SaidaAlmoco
                        };

                    DadosDiaPontoLancado.DataInicial = PrimeiroDiaMes;
                    DadosDiaPontoLancado.DataFinal = UltimoDiaMes;

                    Retorno.Add(DadosDiaPontoLancado);
                }
            }
            return Retorno;
        }

        public PontoViewModel RetornarDadosPonto(PontoViewModel pDados)
        {
            var SQL = "SELECT * FROM Ponto WHERE Id = @Id";

            var Data = Ambiente.CN.Query<PontoViewModel>(SQL, new { Id = pDados.Id }).SingleOrDefault();

            return Data;
        }
    }
}