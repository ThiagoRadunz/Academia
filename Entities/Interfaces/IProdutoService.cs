using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IProdutoService
    {
        Response Insert(Produto p);
        Response Update(Produto p);
        Response StockUpdater(int id, double novoEstoque);
        Response PriceUpdater(int id, double precoUnitario);
        Response Delete(int id);
        DataResponse<Produto> GetAll();
        DataResponse<Produto> SearchName(string palavra);
        DataResponse<Produto> SearchCategory(string palavra);
        DataResponse<Produto> SearchNameAndCategory(string palavra);
        SingleResponse<Produto> GetProduct(int id);
    }
}
