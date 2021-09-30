using BusinessLogical;
using Entities;
using Entities.ViewModel;
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
    public partial class FormListarClientes : Form
    {
        #region Variáveis

        ClienteBLL clienteBLL = new ClienteBLL();

        #endregion

        #region Propriedades

        public Cliente ClienteSelecionado { get; private set; }

        #endregion

        #region Construtor

        public FormListarClientes()
        {
            InitializeComponent();
            this.Load += FormListarClientes_Load;
        }

        #endregion

        #region Métodos

        private void AtualizarGridSearchSomenteAtivos()
        {
            DataResponse<Cliente> response = clienteBLL.SearchAtives(txtPesquisar.Text);
            if (response.Success)
            {
                this.dgvClientes.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void AtualizarGridSearchSomenteInativos()
        {
            DataResponse<Cliente> response = clienteBLL.SearchInatives(txtPesquisar.Text);
            if (response.Success)
            {
                this.dgvClientes.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void AtualizarGridSearchTodos()
        {
            DataResponse<Cliente> response = clienteBLL.Search(txtPesquisar.Text);
            if (response.Success)
            {
                this.dgvClientes.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void AtualizarGrid()
        {
            DataResponse<Cliente> response = clienteBLL.GetAll();
            if (response.Success)
            {
                this.dgvClientes.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        #endregion

        #region Eventos

        private void FormListarClientes_Load(object sender, EventArgs e)
        {
            if (chbAtivo.Checked && !chbInativos.Checked)
            {
                AtualizarGridSearchSomenteAtivos();
            }
            else if (chbInativos.Checked && !chbAtivo.Checked)
            {
                AtualizarGridSearchSomenteInativos();
            }
            else
            {
                AtualizarGrid();
            }
            
        }

        private void BtnNovoCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente fcc = new FormCadastroCliente();
            this.Visible = false;
            fcc.ShowDialog();
            AtualizarGrid();
            this.Visible = true;
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            //somente ativos
            if (chbAtivo.Checked && !chbInativos.Checked)
            {
                AtualizarGridSearchSomenteAtivos();
            }
            //somente inativos
            else if (chbInativos.Checked && !chbAtivo.Checked)
            {
                AtualizarGridSearchSomenteInativos();
            }
            //todos
            else
            {
                AtualizarGrid();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Cliente itemSelecionado = (Cliente)this.dgvClientes.SelectedRows[0].DataBoundItem;
            this.Visible = false;
            FormUpdateCliente fuc = new FormUpdateCliente(itemSelecionado);
            fuc.ShowDialog();
            this.Visible = true;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            //Somente Clientes Ativo
            if (chbAtivo.Checked && !chbInativos.Checked)
            {
                AtualizarGridSearchSomenteAtivos();
            }
            //Somente Clientes Inativos
            else if (chbInativos.Checked && !chbAtivo.Checked)
            {
                
                AtualizarGridSearchSomenteInativos();
            }
            //Todos os Clientes
            else if (chbInativos.Checked && chbAtivo.Checked)
            {
                
                AtualizarGridSearchTodos();
            }
        }

        private void FormListarClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        //Na tela FormCadastroVenda o usuario é encaminhado até esta tela para selecionar um cliente, o cliente selecionado é armazenado na propriedade deste form
        
        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ClienteSelecionado = this.dgvClientes.Rows[e.RowIndex].DataBoundItem as Cliente;
            this.Close();
        }

        #endregion
    }
}
