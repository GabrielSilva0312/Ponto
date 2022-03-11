using Ponto.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Infra
{
    public class AppServiceFactory : IDisposable
    {
        private int _IdUsuario = 0;

        private IRepositoryBase _RepositoryBase;

        public AppServiceFactory()
        {
            string Conexao = Ambiente.ConnectionStringBD;

            _RepositoryBase = new RepositoryBase(Conexao);
        }

        public void Dispose()
        {
            if (_RepositoryBase.Transacao != null)
            {
                if (_RepositoryBase.Transacao.ContTransacoes != 0)
                {
                    this.PontoRep().CancelarTransacao();
                    throw new Exception("Falha no controle de transações do banco de dados.  Procure o suporte do sistema e informe a operação que você estava executando.  Seus dados possivelmente não foram gravados.");
                }
            }
        }

        public PontoRepository PontoRep()
        {
            return new PontoRepository(_RepositoryBase);
        }

        public UsuarioRepository UsuarioRep()
        {
            return new UsuarioRepository(_RepositoryBase);
        }
    }
}