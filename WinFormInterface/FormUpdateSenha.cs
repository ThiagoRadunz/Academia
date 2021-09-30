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
    public partial class FormUpdateSenha : Form
    {
        #region Variáveis
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        #endregion

        #region Construtor
        public FormUpdateSenha(Usuario usuario)
        {
            InitializeComponent();

            txtID.Text = Convert.ToString(usuario.IDUsuario);
            txtEmail.Text = usuario.Email;
            txtNome.Text = usuario.Nome;
            txtFuncao.Text = usuario.Funcao.ToString();

            btnVoltar.Click += BtnVoltar_Click;
        }
        #endregion

        #region Eventos
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            string first = txtSenha.Text;
            string second = txtConfirmarSenha.Text;

            if (first != second)
            {
                MessageBox.Show("Senha não foi confirmada corretamente");
            }

            user.IDUsuario = Convert.ToInt32(txtID.Text);
            user.Senha = first;

            Response r = usuarioBLL.Update(user);
            if (!r.Success)
            {
                MessageBox.Show(r.Message);
            }
            else
            {
                MessageBox.Show(r.Message);
                this.Close();
            }

            #endregion

        }
    }
}
