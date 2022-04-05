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
    public partial class FrmAjustarLancamentoPonto : Form
    {
        public int CodigoRegistro { get; set; }

        public FrmAjustarLancamentoPonto()
        {
            InitializeComponent();
        }

        private void FrmAjustarLancamentoPonto_Load(object sender, EventArgs e)
        {
            using (var Serv = new AppServiceFactory())
            {
                var DadosBusca = new PontoViewModel()
                {
                    Id = CodigoRegistro
                };

                var Id = int.Parse(DadosBusca.Id.ToString());
                var DadosMov = Serv.PontoRep().RetornarDadosPonto(DadosBusca);
                var DadosUsuario = Serv.UsuarioRep().RetornarDadosUsuarioPorId(DadosMov.UsuarioId);

                txtNome.Text = DadosUsuario.Nome;
                txtDataAdmissao.Value = DadosUsuario.DataAdmissao;
                txtFuncao.Text = DadosUsuario.Funcao;
                txtCTPS.Text = DadosUsuario.CTPS;
                chkAtivo.Checked = DadosUsuario.Ativo;

                if (DadosMov.DataEntrada != null)
                {
                    txtHoraEntrada.Text = DadosMov.DataEntrada.ToString("HH:mm");
                }

                if (DadosMov.DataEntradaAlmoco != null)
                {
                    txtHoraEntradaAlmoco.Text = DadosMov.DataSaidaAlmoco.Value.ToString("HH:mm");
                }

                if (DadosMov.DataSaidaAlmoco != null)
                {
                    txtSaidaAlmoco.Text = DadosMov.DataEntradaAlmoco.Value.ToString("HH:mm");
                }

                if (DadosMov.DataSaida != null)
                {
                    txtSaida.Text = DadosMov.DataSaida.Value.ToString("HH:mm");
                }
            }
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            using (var Serv = new AppServiceFactory())
            {
                var DadosBusca = new PontoViewModel()
                {
                    Id = CodigoRegistro
                };

                var Id = int.Parse(DadosBusca.Id.ToString());
                var DadosMov = Serv.PontoRep().RetornarDadosPonto(DadosBusca);
                var HoraEntradaCorreta = "";
                var HoraSaidaAlmocoCorreta = "";
                var HoraEntradaAlmocoCorreta = "";
                var HoraSaidaCorreta = "";

                if (txtHoraEntrada.Text.ToString().Trim() == ":" || txtSaida.Text.ToString().Trim() == ":" || txtHoraEntradaAlmoco.Text.ToString().Trim() == ":" || txtSaidaAlmoco.Text.ToString().Trim() == ":")
                {
                    MessageBox.Show("Informe todas as Entradas e Saídas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (DadosMov.DataEntradaAlmoco == null)
                {
                    DadosMov.DataEntradaAlmoco = DadosMov.DataEntrada;
                }

                if (DadosMov.DataSaidaAlmoco == null)
                {
                    DadosMov.DataSaidaAlmoco = DadosMov.DataEntrada;
                }

                if (DadosMov.DataSaida == null)
                {
                    DadosMov.DataSaida = DadosMov.DataEntrada;
                }

                if (DadosMov.DataEntrada != null)
                {
                    HoraEntradaCorreta = DadosMov.DataEntrada.Date.ToString("dd/MM/yy") + " " + txtHoraEntrada.Text.ToString();
                }

                if (DadosMov.DataSaidaAlmoco != null)
                {
                    HoraSaidaAlmocoCorreta = DadosMov.DataSaidaAlmoco.Value.ToString("dd/MM/yy") + " " + txtHoraEntradaAlmoco.Text.ToString();
                }

                if (DadosMov.DataEntradaAlmoco != null)
                {
                    HoraEntradaAlmocoCorreta = DadosMov.DataEntradaAlmoco.Value.ToString("dd/MM/yy") + " " + txtSaidaAlmoco.Text.ToString();
                }

                if (DadosMov.DataSaida != null)
                {
                    HoraSaidaCorreta = DadosMov.DataSaida.Value.ToString("dd/MM/yy") + " " + txtSaida.Text.ToString();
                }

                var NovoLancamento = new PontoViewModel()
                {
                    Id = DadosMov.Id
                };

                if (!string.IsNullOrWhiteSpace(HoraEntradaCorreta)) NovoLancamento.DataEntrada = Convert.ToDateTime(HoraEntradaCorreta);
                if (!string.IsNullOrWhiteSpace(HoraSaidaAlmocoCorreta)) NovoLancamento.DataSaidaAlmoco = Convert.ToDateTime(HoraSaidaAlmocoCorreta);
                if (!string.IsNullOrWhiteSpace(HoraEntradaAlmocoCorreta)) NovoLancamento.DataEntradaAlmoco = Convert.ToDateTime(HoraEntradaAlmocoCorreta);
                if (!string.IsNullOrWhiteSpace(HoraSaidaCorreta)) NovoLancamento.DataSaida = Convert.ToDateTime(HoraSaidaCorreta);

                try
                {
                    Serv.PontoRep().AjustarPonto(NovoLancamento);
                }
                catch (Exception pEx)
                {
                    MessageBox.Show("Erro na gravação: " + pEx.Message);
                    return;
                }
                MessageBox.Show("Ponto Alterado com Sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}