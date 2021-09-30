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
    public partial class FormCadastroVenda : Form
    {
        #region Variáveis

        ProdutoBLL produtoBLL = new ProdutoBLL();
        ClienteBLL clienteBLL = new ClienteBLL();
        BindingList<ItensVenda> items = new BindingList<ItensVenda>();
        VendaBLL vendaBLL = new VendaBLL();

        #endregion

        #region Construtor

        public FormCadastroVenda()
        {
            InitializeComponent();

            this.Load += FormCadastroVenda_Load;
            this.txtIDCliente.Enabled = false;
            this.txtNomeCliente.Enabled = false;
            BtnSelecionarCliente.Click += BtnSelecionarCliente_Click;
        }

        #endregion

        #region Métodos

        private void AtualizarGridProdutos()
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

        private void AtualizarTextBox()
        {
            txtIDProduto.Text = "";
            txtNomeProduto.Text = "";
            txtPrecoUnitarioItem.Text = "";
            txtQuantidadeVenda.Text = "";
        }

        private void AtualizarTextBoxCliente()
        {
            txtIDCliente.Text = "";
            txtNomeCliente.Text = "";
        }

        #endregion

        #region Eventos

        private void FormCadastroVenda_Load(object sender, EventArgs e)
        {
            AtualizarGridProdutos();

            dgvProdutos.AutoResizeColumns();
        }

        //1o Passo Selecionar Produto 
        private void BtnConfirmarProduto_Click(object sender, EventArgs e)
        {
            Produto itemSelecionado = (Produto)this.dgvProdutos.SelectedRows[0].DataBoundItem;
            txtIDProduto.Text = Convert.ToString(itemSelecionado.ID);
            txtNomeProduto.Text = itemSelecionado.Nome;
            txtPrecoUnitarioItem.Text = Convert.ToString(itemSelecionado.PrecoUnitario);
        }

        //2o Passo Selecionar Cliente
        private void BtnSelecionarCliente_Click(object sender, EventArgs e)
        {
            FormListarClientes frm = new FormListarClientes();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
            if (frm.ClienteSelecionado == null)
            {
                return;
            }
            this.txtIDCliente.Text = frm.ClienteSelecionado.IDCliente.ToString();
            this.txtNomeCliente.Text = frm.ClienteSelecionado.Nome;
        }
       
        //3o Passo Incluir item na Lista desta venda
        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            ItensVenda itensVenda = new ItensVenda();

            itensVenda.IDProduto = Convert.ToInt32(txtIDProduto.Text);
            itensVenda.Produto.Nome = txtNomeProduto.Text;
            itensVenda.Quantidade = Convert.ToDouble(txtQuantidadeVenda.Text);
            itensVenda.PrecoUnitario = Convert.ToDouble(txtPrecoUnitarioItem.Text);
            items.Add(itensVenda);

            dgvItensVenda.DataSource = items;
            AtualizarTextBox();
        }

        //4o Passo Enviar lista de itens para o banco de dados e finalizar a venda
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            try
            {
                venda.IDCliente = int.Parse(txtIDCliente.Text);
                venda.Items = items.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Houve falha no recebimento das informações, a seguir seguem instruções para correto preenchimento das informações ! Obrigado.");
            }
            
            Response response = vendaBLL.SellProducts(venda);
            MessageBox.Show(response.Message);
            AtualizarGridProdutos();
            AtualizarTextBoxCliente();
            dgvItensVenda.DataSource = new List<ItensVenda>();
        }

        private void txtQuantidadeVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dgvProdutos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dgvProdutos.Rows[e.RowIndex].Cells[4].Style.Format = "C2";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
