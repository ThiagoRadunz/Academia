using Entities;
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
    public partial class FormInformacoesInstrutor : Form
    {
        #region Construtor

        
        public FormInformacoesInstrutor(Instrutor instrutor)
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
            btnVoltar.KeyPress += BtnVoltar_Click;
        }

        #endregion

        #region Eventos

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInformacoesInstrutor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormInformacoesInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.BtnVoltar_Click(sender, e);
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
