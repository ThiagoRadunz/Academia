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
    public partial class FormListarTodosFuncionarios : Form
    {
        #region Variáveis

        UsuarioBLL usuarioBLL = new UsuarioBLL();
        AtendenteBLL atendenteBLL = new AtendenteBLL();
        InstrutorBLL instrutorBLL = new InstrutorBLL();

        #endregion

        #region Construtor

        public FormListarTodosFuncionarios()
        {
            InitializeComponent();
            this.txtPesquisar.KeyPress += TxtPesquisar_KeyPress;
        }

        #endregion

        #region Métodos

        private void AtualizarGridSearch()
        {
            DataResponse<Usuario> response = usuarioBLL.Search(txtPesquisar.Text);
            if (response.Success)
            {
                this.dgvTodos.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void AtualizarGrid()
        {
            DataResponse<Usuario> response = usuarioBLL.GetAll();
            if (response.Success)
            {
                this.dgvTodos.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        #endregion

        #region Eventos

        private void TxtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.BtnPesquisar_Click(sender, e);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DataResponse<Usuario> response = usuarioBLL.Search(txtPesquisar.Text);
            this.dgvTodos.DataSource = response.Data;
            AtualizarGridSearch();
        }

        private void FormListarTodosFuncionarios_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void FormListarTodosFuncionarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMaisInformacoes_Click(object sender, EventArgs e)
        {
            Usuario itemSelecionado = (Usuario)this.dgvTodos.SelectedRows[0].DataBoundItem;

            if (itemSelecionado.Funcao == Entities.Enums.Papel.Atendente)
            {
                SingleResponse<Atendente> atendente = atendenteBLL.GetPerson(itemSelecionado.IDUsuario);
                this.Visible = false;
                FormInformacoesAtendentes fia = new FormInformacoesAtendentes(atendente.Item);
                fia.ShowDialog();
                this.Visible = true;
            }
            else if (itemSelecionado.Funcao == Entities.Enums.Papel.Instrutor)
            {
                SingleResponse<Instrutor> instrutor = instrutorBLL.GetPerson(itemSelecionado.IDUsuario);
                this.Visible = false;
                FormInformacoesInstrutor fia = new FormInformacoesInstrutor(instrutor.Item);
                fia.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Administrador não possui informações adicionais, apenas credencial para login !");
            }
        }

        private void BtnAlterarSenha_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)this.dgvTodos.SelectedRows[0].DataBoundItem;
            FormUpdateSenha fus = new FormUpdateSenha(usuario);
            fus.ShowDialog();
        }

        #endregion
    }
}
