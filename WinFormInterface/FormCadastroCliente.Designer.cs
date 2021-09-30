
namespace WinFormInterface
{
    partial class FormCadastroCliente
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gbDadosCliente = new System.Windows.Forms.GroupBox();
            this.dtpDataMatricula = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoneFixo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gbDadosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(796, 469);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(214, 58);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(541, 469);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(214, 58);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gbDadosCliente
            // 
            this.gbDadosCliente.Controls.Add(this.dtpDataMatricula);
            this.gbDadosCliente.Controls.Add(this.label3);
            this.gbDadosCliente.Controls.Add(this.txtRG);
            this.gbDadosCliente.Controls.Add(this.label2);
            this.gbDadosCliente.Controls.Add(this.txtFoneFixo);
            this.gbDadosCliente.Controls.Add(this.label1);
            this.gbDadosCliente.Controls.Add(this.lblNome);
            this.gbDadosCliente.Controls.Add(this.txtNome);
            this.gbDadosCliente.Controls.Add(this.dtpDataDeNascimento);
            this.gbDadosCliente.Controls.Add(this.txtCPF);
            this.gbDadosCliente.Controls.Add(this.lblCPF);
            this.gbDadosCliente.Controls.Add(this.txtEmail);
            this.gbDadosCliente.Controls.Add(this.lblEmail);
            this.gbDadosCliente.Controls.Add(this.lblDataNascimento);
            this.gbDadosCliente.Controls.Add(this.txtCelular);
            this.gbDadosCliente.Controls.Add(this.lblTelefone);
            this.gbDadosCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosCliente.Location = new System.Drawing.Point(42, 39);
            this.gbDadosCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbDadosCliente.Name = "gbDadosCliente";
            this.gbDadosCliente.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbDadosCliente.Size = new System.Drawing.Size(1221, 391);
            this.gbDadosCliente.TabIndex = 36;
            this.gbDadosCliente.TabStop = false;
            this.gbDadosCliente.Text = "Dados Cliente";
            // 
            // dtpDataMatricula
            // 
            this.dtpDataMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataMatricula.Location = new System.Drawing.Point(928, 312);
            this.dtpDataMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDataMatricula.Name = "dtpDataMatricula";
            this.dtpDataMatricula.Size = new System.Drawing.Size(266, 29);
            this.dtpDataMatricula.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(924, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Data Matrícula";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(928, 192);
            this.txtRG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(266, 29);
            this.txtRG.TabIndex = 3;
            this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(924, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "RG";
            // 
            // txtFoneFixo
            // 
            this.txtFoneFixo.Location = new System.Drawing.Point(321, 317);
            this.txtFoneFixo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFoneFixo.Name = "txtFoneFixo";
            this.txtFoneFixo.Size = new System.Drawing.Size(222, 29);
            this.txtFoneFixo.TabIndex = 5;
            this.txtFoneFixo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFoneFixo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Telefone Fixo (Opcional)";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 71);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 21);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(32, 105);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(866, 29);
            this.txtNome.TabIndex = 0;
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.CustomFormat = "";
            this.dtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(632, 312);
            this.dtpDataDeNascimento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDataDeNascimento.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDataDeNascimento.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(266, 29);
            this.dtpDataDeNascimento.TabIndex = 6;
            this.dtpDataDeNascimento.Value = new System.DateTime(2000, 1, 1, 22, 3, 0, 0);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(928, 105);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(266, 29);
            this.txtCPF.TabIndex = 1;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(924, 71);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 21);
            this.lblCPF.TabIndex = 12;
            this.lblCPF.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(32, 192);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(866, 29);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 158);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 21);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "E-mail";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(627, 263);
            this.lblDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(157, 21);
            this.lblDataNascimento.TabIndex = 25;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(34, 317);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(222, 29);
            this.txtCelular.TabIndex = 4;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(30, 263);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(127, 21);
            this.lblTelefone.TabIndex = 24;
            this.lblTelefone.Text = "Telefone Celular";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(1049, 469);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(214, 58);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1334, 581);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gbDadosCliente);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCadastroCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroCliente";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroCliente_KeyDown);
            this.gbDadosCliente.ResumeLayout(false);
            this.gbDadosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gbDadosCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtFoneFixo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
    }
}