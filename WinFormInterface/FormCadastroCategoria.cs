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
    public partial class FormCadastroCategoria : Form
    {
        private CategoriaBLL categoriaBLL = new CategoriaBLL();
        public FormCadastroCategoria()
        {
            InitializeComponent();
            this.Load += FormCadastroCategoria_Load;
            this.dgvCategorias.CellDoubleClick += dgvCategorias_CellDoubleClick;
        }

        private void AtualizarGrid()
        {
            DataResponse<Categoria> response = categoriaBLL.GetAll();
            if (response.Success)
            {
                this.dgvCategorias.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void FormCadastroCategoria_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Categoria c = (Categoria)this.dgvCategorias.Rows[e.RowIndex].DataBoundItem;
            FormEditDeleteCategoria catEditDel = new FormEditDeleteCategoria(c);
            catEditDel.ShowDialog();

            
            this.AtualizarGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();

            cat.Nome = txtCategoria.Text;

            Response response = categoriaBLL.Insert(cat);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                this.Close();
            }
        }
    }
}
