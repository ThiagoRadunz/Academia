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
    public partial class FormCadastroPlano : Form
    {
        //revisado
        #region Variáveis

        private PlanoBLL planoBLL = new PlanoBLL();
        private CategoriaBLL categoriaBLL = new CategoriaBLL();

        #endregion

        #region Construtores

        
        public FormCadastroPlano()
        {
            InitializeComponent();
           
            DataResponse<Categoria> categorias = categoriaBLL.GetAll();
            DataResponse<Plano> duracoesPlanos = planoBLL.GetAllPlansDuration();

            //popula 2 combobox : uma com todas as modalidades do sistema e a outra com a duração dos planos
            if (categorias.Success)
            {
                cbCategoria.DataSource = categorias.Data;
                cbCategoria.ValueMember = "ID";
                cbCategoria.DisplayMember = "Nome";
            }

            if (duracoesPlanos.Success)
            {
                cbDuracao.DataSource = duracoesPlanos.Data;
                cbDuracao.ValueMember = "IDPlano";
                cbDuracao.DisplayMember = "DuracaoPlano";
            }
            this.dgvPlano.RowsAdded += DgvPlano_RowsAdded;
        }
        #endregion

        #region Métodos

        private void AtualizarGrid()
        {
            DataResponse<PlanoQueryView> response = planoBLL.GetAll();
            if (response.Success)
            {
                this.dgvPlano.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        #endregion

        #region Eventos

        private void DgvPlano_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dgvPlano.Rows[e.RowIndex].Cells[4].Style.Format = "C2";
        }

        private void FormCadastroPlano_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dgvPlano_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PlanoQueryView pqv = (PlanoQueryView)this.dgvPlano.Rows[e.RowIndex].DataBoundItem;
            FormDeletePlano formDelPqv = new FormDeletePlano(pqv);
            formDelPqv.ShowDialog();
            this.AtualizarGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Plano p = new Plano();

            try
            {
                p.DuracaoPlano = Convert.ToInt32(cbDuracao.Text);
                p.IDCategoria = (int)cbCategoria.SelectedValue;
                p.QtdAulaSemana = Convert.ToInt32(txtQtdAulasSemana.Text);
                p.PrecoPlano = Convert.ToDouble(txtPrecoPlano.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Houve falha no recebimento das informações, a seguir seguem instruções para correto preenchimento das informações ! Obrigado. ");
            }
            
            Response response = planoBLL.Insert(p);
            MessageBox.Show(response.Message);
            AtualizarGrid();
        }

        #endregion

        private void txtQtdAulasSemana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPrecoPlano_KeyPress(object sender, KeyPressEventArgs e)
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
