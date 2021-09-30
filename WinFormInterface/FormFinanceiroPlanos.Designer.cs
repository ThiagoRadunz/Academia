
namespace WinFormInterface
{
    partial class FormFinanceiroPlanos
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
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.txtIDInstrutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFiltroInstrutor = new System.Windows.Forms.ComboBox();
            this.dgvPlanoInstrutorCliente = new System.Windows.Forms.DataGridView();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanoInstrutorCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(1329, 96);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(200, 76);
            this.BtnCalcular.TabIndex = 72;
            this.BtnCalcular.Text = "Calcular  comissao do Instrutor Selecionado";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // txtIDInstrutor
            // 
            this.txtIDInstrutor.Enabled = false;
            this.txtIDInstrutor.Location = new System.Drawing.Point(28, 47);
            this.txtIDInstrutor.Name = "txtIDInstrutor";
            this.txtIDInstrutor.Size = new System.Drawing.Size(40, 29);
            this.txtIDInstrutor.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 70;
            this.label5.Text = "Cód.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 69;
            this.label1.Text = "Filtrar por Instrutor";
            // 
            // cbFiltroInstrutor
            // 
            this.cbFiltroInstrutor.FormattingEnabled = true;
            this.cbFiltroInstrutor.Location = new System.Drawing.Point(74, 47);
            this.cbFiltroInstrutor.Name = "cbFiltroInstrutor";
            this.cbFiltroInstrutor.Size = new System.Drawing.Size(300, 29);
            this.cbFiltroInstrutor.TabIndex = 68;
            // 
            // dgvPlanoInstrutorCliente
            // 
            this.dgvPlanoInstrutorCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanoInstrutorCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanoInstrutorCliente.Location = new System.Drawing.Point(27, 96);
            this.dgvPlanoInstrutorCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPlanoInstrutorCliente.Name = "dgvPlanoInstrutorCliente";
            this.dgvPlanoInstrutorCliente.ReadOnly = true;
            this.dgvPlanoInstrutorCliente.Size = new System.Drawing.Size(1246, 421);
            this.dgvPlanoInstrutorCliente.TabIndex = 67;
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(1329, 221);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(200, 29);
            this.txtComissao.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1325, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 74;
            this.label2.Text = "Comissao";
            // 
            // FormFinanceiroPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1624, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.txtIDInstrutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFiltroInstrutor);
            this.Controls.Add(this.dgvPlanoInstrutorCliente);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormFinanceiroPlanos";
            this.Text = "FormFinanceiroPlanos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanoInstrutorCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox txtIDInstrutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFiltroInstrutor;
        private System.Windows.Forms.DataGridView dgvPlanoInstrutorCliente;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Label label2;
    }
}