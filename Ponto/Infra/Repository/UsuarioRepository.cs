using Dapper;
using Ponto.Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Infra.Repository
{
    public class UsuarioRepository : RepositoryBase
    {
        public UsuarioRepository(IRepositoryBase pRepositoryBase) : base(pRepositoryBase)
        {
        }

        public bool RetornarSeUsuarioFoiEncontrado(string pSenha)
        {
            string SQL = "SELECT * FROM Usuario where Codigo = " + pSenha;

            var Dados = _CN.Query<UsuarioViewModel>(SQL, null, _Trans).SingleOrDefault();

            if (Dados == null)
                return false;
            else
                return true;
        }

        public UsuarioViewModel RetornarDadosUsuario(string Codigo)
        {
            string SQL = "SELECT * FROM Usuario where Codigo = " + Codigo;

            var Dados = _CN.Query<UsuarioViewModel>(SQL, null, _Trans).SingleOrDefault();

            return Dados;
        }

        public UsuarioViewModel RetornarDadosUsuarioPeloNome(string pNome)
        {
            string SQL = "SELECT * FROM Usuario where Nome = " + pNome;

            var Dados = _CN.Query<UsuarioViewModel>(SQL, null, _Trans).SingleOrDefault();

            return Dados;
        }

        public List<UsuarioBuscaViewModel> RetornarUsuariosParaBusca(string pBusca)
        {
            var SQL = "SELECT * FROM Usuario ORDER BY Id";

            var data = Ambiente.CN.Query<UsuarioBuscaViewModel>(SQL).ToList();

            return data;
        }

        public void Excluir(int pId)
        {
            string SQL = "DELETE FROM Usuario WHERE Id = " + pId;
            Ambiente.CN.Execute(SQL, SQL);
        }

        public UsuarioViewModel RetornarDadosUsuarioPorId(int pUsuarioId)
        {
            var SQL = "Select * FROM Usuario WHERE Id = @Id";

            var data = Ambiente.CN.Query<UsuarioViewModel>(SQL.ToString(), new { Id = pUsuarioId }).SingleOrDefault();

            return data;
        }

        public void IncluirAlterarUsuario(UsuarioViewModel pUsuario)
        {
            if (pUsuario.Id == 0)
            {
                pUsuario.Id = ObterProximo("Id", "Usuario");
                pUsuario.Codigo = ObterProximo("Codigo", "Usuario");

                string SQL = "INSERT INTO Usuario (Id, Codigo, Senha, Nome, Justificativa, Ativo, DataAdmissao, Funcao, CTPS, Entrada, Saida, EntradaAlmoco, SaidaAlmoco) VALUES " +
                                "(@Id, @Codigo, '123', @Nome, null, @Ativo, @DataAdmissao, @Funcao, @CTPS, @Entrada, @Saida, @EntradaAlmoco, @SaidaAlmoco)";
                Ambiente.CN.Execute(SQL, pUsuario);
            }
            else
            {
                string SQL = "UPDATE Usuario SET Nome = @Nome, Ativo = @Ativo, DataAdmissao = @DataAdmissao, Funcao = @Funcao, CTPS = @CTPS, Entrada = @Entrada, Saida = @Saida, " +
                                "EntradaAlmoco = @EntradaAlmoco, SaidaAlmoco = @SaidaAlmoco WHERE Id = @Id";
                Ambiente.CN.Execute(SQL, pUsuario);
            }
        }

        public bool RetornarSeSenhaExiste(string pSenha)
        {
            var SQL = "Select * FROM Senha WHERE Senha = @Senha";

            var data = Ambiente.CN.Query<bool>(SQL.ToString(), new { Senha = pSenha }).SingleOrDefault();

            return data;
        }

        public List<UsuarioViewModel> ConsultarUsuarios()
        {
            string SQL = "SELECT * FROM Usuario ORDER By Nome";

            var Data = Ambiente.CN.Query<UsuarioViewModel>(SQL).ToList();

            return Data;
        }

        public List<UsuarioViewModel> RetornarFuncionarioParaCombo(bool pSelecione = true)
        {
            var SQL = "SELECT * FROM Usuario WHERE Ativo = 1 ORDER BY Nome";

            var data = Ambiente.CN.Query<UsuarioViewModel>(SQL.ToString(), new { Id = pSelecione }).ToList();

            if (pSelecione)
                data.Insert(0, new UsuarioViewModel() { Id = 0, Nome = "Selecione...", Ativo = true });

            return data;
        }

        public string RetornarNomeMaquina()
        {
            return Environment.MachineName;
        }

        public string RetonarIP()
        {
            IPAddress[] IP = Dns.GetHostAddresses(Dns.GetHostName());
            return IP[1].ToString();
        }
    }
}