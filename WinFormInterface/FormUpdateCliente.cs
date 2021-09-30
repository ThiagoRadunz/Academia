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
    public partial class FormUpdateCliente : Form
    {
        #region Variáveis

        ClienteBLL clienteBLL = new ClienteBLL();

        #endregion

        #region Construtor

        public FormUpdateCliente(Cliente c)
        {
            InitializeComponent();
            this.txtNome.Text = c.Nome;
            this.txtCPF.Text = c.CPF;
            this.txtEmail.Text = c.Email;
            this.txtRG.Text = c.RG;
            this.txtCelular.Text = c.FoneCelular;
            this.txtFoneFixo.Text = c.FoneFixo;
            this.dtpDataDeNascimento.Value = c.DataNascimento;
            this.dtpDataMatricula.Value = c.DataMatricula;
            this.txtIDCliente.Text = c.IDCliente.ToString();
        }

        #endregion

        #region Eventos

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();

            try
            {
                //CPF, RG e DATA_NASCIMENTO nao podem ser alteradas
                c.IDCliente = Convert.ToInt32(txtIDCliente.Text);
                c.Nome = txtNome.Text;
                c.Email = txtEmail.Text;
                c.FoneCelular = txtCelular.Text;
                c.FoneFixo = txtFoneFixo.Text;
                dtpDataMatricula.Value = DateTime.Now;
                c.DataMatricula = dtpDataMatricula.Value;
                if (!chbAtivo.Checked && chbInativos.Checked)
                {
                    c.Ativo = false;
                }
                else if (chbAtivo.Checked && !chbInativos.Checked)
                {
                    c.Ativo = true;
                }
                else
                {
                    MessageBox.Show("Por favor marque apenas um status de atividade no sistema, Ativo ou inativo !");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Houve falha no recebimento das informações, a seguir seguem instruções para correto preenchimento das informações ! Obrigado. ");
            }

            Response response = clienteBLL.Update(c);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                this.Close();
            }
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormUpdateCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void btnIncluirPlanos_Click(object sender, EventArgs e)
        {
            FormAddPic fAddPic = new FormAddPic(int.Parse(txtIDCliente.Text));
            fAddPic.ShowDialog();
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtFoneFixo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
