using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Infra.ViewModel
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Justificativa { get; set; }
        public bool Ativo { get; set; }
        public string Funcao { get; set; }
        public string CTPS { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Entrada { get; set; }
        public string Saida { get; set; }
        public string EntradaAlmoco { get; set; }
        public string SaidaAlmoco { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
    }

    public class ClienteBuscaViewModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
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