using Ponto.Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Infra.Repository
{
    public class UsuarioRepository
    {
        public bool RetornarSeUsuarioFoiEncontrado(string pSenha)
        {
            string SQL = "SELECT * FROM Usuario where Codigo = " + pSenha;

            var Dados = Ambiente.CN.Query<UsuarioViewModel>(SQL).SingleOrDefault();

            if (Dados == null)
                return false;
            else
                return true;
        }

        public UsuarioViewModel RetornarDadosUsuario(string Codigo)
        {
            //string SQL = "SELECT * FROM Usuario where Codigo = '" + pCodigo.Codigo + "'";
            string SQL = "SELECT * FROM Usuario where Codigo = " + Codigo;

            var Dados = Ambiente.CN.Query<UsuarioViewModel>(SQL).SingleOrDefault();

            return Dados;
        }
    }
}