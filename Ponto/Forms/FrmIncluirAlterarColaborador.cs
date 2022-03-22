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
    public partial class FrmIncluirAlterarColaborador : Form
    {
        public int CodigoRegistro { get; set; }
        public string Nome { get; set; }

        public FrmIncluirAlterarColaborador()
        {
            InitializeComponent();
        }

        private void FrmIncluirAlterarColaborador_Load(object sender, EventArgs e)
        {
            CarregarDadosRegistro();
        }

        private void CarregarDadosRegistro()
        {
            using (var Serv = new AppServiceFactory())
            {
                if (CodigoRegistro == 0)
                    return;

                var Dados = Serv.UsuarioRep().RetornarDadosUsuarioPorId(CodigoRegistro);

                txtNome.Text = Dados.Nome;
                chkAtivo.Checked = Dados.Ativo;
                txtDataAdmissao.Value = Dados.DataAdmissao;
                txtFuncao.Text = Dados.Funcao;
                txtCTPS.Text = Dados.CTPS;
                txtHoraEntrada.Text = Dados.Entrada;
                txtSaida.Text = Dados.Saida;
                txtHoraEntradaAlmoco.Text = Dados.EntradaAlmoco;
                txtSaidaAlmoco.Text = Dados.SaidaAlmoco;
            }
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            using (var Serv = new AppServiceFactory())
            {
                var Validacao = new List<string>();

                if (string.IsNullOrWhiteSpace(txtNome.Text))
                    Validacao.Add("Entre com o Nome");

                if (Validacao.Count > 0)
                {
                    MessageBox.Show("Verifique os campos:\n\n-> " + string.Join("\n ->", Validacao), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var Dados = new UsuarioViewModel()
                {
                    Nome = txtNome.Text.Trim(),
                    Id = CodigoRegistro,
                    Ativo = chkAtivo.Checked,
                    DataAdmissao = txtDataAdmissao.Value,
                    Funcao = txtFuncao.Text,
                    CTPS = txtCTPS.Text,
                    Entrada = txtHoraEntrada.Text.Trim(),
                    Saida = txtSaida.Text.Trim(),
                    EntradaAlmoco = txtHoraEntradaAlmoco.Text.Trim(),
                    SaidaAlmoco = txtSaidaAlmoco.Text.Trim()
                };

                try
                {
                    Serv.UsuarioRep().IncluirAlterarUsuario(Dados);
                }
                catch (Exception pEx)
                {
                    MessageBox.Show("Falha ao gravar alterações\n\n" + pEx.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Close();
            }
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmIncluirAlterarColaborador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmdConfirmar.PerformClick();
        }
    }
}