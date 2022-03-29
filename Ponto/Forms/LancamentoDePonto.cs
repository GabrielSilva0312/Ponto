using Ponto.Forms;
using Ponto.Infra;
using Ponto.Infra.Repository;
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

namespace Ponto
{
    public partial class LancamentoDePonto : Form
    {
        public LancamentoDePonto()
        {
            InitializeComponent();
        }

        private void LancamentoDePonto_Load(object sender, EventArgs e)
        {
            txtSenha.Focus();
        }

        private void LancamentoDePonto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                using (var Serv = new AppServiceFactory())
                {
                    if (e.KeyCode == Keys.Escape)
                        Close();

                    if (e.KeyCode == Keys.F2)
                        new FrmCadastroDeColaborador().ShowDialog();

                    if (e.KeyCode == Keys.Enter)
                    {
                        string Senha = txtSenha.Text.Trim();
                        var Nome = txtNome.Text.Trim();
                        var Justificativa = txtJustificativaEntrada.Text.Trim();
                        DateTime Data = DateTime.Now;

                        if (string.IsNullOrWhiteSpace(Senha))
                        {
                            MessageBox.Show("Informe a Senha");
                            return;
                        }

                        bool UsuarioEncotrado = Serv.UsuarioRep().RetornarSeUsuarioFoiEncontrado(Senha);

                        if (UsuarioEncotrado == false)
                        {
                            MessageBox.Show("Usuário não Encontrado", "Aviso");
                            LimparCampos();
                            txtSenha.Focus();
                            return;
                        }
                        else
                        {
                            var DadosUsuario = Serv.UsuarioRep().RetornarDadosUsuario(Senha);
                            txtNome.Text = DadosUsuario.Nome;
                        }

                        if (UsuarioEncotrado == true)
                        {
                            if (!UsuarioEncotrado)
                            {
                                HabilitarCamposEntrada(true);
                                txtJustificativaEntrada.Focus();
                                return;
                            }

                            var DadosPonto = Serv.PontoRep().RetornarSeJaFoiLancado(Senha);

                            if (DadosPonto == null)
                            {
                                HabilitarCamposEntrada(true);
                                txtJustificativaEntrada.Focus();
                                DateTime HoraAtualServidor = Serv.PontoRep().RetonarHoraServidor();
                                DataEntrada.Text = HoraAtualServidor.ToString("HH:mm");
                                return;
                            }

                            if (UsuarioEncotrado && DadosPonto != null && DadosPonto.DataSaidaAlmoco == null)
                            {
                                txtJustificativaEntrada.Text = DadosPonto.JustificativaEntrada;
                                DataEntrada.Text = DadosPonto.DataEntrada.ToString("HH:mm");
                                HabilitarCamposSaidaAlmoco(true);
                                txtJustificativaSaidaAlmoco.Focus();
                                DateTime HoraAtualServidor = Serv.PontoRep().RetonarHoraServidor();
                                DataSaidaAlmoco.Text = HoraAtualServidor.ToString("HH:mm");
                                return;
                            }
                            else if (UsuarioEncotrado && DadosPonto != null && DadosPonto.DataSaidaAlmoco != null && DadosPonto.DataEntradaAlmoco == null)
                            {
                                txtJustificativaEntrada.Text = DadosPonto.JustificativaEntrada;
                                txtJustificativaSaidaAlmoco.Text = DadosPonto.JustificativaSaidaAlmoco;
                                DataEntrada.Text = DadosPonto.DataEntrada.ToString("HH:mm");
                                DataSaidaAlmoco.Text = DadosPonto.DataSaidaAlmoco.Value.ToString("HH:mm");
                                HabilitarCamposEntradaAlmoco(true);
                                txtJustificativaEntradaAlmoco.Focus();
                                DateTime HoraAtualServidor = Serv.PontoRep().RetonarHoraServidor();
                                DataEntradaAlmoco.Text = HoraAtualServidor.ToString("HH:mm");
                                return;
                            }
                            else if (UsuarioEncotrado && DadosPonto != null && DadosPonto.DataSaidaAlmoco != null && DadosPonto.DataEntradaAlmoco != null && DadosPonto.DataSaida == null)
                            {
                                txtJustificativaEntrada.Text = DadosPonto.JustificativaEntrada;
                                txtJustificativaSaidaAlmoco.Text = DadosPonto.JustificativaSaidaAlmoco;
                                txtJustificativaEntradaAlmoco.Text = DadosPonto.JustificativaEntradaAlmoco;
                                DataEntrada.Text = DadosPonto.DataEntrada.ToString("HH:mm");
                                DataSaidaAlmoco.Text = DadosPonto.DataSaidaAlmoco.Value.ToString("HH:mm");
                                DataEntradaAlmoco.Text = DadosPonto.DataEntradaAlmoco.Value.ToString("HH:mm");
                                HabilitarCamposSaida(true);
                                txtJustificativaSaida.Focus();
                                DateTime HoraAtualServidor = Serv.PontoRep().RetonarHoraServidor();
                                DataSaida.Text = HoraAtualServidor.ToString("HH:mm");
                                return;
                            }
                            else
                            {
                                txtJustificativaEntrada.Text = DadosPonto.JustificativaEntrada;
                                txtJustificativaSaidaAlmoco.Text = DadosPonto.JustificativaSaidaAlmoco;
                                txtJustificativaEntradaAlmoco.Text = DadosPonto.JustificativaEntradaAlmoco;
                                txtJustificativaSaida.Text = DadosPonto.JustificativaSaida;
                                DataEntrada.Text = DadosPonto.DataEntrada.ToString("HH:mm");
                                DataSaidaAlmoco.Text = DadosPonto.DataSaidaAlmoco.Value.ToString("HH:mm");
                                DataEntradaAlmoco.Text = DadosPonto.DataEntradaAlmoco.Value.ToString("HH:mm");
                                DataSaida.Text = DadosPonto.DataSaida.Value.ToString("HH:mm");
                                HabilitarCamposFinal(true);
                                MessageBox.Show("Ponto já lançado", "Aviso");
                                txtNome.Clear();
                                txtSenha.Clear();
                                txtJustificativaEntrada.Clear();
                                txtJustificativaSaidaAlmoco.Clear();
                                txtJustificativaEntradaAlmoco.Clear();
                                txtJustificativaSaida.Clear();
                                DataEntrada.Clear();
                                DataEntradaAlmoco.Clear();
                                DataSaidaAlmoco.Clear();
                                DataSaida.Clear();
                                txtSenha.Focus();
                                HabilitarCamposRetorno(true);
                                return;
                            }
                        }
                    }

                    if (e.KeyCode == Keys.F10)
                        cmdConfirmar.PerformClick();
                }
            }
            catch (Exception pEx)
            {
                MessageBox.Show("Falha ao gravar dados.\n\n" + pEx.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtJustificativaEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                LimparCampos();
                txtSenha.Focus();
            }
            if (e.KeyCode == Keys.F10 || e.KeyCode == Keys.Enter)
            {
                LancarConfirmacaoPonto();
                MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                Close();
            }
        }

