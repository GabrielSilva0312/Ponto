using Ponto.Infra;
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
    public partial class FrmSenha : Form
    {
        public bool LoginOK { get; set; }

        public FrmSenha()
        {
            InitializeComponent();
        }

        private void FrmSenha_Load(object sender, EventArgs e)
        {
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            using (var Serv = new AppServiceFactory())
            {
                LoginOK = Serv.UsuarioRep().RetornarSeSenhaExiste(txtSenha.Text);

                var Validacao = new List<string>();

                if (!LoginOK)
                {
                    MessageBox.Show("Senha Incorreta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    Close();
                    new FrmRelatorio().ShowDialog();
                }
            }
        }

        private void FrmSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdConfirmar.PerformClick();
            }
        }
    }
}