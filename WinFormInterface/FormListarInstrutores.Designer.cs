
namespace WinFormInterface
{
    partial class FormListarInstrutores
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
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnNovoInstrutor = new System.Windows.Forms.Button();
            this.dgvInstrutores = new System.Windows.Forms.DataGridView();
            this.chbInativos = new System.Windows.Forms.CheckBox();
            this.chbAtivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrutores)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMaisInformacoes
            // 
            this.BtnMaisInformacoes.Location = new System.Drawing.Point(454, 495);
            this.BtnMaisInformacoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMaisInformacoes.Name = "BtnMaisInformacoes";
            this.BtnMaisInformacoes.Size = new System.Drawing.Size(204, 76);
            this.BtnMaisInformacoes.TabIndex = 24;
            this.BtnMaisInformacoes.Text = "+ Informações sobre este Instrutor";
            this.BtnMaisInformacoes.UseVisualStyleBackColor = true;
            this.BtnMaisInformacoes.Click += new System.EventHandler(this.BtnMaisInformacoes_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(417, 68);
            this.BtnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(196, 29);
            this.BtnPesquisar.TabIndex = 17;
            this.BtnPesquisar.Text = "Executar pesquisa ";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pesquisar Instrutor por Nome";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(59, 68);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(344, 29);
            this.txtPesquisar.TabIndex = 16;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(898, 495);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(204, 76);
            this.BtnEditar.TabIndex = 19;
            this.BtnEditar.Text = "Editar Instrutor Selecionado";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(1121, 495);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(204, 76);
            this.BtnFechar.TabIndex = 21;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnNovoInstrutor
            // 
            this.BtnNovoInstrutor.Location = new System.Drawing.Point(673, 495);
            this.BtnNovoInstrutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNovoInstrutor.Name = "BtnNovoInstrutor";
            this.BtnNovoInstrutor.Size = new System.Drawing.Size(204, 76);
            this.BtnNovoInstrutor.TabIndex = 18;
            this.BtnNovoInstrutor.Text = "Novo Instrutor";
            this.BtnNovoInstrutor.UseVisualStyleBackColor = true;
            this.BtnNovoInstrutor.Click += new System.EventHandler(this.BtnNovoInstrutor_Click);
            // 
            // dgvInstrutores
            // 
            this.dgvInstrutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInstrutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrutores.Location = new System.Drawing.Point(59, 139);
            this.dgvInstrutores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInstrutores.Name = "dgvInstrutores";
            this.dgvInstrutores.ReadOnly = true;
            this.dgvInstrutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstrutores.Size = new System.Drawing.Size(1266, 346);
            this.dgvInstrutores.TabIndex = 23;
            // 
            // chbInativos
            // 
            this.chbInativos.AutoSize = true;
            this.chbInativos.Location = new System.Drawing.Point(137, 103);
            this.chbInativos.Name = "chbInativos";
            this.chbInativos.Size = new System.Drawing.Size(83, 25);
            this.chbInativos.TabIndex = 26;
            this.chbInativos.Text = "Inativos";
            this.chbInativos.UseVisualStyleBackColor = true;
            // 
            // chbAtivo
            // 
            this.chbAtivo.AutoSize = true;
            this.chbAtivo.Checked = true;
            this.chbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAtivo.Location = new System.Drawing.Point(59, 103);
            this.chbAtivo.Name = "chbAtivo";
            this.chbAtivo.Size = new System.Drawing.Size(72, 25);
            this.chbAtivo.TabIndex = 25;
            this.chbAtivo.Text = "Ativos";
            this.chbAtivo.UseVisualStyleBackColor = true;
            // 
            // FormListarInstrutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1384, 611);
            this.Controls.Add(this.chbInativos);
            this.Controls.Add(this.chbAtivo);
            this.Controls.Add(this.BtnMaisInformacoes);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnNovoInstrutor);
            this.Controls.Add(this.dgvInstrutores);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormListarInstrutores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instrutores";
            this.Load += new System.EventHandler(this.FormListarInstrutores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormListarInstrutores_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMaisInformacoes;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnNovoInstrutor;
        private System.Windows.Forms.DataGridView dgvInstrutores;
        private System.Windows.Forms.CheckBox chbInativos;
        private System.Windows.Forms.CheckBox chbAtivo;
    }
}