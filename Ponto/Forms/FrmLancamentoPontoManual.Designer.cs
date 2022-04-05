namespace Ponto.Forms
{
    partial class FrmLancamentoPontoManual
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFuncionarios = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtDataLancamento = new System.Windows.Forms.DateTimePicker();
            this.grpJornadaDeTrabalho = new System.Windows.Forms.GroupBox();
            this.grpAlmoco = new System.Windows.Forms.GroupBox();
            this.lblSaidaAlmoco = new System.Windows.Forms.Label();
            this.txtHoraSaidaAlmoco = new System.Windows.Forms.MaskedTextBox();
            this.lblEntradaAlmoco = new System.Windows.Forms.Label();
            this.txtHoraEntradaAlmoco = new System.Windows.Forms.MaskedTextBox();
            this.grpEntradaSaida = new System.Windows.Forms.GroupBox();
            this.lblSaida = new System.Windows.Forms.Label();
            this.txtHoraSaida = new System.Windows.Forms.MaskedTextBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.cmdConfirmar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpJornadaDeTrabalho.SuspendLayout();
            this.grpAlmoco.SuspendLayout();
            this.grpEntradaSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFuncionarios);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.txtDataLancamento);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informeções do Funcionário:";
            // 
            // cmbFuncionarios
            // 
            this.cmbFuncionarios.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFuncionarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncionarios.FormattingEnabled = true;
            this.cmbFuncionarios.Location = new System.Drawing.Point(23, 50);
            this.cmbFuncionarios.Name = "cmbFuncionarios";
            this.cmbFuncionarios.Size = new System.Drawing.Size(326, 24);
            this.cmbFuncionarios.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(19, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(381, 27);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(141, 20);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data Lançamento:";
            // 
            // txtDataLancamento
            // 
            this.txtDataLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataLancamento.Location = new System.Drawing.Point(385, 50);
            this.txtDataLancamento.Name = "txtDataLancamento";
            this.txtDataLancamento.Size = new System.Drawing.Size(138, 26);
            this.txtDataLancamento.TabIndex = 3;
            // 
            // grpJornadaDeTrabalho
            // 
            this.grpJornadaDeTrabalho.Controls.Add(this.grpAlmoco);
            this.grpJornadaDeTrabalho.Controls.Add(this.grpEntradaSaida);
            this.grpJornadaDeTrabalho.Location = new System.Drawing.Point(9, 123);
            this.grpJornadaDeTrabalho.Name = "grpJornadaDeTrabalho";
            this.grpJornadaDeTrabalho.Size = new System.Drawing.Size(632, 135);
            this.grpJornadaDeTrabalho.TabIndex = 1;
            this.grpJornadaDeTrabalho.TabStop = false;
            this.grpJornadaDeTrabalho.Text = "Lançamentos:";
            // 
            // grpAlmoco
            // 
            this.grpAlmoco.Controls.Add(this.lblSaidaAlmoco);
            this.grpAlmoco.Controls.Add(this.txtHoraSaidaAlmoco);
            this.grpAlmoco.Controls.Add(this.lblEntradaAlmoco);
            this.grpAlmoco.Controls.Add(this.txtHoraEntradaAlmoco);
            this.grpAlmoco.Location = new System.Drawing.Point(321, 19);
            this.grpAlmoco.Name = "grpAlmoco";
            this.grpAlmoco.Size = new System.Drawing.Size(301, 102);
            this.grpAlmoco.TabIndex = 1;
            this.grpAlmoco.TabStop = false;
            this.grpAlmoco.Text = "Almoço:";
            // 
            // lblSaidaAlmoco
            // 
            this.lblSaidaAlmoco.AutoSize = true;
            this.lblSaidaAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaidaAlmoco.Location = new System.Drawing.Point(158, 32);
            this.lblSaidaAlmoco.Name = "lblSaidaAlmoco";
            this.lblSaidaAlmoco.Size = new System.Drawing.Size(38, 20);
            this.lblSaidaAlmoco.TabIndex = 2;
            this.lblSaidaAlmoco.Text = "Até:";
            // 
            // txtHoraSaidaAlmoco
            // 
            this.txtHoraSaidaAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraSaidaAlmoco.Location = new System.Drawing.Point(162, 55);
            this.txtHoraSaidaAlmoco.Mask = "00:00";
            this.txtHoraSaidaAlmoco.Name = "txtHoraSaidaAlmoco";
            this.txtHoraSaidaAlmoco.Size = new System.Drawing.Size(117, 26);
            this.txtHoraSaidaAlmoco.TabIndex = 3;
            this.txtHoraSaidaAlmoco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoraSaidaAlmoco.ValidatingType = typeof(System.DateTime);
            // 
            // lblEntradaAlmoco
            // 
            this.lblEntradaAlmoco.AutoSize = true;
            this.lblEntradaAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaAlmoco.Location = new System.Drawing.Point(10, 32);
            this.lblEntradaAlmoco.Name = "lblEntradaAlmoco";
            this.lblEntradaAlmoco.Size = new System.Drawing.Size(34, 20);
            this.lblEntradaAlmoco.TabIndex = 0;
            this.lblEntradaAlmoco.Text = "De:";
            // 
            // txtHoraEntradaAlmoco
            // 
            this.txtHoraEntradaAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraEntradaAlmoco.Location = new System.Drawing.Point(14, 55);
            this.txtHoraEntradaAlmoco.Mask = "00:00";
            this.txtHoraEntradaAlmoco.Name = "txtHoraEntradaAlmoco";
            this.txtHoraEntradaAlmoco.Size = new System.Drawing.Size(117, 26);
            this.txtHoraEntradaAlmoco.TabIndex = 1;
            this.txtHoraEntradaAlmoco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoraEntradaAlmoco.ValidatingType = typeof(System.DateTime);
            // 
            // grpEntradaSaida
            // 
            this.grpEntradaSaida.Controls.Add(this.lblSaida);
            this.grpEntradaSaida.Controls.Add(this.txtHoraSaida);
            this.grpEntradaSaida.Controls.Add(this.lblEntrada);
            this.grpEntradaSaida.Controls.Add(this.txtHoraEntrada);
            this.grpEntradaSaida.Location = new System.Drawing.Point(14, 19);
            this.grpEntradaSaida.Name = "grpEntradaSaida";
            this.grpEntradaSaida.Size = new System.Drawing.Size(301, 102);
            this.grpEntradaSaida.TabIndex = 0;
            this.grpEntradaSaida.TabStop = false;
            this.grpEntradaSaida.Text = "Entrada e Saída:";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.Location = new System.Drawing.Point(158, 32);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(54, 20);
            this.lblSaida.TabIndex = 2;
            this.lblSaida.Text = "Saída:";
            // 
            // txtHoraSaida
            // 
            this.txtHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraSaida.Location = new System.Drawing.Point(162, 55);
            this.txtHoraSaida.Mask = "00:00";
            this.txtHoraSaida.Name = "txtHoraSaida";
            this.txtHoraSaida.Size = new System.Drawing.Size(117, 26);
            this.txtHoraSaida.TabIndex = 3;
            this.txtHoraSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoraSaida.ValidatingType = typeof(System.DateTime);
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(10, 32);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(70, 20);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Entrada:";
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraEntrada.Location = new System.Drawing.Point(14, 55);
            this.txtHoraEntrada.Mask = "00:00";
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(117, 26);
            this.txtHoraEntrada.TabIndex = 1;
            this.txtHoraEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoraEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfirmar.Location = new System.Drawing.Point(141, 275);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(110, 28);
            this.cmdConfirmar.TabIndex = 2;
            this.cmdConfirmar.Text = "Confirmar";
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSair.Location = new System.Drawing.Point(386, 275);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(110, 28);
            this.cmdSair.TabIndex = 3;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            // 
            // FrmLancamentoPontoManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpJornadaDeTrabalho);
            this.Controls.Add(this.cmdConfirmar);
            this.Controls.Add(this.cmdSair);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLancamentoPontoManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento Manual";
            this.Load += new System.EventHandler(this.FrmLancamentoPontoManual_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpJornadaDeTrabalho.ResumeLayout(false);
            this.grpAlmoco.ResumeLayout(false);
            this.grpAlmoco.PerformLayout();
            this.grpEntradaSaida.ResumeLayout(false);
            this.grpEntradaSaida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFuncionarios;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker txtDataLancamento;
        private System.Windows.Forms.GroupBox grpJornadaDeTrabalho;
        private System.Windows.Forms.GroupBox grpAlmoco;
        private System.Windows.Forms.Label lblSaidaAlmoco;
        private System.Windows.Forms.MaskedTextBox txtHoraSaidaAlmoco;
        private System.Windows.Forms.Label lblEntradaAlmoco;
        private System.Windows.Forms.MaskedTextBox txtHoraEntradaAlmoco;
        private System.Windows.Forms.GroupBox grpEntradaSaida;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.MaskedTextBox txtHoraSaida;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.MaskedTextBox txtHoraEntrada;
        private System.Windows.Forms.Button cmdConfirmar;
        private System.Windows.Forms.Button cmdSair;
    }
}