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
    public partial class FormFinanceiroPlanos : Form
    {
        #region Variáveis

        PlanoInstrutorClienteBLL picBLL = new PlanoInstrutorClienteBLL();
        Instrutor instrutor = new Instrutor();
        InstrutorBLL instrutorBLL = new InstrutorBLL();

        #endregion

        #region Construtor

        public FormFinanceiroPlanos()
        {
            InitializeComponent();

            DataResponse<Instrutor> instrutores = instrutorBLL.GetAll();
            cbFiltroInstrutor.DataSource = instrutores.Data;
            cbFiltroInstrutor.ValueMember = "IDInstrutor";
            cbFiltroInstrutor.DisplayMember = "Usuario";

            cbFiltroInstrutor.SelectedIndexChanged += CbFiltroInstrutor_SelectedIndexChanged;
            this.Load += FormFinanceiroPlanos_Load;
            AtualizarTextBox();
        }

        #endregion

        #region Métodos

        private void AtualizarTextBox()
        {
            txtIDInstrutor.Text = Convert.ToString(cbFiltroInstrutor.SelectedValue);
        }

        private void AtualizarGrid()
        {
            DataResponse<PlanoInstrutorClienteQueryView> response = picBLL.GetAll();
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
            AtualizarTextBox();
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

        #endregion

        #region Eventos

        private void CbFiltroInstrutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarGridbyIDInstrutor();
            AtualizarTextBox();
        }

        private void FormFinanceiroPlanos_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            AtualizarTextBox();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 0; i < dgvPlanoInstrutorCliente.Rows.Count; ++i)
            {
                soma += Convert.ToInt32(dgvPlanoInstrutorCliente.Rows[i].Cells[5].Value);
            }
            txtComissao.Text = instrutor.CalcularComissao(soma).ToString("C2");
        }

        #endregion
    }
}

