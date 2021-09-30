
namespace WinFormInterface
{
    partial class FormListarClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.BtnNovoCliente = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.chbAtivo = new System.Windows.Forms.CheckBox();
            this.chbInativos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(61, 117);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1408, 346);
            this.dgvClientes.TabIndex = 6;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // BtnNovoCliente
            // 
            this.BtnNovoCliente.Location = new System.Drawing.Point(602, 496);
            this.BtnNovoCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNovoCliente.Name = "BtnNovoCliente";
            this.BtnNovoCliente.Size = new System.Drawing.Size(200, 76);
            this.BtnNovoCliente.TabIndex = 2;
            this.BtnNovoCliente.Text = "Novo Cliente";
            this.BtnNovoCliente.UseVisualStyleBackColor = true;
            this.BtnNovoCliente.Click += new System.EventHandler(this.BtnNovoCliente_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Location = new System.Drawing.Point(1051, 496);
            this.BtnAtualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(200, 76);
            this.BtnAtualizar.TabIndex = 4;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(1269, 496);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(200, 76);
            this.BtnFechar.TabIndex = 5;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(827, 496);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(200, 76);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar Cliente Selecionado";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(61, 49);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(340, 29);
            this.txtPesquisar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pesquisar Cliente por Nome";
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(419, 49);
            this.BtnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(192, 29);
            this.BtnPesquisar.TabIndex = 1;
            this.BtnPesquisar.Text = "Executar pesquisa ";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // chbAtivo
            // 
            this.chbAtivo.AutoSize = true;
            this.chbAtivo.Checked = true;
            this.chbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAtivo.Location = new System.Drawing.Point(61, 84);
            this.chbAtivo.Name = "chbAtivo";
            this.chbAtivo.Size = new System.Drawing.Size(72, 25);
            this.chbAtivo.TabIndex = 7;
            this.chbAtivo.Text = "Ativos";
            this.chbAtivo.UseVisualStyleBackColor = true;
            // 
            // chbInativos
            // 
            this.chbInativos.AutoSize = true;
            this.chbInativos.Location = new System.Drawing.Point(139, 84);
            this.chbInativos.Name = "chbInativos";
            this.chbInativos.Size = new System.Drawing.Size(83, 25);
            this.chbInativos.TabIndex = 8;
            this.chbInativos.Text = "Inativos";
            this.chbInativos.UseVisualStyleBackColor = true;
            // 
            // FormListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1554, 631);
            this.Controls.Add(this.chbInativos);
            this.Controls.Add(this.chbAtivo);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnNovoCliente);
            this.Controls.Add(this.dgvClientes);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormListarClientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormListarClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormListarClientes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button BtnNovoCliente;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.CheckBox chbAtivo;
        private System.Windows.Forms.CheckBox chbInativos;
    }
}