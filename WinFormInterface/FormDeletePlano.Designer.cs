
namespace WinFormInterface
{
    partial class FormDeletePlano
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoriaID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAulaSemana = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDuracaoPlano = new System.Windows.Forms.TextBox();
            this.lblPrecoNum = new System.Windows.Forms.Label();
            this.lblPrecoTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(565, 436);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(225, 39);
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(307, 43);
            this.txtID.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(484, 29);
            this.txtID.TabIndex = 27;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(304, 436);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(213, 39);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Excluir";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Categoria";
            // 
            // txtCategoriaID
            // 
            this.txtCategoriaID.Enabled = false;
            this.txtCategoriaID.Location = new System.Drawing.Point(307, 121);
            this.txtCategoriaID.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtCategoriaID.Name = "txtCategoriaID";
            this.txtCategoriaID.Size = new System.Drawing.Size(484, 29);
            this.txtCategoriaID.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Aulas por semana";
            // 
            // txtAulaSemana
            // 
            this.txtAulaSemana.Enabled = false;
            this.txtAulaSemana.Location = new System.Drawing.Point(306, 208);
            this.txtAulaSemana.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtAulaSemana.Name = "txtAulaSemana";
            this.txtAulaSemana.Size = new System.Drawing.Size(484, 29);
            this.txtAulaSemana.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Duração  do plano (Meses)";
            // 
            // txtDuracaoPlano
            // 
            this.txtDuracaoPlano.Enabled = false;
            this.txtDuracaoPlano.Location = new System.Drawing.Point(306, 288);
            this.txtDuracaoPlano.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtDuracaoPlano.Name = "txtDuracaoPlano";
            this.txtDuracaoPlano.Size = new System.Drawing.Size(484, 29);
            this.txtDuracaoPlano.TabIndex = 32;
            // 
            // lblPrecoNum
            // 
            this.lblPrecoNum.AutoSize = true;
            this.lblPrecoNum.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoNum.Location = new System.Drawing.Point(542, 351);
            this.lblPrecoNum.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblPrecoNum.Name = "lblPrecoNum";
            this.lblPrecoNum.Size = new System.Drawing.Size(108, 37);
            this.lblPrecoNum.TabIndex = 35;
            this.lblPrecoNum.Text = "R$ 0.00";
            // 
            // lblPrecoTxt
            // 
            this.lblPrecoTxt.AutoSize = true;
            this.lblPrecoTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoTxt.Location = new System.Drawing.Point(431, 351);
            this.lblPrecoTxt.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblPrecoTxt.Name = "lblPrecoTxt";
            this.lblPrecoTxt.Size = new System.Drawing.Size(100, 37);
            this.lblPrecoTxt.TabIndex = 34;
            this.lblPrecoTxt.Text = "Preço :";
            // 
            // FormDeletePlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.lblPrecoNum);
            this.Controls.Add(this.lblPrecoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDuracaoPlano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAulaSemana);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoriaID);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDeletePlano";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Plano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoriaID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAulaSemana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDuracaoPlano;
        private System.Windows.Forms.Label lblPrecoNum;
        private System.Windows.Forms.Label lblPrecoTxt;
    }
}