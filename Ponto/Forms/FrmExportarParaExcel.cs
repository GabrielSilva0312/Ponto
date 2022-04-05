using Ponto.Infra;
using Ponto.Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto.Forms
{
    public partial class FrmExportarParaExcel : Form
    {
        public FrmExportarParaExcel()
        {
            InitializeComponent();
        }

        private void FrmExportarParaExcel_Load(object sender, EventArgs e)
        {
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            using (var Serv = new AppServiceFactory())
            {
                var DadosFiltro = new ExportarParaExcelViewModel()
                {
                    DataInicial = txtDataInicial.Value.Date,
                    DataFinal = txtDataFinal.Value.Date
                };

                var DadosExportacao = Serv.ExcelRep().RetornarDadosParaExportacao(DadosFiltro);

                string NomeArquivo = @"C:\" + "Exportação Ponto " + DateTime.Now.ToString("ddMMyyyy") + ".csv";

                StreamWriter writer = new StreamWriter(NomeArquivo.ToString());

                writer.WriteLine("Nome ;" + "Nome Maquina ;" + "Data Entrada ;" + "Data Saida Alomoco ;" + "Data Entrada Alomoco ;" + "Data Saida ;" + "Justificativa Entrada ;" + "Justificativa Saida Almoco ;" + "Justificativa Entrada Almoco ;" + "Justificativa Saida");

                for (int i = 0; i < DadosExportacao.Count; i++)
                {
                    writer.WriteLine(DadosExportacao[i].Nome + ";" + DadosExportacao[i].NomeMaquina + ";" + DadosExportacao[i].DataEntrada + ";" + DadosExportacao[i].DataSaidaAlmoco + ";" + DadosExportacao[i].DataEntradaAlmoco + ";" + DadosExportacao[i].DataSaida + ";" + DadosExportacao[i].JustificativaEntrada + ";" + DadosExportacao[i].JustificativaSaidaAlmoco + ";" + DadosExportacao[i].JustificativaEntradaAlmoco + ";" + DadosExportacao[i].JustificativaSaida);
                }

                writer.Flush();
                writer.Close();

                MessageBox.Show("Arquivo Exportado com Sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }
    }
}