using Dapper;
using MySql.Data.MySqlClient;
using Ponto.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Infra
{
    public class Ambiente
    {
        public static TransactionRepositoryBase TransactionRepositoryBase;
        public static MySqlConnection CN;
        public static MySqlTransaction Trans;
        public static string ConnectionStringBD;

        public static MySqlConnection ObterConexao()
        {
            if (CN == null)
            {
                CN = new MySqlConnection(ConnectionStringBD);
                try
                {
                    CN.Open();
                }
                catch (Exception pEx)
                {
                    throw new Exception("Falha na conexão com o banco de dados.\n\n" + pEx.Message);
                }
            }
            else
            {
                if (!CN.Ping())
                {
                    CN = new MySqlConnection(ConnectionStringBD);
                    CN.Open();
                }
            }

            return CN;
        }
    }
}