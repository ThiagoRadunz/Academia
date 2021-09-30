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
    public partial class FormCadastroEntradaProdutos : Form
    {
        //revisado
        #region Variáveis

        ProdutoBLL produtoBLL = new ProdutoBLL();
        BindingList<ItensEntrada> items = new BindingList<ItensEntrada>();
        EntradaProdutosBLL entradaProdutosBLL = new EntradaProdutosBLL();

        #endregion

        #region Construtor

        public FormCadastroEntradaProdutos()
        {
            InitializeComponent();

            this.Load += FormCadastroEntradaProdutos_Load;
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

        #endregion

        #region Eventos

        
        private void FormCadastroEntradaProdutos_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            dgvProdutos.AutoResizeColumns();
        }

        //1o Passo = Selecionar item na grid
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Produto itemSelecionado = (Produto)this.dgvProdutos.SelectedRows[0].DataBoundItem;
            txtIDProduto.Text = Convert.ToString(itemSelecionado.ID);
            txtNome.Text = itemSelecionado.Nome;
            txtDescricao.Text = itemSelecionado.Descricao;
            txtCategoria.Text = itemSelecionado.Categoria.Nome;
            txtPrecoUnitarioAtual.Text = Convert.ToString(itemSelecionado.PrecoUnitario);
            txtEstoqueAtual.Text = Convert.ToString(itemSelecionado.QtdEstoque);
        }

        //2o Passo = Incluir na lista de itens entrada
        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            ItensEntrada item = new ItensEntrada();

            item.IDProduto = int.Parse(txtIDProduto.Text);
            item.Produto.Nome = txtNome.Text;
            item.Produto.Descricao = txtDescricao.Text;
            item.Quantidade = double.Parse(txtQuantidadeEntrada.Text);
            item.PrecoUnitario = double.Parse(txtPrecoUnitarioEntrada.Text);
            items.Add(item);

            dgvItensEntrada.DataSource = items;
            FormCleaner.ClearForm(this);
        }

        //3o Passo = Registrar a entrada completa com qtd e preco unitario
        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            EntradaProdutos entrada = new EntradaProdutos();
            entrada.Items = items.ToList();

            Response response = entradaProdutosBLL.Includer(entrada);
            MessageBox.Show(response.Message);
            AtualizarGrid();
            
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            dgvItensEntrada.ClearSelection();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormCadastroProduto fcProd = new FormCadastroProduto();
            fcProd.ShowDialog();
            AtualizarGrid();
            this.Visible = true;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void txtQuantidadeEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPrecoUnitarioEntrada_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvProdutos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dgvProdutos.Rows[e.RowIndex].Cells[4].Style.Format = "C2";
        }
    }
}
