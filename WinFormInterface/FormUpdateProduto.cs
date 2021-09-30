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
    public partial class FormUpdateProduto : Form
    {
        #region Variáveis

        ProdutoBLL produtoBLL = new ProdutoBLL();
        CategoriaBLL categoriaBLL = new CategoriaBLL();
        Produto produtoPassadoPorParametro = null;

        #endregion

        #region Construtor

        public FormUpdateProduto(Produto produto)
        {
            InitializeComponent();
            this.produtoPassadoPorParametro = produto;

            txtNome.Text = produto.Nome;
            txtDescricao.Text = produto.Descricao;
            txtPrecoUnitario.Text = produto.PrecoUnitario.ToString("C2");
            txtQtdEstoque.Text = produto.QtdEstoque.ToString();
            txtIDProduto.Text = produto.ID.ToString();

            this.Load += FormUpdateProduto_Load;
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
            dgvProdutos.AutoResizeColumns();
        }

        #endregion

        #region Eventos

        private void FormUpdateProduto_Load(object sender, EventArgs e)
        {
            //popula a combobox com todas as modalidades do sistema
            DataResponse<Categoria> response = categoriaBLL.GetAll();
            if (response.Success)
            {
                cbCategoria.DataSource = response.Data;
                cbCategoria.ValueMember = "ID";
                cbCategoria.DisplayMember = "Nome";
                
            }
            //Seta a combobox com a modalidade que o cliente foi cadastrado
            for (int i = 0; i < cbCategoria.Items.Count; i++)
            {
                Categoria c =  (Categoria)cbCategoria.Items[i];
                if (c.Nome == produtoPassadoPorParametro.Categoria.Nome)
                {
                    cbCategoria.SelectedIndex = i;
                    break;
                }
            }
            AtualizarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.ID = Convert.ToInt32(txtIDProduto.Text);
            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Categoria.ID = (int)cbCategoria.SelectedValue;
            var product = txtPrecoUnitario.Text.Trim().Replace("R$", "").Replace(" ", "");
            produto.PrecoUnitario = Convert.ToDouble(product);
            produto.QtdEstoque = Convert.ToDouble(txtQtdEstoque.Text);

            Response response = produtoBLL.Update(produto);
            MessageBox.Show(response.Message);
            MessageBox.Show("Verificar se modalidade está correta !");//ver tambem como melhorar set da categoria

            AtualizarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Response r = produtoBLL.Delete(int.Parse(txtIDProduto.Text));
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

        private void txtQtdEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.Handled = (sender as TextBox).Text.Contains(",");
            }
            else if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
