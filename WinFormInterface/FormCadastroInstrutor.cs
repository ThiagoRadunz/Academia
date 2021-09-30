using BusinessLogical;
using Entities;
using Entities.Enums;
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
    public partial class FormCadastroInstrutor : Form
    {
        //revisado
        #region Variáveis

        InstrutorBLL instrutorBLL = new InstrutorBLL();

        #endregion

        #region Construtor

        public FormCadastroInstrutor()
        {
            InitializeComponent();
            this.txtNumero.Text = "0";
            this.txtComissao.Text = "10";
            this.cbEstado.DataSource = Enum.GetValues(typeof(UFs));
        }

        #endregion

        #region Eventos

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string first = txtSenha.Text;
            string second = txtConfirmarSenha.Text;

            if (first != second)
            {
                MessageBox.Show("Senha não foi confirmada corretamente");
            }

            Usuario u = new Usuario();
            Instrutor i = new Instrutor();

            try
            {
                i.Usuario.Nome = txtNome.Text;
                i.Usuario.Email = txtEmail.Text;
                i.Usuario.Senha = first;
                i.Usuario.Funcao = Entities.Enums.Papel.Instrutor;
                i.TelefoneCelular = txtCelular.Text;
                i.CPF = txtCPF.Text;
                i.DataNascimento = dtpDataDeNascimento.Value;
                i.RG = txtRG.Text;
                i.Estado = cbEstado.SelectedIndex.ToString();
                i.Cidade = txtCidade.Text;
                i.Bairro = txtBairro.Text;
                i.Rua = txtRua.Text;
                i.Numero = Convert.ToInt32(txtNumero.Text);
                i.Salario = Convert.ToDouble(txtSalario.Text);
                i.Comissao = Convert.ToDouble(txtComissao.Text);
                i.Ativo = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Houve falha no recebimento das informações, a seguir seguem instruções para correto preenchimento das informações ! Obrigado.");
            }
            
            Response response = instrutorBLL.Insert(i);
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

        #endregion

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
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
    }
}
