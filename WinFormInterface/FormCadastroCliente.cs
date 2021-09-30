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
    public partial class FormCadastroCliente : Form
    {
        //revisado (idéia encapsular salario, criar método alterar salário)
        #region Variáveis

        ClienteBLL clienteBLL = new ClienteBLL();

        #endregion

        #region Construtor

        public FormCadastroCliente()
        {
            InitializeComponent();
            dtpDataMatricula.Value = DateTime.Now;

        }

        #endregion

        #region Eventos

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            FormCleaner.ClearForm(this);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();

            try
            {
                c.Nome = txtNome.Text;
                c.CPF = txtCPF.Text;
                c.RG = txtRG.Text;
                c.DataNascimento = dtpDataDeNascimento.Value;
                c.Email = txtEmail.Text;
                c.FoneCelular = txtCelular.Text;
                c.FoneFixo = txtFoneFixo.Text;
                dtpDataMatricula.Value = DateTime.Now;
                c.DataMatricula = dtpDataMatricula.Value;
                c.Ativo = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Houve falha no recebimento das informações, a seguir seguem instruções para correto preenchimento das informações ! Obrigado. ");
            }
            
            Response response = clienteBLL.Insert(c);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                this.Close();
            }

        }

        private void FormCadastroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        #endregion

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

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
