using MySql.Data.MySqlClient;
using Ponto.Infra;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto
{
    internal static class Program
    {
        private static Mutex mutex = new Mutex(true, "{82504e81-2875-4a43-8735-81c79e820213}");

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            const string appName = "Ponto";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("O programa já está sendo executado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string ArquivoCfg = "BD.CFG";
            if (!File.Exists(ArquivoCfg))
            {
                MessageBox.Show("Arquivo de configuração não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string ConnectionString = File.ReadAllLines(ArquivoCfg)[0];

                Ambiente.ConnectionStringBD = ConnectionString;
            }
            catch
            {
                MessageBox.Show("Falha na leitura do arquivo de configuração", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Ambiente.TestarConexao();
            }
            catch (Exception pEx)
            {
                MessageBox.Show(pEx.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.Run(new LancamentoDePonto());
        }
    }
}