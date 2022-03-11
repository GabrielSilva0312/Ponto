using Dapper;
using Ponto.Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}