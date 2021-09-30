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
    public partial class FormListarAtendentes : Form
    {
        #region Variáveis

        AtendenteBLL atendenteBLL = new AtendenteBLL();

        #endregion

        #region Construtor

        public FormListarAtendentes()
        {
            InitializeComponent();

            this.txtPesquisar.KeyPress += TxtPesquisar_KeyPress;
        }

        #endregion

        #region Métodos

        private void AtualizarGrid()
        {
            DataResponse<Atendente> response = atendenteBLL.GetAll();
            if (response.Success)
            {
                this.dgvAtendentes.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
        private void AtualizarGridSearchAtivos()
        {
            DataResponse<Atendente> response = atendenteBLL.SearchAtivos(txtPesquisar.Text);
            if (response.Success)
            {
                this.dgvAtendentes.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
        private void AtualizarGridSearchInativos()
        {
            DataResponse<Atendente> response = atendenteBLL.SearchInativos(txtPesquisar.Text);
            if (response.Success)
            {
                this.dgvAtendentes.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
        private void AtualizarGridSearch()
        {
            DataResponse<Atendente> response = atendenteBLL.Search(txtPesquisar.Text);
            if (response.Success)
            {
                this.dgvAtendentes.DataSource = response.Data;
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

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            //Somente Ativos
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

        private void FormListarAtendentes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListarAtendentes_Load(object sender, EventArgs e)
        {
            AtualizarGrid();

        }

        private void BtnNovoAtendente_Click(object sender, EventArgs e)
        {
            FormCadastroAtendente fca = new FormCadastroAtendente();
            fca.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Atendente itemSelecionado = (Atendente)this.dgvAtendentes.SelectedRows[0].DataBoundItem;
            this.Visible = false;
            FormUpdateAtendente fua = new FormUpdateAtendente(itemSelecionado);
            fua.ShowDialog();
            this.Visible = true;
        }

        private void BtnMaisInformacoes_Click(object sender, EventArgs e)
        {
            Atendente itemSelecionado = (Atendente)this.dgvAtendentes.SelectedRows[0].DataBoundItem;
            
            this.Visible = false;
            FormInformacoesAtendentes fia = new FormInformacoesAtendentes(itemSelecionado);
            fia.ShowDialog();
            this.Visible = true;
        }

        #endregion
    }
}
