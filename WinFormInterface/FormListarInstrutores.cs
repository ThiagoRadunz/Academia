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
    public partial class FormListarInstrutores : Form
    {
        #region Variáveis

        InstrutorBLL instrutorBLL = new InstrutorBLL();

        #endregion

        #region Construtor

        public FormListarInstrutores()
        {
            InitializeComponent();

            this.txtPesquisar.KeyPress += TxtPesquisar_KeyPress;
            BtnPesquisar.Click += BtnPesquisar_Click;
        }

        #endregion

        #region Métodos

        private void AtualizarGridSearchAtivos()
        {
            DataResponse<Instrutor> response = instrutorBLL.SearchAtivos(txtPesquisar.Text);
            if (response.Success)
            {
                this.dgvInstrutores.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void AtualizarGridSearchInativos()
        {
            DataResponse<Instrutor> response = instrutorBLL.SearchInativos(txtPesquisar.Text);
            if (response.Success)
            {
                this.dgvInstrutores.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void AtualizarGridSearch()
        {
            DataResponse<Instrutor> response = instrutorBLL.Search(txtPesquisar.Text);
            if (response.Success)
            {
                this.dgvInstrutores.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
        private void AtualizarGridSomenteAtivos()
        {
            DataResponse<Instrutor> response = instrutorBLL.GetAllAtivos();
            if (response.Success)
            {
                this.dgvInstrutores.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
        private void AtualizarGridSomenteInativos()
        {
            DataResponse<Instrutor> response = instrutorBLL.GetAllInativos();
            if (response.Success)
            {
                this.dgvInstrutores.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
        private void AtualizarGrid()
        {
            DataResponse<Instrutor> response = instrutorBLL.GetAll();
            if (response.Success)
            {
                this.dgvInstrutores.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        #endregion

        #region Eventos

        private void TxtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.BtnPesquisar_Click(sender, e);
        }

        private void FormListarInstrutores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void BtnMaisInformacoes_Click(object sender, EventArgs e)
        {
            Instrutor itemSelecionado = (Instrutor)this.dgvInstrutores.SelectedRows[0].DataBoundItem;
            this.Visible = false;
            FormInformacoesInstrutor fii = new FormInformacoesInstrutor(itemSelecionado);
            fii.ShowDialog();
            this.Visible = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Instrutor itemSelecionado = (Instrutor)this.dgvInstrutores.SelectedRows[0].DataBoundItem;
            this.Visible = false;
            FormUpdateInstrutor fua = new FormUpdateInstrutor(itemSelecionado);
            fua.ShowDialog();
            this.Visible = true;
            AtualizarGrid();
        }

        private void BtnNovoInstrutor_Click(object sender, EventArgs e)
        {
            FormCadastroInstrutor fci = new FormCadastroInstrutor();
            fci.ShowDialog();
        }

        private void FormListarInstrutores_Load(object sender, EventArgs e)
        {
            if (chbAtivo.Checked && !chbInativos.Checked)
            {
                AtualizarGridSomenteAtivos();
            }
            else if (chbInativos.Checked && !chbAtivo.Checked)
            {
                AtualizarGridSomenteInativos();
            }
            else
            {
                AtualizarGrid();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            //Somente Ativo
            if (chbAtivo.Checked && !chbInativos.Checked)
            {
                AtualizarGridSearchAtivos();
            }
            //Somente Inativos
            else if (chbInativos.Checked && !chbAtivo.Checked)
            {
                AtualizarGridSearchInativos();
            }
            //Todos
            else if (chbInativos.Checked && chbAtivo.Checked)
            {
                AtualizarGridSearch();
            }
        }

        #endregion
    }
}
