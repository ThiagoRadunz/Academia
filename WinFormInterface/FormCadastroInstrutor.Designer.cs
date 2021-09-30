
namespace WinFormInterface
{
    partial class FormCadastroInstrutor
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.gbEndereco.SuspendLayout();
            this.gbDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(981, 580);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(167, 38);
            this.btnVoltar.TabIndex = 50;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(795, 580);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(167, 38);
            this.btnLimpar.TabIndex = 49;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.cbEstado);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.label4);
            this.gbEndereco.Controls.Add(this.label3);
            this.gbEndereco.Controls.Add(this.lblRua);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.lblBairro);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEndereco.Location = new System.Drawing.Point(199, 342);
            this.gbEndereco.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbEndereco.Size = new System.Drawing.Size(950, 228);
            this.gbEndereco.TabIndex = 52;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(27, 73);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(211, 29);
            this.cbEstado.TabIndex = 27;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(295, 73);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(234, 29);
            this.txtCidade.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Estado";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(21, 129);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(37, 21);
            this.lblRua.TabIndex = 16;
            this.lblRua.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(24, 157);
            this.txtRua.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(675, 29);
            this.txtRua.TabIndex = 13;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(582, 73);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(334, 29);
            this.txtBairro.TabIndex = 12;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(593, 46);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(54, 21);
            this.lblBairro.TabIndex = 18;
            this.lblBairro.Text = "Bairro";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(716, 129);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(70, 21);
            this.lblNumero.TabIndex = 22;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(721, 157);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(209, 29);
            this.txtNumero.TabIndex = 14;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.txtSalario);
            this.gbDadosPessoais.Controls.Add(this.lblSalario);
            this.gbDadosPessoais.Controls.Add(this.txtComissao);
            this.gbDadosPessoais.Controls.Add(this.label7);
            this.gbDadosPessoais.Controls.Add(this.txtConfirmarSenha);
            this.gbDadosPessoais.Controls.Add(this.label6);
            this.gbDadosPessoais.Controls.Add(this.txtSenha);
            this.gbDadosPessoais.Controls.Add(this.label5);
            this.gbDadosPessoais.Controls.Add(this.txtRG);
            this.gbDadosPessoais.Controls.Add(this.label2);
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
            this.gbDadosPessoais.Location = new System.Drawing.Point(199, 16);
            this.gbDadosPessoais.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbDadosPessoais.Size = new System.Drawing.Size(950, 316);
            this.gbDadosPessoais.TabIndex = 51;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(19, 281);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(208, 29);
            this.txtSalario.TabIndex = 8;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(16, 253);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(59, 21);
            this.lblSalario.TabIndex = 43;
            this.lblSalario.Text = "Salário";
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(261, 281);
            this.txtComissao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(208, 29);
            this.txtComissao.TabIndex = 9;
            this.txtComissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComissao_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Comissão";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(718, 215);
            this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(208, 29);
            this.txtConfirmarSenha.TabIndex = 7;
            this.txtConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(712, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Confirmar Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(463, 215);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(208, 29);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Senha";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(718, 126);
            this.txtRG.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(208, 29);
            this.txtRG.TabIndex = 3;
            this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "RG";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 21);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 55);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(675, 29);
            this.txtNome.TabIndex = 0;
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(217, 215);
            this.dtpDataDeNascimento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(208, 29);
            this.dtpDataDeNascimento.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(718, 55);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(208, 29);
            this.txtCPF.TabIndex = 1;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(715, 28);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 21);
            this.lblCPF.TabIndex = 12;
            this.lblCPF.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(19, 126);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(675, 29);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 21);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "E-mail";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(214, 183);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(157, 21);
            this.lblDataNascimento.TabIndex = 25;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(23, 215);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(173, 29);
            this.txtCelular.TabIndex = 4;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(19, 183);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(127, 21);
            this.lblTelefone.TabIndex = 24;
            this.lblTelefone.Text = "Telefone Celular";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.Black;
            this.BtnSalvar.Location = new System.Drawing.Point(608, 580);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(167, 38);
            this.BtnSalvar.TabIndex = 53;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // FormCadastroInstrutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1370, 641);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gbDadosPessoais);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCadastroInstrutor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Instrutor";
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}