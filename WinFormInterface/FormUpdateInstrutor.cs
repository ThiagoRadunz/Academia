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
    public partial class FormUpdateInstrutor : Form
    {
        #region Variáveis

        InstrutorBLL instrutorBLL = new InstrutorBLL();

        #endregion

        #region Construtor

        public FormUpdateInstrutor(Instrutor instrutor)
        {
            InitializeComponent();

            txtCodigoInstrutor.Text = Convert.ToString(instrutor.IDInstrutor);
            txtNome.Text = instrutor.Usuario.Nome;
            txtEmail.Text = instrutor.Usuario.Email;
            txtCodigoUsuario.Text = Convert.ToString(instrutor.IDUsuario);
            txtCelular.Text = instrutor.TelefoneCelular;
            txtCPF.Text = instrutor.CPF;
            dtpDataDeNascimento.Value = instrutor.DataNascimento;
            txtRG.Text = instrutor.RG;
            txtEstado.Text = instrutor.Estado;
            txtCidade.Text = instrutor.Cidade;
            txtBairro.Text = instrutor.Bairro;
            txtRua.Text = instrutor.Rua;
            txtNumero.Text = Convert.ToString(instrutor.Numero);
            txtSalario.Text = Convert.ToString(instrutor.Salario);
            txtComissao.Text = Convert.ToString(instrutor.Comissao);
            if (instrutor.Ativo)
            {
                chbAtivo.Checked = true;
                chbInativos.Checked = false;
            }
            else
            {
                chbAtivo.Checked = false;
                chbInativos.Checked = true;
            }
        }

        #endregion

        #region Eventos

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Instrutor instrutor = new Instrutor();
            try
            {
                //CPF, RG e DATA_NASCIMENTO nao podem ser alteradas
                instrutor.Usuario.Nome = txtNome.Text;
                instrutor.Usuario.Email = txtEmail.Text;
                instrutor.Usuario.Funcao = Entities.Enums.Papel.Instrutor;
                instrutor.Usuario.IDUsuario = int.Parse(txtCodigoUsuario.Text);
                instrutor.IDUsuario = int.Parse(txtCodigoUsuario.Text);
                instrutor.TelefoneCelular = txtCelular.Text;
                instrutor.Estado = txtEstado.Text;
                instrutor.Cidade = txtCidade.Text;
                instrutor.Bairro = txtBairro.Text;
                instrutor.Rua = txtRua.Text;
                instrutor.Numero = int.Parse(txtNumero.Text);
                instrutor.Salario = double.Parse(txtSalario.Text);
                instrutor.Comissao = double.Parse(txtComissao.Text);
                instrutor.IDInstrutor = int.Parse(txtCodigoInstrutor.Text);

                if (!chbAtivo.Checked && chbInativos.Checked)
                {
                    instrutor.Ativo = false;
                }
                else if (chbAtivo.Checked && !chbInativos.Checked)
                {
                    instrutor.Ativo = true;
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
            
            Response response = instrutorBLL.Update(instrutor);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                this.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            FormCleaner.ClearForm(this);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUpdateInstrutor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtComissao_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
