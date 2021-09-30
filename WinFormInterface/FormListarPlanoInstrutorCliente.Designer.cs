
namespace WinFormInterface
{
    partial class FormListarPlanoInstrutorCliente
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
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnAddPlanoCliente = new System.Windows.Forms.Button();
            this.dgvPlanoInstrutorCliente = new System.Windows.Forms.DataGridView();
            this.cbFiltroInstrutor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFiltroCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFiltroModalidade = new System.Windows.Forms.ComboBox();
            this.txtIDModalidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDInstrutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanoInstrutorCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(1279, 541);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(200, 76);
            this.BtnFechar.TabIndex = 7;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Location = new System.Drawing.Point(1061, 541);
            this.BtnAtualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(200, 76);
            this.BtnAtualizar.TabIndex = 6;
            this.BtnAtualizar.Text = "Todos os contratos";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnAddPlanoCliente
            // 
            this.BtnAddPlanoCliente.Location = new System.Drawing.Point(833, 541);
            this.BtnAddPlanoCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddPlanoCliente.Name = "BtnAddPlanoCliente";
            this.BtnAddPlanoCliente.Size = new System.Drawing.Size(200, 76);
            this.BtnAddPlanoCliente.TabIndex = 5;
            this.BtnAddPlanoCliente.Text = "Adicionar Plano à Cliente";
            this.BtnAddPlanoCliente.UseVisualStyleBackColor = true;
            this.BtnAddPlanoCliente.Click += new System.EventHandler(this.BtnAddPlanoCliente_Click);
            // 
            // dgvPlanoInstrutorCliente
            // 
            this.dgvPlanoInstrutorCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanoInstrutorCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanoInstrutorCliente.Location = new System.Drawing.Point(71, 110);
            this.dgvPlanoInstrutorCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPlanoInstrutorCliente.Name = "dgvPlanoInstrutorCliente";
            this.dgvPlanoInstrutorCliente.ReadOnly = true;
            this.dgvPlanoInstrutorCliente.Size = new System.Drawing.Size(1408, 421);
            this.dgvPlanoInstrutorCliente.TabIndex = 4;
            // 
            // cbFiltroInstrutor
            // 
            this.cbFiltroInstrutor.FormattingEnabled = true;
            this.cbFiltroInstrutor.Location = new System.Drawing.Point(130, 52);
            this.cbFiltroInstrutor.Name = "cbFiltroInstrutor";
            this.cbFiltroInstrutor.Size = new System.Drawing.Size(300, 29);
            this.cbFiltroInstrutor.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtrar por Instrutor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filtrar por Cliente";
            // 
            // cbFiltroCliente
            // 
            this.cbFiltroCliente.FormattingEnabled = true;
            this.cbFiltroCliente.Location = new System.Drawing.Point(565, 52);
            this.cbFiltroCliente.Name = "cbFiltroCliente";
            this.cbFiltroCliente.Size = new System.Drawing.Size(300, 29);
            this.cbFiltroCliente.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1000, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Filtrar por Modalidade";
            // 
            // cbFiltroModalidade
            // 
            this.cbFiltroModalidade.FormattingEnabled = true;
            this.cbFiltroModalidade.Location = new System.Drawing.Point(1004, 52);
            this.cbFiltroModalidade.Name = "cbFiltroModalidade";
            this.cbFiltroModalidade.Size = new System.Drawing.Size(300, 29);
            this.cbFiltroModalidade.TabIndex = 12;
            // 
            // txtIDModalidade
            // 
            this.txtIDModalidade.Enabled = false;
            this.txtIDModalidade.Location = new System.Drawing.Point(954, 52);
            this.txtIDModalidade.Name = "txtIDModalidade";
            this.txtIDModalidade.Size = new System.Drawing.Size(40, 29);
            this.txtIDModalidade.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(950, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 21);
            this.label9.TabIndex = 60;
            this.label9.Text = "Cód.";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Enabled = false;
            this.txtIDCliente.Location = new System.Drawing.Point(519, 52);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(40, 29);
            this.txtIDCliente.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 62;
            this.label3.Text = "Cód.";
            // 
            // txtIDInstrutor
            // 
            this.txtIDInstrutor.Enabled = false;
            this.txtIDInstrutor.Location = new System.Drawing.Point(84, 52);
            this.txtIDInstrutor.Name = "txtIDInstrutor";
            this.txtIDInstrutor.Size = new System.Drawing.Size(40, 29);
            this.txtIDInstrutor.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 64;
            this.label5.Text = "Cód.";
            // 
            // FormListarPlanoInstrutorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1554, 642);
            this.Controls.Add(this.txtIDInstrutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDModalidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFiltroModalidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltroCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFiltroInstrutor);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnAddPlanoCliente);
            this.Controls.Add(this.dgvPlanoInstrutorCliente);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormListarPlanoInstrutorCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planos Contratados";
            this.Load += new System.EventHandler(this.FormListarPlanoInstrutorCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanoInstrutorCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnAddPlanoCliente;
        private System.Windows.Forms.DataGridView dgvPlanoInstrutorCliente;
        private System.Windows.Forms.ComboBox cbFiltroInstrutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFiltroCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFiltroModalidade;
        private System.Windows.Forms.TextBox txtIDModalidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDInstrutor;
        private System.Windows.Forms.Label label5;
    }
}