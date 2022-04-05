using Ponto.Infra;
using Ponto.Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto.Forms
{
    public partial class FrmLancamentoPontoManual : Form
    {
        public FrmLancamentoPontoManual()
        {
            InitializeComponent();
        }

        private void FrmLancamentoPontoManual_Load(object sender, EventArgs e)
        {
            using (var Serv = new AppServiceFactory())
            {
                var DadosFuncionarioRep = Serv.UsuarioRep().RetornarFuncionarioParaCombo(true);

                cmbFuncionarios.DataSource = DadosFuncionarioRep;
                cmbFuncionarios.DisplayMember = "Nome";
                cmbFuncionarios.ValueMember = "Id";
            }
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            using (var Serv = new AppServiceFactory())
            {
                var EntradaManual = "";
                var SaidaManual = "";
                var EntradaAlmocoManual = "";
                var SaidaAlmocoManual = "";
                var FuncionarioId = int.Parse(cmbFuncionarios.SelectedValue.ToString());
                var NomeMaquina = Serv.UsuarioRep().RetornarNomeMaquina();
                var Ip = Serv.UsuarioRep().RetonarIP();

                if (FuncionarioId == 0)
                {
                    MessageBox.Show("Selecione o Funcionário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DateTime Aux;

                if (!DateTime.TryParse(txtHoraEntrada.Text.ToString(), out Aux))
                {
                    MessageBox.Show("Informe a Hora da Entrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!DateTime.TryParse(txtHoraSaida.Text.ToString(), out Aux))
                {
                    MessageBox.Show("Informe a Hora da Saída.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!DateTime.TryParse(txtHoraEntradaAlmoco.Text.ToString(), out Aux))
                {
                    MessageBox.Show("Informe a Hora do Almoço.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!DateTime.TryParse(txtHoraSaidaAlmoco.Text.ToString(), out Aux))
                {
                    MessageBox.Show("Informe a Hora do Almoço.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var Dados = new PontoViewModel()
                {
                    DataLancamento = Convert.ToDateTime(txtDataLancamento.Text.ToString())
                };

                EntradaManual = Dados.DataLancamento.Date.ToString("dd/MM/yy") + " " + txtHoraEntrada.Text.ToString();
                SaidaManual = Dados.DataLancamento.Date.ToString("dd/MM/yy") + " " + txtHoraSaida.Text.ToString();
                EntradaAlmocoManual = Dados.DataLancamento.Date.ToString("dd/MM/yy") + " " + txtHoraSaidaAlmoco.Text.ToString();
                SaidaAlmocoManual = Dados.DataLancamento.Date.ToString("dd/MM/yy") + " " + txtHoraEntradaAlmoco.Text.ToString();

                var DadosUsuario = Serv.UsuarioRep().RetornarDadosUsuarioPorId(FuncionarioId);

                var DadosLancamento = new PontoViewModel()
                {
                    DataEntrada = Convert.ToDateTime(EntradaManual),
                    DataSaida = Convert.ToDateTime(SaidaManual),
                    DataEntradaAlmoco = Convert.ToDateTime(EntradaAlmocoManual),
                    DataSaidaAlmoco = Convert.ToDateTime(SaidaAlmocoManual),
                    UsuarioId = FuncionarioId,
                    Nome = DadosUsuario.Nome,
                    NomeMaquina = NomeMaquina,
                    Ip = Ip
                };

                bool RetornarLancamento = Serv.PontoRep().RetornarLancamentoDePonto(FuncionarioId, DadosLancamento.DataEntrada);

                if (!RetornarLancamento)
                {
                    MessageBox.Show("Já existe lançamento para esse dia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    Serv.PontoRep().LancarPontoManual(DadosLancamento);
                }
                catch (Exception pEx)
                {
                    MessageBox.Show("Erro na gravação: " + pEx.Message);
                    return;
                }
                MessageBox.Show("Ponto Lançado com Sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}