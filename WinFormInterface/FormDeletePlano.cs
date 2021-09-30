using BusinessLogical;
using Entities;
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
    public partial class FormDeletePlano : Form
    {
        #region Variáveis

        private PlanoBLL planoBLL = new PlanoBLL();

        #endregion

        #region Construtor

        public FormDeletePlano(PlanoQueryView pqv)
        {
            InitializeComponent();
            this.txtID.Text = pqv.IDPlano.ToString();
            this.txtCategoriaID.Text = pqv.Categoria;
            this.txtAulaSemana.Text = pqv.QtdAulaSemana.ToString();
            this.txtDuracaoPlano.Text = pqv.DuracaoPlano.ToString();
            this.lblPrecoNum.Text = pqv.PrecoPlano.ToString("C2");
        }

        #endregion

        #region Eventos
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Response r = planoBLL.Delete(int.Parse(txtID.Text));
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
