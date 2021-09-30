
namespace WinFormInterface
{
    partial class FormListarProdutos
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
            this.chbNome = new System.Windows.Forms.CheckBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnNovoProduto = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.chbCategoria = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // chbNome
            // 
            this.chbNome.AutoSize = true;
            this.chbNome.Checked = true;
            this.chbNome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbNome.Location = new System.Drawing.Point(167, 105);
            this.chbNome.Name = "chbNome";
            this.chbNome.Size = new System.Drawing.Size(74, 25);
            this.chbNome.TabIndex = 37;
            this.chbNome.Text = "Nome";
            this.chbNome.UseVisualStyleBackColor = true;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(525, 70);
            this.BtnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(196, 29);
            this.BtnPesquisar.TabIndex = 30;
            this.BtnPesquisar.Text = "Executar pesquisa ";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Pesquisar Produto";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(167, 70);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(344, 29);
            this.txtPesquisar.TabIndex = 29;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(1005, 513);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(204, 76);
            this.BtnEditar.TabIndex = 32;
            this.BtnEditar.Text = "Editar Produto Selecionado";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(1229, 513);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(204, 76);
            this.BtnFechar.TabIndex = 33;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnNovoProduto
            // 
            this.BtnNovoProduto.Location = new System.Drawing.Point(780, 513);
            this.BtnNovoProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNovoProduto.Name = "BtnNovoProduto";
            this.BtnNovoProduto.Size = new System.Drawing.Size(204, 76);
            this.BtnNovoProduto.TabIndex = 31;
            this.BtnNovoProduto.Text = "Novo Produto";
            this.BtnNovoProduto.UseVisualStyleBackColor = true;
            this.BtnNovoProduto.Click += new System.EventHandler(this.BtnNovoProduto_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(167, 138);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1266, 346);
            this.dgvProdutos.TabIndex = 35;
            // 
            // chbCategoria
            // 
            this.chbCategoria.AutoSize = true;
            this.chbCategoria.Location = new System.Drawing.Point(247, 105);
            this.chbCategoria.Name = "chbCategoria";
            this.chbCategoria.Size = new System.Drawing.Size(117, 25);
            this.chbCategoria.TabIndex = 39;
            this.chbCategoria.Text = "Modalidade";
            this.chbCategoria.UseVisualStyleBackColor = true;
            // 
            // FormListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1370, 630);
            this.Controls.Add(this.chbCategoria);
            this.Controls.Add(this.chbNome);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnNovoProduto);
            this.Controls.Add(this.dgvProdutos);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormListarProdutos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chbNome;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnNovoProduto;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.CheckBox chbCategoria;
    }
}