using DataAccess;
using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessLogical
{
    public class EntradaProdutosBLL : BaseValidator<EntradaProdutos>, IEntradaProdutosService
    {
        
        private EntradaProdutosDAL entradaProdutosDAL = new EntradaProdutosDAL();
        private ProdutoBLL produtoBLL = new ProdutoBLL();
        public override Response Validate(EntradaProdutos item)
        {
            foreach (ItensEntrada ie in item.Items)
            {
                if (ie.PrecoUnitario <= 0 || ie.Quantidade <= 0)
                {
                    this.AddError("Valor e/ou quantidade não pode ser menor ou igual a ZERO.");
                }
            }

            return base.Validate(item);
        }

        public Response Includer(EntradaProdutos entradaProdutos)
        {
            entradaProdutos.DataEntrada = DateTime.Now;
            entradaProdutos.IDUsuario = SystemParameters.GetCurrentFuncionario().IDUsuario;
            entradaProdutos.CalcularPreco();

            Response response = this.Validate(entradaProdutos);
            if (!response.Success)
            {
                return response;
            }

            using (TransactionScope scope = new TransactionScope())
            {
                //Cadastra Entrada
                Response responseRegistroEntrada = entradaProdutosDAL.Includer(entradaProdutos);

                if (!responseRegistroEntrada.Success)
                {
                    return responseRegistroEntrada;
                }
                //Cadastra os Itens da Entrada
                foreach (ItensEntrada item in entradaProdutos.Items)
                {
                    item.IDItensEntrada = entradaProdutos.IDEntradaProdutos;
                    Response responseCadastroItem = entradaProdutosDAL.IncluderItem(item);
                    if (!response.Success)
                    {
                        return response;
                    }
                    //Atualiza estoque e preço da entrada
                    SingleResponse<Produto> responseProduto = produtoBLL.GetProduct(item.IDProduto);
                    if (!responseProduto.Success)
                    {
                        return responseProduto;
                    }
                    Produto produto = responseProduto.Item;
                    double novoEstoque = item.Quantidade + produto.QtdEstoque;
                    double novoPreco = ((item.Quantidade * item.PrecoUnitario) + (produto.PrecoUnitario * produto.QtdEstoque)) / (item.Quantidade + produto.QtdEstoque);

                    produtoBLL.StockUpdater(produto.ID, novoEstoque);
                    produtoBLL.PriceUpdater(produto.ID, novoPreco);
                }
                scope.Complete();
            }

            Response r = new Response();
            r.Success = true;
            r.Message = "Itens registrados com sucesso.";
            return r;
        }
    }
}
