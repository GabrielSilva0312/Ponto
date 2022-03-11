using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Infra.ViewModel
{
    public class Ambiente
    {
        public static MySqlTransaction Trans;
        protected MySqlTransaction _Trans = Ambiente.Trans;
        protected MySqlConnection _CN;

        public DateTime RetornarHoraServidor()
        {
            string SQL = "SELECT CURRENT_TIMESTAMP AS Hora";
            DateTime Hora = _CN.Query<DateTime>(SQL.ToString(), null, _Trans).SingleOrDefault();

            return Hora;
        }
    }
}