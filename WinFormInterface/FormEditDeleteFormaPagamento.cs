using BusinessLogical;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormInterface
{
    public partial class FormEditDeleteFormaPagamento : Form
    {
        #region Variáveis

        private FormaPagamentoBLL formaPagamentoBLL = new FormaPagamentoBLL();

        #endregion

        #region Construtor

        public FormEditDeleteFormaPagamento(FormaPagamento fp)
        {
            InitializeComponent();
            this.txtID.Text = fp.ID.ToString();
            this.txtFormaPagamento.Text = fp.Descricao;
        }

        #endregion

        #region Eventos

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Response r = formaPagamentoBLL.Update(new FormaPagamento()
            {
                ID = int.Parse(txtID.Text),
                Descricao = txtFormaPagamento.Text
            });
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Response r = formaPagamentoBLL.Delete(int.Parse(txtID.Text));
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
