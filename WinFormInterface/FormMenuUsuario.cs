using BusinessLogical;
using Entities;
using Entities.Enums;
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
    public partial class FormMenuUsuario : Form
    {
        private Usuario _usuario;
        public FormMenuUsuario()
        {
            InitializeComponent();
            _usuario = SystemParameters.GetCurrentFuncionario();
            if (_usuario.Funcao == Papel.Atendente)
            {
                funcionariosToolStripMenuItem.Visible = false;
                consultarTodosToolStripMenuItem.Visible = false;
                instrutoresToolStripMenuItem.Visible = false;
                atendentesToolStripMenuItem.Visible = false;

                clientesToolStripMenuItem1.Visible = true;
                consultarClientesToolStripMenuItem.Visible = true;
                novoClienteToolStripMenuItem.Visible = true;

                planosToolStripMenuItem1.Visible = true;
                planosExistentesToolStripMenuItem.Visible = true;
                contratadosToolStripMenuItem.Visible = true;
                novoToolStripMenuItem.Visible = true;
                
                produtosToolStripMenuItem1.Visible = true;
                consultarProdutosToolStripMenuItem.Visible = true;
                novoProdutoToolStripMenuItem.Visible = true;
                entradaProdutosToolStripMenuItem.Visible = true;
                vendaProdutosToolStripMenuItem.Visible = true;

                estoqueToolStripMenuItem.Visible = true;
                
                finaceiroToolStripMenuItem.Visible = true;
                formasDePagamentoToolStripMenuItem1.Visible = false;
                folhaDePagamentoToolStripMenuItem.Visible = false;
                controleDeVendasToolStripMenuItem.Visible = true;
                controleDePlanosRealizadosToolStripMenuItem.Visible = false;
                
            }
            else if (_usuario.Funcao == Papel.Instrutor)
            {

                funcionariosToolStripMenuItem.Visible = false;
                consultarTodosToolStripMenuItem.Visible = false;
                instrutoresToolStripMenuItem.Visible = false;
                atendentesToolStripMenuItem.Visible = false;

                clientesToolStripMenuItem1.Visible = true;
                consultarClientesToolStripMenuItem.Visible = true;
                novoClienteToolStripMenuItem.Visible = true;

                planosToolStripMenuItem1.Visible = true;
                planosExistentesToolStripMenuItem.Visible = true;
                contratadosToolStripMenuItem.Visible = true;
                novoToolStripMenuItem.Visible = true;

                produtosToolStripMenuItem1.Visible = false;
                consultarProdutosToolStripMenuItem.Visible = false;
                novoProdutoToolStripMenuItem.Visible = false;
                entradaProdutosToolStripMenuItem.Visible = false;
                vendaProdutosToolStripMenuItem.Visible = false;

                estoqueToolStripMenuItem.Visible = false;

                finaceiroToolStripMenuItem.Visible = true;
                formasDePagamentoToolStripMenuItem1.Visible = false;
                folhaDePagamentoToolStripMenuItem.Visible = false;
                controleDeVendasToolStripMenuItem.Visible = false;
                controleDePlanosRealizadosToolStripMenuItem.Visible = true;

            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCategoria fcc = new FormCadastroCategoria();
            this.Visible = false;
            fcc.ShowDialog();
            this.Visible = true;
        }

        private void formaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFormaPagamento ffp = new FormCadastroFormaPagamento();
            this.Visible = false;
            ffp.ShowDialog();
            this.Visible = true;
        }

        private void planoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroPlano fp = new FormCadastroPlano();
            fp.ShowDialog();
        }

        private void instrutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroInstrutor fi = new FormCadastroInstrutor();
            fi.ShowDialog();
        }

        private void contratadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarPlanoInstrutorCliente flpic = new FormListarPlanoInstrutorCliente();
            flpic.ShowDialog();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarClientes flc = new FormListarClientes();
            flc.ShowDialog();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCliente fcc = new FormCadastroCliente();
            
            fcc.ShowDialog();
        }

        private void FormMenuUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                
                this.Close();
            }
        }

        private void planosExistentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroPlano fcp = new FormCadastroPlano();
            fcp.ShowDialog();
        }

        private void consultarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarTodosFuncionarios fltf = new FormListarTodosFuncionarios();
            fltf.ShowDialog();
        }

        private void atendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarAtendentes fla = new FormListarAtendentes();
            fla.ShowDialog();
        }

        private void instrutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarInstrutores fli = new FormListarInstrutores();
            fli.ShowDialog();
        }

        private void formasDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCadastroFormaPagamento fcfp = new FormCadastroFormaPagamento();
            fcfp.ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCategoria fcc = new FormCadastroCategoria();
            fcc.ShowDialog();
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroProduto fcProd = new FormCadastroProduto();
            fcProd.ShowDialog();
        }

        private void consultarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarProdutos flProd = new FormListarProdutos();
            flProd.ShowDialog();
        }

        private void entradaProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroEntradaProdutos fcep = new FormCadastroEntradaProdutos();
            fcep.ShowDialog();
        }

        private void vendaProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroVenda fcv = new FormCadastroVenda();
            fcv.ShowDialog();
        }

        private void controleDePlanosRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFinanceiroPlanos ffp = new FormFinanceiroPlanos();
            ffp.ShowDialog();
        }
    }
}


