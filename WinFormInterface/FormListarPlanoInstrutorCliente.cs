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
    public partial class FormListarPlanoInstrutorCliente : Form
    {
        #region Variáveis

        PlanoInstrutorClienteBLL picBLL = new PlanoInstrutorClienteBLL();
        InstrutorBLL instrutorBLL = new InstrutorBLL();
        ClienteBLL clienteBLL = new ClienteBLL();
        CategoriaBLL categoriaBLL = new CategoriaBLL();
        List<PlanoInstrutorClienteQueryView> dadosBanco = null;

        #endregion

        #region Construtor

        public FormListarPlanoInstrutorCliente()
        {
            InitializeComponent();

            this.Load += FormListarPlanoInstrutorCliente_Load;
            this.dgvPlanoInstrutorCliente.RowsAdded += DgvPlanoInstrutorCliente_RowsAdded;
            this.dgvPlanoInstrutorCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanoInstrutorCliente.MultiSelect = false;
            

            DataResponse<Instrutor> instrutores = instrutorBLL.GetAll();
            cbFiltroInstrutor.DataSource = instrutores.Data;
            cbFiltroInstrutor.ValueMember = "IDInstrutor";
            cbFiltroInstrutor.DisplayMember = "Usuario";

            cbFiltroInstrutor.SelectedIndexChanged += CbFiltroInstrutor_SelectedIndexChanged;

            DataResponse<Cliente> clientes = clienteBLL.GetAll();
            cbFiltroCliente.DataSource = clientes.Data;
            cbFiltroCliente.ValueMember = "IDCliente";
            cbFiltroCliente.DisplayMember = "Nome";

            cbFiltroCliente.SelectedIndexChanged += CbFiltroCliente_SelectedIndexChanged;

            DataResponse<Categoria> categorias = categoriaBLL.GetAll();
            cbFiltroModalidade.DataSource = categorias.Data;
            cbFiltroModalidade.ValueMember = "ID";
            cbFiltroModalidade.DisplayMember = "Nome";

            cbFiltroModalidade.SelectedIndexChanged += CbFiltroModalidade_SelectedIndexChanged;

            AtualizarTextBox();

        }

        #endregion
        
        #region Métodos

        private void AtualizarTextBox()
        {
            txtIDCliente.Text = Convert.ToString(cbFiltroCliente.SelectedValue);
            txtIDInstrutor.Text = Convert.ToString(cbFiltroInstrutor.SelectedValue);
            txtIDModalidade.Text = Convert.ToString(cbFiltroModalidade.SelectedValue);
        }

        private void AtualizarGridbyIDModalidade()
        {
            DataResponse<PlanoInstrutorClienteQueryView> response = picBLL.GetAllbyIDModalidade(int.Parse(txtIDModalidade.Text));
            if (response.Success)
            {
                this.dgvPlanoInstrutorCliente.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void AtualizarGridbyIDCliente()
        {
            DataResponse<PlanoInstrutorClienteQueryView> response = picBLL.GetAllbyIDCliente(int.Parse(txtIDCliente.Text));
            if (response.Success)
            {
                this.dgvPlanoInstrutorCliente.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void AtualizarGridbyIDInstrutor()
        {
            DataResponse<PlanoInstrutorClienteQueryView> response = picBLL.GetAllbyIDInstrutor(int.Parse(txtIDInstrutor.Text));
            if (response.Success)
            {
                this.dgvPlanoInstrutorCliente.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void AtualizarGrid()
        {
            DataResponse<PlanoInstrutorClienteQueryView> response = picBLL.GetAll();
            if (response.Success)
            {
                this.dadosBanco = response.Data;
                this.dgvPlanoInstrutorCliente.DataSource = this.dadosBanco;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        #endregion

        #region Eventos

        private void CbFiltroModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTextBox();
            AtualizarGridbyIDModalidade();
        }

        private void CbFiltroCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTextBox();
            AtualizarGridbyIDCliente();
        }

        private void CbFiltroInstrutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTextBox();
            AtualizarGridbyIDInstrutor();
        }

        private void DgvPlanoInstrutorCliente_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dgvPlanoInstrutorCliente.Rows[e.RowIndex].Cells["Valor"].Style.Format = "C2";
        }
        private void BtnAddPlanoCliente_Click(object sender, EventArgs e)
        {
            if (this.dgvPlanoInstrutorCliente.SelectedRows == null || this.dgvPlanoInstrutorCliente.SelectedRows.Count == 0)
            {
                PlanoInstrutorClienteQueryView view = new PlanoInstrutorClienteQueryView();
                this.Visible = false;
                FormAddPic faddPic = new FormAddPic(int.Parse(txtIDCliente.Text));
                faddPic.ShowDialog();
                this.Visible = true;
                AtualizarGrid();
            }
            else
            {
                PlanoInstrutorClienteQueryView itemSelecionado = (PlanoInstrutorClienteQueryView)this.dgvPlanoInstrutorCliente.SelectedRows[0].DataBoundItem;
                this.Visible = false;
                FormAddPic faddPic = new FormAddPic(itemSelecionado);
                faddPic.ShowDialog();
                this.Visible = true;
                AtualizarGrid();
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListarPlanoInstrutorCliente_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        #endregion

        
    }



}
