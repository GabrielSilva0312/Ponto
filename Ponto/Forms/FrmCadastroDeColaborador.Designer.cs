namespace Ponto.Forms
{
    partial class FrmCadastroDeColaborador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpColaborador = new System.Windows.Forms.Panel();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdAlterar = new System.Windows.Forms.Button();
            this.cmdIncluir = new System.Windows.Forms.Button();
            this.cmdPesquisar = new System.Windows.Forms.Button();
            this.GridColaborador = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grpColaborador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridColaborador)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 59);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Colaborador";
            // 
            // grpColaborador
            // 
            this.grpColaborador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpColaborador.Controls.Add(this.txtBusca);
            this.grpColaborador.Controls.Add(this.cmdExcluir);
            this.grpColaborador.Controls.Add(this.cmdAlterar);
            this.grpColaborador.Controls.Add(this.cmdIncluir);
            this.grpColaborador.Controls.Add(this.cmdPesquisar);
            this.grpColaborador.Controls.Add(this.GridColaborador);
            this.grpColaborador.Location = new System.Drawing.Point(3, 77);
            this.grpColaborador.Name = "grpColaborador";
            this.grpColaborador.Size = new System.Drawing.Size(490, 435);
            this.grpColaborador.TabIndex = 7;
            this.grpColaborador.TabStop = true;
            this.grpColaborador.Tag = "Colaborador";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(12, 15);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(322, 26);
            this.txtBusca.TabIndex = 7;
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcluir.Location = new System.Drawing.Point(351, 380);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(128, 34);
            this.cmdExcluir.TabIndex = 6;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdAlterar
            // 
            this.cmdAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAlterar.Location = new System.Drawing.Point(175, 380);
            this.cmdAlterar.Name = "cmdAlterar";
            this.cmdAlterar.Size = new System.Drawing.Size(128, 34);
            this.cmdAlterar.TabIndex = 5;
            this.cmdAlterar.Text = "Alterar";
            this.cmdAlterar.UseVisualStyleBackColor = true;
            this.cmdAlterar.Click += new System.EventHandler(this.cmdAlterar_Click);
            // 
            // cmdIncluir
            // 
            this.cmdIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIncluir.Location = new System.Drawing.Point(8, 380);
            this.cmdIncluir.Name = "cmdIncluir";
            this.cmdIncluir.Size = new System.Drawing.Size(128, 34);
            this.cmdIncluir.TabIndex = 4;
            this.cmdIncluir.Text = "Incluir";
            this.cmdIncluir.UseVisualStyleBackColor = true;
            this.cmdIncluir.Click += new System.EventHandler(this.cmdIncluir_Click);
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPesquisar.Location = new System.Drawing.Point(351, 12);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(128, 34);
            this.cmdPesquisar.TabIndex = 1;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.UseVisualStyleBackColor = true;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // GridColaborador
            // 
            this.GridColaborador.BackgroundColor = System.Drawing.Color.White;
            this.GridColaborador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridColaborador.Location = new System.Drawing.Point(8, 57);
            this.GridColaborador.Name = "GridColaborador";
            this.GridColaborador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridColaborador.Size = new System.Drawing.Size(473, 311);
            this.GridColaborador.TabIndex = 0;
            // 
            // FrmCadastroDeColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 529);
            this.Controls.Add(this.grpColaborador);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(521, 568);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(521, 568);
            this.Name = "FrmCadastroDeColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Colaborador";
            this.Load += new System.EventHandler(this.FrmCadastroDeColaborador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpColaborador.ResumeLayout(false);
            this.grpColaborador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridColaborador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel grpColaborador;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Button cmdAlterar;
        private System.Windows.Forms.Button cmdIncluir;
        private System.Windows.Forms.Button cmdPesquisar;
        private System.Windows.Forms.DataGridView GridColaborador;
    }
}