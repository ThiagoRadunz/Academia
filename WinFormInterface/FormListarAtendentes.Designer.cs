
namespace WinFormInterface
{
    partial class FormListarAtendentes
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
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnNovoAtendente = new System.Windows.Forms.Button();
            this.dgvAtendentes = new System.Windows.Forms.DataGridView();
            this.BtnMaisInformacoes = new System.Windows.Forms.Button();
            this.chbInativos = new System.Windows.Forms.CheckBox();
            this.chbAtivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(413, 47);
            this.BtnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(196, 29);
            this.BtnPesquisar.TabIndex = 1;
            this.BtnPesquisar.Text = "Executar pesquisa ";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pesquisar Atendente por Nome";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(55, 47);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(344, 29);
            this.txtPesquisar.TabIndex = 0;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(893, 490);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(204, 76);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar Atendente Selecionado";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(1117, 490);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(204, 76);
            this.BtnFechar.TabIndex = 5;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnNovoAtendente
            // 
            this.BtnNovoAtendente.Location = new System.Drawing.Point(668, 490);
            this.BtnNovoAtendente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNovoAtendente.Name = "BtnNovoAtendente";
            this.BtnNovoAtendente.Size = new System.Drawing.Size(204, 76);
            this.BtnNovoAtendente.TabIndex = 2;
            this.BtnNovoAtendente.Text = "Novo Atendente";
            this.BtnNovoAtendente.UseVisualStyleBackColor = true;
            this.BtnNovoAtendente.Click += new System.EventHandler(this.BtnNovoAtendente_Click);
            // 
            // dgvAtendentes
            // 
            this.dgvAtendentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendentes.Location = new System.Drawing.Point(55, 115);
            this.dgvAtendentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAtendentes.Name = "dgvAtendentes";
            this.dgvAtendentes.ReadOnly = true;
            this.dgvAtendentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtendentes.Size = new System.Drawing.Size(1266, 346);
            this.dgvAtendentes.TabIndex = 14;
            // 
            // BtnMaisInformacoes
            // 
            this.BtnMaisInformacoes.Location = new System.Drawing.Point(449, 490);
            this.BtnMaisInformacoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMaisInformacoes.Name = "BtnMaisInformacoes";
            this.BtnMaisInformacoes.Size = new System.Drawing.Size(204, 76);
            this.BtnMaisInformacoes.TabIndex = 15;
            this.BtnMaisInformacoes.Text = "+ Informações sobre este Atendente";
            this.BtnMaisInformacoes.UseVisualStyleBackColor = true;
            this.BtnMaisInformacoes.Click += new System.EventHandler(this.BtnMaisInformacoes_Click);
            // 
            // chbInativos
            // 
            this.chbInativos.AutoSize = true;
            this.chbInativos.Location = new System.Drawing.Point(133, 82);
            this.chbInativos.Name = "chbInativos";
            this.chbInativos.Size = new System.Drawing.Size(83, 25);
            this.chbInativos.TabIndex = 28;
            this.chbInativos.Text = "Inativos";
            this.chbInativos.UseVisualStyleBackColor = true;
            // 
            // chbAtivo
            // 
            this.chbAtivo.AutoSize = true;
            this.chbAtivo.Checked = true;
            this.chbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAtivo.Location = new System.Drawing.Point(55, 82);
            this.chbAtivo.Name = "chbAtivo";
            this.chbAtivo.Size = new System.Drawing.Size(72, 25);
            this.chbAtivo.TabIndex = 27;
            this.chbAtivo.Text = "Ativos";
            this.chbAtivo.UseVisualStyleBackColor = true;
            // 
            // FormListarAtendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 611);
            this.Controls.Add(this.chbInativos);
            this.Controls.Add(this.chbAtivo);
            this.Controls.Add(this.BtnMaisInformacoes);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnNovoAtendente);
            this.Controls.Add(this.dgvAtendentes);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormListarAtendentes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendentes";
            this.Load += new System.EventHandler(this.FormListarAtendentes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormListarAtendentes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnNovoAtendente;
        private System.Windows.Forms.DataGridView dgvAtendentes;
        private System.Windows.Forms.Button BtnMaisInformacoes;
        private System.Windows.Forms.CheckBox chbInativos;
        private System.Windows.Forms.CheckBox chbAtivo;
    }
}