
namespace WinFormInterface
{
    partial class FormUpdateCliente
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnIncluirPlanos = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.chbInativos = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chbAtivo = new System.Windows.Forms.CheckBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.BtnFechar = new System.Windows.Forms.Button();
            this.gbDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(805, 471);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(214, 58);
            this.btnVoltar.TabIndex = 44;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnIncluirPlanos
            // 
            this.btnIncluirPlanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirPlanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirPlanos.ForeColor = System.Drawing.Color.Black;
            this.btnIncluirPlanos.Location = new System.Drawing.Point(552, 471);
            this.btnIncluirPlanos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIncluirPlanos.Name = "btnIncluirPlanos";
            this.btnIncluirPlanos.Size = new System.Drawing.Size(214, 58);
            this.btnIncluirPlanos.TabIndex = 43;
            this.btnIncluirPlanos.Text = "Modalidades";
            this.btnIncluirPlanos.UseVisualStyleBackColor = true;
            this.btnIncluirPlanos.Click += new System.EventHandler(this.btnIncluirPlanos_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(297, 471);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(214, 58);
            this.btnCadastrar.TabIndex = 42;
            this.btnCadastrar.Text = "Salvar alterações";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.chbInativos);
            this.gbDadosPessoais.Controls.Add(this.label5);
            this.gbDadosPessoais.Controls.Add(this.chbAtivo);
            this.gbDadosPessoais.Controls.Add(this.txtIDCliente);
            this.gbDadosPessoais.Controls.Add(this.label4);
            this.gbDadosPessoais.Controls.Add(this.dtpDataMatricula);
            this.gbDadosPessoais.Controls.Add(this.label3);
            this.gbDadosPessoais.Controls.Add(this.txtRG);
            this.gbDadosPessoais.Controls.Add(this.label2);
            this.gbDadosPessoais.Controls.Add(this.txtFoneFixo);
            this.gbDadosPessoais.Controls.Add(this.label1);
            this.gbDadosPessoais.Controls.Add(this.lblNome);
            this.gbDadosPessoais.Controls.Add(this.txtNome);
            this.gbDadosPessoais.Controls.Add(this.dtpDataDeNascimento);
            this.gbDadosPessoais.Controls.Add(this.txtCPF);
            this.gbDadosPessoais.Controls.Add(this.lblCPF);
            this.gbDadosPessoais.Controls.Add(this.txtEmail);
            this.gbDadosPessoais.Controls.Add(this.lblEmail);
            this.gbDadosPessoais.Controls.Add(this.lblDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.txtCelular);
            this.gbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gbDadosPessoais.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosPessoais.Location = new System.Drawing.Point(42, 39);
            this.gbDadosPessoais.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbDadosPessoais.Size = new System.Drawing.Size(1221, 391);
            this.gbDadosPessoais.TabIndex = 41;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Cliente";
            // 
            // chbInativos
            // 
            this.chbInativos.AutoSize = true;
            this.chbInativos.Location = new System.Drawing.Point(108, 31);
            this.chbInativos.Name = "chbInativos";
            this.chbInativos.Size = new System.Drawing.Size(79, 25);
            this.chbInativos.TabIndex = 47;
            this.chbInativos.Text = "Inativo";
            this.chbInativos.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1134, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Código";
            // 
            // chbAtivo
            // 
            this.chbAtivo.AutoSize = true;
            this.chbAtivo.Checked = true;
            this.chbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAtivo.Location = new System.Drawing.Point(30, 31);
            this.chbAtivo.Name = "chbAtivo";
            this.chbAtivo.Size = new System.Drawing.Size(68, 25);
            this.chbAtivo.TabIndex = 46;
            this.chbAtivo.Text = "Ativo";
            this.chbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Enabled = false;
            this.txtIDCliente.Location = new System.Drawing.Point(1135, 51);
            this.txtIDCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(59, 29);
            this.txtIDCliente.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(968, -20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Telefone Celular";
            // 
            // dtpDataMatricula
            // 
            this.dtpDataMatricula.Enabled = false;
            this.dtpDataMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataMatricula.Location = new System.Drawing.Point(928, 312);
            this.dtpDataMatricula.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpDataMatricula.Name = "dtpDataMatricula";
            this.dtpDataMatricula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpDataMatricula.RightToLeftLayout = true;
            this.dtpDataMatricula.Size = new System.Drawing.Size(266, 29);
            this.dtpDataMatricula.TabIndex = 36;
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
            this.txtRG.Enabled = false;
            this.txtRG.Location = new System.Drawing.Point(928, 192);
            this.txtRG.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(266, 29);
            this.txtRG.TabIndex = 34;
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
            this.txtFoneFixo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFoneFixo.Name = "txtFoneFixo";
            this.txtFoneFixo.Size = new System.Drawing.Size(222, 29);
            this.txtFoneFixo.TabIndex = 32;
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
            this.txtNome.Location = new System.Drawing.Point(32, 105);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(866, 29);
            this.txtNome.TabIndex = 0;
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.Enabled = false;
            this.dtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(632, 312);
            this.dtpDataDeNascimento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpDataDeNascimento.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(266, 29);
            this.dtpDataDeNascimento.TabIndex = 9;
            this.dtpDataDeNascimento.Value = new System.DateTime(2000, 1, 1, 20, 5, 0, 0);
            // 
            // txtCPF
            // 
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(928, 105);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(266, 29);
            this.txtCPF.TabIndex = 11;
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
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(866, 29);
            this.txtEmail.TabIndex = 13;
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
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(222, 29);
            this.txtCelular.TabIndex = 23;
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
            // BtnFechar
            // 
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.Color.Black;
            this.BtnFechar.Location = new System.Drawing.Point(1049, 471);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(214, 58);
            this.BtnFechar.TabIndex = 45;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FormUpdateCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 581);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnIncluirPlanos);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gbDadosPessoais);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUpdateCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cliente";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormUpdateCliente_KeyDown);
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnIncluirPlanos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.DateTimePicker dtpDataMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFoneFixo;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbInativos;
        private System.Windows.Forms.CheckBox chbAtivo;
    }
}