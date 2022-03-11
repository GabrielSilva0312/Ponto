using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Infra.ViewModel
{
    public class PontoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaidaAlmoco { get; set; }
        public DateTime? DataEntradaAlmoco { get; set; }
        public DateTime? DataSaida { get; set; }
        public string Justificativa { get; set; }
        public string JustificativaEntrada { get; set; }
        public string JustificativaSaidaAlmoco { get; set; }
        public string JustificativaEntradaAlmoco { get; set; }
        public string JustificativaSaida { get; set; }
        public string NomeMaquina { get; set; }
        public string Ip { get; set; }
        public int UsuarioId { get; set; }
        public string Senha { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public int FuncionarioId { get; set; }
        public DateTime DataLancamento { get; set; }
    }

    public class PontoImpressaoViewModel : PontoViewModel
    {
        public int NumeroDia { get; set; }
        public string Codigo { get; set; }
        public string NomeUsuario { get; set; }
        public bool Ativo { get; set; }
        public string Funcao { get; set; }
        public string CTPS { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Entrada { get; set; }
        public string Saida { get; set; }
        public string EntradaAlmoco { get; set; }
        public string SaidaAlmoco { get; set; }
    }
}