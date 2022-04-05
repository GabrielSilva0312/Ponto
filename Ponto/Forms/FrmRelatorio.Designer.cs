namespace Ponto.Forms
{
    partial class FrmRelatorio
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
            this.grpGeral = new System.Windows.Forms.GroupBox();
            this.GridLancamento = new System.Windows.Forms.DataGridView();
            this.GridUsuarios = new System.Windows.Forms.DataGridView();
            this.cmdExportarParaExcel = new System.Windows.Forms.Button();
            this.cmdRelatorio = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.cmdPesquisar = new System.Windows.Forms.Button();
            this.cmdLancamentoManual = new System.Windows.Forms.Button();
            this.cmdAjustarLancamento = new System.Windows.Forms.Button();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLancamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGeral
            // 
            this.grpGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGeral.Controls.Add(this.GridLancamento);
            this.grpGeral.Controls.Add(this.GridUsuarios);
            this.grpGeral.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpGeral.Location = new System.Drawing.Point(13, 40);
            this.grpGeral.Margin = new System.Windows.Forms.Padding(4);
            this.grpGeral.Name = "grpGeral";
            this.grpGeral.Padding = new System.Windows.Forms.Padding(4);
            this.grpGeral.Size = new System.Drawing.Size(1110, 478);
            this.grpGeral.TabIndex = 3;
            this.grpGeral.TabStop = false;
            // 
            // GridLancamento
            // 
            this.GridLancamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridLancamento.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridLancamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLancamento.Location = new System.Drawing.Point(205, 15);
            this.GridLancamento.Name = "GridLancamento";
            this.GridLancamento.Size = new System.Drawing.Size(898, 445);
            this.GridLancamento.TabIndex = 11;
            // 
            // GridUsuarios
            // 
            this.GridUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GridUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsuarios.Location = new System.Drawing.Point(7, 15);
            this.GridUsuarios.Name = "GridUsuarios";
            this.GridUsuarios.Size = new System.Drawing.Size(178, 445);
            this.GridUsuarios.TabIndex = 10;
            this.GridUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsuarios_CellClick);
            // 
            // cmdExportarParaExcel
            // 
            this.cmdExportarParaExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExportarParaExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportarParaExcel.Location = new System.Drawing.Point(377, 536);
            this.cmdExportarParaExcel.Name = "cmdExportarParaExcel";
            this.cmdExportarParaExcel.Size = new System.Drawing.Size(179, 28);
            this.cmdExportarParaExcel.TabIndex = 18;
            this.cmdExportarParaExcel.Text = "Exportar p/ Excel";
            this.cmdExportarParaExcel.UseVisualStyleBackColor = true;
            this.cmdExportarParaExcel.Click += new System.EventHandler(this.cmdExportarParaExcel_Click);
            // 
            // cmdRelatorio
            // 
            this.cmdRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRelatorio.Location = new System.Drawing.Point(47, 536);
            this.cmdRelatorio.Name = "cmdRelatorio";
            this.cmdRelatorio.Size = new System.Drawing.Size(111, 28);
            this.cmdRelatorio.TabIndex = 17;
            this.cmdRelatorio.Text = "Relatório";
            this.cmdRelatorio.UseVisualStyleBackColor = true;
            this.cmdRelatorio.Click += new System.EventHandler(this.cmdRelatorio_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSair.Location = new System.Drawing.Point(930, 536);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(105, 28);
            this.cmdSair.TabIndex = 16;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPesquisar.Location = new System.Drawing.Point(218, 536);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(111, 28);
            this.cmdPesquisar.TabIndex = 15;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.UseVisualStyleBackColor = true;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // cmdLancamentoManual
            // 
            this.cmdLancamentoManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdLancamentoManual.Enabled = false;
            this.cmdLancamentoManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLancamentoManual.Location = new System.Drawing.Point(918, 6);
            this.cmdLancamentoManual.Name = "cmdLancamentoManual";
            this.cmdLancamentoManual.Size = new System.Drawing.Size(203, 27);
            this.cmdLancamentoManual.TabIndex = 25;
            this.cmdLancamentoManual.Text = "Lançamento Manual";
            this.cmdLancamentoManual.UseVisualStyleBackColor = true;
            this.cmdLancamentoManual.Click += new System.EventHandler(this.cmdLancamentoManual_Click);
            // 
            // cmdAjustarLancamento
            // 
            this.cmdAjustarLancamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAjustarLancamento.Enabled = false;
            this.cmdAjustarLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjustarLancamento.Location = new System.Drawing.Point(687, 6);
            this.cmdAjustarLancamento.Name = "cmdAjustarLancamento";
            this.cmdAjustarLancamento.Size = new System.Drawing.Size(206, 27);
            this.cmdAjustarLancamento.TabIndex = 24;
            this.cmdAjustarLancamento.Text = "Ajustar Lançamento";
            this.cmdAjustarLancamento.UseVisualStyleBackColor = true;
            this.cmdAjustarLancamento.Click += new System.EventHandler(this.cmdAjustarLancamento_Click);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(547, 8);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(111, 26);
            this.txtDataFinal.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data Final:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data Inicial:";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicial.Location = new System.Drawing.Point(327, 7);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(111, 26);
            this.txtDataInicial.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuários:";
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 576);
            this.Controls.Add(this.cmdLancamentoManual);
            this.Controls.Add(this.cmdAjustarLancamento);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdExportarParaExcel);
            this.Controls.Add(this.cmdRelatorio);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.grpGeral);
            this.MinimumSize = new System.Drawing.Size(1152, 615);
            this.Name = "FrmRelatorio";
            this.Text = "Relatório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.grpGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridLancamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGeral;
        private System.Windows.Forms.DataGridView GridUsuarios;
        private System.Windows.Forms.Button cmdExportarParaExcel;
        private System.Windows.Forms.Button cmdRelatorio;
        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.Button cmdPesquisar;
        private System.Windows.Forms.DataGridView GridLancamento;
        private System.Windows.Forms.Button cmdLancamentoManual;
        private System.Windows.Forms.Button cmdAjustarLancamento;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDataInicial;
        private System.Windows.Forms.Label label1;
    }
}