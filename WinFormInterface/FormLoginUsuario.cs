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
    public partial class FormLoginUsuario : Form
    {
        #region Variáveis

        private UsuarioBLL _usuarioBLL = new UsuarioBLL();

        #endregion

        #region Construtor

        public FormLoginUsuario()
        {
            InitializeComponent();
            this.txtEmail.Text = "arnold@arnoldhealthclub.com";
            //this.txtEmail.Text = "instrutorlucas@arnoldhealthclub.com";
            //this.txtEmail.Text = "eduardorecepcao@arnoldhealthclub.com";
            this.txtSenha.Text = "Pa55w.rd";

            this.btnAuthenticate.KeyPress += BtnAuthenticate_KeyPress;
        }

        #endregion

        #region Eventos

        private void BtnAuthenticate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.btnAuthenticate_Click(sender, e);
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            SingleResponse<Usuario> response =
                _usuarioBLL.Authenticate(txtEmail.Text, txtSenha.Text);

            if (response.Success)
            {
                FormMenuUsuario frm = new FormMenuUsuario();
                this.Visible = false;
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
