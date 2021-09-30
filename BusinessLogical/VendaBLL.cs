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
    public class VendaBLL : BaseValidator<Venda>, IVendaService
    {
        VendaDAL vendaDAL = new VendaDAL();
        private ProdutoBLL produtoBLL = new ProdutoBLL();

        public override Response Validate(Venda item)
        {
            if (item.IDCliente == 0)
            {
                this.AddError("Favor selecione um Cliente.");
            }
            return base.Validate(item); 
        }
        public Response SellItem(ItensVenda itensVenda)
        {
            return vendaDAL.SellItem(itensVenda);
        }

        public Response SellProducts(Venda saidaProdutos)
        {
            Response r = this.Validate(saidaProdutos);
            if (!r.Success)
            {
                return r;
            }

            saidaProdutos.DataVenda = DateTime.Now;
            saidaProdutos.IDUsuario = SystemParameters.GetCurrentFuncionario().IDUsuario;
            saidaProdutos.CalcularPreco();

            Response response = this.Validate(saidaProdutos);
            if (!response.Success)
            {
                return response;
            }

            using (TransactionScope scope = new TransactionScope())
            {
                //Cadastra Venda
                Response responseRegistroVenda = vendaDAL.SellProducts(saidaProdutos);

                if (!responseRegistroVenda.Success)
                {
                    return responseRegistroVenda;
                }
                //Cadastra os Itens da Venda
                foreach (ItensVenda item in saidaProdutos.Items)
                {
                    item.IDItensVenda = saidaProdutos.IDVenda;
                    Response responseCadastroItem = vendaDAL.SellItem(item);
                    if (!response.Success)
                    {
                        return response;
                    }
                    //Atualiza estoque (baixa as quantidades vendidas)
                    SingleResponse<Produto> responseProduto = produtoBLL.GetProduct(item.IDProduto);
                    if (!responseProduto.Success)
                    {
                        return responseProduto;
                    }
                    Produto produto = responseProduto.Item;
                    double novoEstoque = produto.QtdEstoque - item.Quantidade;

                    produtoBLL.StockUpdater(produto.ID, novoEstoque);
                }
                scope.Complete();
            }

            Response resposta = new Response();
            resposta.Success = true;
            resposta.Message = "Itens registrados com sucesso.";
            return resposta;
        }
    }
}
