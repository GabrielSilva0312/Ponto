using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Infra.Repository
{
    public interface IRepositoryBase
    {
        MySqlConnection ObterConexaoBD();

        TransactionRepositoryBase Transacao { get; set; }
    }

    public class TransactionRepositoryBase
    {
        public TransactionRepositoryBase()
        {
            StatusTransacaoBD = StatusTransacaoBD.Indefinido;
            ContTransacoes = 0;
        }

        public int ContTransacoes { get; set; }
        public StatusTransacaoBD StatusTransacaoBD { get; set; }
        public MySqlTransaction Trans { get; set; }
    }

    public enum StatusTransacaoBD
    {
        Iniciada,
        Confirmada,
        Cancelada,
        Indefinido
    }

    public class RepositoryBase : IRepositoryBase
    {
        protected int _IdUsuario;
        protected int _IdProjeto;

        protected MySqlConnection _CN;
        protected MySqlTransaction _Trans;
        protected TransactionRepositoryBase _TransactionRepositoryBase;

        public RepositoryBase(IRepositoryBase pRepositoryBase)
        {
            _CN = pRepositoryBase.ObterConexaoBD();

            if (pRepositoryBase.Transacao == null)
                pRepositoryBase.Transacao = new TransactionRepositoryBase();

            _TransactionRepositoryBase = pRepositoryBase.Transacao;
            _Trans = _TransactionRepositoryBase.Trans;
        }

        public RepositoryBase(string pConnectionString)
        {
            if (Ambiente.CN == null)
                _CN = ConfigurarConexao(pConnectionString);
            else
                _CN = Ambiente.CN;
        }

        public int ObterProximo(string pCampo, string pTabela)
        {
            string SQL = "SELECT coalesce(MAX(" + pCampo + "), 0) + 1 FROM " + pTabela;

            var data = _CN.Query<int>(SQL, null, _Trans).SingleOrDefault();

            return data;
        }

        public int ObterLastInsertId()
        {
            string SQL = "SELECT LAST_INSERT_ID()";

            var data = _CN.Query<int>(SQL, null, _Trans).SingleOrDefault();

            return data;
        }

        private MySqlConnection ConfigurarConexao(string pConnectionString)
        {
            if (_CN != null)
                return _CN;

            _CN = new MySqlConnection(pConnectionString);

            try
            {
                _CN.Open();
            }
            catch
            {
                try
                {
                    System.Threading.Thread.Sleep(2000);
                    _CN.Open();
                }
                catch (Exception ex2)
                {
                    throw ex2;
                }
            }

            return _CN;
        }

        public int ObterUltimoIdentity()
        {
            int NumeroAleatorio = new Random().Next(1000);

            try
            {
                var data = _CN.Query<int>("SELECT @@IDENTITY AS Campo" + NumeroAleatorio, null, _Trans).SingleOrDefault();
                return data;
            }
            catch
            {
                return -1;
            }
        }

        public void IniciarTransacao()
        {
            _TransactionRepositoryBase.ContTransacoes++;

            if (_TransactionRepositoryBase.ContTransacoes == 1)
                _Trans = null; // Forçar o NULL para 2 chamadas distintas no controller

            if (_Trans == null)
            {
                _Trans = (_CN.BeginTransaction(IsolationLevel.ReadCommitted) as MySqlTransaction);
                _TransactionRepositoryBase.StatusTransacaoBD = StatusTransacaoBD.Iniciada;
                _TransactionRepositoryBase.Trans = _Trans;
            }
        }

        public void ConfirmarTransacao()
        {
            _TransactionRepositoryBase.ContTransacoes--;

            if (_TransactionRepositoryBase.ContTransacoes == 0)
            {
                if (_Trans != null && _TransactionRepositoryBase.StatusTransacaoBD != StatusTransacaoBD.Confirmada)
                {
                    _Trans.Commit();
                    _TransactionRepositoryBase.StatusTransacaoBD = StatusTransacaoBD.Confirmada;
                }
            }
        }

        public void CancelarTransacao()
        {
            if (_Trans != null && _TransactionRepositoryBase.StatusTransacaoBD != StatusTransacaoBD.Cancelada)
            {
                if (_TransactionRepositoryBase.ContTransacoes == 0)
                    return;

                _Trans.Rollback();
                _TransactionRepositoryBase.ContTransacoes = 0;

                _TransactionRepositoryBase.StatusTransacaoBD = StatusTransacaoBD.Cancelada;
            }
        }

        public MySqlConnection ObterConexaoBD()
        {
            return Ambiente.CN;
        }

        public int IdUsuario
        {
            get { return _IdUsuario; }
        }

        private bool RetornarValorParametroBoolEmpresa(int pCodigoParametro)
        {
            string SQL = "SELECT Valor FROM Parametro (NOLOCK) WHERE Id = " + pCodigoParametro;
            string Valor = _CN.Query<string>(SQL, null, _Trans).SingleOrDefault();

            if (Valor == null)
                Valor = string.Empty;

            return Valor.Equals("1") || Valor.Equals("S");
        }

        public DateTime RetornarDataHoraServidorBD()
        {
            string SQL = "SELECT Now()";
            return _CN.Query<DateTime>(SQL, null, _Trans).SingleOrDefault();
        }

        public TransactionRepositoryBase Transacao
        {
            get
            {
                return _TransactionRepositoryBase;
            }
            set
            {
                _TransactionRepositoryBase = value;
            }
        }
    }
}