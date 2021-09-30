
namespace WinFormInterface
{
    partial class FormCadastroEntradaProdutos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.dgvItensEntrada = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidadeEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecoUnitarioEntrada = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecoUnitarioAtual = new System.Windows.Forms.TextBox();
            this.txtEstoqueAtual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensEntrada)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCadastrar);
            this.groupBox2.Controls.Add(this.BtnConfirmar);
            this.groupBox2.Controls.Add(this.dgvProdutos);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(850, 298);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1. Selecione o item aqui";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(659, 244);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(151, 29);
            this.BtnCadastrar.TabIndex = 53;
            this.BtnCadastrar.Text = "Não encontrou?";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(451, 244);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(179, 29);
            this.BtnConfirmar.TabIndex = 52;
            this.BtnConfirmar.Text = "2. Confirmar seleção";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvProdutos.Location = new System.Drawing.Point(42, 49);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(768, 186);
            this.dgvProdutos.TabIndex = 20;
            this.dgvProdutos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProdutos_RowsAdded);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnFinalizar);
            this.groupBox1.Controls.Add(this.BtnRemover);
            this.groupBox1.Controls.Add(this.dgvItensEntrada);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 322);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(850, 288);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "5. Repita o processo até concluir todos itens da entrada";
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Location = new System.Drawing.Point(504, 232);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(168, 29);
            this.BtnFinalizar.TabIndex = 54;
            this.BtnFinalizar.Text = "6. Finalizar entrada ";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(696, 232);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(114, 29);
            this.BtnRemover.TabIndex = 53;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // dgvItensEntrada
            // 
            this.dgvItensEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItensEntrada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItensEntrada.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItensEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensEntrada.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvItensEntrada.Location = new System.Drawing.Point(42, 35);
            this.dgvItensEntrada.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.dgvItensEntrada.Name = "dgvItensEntrada";
            this.dgvItensEntrada.RowHeadersVisible = false;
            this.dgvItensEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensEntrada.Size = new System.Drawing.Size(768, 186);
            this.dgvItensEntrada.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Quantidade";
            // 
            // txtQuantidadeEntrada
            // 
            this.txtQuantidadeEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeEntrada.Location = new System.Drawing.Point(22, 55);
            this.txtQuantidadeEntrada.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtQuantidadeEntrada.Name = "txtQuantidadeEntrada";
            this.txtQuantidadeEntrada.Size = new System.Drawing.Size(110, 29);
            this.txtQuantidadeEntrada.TabIndex = 46;
            this.txtQuantidadeEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeEntrada_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Preço Unitário";
            // 
            // txtPrecoUnitarioEntrada
            // 
            this.txtPrecoUnitarioEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUnitarioEntrada.Location = new System.Drawing.Point(22, 121);
            this.txtPrecoUnitarioEntrada.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtPrecoUnitarioEntrada.Name = "txtPrecoUnitarioEntrada";
            this.txtPrecoUnitarioEntrada.Size = new System.Drawing.Size(110, 29);
            this.txtPrecoUnitarioEntrada.TabIndex = 44;
            this.txtPrecoUnitarioEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoUnitarioEntrada_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnIncluir);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(889, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(522, 465);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Informe qtd e preço do item a ser inserido";
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(359, 388);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(114, 29);
            this.BtnIncluir.TabIndex = 51;
            this.BtnIncluir.Text = "4. Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtPrecoUnitarioAtual);
            this.groupBox5.Controls.Add(this.txtEstoqueAtual);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtCategoria);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtDescricao);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtNome);
            this.groupBox5.Controls.Add(this.txtIDProduto);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(24, 58);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(288, 374);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Identificação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(154, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 21);
            this.label8.TabIndex = 59;
            this.label8.Text = "Preço Unitário";
            // 
            // txtPrecoUnitarioAtual
            // 
            this.txtPrecoUnitarioAtual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUnitarioAtual.Location = new System.Drawing.Point(158, 64);
            this.txtPrecoUnitarioAtual.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtPrecoUnitarioAtual.Name = "txtPrecoUnitarioAtual";
            this.txtPrecoUnitarioAtual.Size = new System.Drawing.Size(110, 29);
            this.txtPrecoUnitarioAtual.TabIndex = 58;
            // 
            // txtEstoqueAtual
            // 
            this.txtEstoqueAtual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueAtual.Location = new System.Drawing.Point(17, 317);
            this.txtEstoqueAtual.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtEstoqueAtual.Name = "txtEstoqueAtual";
            this.txtEstoqueAtual.Size = new System.Drawing.Size(251, 29);
            this.txtEstoqueAtual.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 21);
            this.label7.TabIndex = 57;
            this.label7.Text = "Quantida em estoque";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(17, 250);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(251, 29);
            this.txtCategoria.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 55;
            this.label6.Text = "Categoria";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(17, 190);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(251, 29);
            this.txtDescricao.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 53;
            this.label4.Text = "Descricao";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(17, 121);
            this.txtNome.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(251, 29);
            this.txtNome.TabIndex = 50;
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProduto.Location = new System.Drawing.Point(17, 64);
            this.txtIDProduto.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(110, 29);
            this.txtIDProduto.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "IDProduto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtQuantidadeEntrada);
            this.groupBox4.Controls.Add(this.txtPrecoUnitarioEntrada);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(341, 58);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(153, 167);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Item Entrada";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(1276, 518);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(135, 65);
            this.BtnFechar.TabIndex = 54;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FormCadastroEntradaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1370, 654);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCadastroEntradaProdutos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada Produtos";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensEntrada)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvItensEntrada;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidadeEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecoUnitarioEntrada;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIDProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecoUnitarioAtual;
        private System.Windows.Forms.TextBox txtEstoqueAtual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label6;
    }
}