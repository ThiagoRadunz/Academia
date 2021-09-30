
namespace WinFormInterface
{
    partial class FormAddPic
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFiltroInstrutor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFiltroCliente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnAddContrato = new System.Windows.Forms.Button();
            this.dtpAdesaoContrato = new System.Windows.Forms.DateTimePicker();
            this.lblTermino = new System.Windows.Forms.Label();
            this.dtpTerminoContrato = new System.Windows.Forms.DateTimePicker();
            this.lblAdesao = new System.Windows.Forms.Label();
            this.BtnConfirmarFormaPag = new System.Windows.Forms.Button();
            this.dgvFormaPagamento = new System.Windows.Forms.DataGridView();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.txtCodigoFormaPagamento = new System.Windows.Forms.TextBox();
            this.txtCodigoPlano = new System.Windows.Forms.TextBox();
            this.dgvPlano = new System.Windows.Forms.DataGridView();
            this.BtnConfirmarPlano = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQtdAulaSemana = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQtdDuracao = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIDInstrutor = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlano)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cód.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome do Instrutor";
            // 
            // cbFiltroInstrutor
            // 
            this.cbFiltroInstrutor.FormattingEnabled = true;
            this.cbFiltroInstrutor.Location = new System.Drawing.Point(157, 114);
            this.cbFiltroInstrutor.Name = "cbFiltroInstrutor";
            this.cbFiltroInstrutor.Size = new System.Drawing.Size(300, 29);
            this.cbFiltroInstrutor.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cód.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nome do Cliente";
            // 
            // cbFiltroCliente
            // 
            this.cbFiltroCliente.FormattingEnabled = true;
            this.cbFiltroCliente.Location = new System.Drawing.Point(157, 45);
            this.cbFiltroCliente.Name = "cbFiltroCliente";
            this.cbFiltroCliente.Size = new System.Drawing.Size(300, 29);
            this.cbFiltroCliente.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1070, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 21);
            this.label9.TabIndex = 46;
            this.label9.Text = "Cód.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1128, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 21);
            this.label10.TabIndex = 45;
            this.label10.Text = "Forma Pagamento";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnVoltar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(1322, 524);
            this.BtnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(200, 76);
            this.BtnVoltar.TabIndex = 49;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnAddContrato
            // 
            this.BtnAddContrato.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAddContrato.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddContrato.Location = new System.Drawing.Point(1070, 524);
            this.BtnAddContrato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddContrato.Name = "BtnAddContrato";
            this.BtnAddContrato.Size = new System.Drawing.Size(200, 76);
            this.BtnAddContrato.TabIndex = 50;
            this.BtnAddContrato.Text = "Finalizar Operação";
            this.BtnAddContrato.UseVisualStyleBackColor = true;
            this.BtnAddContrato.Click += new System.EventHandler(this.BtnAddContrato_Click);
            // 
            // dtpAdesaoContrato
            // 
            this.dtpAdesaoContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdesaoContrato.Location = new System.Drawing.Point(281, 210);
            this.dtpAdesaoContrato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpAdesaoContrato.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpAdesaoContrato.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpAdesaoContrato.Name = "dtpAdesaoContrato";
            this.dtpAdesaoContrato.Size = new System.Drawing.Size(158, 29);
            this.dtpAdesaoContrato.TabIndex = 53;
            this.dtpAdesaoContrato.Value = new System.DateTime(2021, 8, 6, 23, 37, 47, 0);
            // 
            // lblTermino
            // 
            this.lblTermino.AutoSize = true;
            this.lblTermino.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermino.Location = new System.Drawing.Point(277, 251);
            this.lblTermino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTermino.Name = "lblTermino";
            this.lblTermino.Size = new System.Drawing.Size(175, 21);
            this.lblTermino.TabIndex = 54;
            this.lblTermino.Text = "Data Término Contrato";
            // 
            // dtpTerminoContrato
            // 
            this.dtpTerminoContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTerminoContrato.Location = new System.Drawing.Point(281, 275);
            this.dtpTerminoContrato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTerminoContrato.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpTerminoContrato.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpTerminoContrato.Name = "dtpTerminoContrato";
            this.dtpTerminoContrato.Size = new System.Drawing.Size(158, 29);
            this.dtpTerminoContrato.TabIndex = 51;
            this.dtpTerminoContrato.Value = new System.DateTime(2021, 8, 6, 23, 39, 50, 0);
            // 
            // lblAdesao
            // 
            this.lblAdesao.AutoSize = true;
            this.lblAdesao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdesao.Location = new System.Drawing.Point(277, 186);
            this.lblAdesao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdesao.Name = "lblAdesao";
            this.lblAdesao.Size = new System.Drawing.Size(171, 21);
            this.lblAdesao.TabIndex = 52;
            this.lblAdesao.Text = "Data Adesao Contrato";
            // 
            // BtnConfirmarFormaPag
            // 
            this.BtnConfirmarFormaPag.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnConfirmarFormaPag.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmarFormaPag.Location = new System.Drawing.Point(1424, 380);
            this.BtnConfirmarFormaPag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnConfirmarFormaPag.Name = "BtnConfirmarFormaPag";
            this.BtnConfirmarFormaPag.Size = new System.Drawing.Size(98, 37);
            this.BtnConfirmarFormaPag.TabIndex = 56;
            this.BtnConfirmarFormaPag.Text = "Confirmar";
            this.BtnConfirmarFormaPag.UseVisualStyleBackColor = true;
            this.BtnConfirmarFormaPag.Click += new System.EventHandler(this.BtnConfirmarFormaPag_Click);
            // 
            // dgvFormaPagamento
            // 
            this.dgvFormaPagamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormaPagamento.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFormaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormaPagamento.Location = new System.Drawing.Point(1073, 96);
            this.dgvFormaPagamento.Name = "dgvFormaPagamento";
            this.dgvFormaPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormaPagamento.Size = new System.Drawing.Size(449, 276);
            this.dgvFormaPagamento.TabIndex = 57;
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Enabled = false;
            this.txtFormaPagamento.Location = new System.Drawing.Point(1132, 45);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(390, 29);
            this.txtFormaPagamento.TabIndex = 58;
            // 
            // txtCodigoFormaPagamento
            // 
            this.txtCodigoFormaPagamento.Enabled = false;
            this.txtCodigoFormaPagamento.Location = new System.Drawing.Point(1074, 45);
            this.txtCodigoFormaPagamento.Name = "txtCodigoFormaPagamento";
            this.txtCodigoFormaPagamento.Size = new System.Drawing.Size(40, 29);
            this.txtCodigoFormaPagamento.TabIndex = 59;
            // 
            // txtCodigoPlano
            // 
            this.txtCodigoPlano.Enabled = false;
            this.txtCodigoPlano.Location = new System.Drawing.Point(544, 45);
            this.txtCodigoPlano.Name = "txtCodigoPlano";
            this.txtCodigoPlano.Size = new System.Drawing.Size(40, 29);
            this.txtCodigoPlano.TabIndex = 65;
            // 
            // dgvPlano
            // 
            this.dgvPlano.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlano.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPlano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlano.Location = new System.Drawing.Point(544, 96);
            this.dgvPlano.Name = "dgvPlano";
            this.dgvPlano.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlano.Size = new System.Drawing.Size(477, 276);
            this.dgvPlano.TabIndex = 63;
            // 
            // BtnConfirmarPlano
            // 
            this.BtnConfirmarPlano.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnConfirmarPlano.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmarPlano.Location = new System.Drawing.Point(910, 380);
            this.BtnConfirmarPlano.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnConfirmarPlano.Name = "BtnConfirmarPlano";
            this.BtnConfirmarPlano.Size = new System.Drawing.Size(111, 37);
            this.BtnConfirmarPlano.TabIndex = 62;
            this.BtnConfirmarPlano.Text = "Confirmar";
            this.BtnConfirmarPlano.UseVisualStyleBackColor = true;
            this.BtnConfirmarPlano.Click += new System.EventHandler(this.BtnConfirmarPlano_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 61;
            this.label3.Text = "Cód.";
            // 
            // txtModalidade
            // 
            this.txtModalidade.Enabled = false;
            this.txtModalidade.Location = new System.Drawing.Point(605, 45);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.Size = new System.Drawing.Size(416, 29);
            this.txtModalidade.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(601, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 66;
            this.label7.Text = "Modalidade";
            // 
            // txtQtdAulaSemana
            // 
            this.txtQtdAulaSemana.Enabled = false;
            this.txtQtdAulaSemana.Location = new System.Drawing.Point(97, 275);
            this.txtQtdAulaSemana.Name = "txtQtdAulaSemana";
            this.txtQtdAulaSemana.Size = new System.Drawing.Size(144, 29);
            this.txtQtdAulaSemana.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 21);
            this.label8.TabIndex = 68;
            this.label8.Text = "Qtd Aula Semana";
            // 
            // txtQtdDuracao
            // 
            this.txtQtdDuracao.Enabled = false;
            this.txtQtdDuracao.Location = new System.Drawing.Point(97, 210);
            this.txtQtdDuracao.Name = "txtQtdDuracao";
            this.txtQtdDuracao.Size = new System.Drawing.Size(144, 29);
            this.txtQtdDuracao.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(93, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 21);
            this.label13.TabIndex = 70;
            this.label13.Text = "Duração (nº Meses)";
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(97, 343);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(144, 29);
            this.txtPreco.TabIndex = 73;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(93, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 21);
            this.label14.TabIndex = 72;
            this.label14.Text = "Preço";
            // 
            // txtIDInstrutor
            // 
            this.txtIDInstrutor.Enabled = false;
            this.txtIDInstrutor.Location = new System.Drawing.Point(99, 114);
            this.txtIDInstrutor.Name = "txtIDInstrutor";
            this.txtIDInstrutor.Size = new System.Drawing.Size(40, 29);
            this.txtIDInstrutor.TabIndex = 74;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Enabled = false;
            this.txtIDCliente.Location = new System.Drawing.Point(99, 45);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(40, 29);
            this.txtIDCliente.TabIndex = 75;
            // 
            // FormAddPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 642);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.txtIDInstrutor);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtQtdDuracao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtQtdAulaSemana);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtModalidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodigoPlano);
            this.Controls.Add(this.dgvPlano);
            this.Controls.Add(this.BtnConfirmarPlano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoFormaPagamento);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.dgvFormaPagamento);
            this.Controls.Add(this.BtnConfirmarFormaPag);
            this.Controls.Add(this.dtpAdesaoContrato);
            this.Controls.Add(this.lblTermino);
            this.Controls.Add(this.dtpTerminoContrato);
            this.Controls.Add(this.lblAdesao);
            this.Controls.Add(this.BtnAddContrato);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltroCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFiltroInstrutor);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAddPic";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Plano à Cliente";
            this.Load += new System.EventHandler(this.FormAddPic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFiltroInstrutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFiltroCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnAddContrato;
        private System.Windows.Forms.DateTimePicker dtpAdesaoContrato;
        private System.Windows.Forms.Label lblTermino;
        private System.Windows.Forms.DateTimePicker dtpTerminoContrato;
        private System.Windows.Forms.Label lblAdesao;
        private System.Windows.Forms.Button BtnConfirmarFormaPag;
        private System.Windows.Forms.DataGridView dgvFormaPagamento;
        private System.Windows.Forms.TextBox txtFormaPagamento;
        private System.Windows.Forms.TextBox txtCodigoFormaPagamento;
        private System.Windows.Forms.TextBox txtCodigoPlano;
        private System.Windows.Forms.DataGridView dgvPlano;
        private System.Windows.Forms.Button BtnConfirmarPlano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQtdAulaSemana;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQtdDuracao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIDInstrutor;
        private System.Windows.Forms.TextBox txtIDCliente;
    }
}