        private void txtJustificativaSaidaAlmoco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                LimparCampos();
                txtSenha.Focus();
            }
            if (e.KeyCode == Keys.F10 || e.KeyCode == Keys.Enter)
            {
                LancarConfirmacaoPonto();
                MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void txtJustificativaEntradaAlmoco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                LimparCampos();
                txtSenha.Focus();
            }

            if (e.KeyCode == Keys.F10 || e.KeyCode == Keys.Enter)
            {
                LancarConfirmacaoPonto();
                MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void txtJustificativaSaida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                LimparCampos();
                txtSenha.Focus();
            }

            if (e.KeyCode == Keys.F10 || e.KeyCode == Keys.Enter)
            {
                LancarConfirmacaoPonto();
                MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void LancarConfirmacaoPonto()
        {
            try
            {
                using (var Serv = new AppServiceFactory())
                {
                    var Justificativa = new PontoViewModel();

                    string JustificativaLancada = "";

                    if (txtJustificativaEntrada.Enabled == true) JustificativaLancada = txtJustificativaEntrada.Text.Trim();
                    if (txtJustificativaEntradaAlmoco.Enabled == true) JustificativaLancada = txtJustificativaEntradaAlmoco.Text.Trim();
                    if (txtJustificativaSaida.Enabled == true) JustificativaLancada = txtJustificativaSaida.Text.Trim();
                    if (txtJustificativaSaidaAlmoco.Enabled == true) JustificativaLancada = txtJustificativaSaidaAlmoco.Text.Trim();

                    Serv.PontoRep().LancarPonto(txtSenha.Text.Trim(), JustificativaLancada);
                }
            }
            catch (Exception pEx)
            {
                MessageBox.Show("Erro na gravação: " + pEx.Message);
                return;
            }
            MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            Close();
        }

        private void LimparCampos()
        {
            txtSenha.Text = "";
            txtNome.Text = "";
            txtJustificativaEntrada.Text = "";
        }

        private void HabilitarCamposEntrada(bool pedicao)
        {
            txtSenha.Enabled = !pedicao;
            txtNome.Enabled = !pedicao;
            txtJustificativaEntrada.Enabled = pedicao;
            txtJustificativaEntradaAlmoco.Enabled = !pedicao;
            txtJustificativaSaidaAlmoco.Enabled = !pedicao;
            txtJustificativaSaida.Enabled = !pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtSenha.Focus();
        }

        private void HabilitarCamposSaidaAlmoco(bool pedicao)
        {
            txtSenha.Enabled = !pedicao;
            txtNome.Enabled = !pedicao;
            txtJustificativaEntrada.Enabled = !pedicao;
            txtJustificativaEntradaAlmoco.Enabled = !pedicao;
            txtJustificativaSaidaAlmoco.Enabled = pedicao;
            txtJustificativaSaida.Enabled = !pedicao;
            DataEntrada.Enabled = !pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtSenha.Focus();
        }

        private void HabilitarCamposEntradaAlmoco(bool pedicao)
        {
            txtSenha.Enabled = !pedicao;
            txtNome.Enabled = !pedicao;
            txtJustificativaEntrada.Enabled = !pedicao;
            txtJustificativaEntradaAlmoco.Enabled = pedicao;
            txtJustificativaSaidaAlmoco.Enabled = !pedicao;
            txtJustificativaSaida.Enabled = !pedicao;
            DataEntrada.Enabled = !pedicao;
            DataSaidaAlmoco.Enabled = !pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtSenha.Focus();
        }

        private void HabilitarCamposSaida(bool pedicao)
        {
            txtSenha.Enabled = !pedicao;
            txtNome.Enabled = !pedicao;
            txtJustificativaEntrada.Enabled = !pedicao;
            txtJustificativaEntradaAlmoco.Enabled = !pedicao;
            txtJustificativaSaidaAlmoco.Enabled = !pedicao;
            txtJustificativaSaida.Enabled = pedicao;
            DataEntrada.Enabled = !pedicao;
            DataSaidaAlmoco.Enabled = !pedicao;
            DataEntradaAlmoco.Enabled = !pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtSenha.Focus();
        }

        private void HabilitarCamposFinal(bool pedicao)
        {
            txtSenha.Enabled = !pedicao;
            txtNome.Enabled = !pedicao;
            txtJustificativaEntrada.Enabled = !pedicao;
            txtJustificativaEntradaAlmoco.Enabled = !pedicao;
            txtJustificativaSaidaAlmoco.Enabled = !pedicao;
            txtJustificativaSaida.Enabled = !pedicao;
            DataEntrada.Enabled = !pedicao;
            DataSaidaAlmoco.Enabled = !pedicao;
            DataEntradaAlmoco.Enabled = !pedicao;
            DataSaida.Enabled = !pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtSenha.Focus();
        }

        private void HabilitarCamposRetorno(bool pedicao)
        {
            txtSenha.Enabled = pedicao;
            txtNome.Enabled = !pedicao;
            txtJustificativaEntrada.Enabled = pedicao;
            txtJustificativaEntradaAlmoco.Enabled = !pedicao;
            txtJustificativaSaidaAlmoco.Enabled = !pedicao;
            txtJustificativaSaida.Enabled = !pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtSenha.Focus();
        }

        private void cmdRelatorio_Click(object sender, EventArgs e)
        {
            var Frm = new FrmSenha().ShowDialog();
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
        }
    }
}