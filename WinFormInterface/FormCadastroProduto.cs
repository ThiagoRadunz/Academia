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
    public partial class FormCadastroProduto : Form
    {
        //revisado
        #region Variáveis

        ProdutoBLL produtoBLL = new ProdutoBLL();
        CategoriaBLL categoriaBLL = new CategoriaBLL();

        #endregion

        #region Construtor

        public FormCadastroProduto()
        {
            InitializeComponent();

            //Usuario u = SystemParameters.GetCurrentFuncionario();
            //SingleResponse<Atendente> atendenteUsandoOSistema =
            //    new AtendenteBLL().GetPerson(u.IDUsuario);

            this.Load += FormCadastroProduto_Load;
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

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            DataResponse<Categoria> response = categoriaBLL.GetAll();
            if (response.Success)
            {
                cbCategoria.DataSource = response.Data;
                cbCategoria.ValueMember = "ID";
                cbCategoria.DisplayMember = "Nome";
            }
            AtualizarGrid();
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            try
            {
                produto.Nome = txtNome.Text;
                produto.Descricao = txtDescricao.Text;
                produto.Categoria.ID = (int)cbCategoria.SelectedValue;
                produto.PrecoUnitario = Convert.ToDouble(txtPrecoUnitario.Text);
                produto.QtdEstoque = Convert.ToDouble(txtQtdEstoque.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Houve falha no recebimento das informações, a seguir seguem instruções para correto preenchimento das informações ! Obrigado. ");
            }

            Response response = produtoBLL.Insert(produto);
            MessageBox.Show(response.Message);
            AtualizarGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        #endregion

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
    }
}
