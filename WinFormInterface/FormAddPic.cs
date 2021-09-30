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
    public partial class FormAddPic : Form
    {
        //revisado
        #region Variáveis
        PlanoInstrutorClienteBLL picBLL = new PlanoInstrutorClienteBLL();
        PlanoBLL planoBLL = new PlanoBLL();
        InstrutorBLL instrutorBLL = new InstrutorBLL();
        ClienteBLL clienteBLL = new ClienteBLL();
        FormaPagamentoBLL formaPagamentoBLL = new FormaPagamentoBLL();
        int idClientePassadoPorParametro = 0;
        #endregion

        #region Construtores

        public FormAddPic(int id)
        {
            InitializeComponent();

            DataResponse<Cliente> cliente = clienteBLL.GetAll();
            if (cliente.Success)
            {
                cbFiltroCliente.DataSource = cliente.Data;
                cbFiltroCliente.ValueMember = "IDCliente";
                cbFiltroCliente.DisplayMember = "Nome";
            }

            cbFiltroCliente.SelectedIndexChanged += CbFiltroCliente_SelectedIndexChanged;

            DataResponse<Instrutor> instrutor = instrutorBLL.GetAll();
            if (instrutor.Success)
            {
                cbFiltroInstrutor.DataSource = instrutor.Data;
                cbFiltroInstrutor.ValueMember = "IDInstrutor";
                cbFiltroInstrutor.DisplayMember = "Usuario";
            }

            cbFiltroInstrutor.SelectedIndexChanged += CbFiltroInstrutor_SelectedIndexChanged;
            idClientePassadoPorParametro = id;
        }
        public FormAddPic(PlanoInstrutorClienteQueryView picQv)
        {
            InitializeComponent();

            DataResponse<Cliente> cliente = clienteBLL.GetAll();
            if (cliente.Success)
            {
                cbFiltroCliente.DataSource = cliente.Data;
                cbFiltroCliente.ValueMember = "IDCliente";
                cbFiltroCliente.DisplayMember = "Nome";
            }
            cbFiltroCliente.SelectedIndexChanged += CbFiltroCliente_SelectedIndexChanged;
            DataResponse<Instrutor> instrutor = instrutorBLL.GetAll();
            if (instrutor.Success)
            {
                cbFiltroInstrutor.DataSource = instrutor.Data;
                cbFiltroInstrutor.ValueMember = "IDInstrutor";
                cbFiltroInstrutor.DisplayMember = "Usuario";
            }
            cbFiltroInstrutor.SelectedIndexChanged += CbFiltroInstrutor_SelectedIndexChanged;
            idClientePassadoPorParametro = Convert.ToInt32(picQv.IDCliente);
        }
        #endregion

        #region Eventos dos componentes de tela
        private void CbFiltroInstrutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTextBox();
        }
        private void CbFiltroCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTextBox();
        }
        private void FormAddPic_Load(object sender, EventArgs e)
        {
            //este 'for' seta a combobox de acordo com o id do cliente 
            for (int i = 0; i < cbFiltroCliente.Items.Count; i++)
            {
                Cliente c = (Cliente)cbFiltroCliente.Items[i];
                if (c.IDCliente == idClientePassadoPorParametro)
                {
                    cbFiltroCliente.SelectedIndex = i;
                    break;
                }
            }
            AtualizarTextBox();
            AtualizarGridFormaPagamento();
            AtualizarGridPlano();
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnConfirmarFormaPag_Click(object sender, EventArgs e)
        {
            FormaPagamento itemSelecionado = (FormaPagamento)this.dgvFormaPagamento.SelectedRows[0].DataBoundItem;
            txtFormaPagamento.Text = itemSelecionado.Descricao;
            txtCodigoFormaPagamento.Text = Convert.ToString(itemSelecionado.ID);
        }
        private void BtnConfirmarPlano_Click(object sender, EventArgs e)
        {
            PlanoQueryView itemSelecionado = (PlanoQueryView)this.dgvPlano.SelectedRows[0].DataBoundItem;
            txtCodigoPlano.Text = Convert.ToString(itemSelecionado.IDPlano);
            txtModalidade.Text = itemSelecionado.Categoria;
            txtQtdAulaSemana.Text = Convert.ToString(itemSelecionado.QtdAulaSemana);
            txtQtdDuracao.Text = Convert.ToString(itemSelecionado.DuracaoPlano);
            txtPreco.Text = itemSelecionado.PrecoPlano.ToString("C2");
        }
        private void BtnAddContrato_Click(object sender, EventArgs e)
        {
            PlanoInstrutorCliente pic = new PlanoInstrutorCliente();

            try
            {
                pic.IDInstrutor = Convert.ToInt32(cbFiltroInstrutor.SelectedValue);
                pic.IDPlano = int.Parse(txtCodigoPlano.Text);
                pic.IDCliente = Convert.ToInt32(cbFiltroCliente.SelectedValue);
                pic.IDFormapagamento = int.Parse(txtCodigoFormaPagamento.Text);
                pic.AdesaoContrato = DateTime.Now;
                pic.TerminoContrato = AtualizarDateTimePicker();
            }
            catch (Exception)
            {
                MessageBox.Show("Houve falha no recebimento das informações, a seguir seguem instruções para correto preenchimento das informações ! Obrigado. ");
            }

            Response response = picBLL.Insert(pic);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                this.Close();
            }

        }
        #endregion

        #region Métodos
        private DateTime AtualizarDateTimePicker()
        {
            dtpAdesaoContrato.Value = DateTime.Now;
            dtpTerminoContrato.Value = dtpAdesaoContrato.Value.AddMonths(int.Parse(txtQtdDuracao.Text));
            return dtpTerminoContrato.Value;
        }
        private void AtualizarTextBox()
        {
            txtIDCliente.Text = cbFiltroCliente.SelectedValue.ToString();
            txtIDInstrutor.Text = cbFiltroInstrutor.SelectedValue.ToString();
        }
        private void AtualizarGridPlano()
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
        private void AtualizarGridFormaPagamento()
        {
            DataResponse<FormaPagamento> response = formaPagamentoBLL.GetAll();
            if (response.Success)
            {
                this.dgvFormaPagamento.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
        #endregion
    }
}
