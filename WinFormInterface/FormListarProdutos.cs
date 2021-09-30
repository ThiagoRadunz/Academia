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

    public partial class FormListarProdutos : Form
    {
        #region Variáveis

        ProdutoBLL produtoBLL = new ProdutoBLL();

        #endregion

        #region Construtor

        public FormListarProdutos()
        {
            InitializeComponent();

            this.Load += FormListarProdutos_Load;
            this.txtPesquisar.TextChanged += TxtPesquisar_TextChanged;
        }

        

        #endregion

        #region Métodos

        private void AtualizarGrid()
        {
            DataResponse<Produto> response = produtoBLL.GetAll();
            if (response.Success)
            {
                this.dgvProdutos.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void AtualizarGridSearchName()
        {
            DataResponse<Produto> response = produtoBLL.SearchName(txtPesquisar.Text);
            if (response.Success)
            {
                this.dgvProdutos.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void AtualizarGridSearchCategory()
        {
            DataResponse<Produto> response = produtoBLL.SearchCategory(txtPesquisar.Text);
            if (response.Success)
            {
                this.dgvProdutos.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void AtualizarGridSearchNameAndCategory()
        {
            DataResponse<Produto> response = produtoBLL.SearchNameAndCategory(txtPesquisar.Text);
            if (response.Success)
            {
                this.dgvProdutos.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        #endregion

        #region Eventos

        private void FormListarProdutos_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void BtnNovoProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto pcProd = new FormCadastroProduto();
            this.Visible = false;
            pcProd.ShowDialog();
            this.Visible = true;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            //Somente Nome
            if (chbNome.Checked && !chbCategoria.Checked)
            {
                AtualizarGridSearchName();
            }
            //Somente Inativos
            else if (!chbNome.Checked && chbCategoria.Checked)
            {
                AtualizarGridSearchCategory();
            }
            //Todos
            else if ((chbNome.Checked && chbCategoria.Checked) || (!chbNome.Checked && !chbCategoria.Checked))
            {
                AtualizarGridSearchNameAndCategory();
            }
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            //Somente Nome
            if (chbNome.Checked && !chbCategoria.Checked)
            {
                AtualizarGridSearchName();
            }
            //Somente Categoria
            else if (!chbNome.Checked && chbCategoria.Checked)
            {

                AtualizarGridSearchCategory();
            }
            //Pesquisa tanto nos campos de nome e de categoria do produto. Ou seja, pesquisa todos.
            else if ((chbNome.Checked && chbCategoria.Checked) || (!chbNome.Checked && !chbCategoria.Checked))
            {
                AtualizarGridSearchNameAndCategory();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Produto itemSelecionado = (Produto)this.dgvProdutos.SelectedRows[0].DataBoundItem;
            this.Visible = false;
            FormUpdateProduto fuProd = new FormUpdateProduto(itemSelecionado);
            fuProd.ShowDialog();
            AtualizarGrid();
            this.Visible = true;
        }

        //private void btnExcluir_Click(object sender, EventArgs e)
        //{

        //    Produto itemSelecionado = (Produto)this.dgvProdutos.SelectedRows[0].DataBoundItem;
        //    MessageBox.Show(produtoBLL.Delete(itemSelecionado.ID).Message.ToString());
        //    if (chbNome.Checked && !chbCategoria.Checked)
        //    {
        //        AtualizarGridSearchName();
        //    }
        //    else if (!chbNome.Checked && chbCategoria.Checked)
        //    {

        //        AtualizarGridSearchCategory();
        //    }
        //    else if ((chbNome.Checked && chbCategoria.Checked) || (!chbNome.Checked && !chbCategoria.Checked))
        //    {
        //        AtualizarGridSearchNameAndCategory();
        //    }
        //}

        #endregion


    }
}
