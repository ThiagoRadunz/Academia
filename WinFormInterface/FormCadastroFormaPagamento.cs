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
    public partial class FormCadastroFormaPagamento : Form
    {
        //revisado
        #region Variáveis
        
        private FormaPagamentoBLL formaPagamentoBLL = new FormaPagamentoBLL();

        #endregion

        #region Construtor

        public FormCadastroFormaPagamento()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        private void AtualizarGrid()
        {
            DataResponse<FormaPagamento> response = formaPagamentoBLL.GetAll();
            if (response.Success)
            {
                this.dgvFormasPagamento.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        #endregion

        #region Eventos

        
        private void FormCadastroFormaPagamento_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dgvFormasPagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormaPagamento fp = (FormaPagamento)this.dgvFormasPagamento.Rows[e.RowIndex].DataBoundItem;
            FormEditDeleteFormaPagamento fpEditDel = new FormEditDeleteFormaPagamento(fp);
            this.Visible = false;
            fpEditDel.ShowDialog();
            this.Visible = true;
            this.AtualizarGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormaPagamento fpag = new FormaPagamento();
            fpag.Descricao = txtCategoria.Text;

            Response response = formaPagamentoBLL.Insert(fpag);
            MessageBox.Show(response.Message);
            AtualizarGrid();
            FormCleaner.ClearForm(this);
        }

        #endregion
    }
}
