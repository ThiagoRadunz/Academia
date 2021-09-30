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
    public partial class FormUpdateAtendente : Form
    {
        #region Variáveis

        AtendenteBLL atendenteBLL = new AtendenteBLL();

        #endregion

        #region Construtor

        public FormUpdateAtendente(Atendente atendente)
        {
            InitializeComponent();
            txtCodigoAtendente.Text = Convert.ToString(atendente.IDAtendente);
            txtNome.Text = atendente.Usuario.Nome;
            txtEmail.Text = atendente.Usuario.Email;
            txtCodigoUsuario.Text = Convert.ToString(atendente.IDUsuario);
            txtCelular.Text = atendente.TelefoneCelular;
            txtCPF.Text = atendente.CPF;
            dtpDataDeNascimento.Value = atendente.DataNascimento;
            txtRG.Text = atendente.RG;
            txtEstado.Text = atendente.Estado;
            txtCidade.Text = atendente.Cidade;
            txtBairro.Text = atendente.Bairro;
            txtRua.Text = atendente.Rua;
            txtNumero.Text = Convert.ToString(atendente.Numero);
            txtSalario.Text = Convert.ToString(atendente.Salario);
            txtComissao.Text = Convert.ToString(atendente.Comissao);

            if (atendente.Ativo)
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

        private void FormUpdateAtendente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            FormCleaner.ClearForm(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Atendente atendente = new Atendente();

            try
            {
                //CPF, RG e DATA_NASCIMENTO nao podem ser alteradas
                atendente.Usuario.IDUsuario = Convert.ToInt32(txtCodigoUsuario.Text);
                atendente.Usuario.Nome = txtNome.Text;
                atendente.Usuario.Email = txtEmail.Text;
                atendente.Usuario.Funcao = Entities.Enums.Papel.Atendente;
                atendente.IDUsuario = int.Parse(txtCodigoUsuario.Text);
                atendente.TelefoneCelular = txtCelular.Text;
                atendente.Estado = txtEstado.Text;
                atendente.Cidade = txtCidade.Text;
                atendente.Bairro = txtBairro.Text;
                atendente.Rua = txtRua.Text;
                atendente.Numero = int.Parse(txtNumero.Text);
                atendente.Salario = double.Parse(txtSalario.Text);
                atendente.Comissao = double.Parse(txtComissao.Text);
                atendente.IDAtendente = int.Parse(txtCodigoAtendente.Text);

                if (!chbAtivo.Checked && chbInativos.Checked)
                {
                    atendente.Ativo = false;
                }
                else if (chbAtivo.Checked && !chbInativos.Checked)
                {
                    atendente.Ativo = true;
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
            
            Response response = atendenteBLL.Update(atendente);
            MessageBox.Show(response.Message);
            if (response.Success)
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
