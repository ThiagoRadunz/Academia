using BusinessLogical;
using Entities;
using Entities.Enums;
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
    public partial class FormCadastroAtendente : Form
    {
        //revisado
        #region Variáveis

        AtendenteBLL atendenteBLL = new AtendenteBLL();

        #endregion

        #region Construtor

        public FormCadastroAtendente()
        {
            InitializeComponent();
            this.txtNumero.Text = "0";
            this.txtComissao.Text = "2";
            this.cbEstado.DataSource = Enum.GetValues(typeof(UFs));
        }

        #endregion

        #region Eventos

        
        private void FormCadastroAtendente_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void FormCadastroAtendente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string first = txtSenha.Text;
            string second = txtConfirmarSenha.Text;

            if (first != second)
            {
                MessageBox.Show("Senha não foi confirmada corretamente");
            }

            Usuario u = new Usuario();
            Atendente a = new Atendente();

            try
            {
                u.Nome = txtNome.Text;
                u.Email = txtEmail.Text;
                u.Senha = first;
                u.Funcao = Entities.Enums.Papel.Atendente;

                a.Usuario = u;
                a.TelefoneCelular = txtCelular.Text;
                a.CPF = txtCPF.Text;
                a.DataNascimento = dtpDataDeNascimento.Value;
                a.RG = txtRG.Text;
                a.Estado = cbEstado.SelectedIndex.ToString();
                a.Cidade = txtCidade.Text;
                a.Bairro = txtBairro.Text;
                a.Rua = txtRua.Text;
                a.Numero = Convert.ToInt32(txtNumero.Text);
                a.Salario = Convert.ToDouble(txtSalario.Text);
                a.Comissao = Convert.ToDouble(txtComissao.Text);
                a.Ativo = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Houve falha no recebimento das informações, a seguir seguem instruções para correto preenchimento das informações ! Obrigado. ");
            }

            Response response = atendenteBLL.Insert(a);
            MessageBox.Show(response.Message);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            FormCleaner.ClearForm(this);
        }

        #endregion

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
    }
}
