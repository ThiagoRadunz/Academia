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
    public partial class FormInformacoesAtendentes : Form
    {
        #region Construtor

        public FormInformacoesAtendentes(Atendente atendente)
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
            this.btnVoltar.KeyPress += btnVoltar_Click;
        }

        #endregion

        #region Eventos

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInformacoesAtendentes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnVoltar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.btnVoltar_Click(sender, e);
        }

        #endregion
    }
}
