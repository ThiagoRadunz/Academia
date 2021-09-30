
namespace WinFormInterface
{
    partial class FormListarTodosFuncionarios
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
            this.BtnMaisInformacoes = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.dgvTodos = new System.Windows.Forms.DataGridView();
            this.BtnAlterarSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMaisInformacoes
            // 
            this.BtnMaisInformacoes.Location = new System.Drawing.Point(850, 490);
            this.BtnMaisInformacoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMaisInformacoes.Name = "BtnMaisInformacoes";
            this.BtnMaisInformacoes.Size = new System.Drawing.Size(204, 76);
            this.BtnMaisInformacoes.TabIndex = 24;
            this.BtnMaisInformacoes.Text = "+ Informações sobre este Funcionario";
            this.BtnMaisInformacoes.UseVisualStyleBackColor = true;
            this.BtnMaisInformacoes.Click += new System.EventHandler(this.BtnMaisInformacoes_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(371, 63);
            this.BtnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(196, 29);
            this.BtnPesquisar.TabIndex = 17;
            this.BtnPesquisar.Text = "Executar pesquisa ";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pesquisar Funcionarios por nome :";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(13, 63);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(344, 29);
            this.txtPesquisar.TabIndex = 16;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(1075, 490);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(204, 76);
            this.BtnFechar.TabIndex = 21;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // dgvTodos
            // 
            this.dgvTodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodos.Location = new System.Drawing.Point(13, 115);
            this.dgvTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTodos.Name = "dgvTodos";
            this.dgvTodos.ReadOnly = true;
            this.dgvTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodos.Size = new System.Drawing.Size(1266, 346);
            this.dgvTodos.TabIndex = 23;
            // 
            // BtnAlterarSenha
            // 
            this.BtnAlterarSenha.Location = new System.Drawing.Point(626, 490);
            this.BtnAlterarSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAlterarSenha.Name = "BtnAlterarSenha";
            this.BtnAlterarSenha.Size = new System.Drawing.Size(204, 76);
            this.BtnAlterarSenha.TabIndex = 25;
            this.BtnAlterarSenha.Text = "Alterar Senha";
            this.BtnAlterarSenha.UseVisualStyleBackColor = true;
            this.BtnAlterarSenha.Click += new System.EventHandler(this.BtnAlterarSenha_Click);
            // 
            // FormListarTodosFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1292, 628);
            this.Controls.Add(this.BtnAlterarSenha);
            this.Controls.Add(this.BtnMaisInformacoes);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.dgvTodos);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormListarTodosFuncionarios";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.FormListarTodosFuncionarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormListarTodosFuncionarios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMaisInformacoes;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.DataGridView dgvTodos;
        private System.Windows.Forms.Button BtnAlterarSenha;
    }
}