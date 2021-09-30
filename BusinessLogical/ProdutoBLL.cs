using DataAccess;
using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogical
{
    public class ProdutoBLL : BaseValidator<Produto>, IProdutoService
    {
        ProdutoDAL produtoDAL = new ProdutoDAL();

        public override Response Validate(Produto item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))
            {
                this.AddError("Nome do produto deve ser informado.");
            }
            else
            {
                item.Nome = Normatization.NormatizeString(item.Nome);
                if (item.Nome.Length < 3 || item.Nome.Length > 50)
                {
                    this.AddError("Nome deve conter entre 3 e 50 caracteres.");
                }
            }
            if (string.IsNullOrWhiteSpace(item.Descricao))
            {
                this.AddError("Descrição do produto deve ser informada.");
            }
            else
            {
                item.Descricao = Normatization.NormatizeString(item.Descricao);
                if (item.Descricao.Length < 3 || item.Descricao.Length > 50)
                {
                    this.AddError("Descrição deve conter entre 3 e 50 caracteres.");
                }
            }

            return base.Validate(item);
        }

        public Response Insert(Produto p)
        {
            Response r = this.Validate(p);
            if (!r.Success)
            {
                return r;
            }
            return produtoDAL.Insert(p);
        }
        public DataResponse<Produto> GetAll()
        {
            return produtoDAL.GetAll();
        }
        public Response Update(Produto p)
        {
            return produtoDAL.Update(p);
        }
        public Response Delete(int id)
        {
            return produtoDAL.Delete(id);
        }

        public DataResponse<Produto> SearchName(string palavra)
        {
            return produtoDAL.SearchName(palavra);
        }

        public DataResponse<Produto> SearchCategory(string palavra)
        {
            return produtoDAL.SearchCategory(palavra);
        }

        public SingleResponse<Produto> GetProduct(int id)
        {
            return produtoDAL.GetProduct(id);
        }

        public Response StockUpdater(int id, double novoEstoque)
        {
            return produtoDAL.StockUpdater(id, novoEstoque);
        }

        public Response PriceUpdater(int id, double precoUnitario)
        {
            return produtoDAL.PriceUpdater(id, precoUnitario);
        }

        public DataResponse<Produto> SearchNameAndCategory(string palavra)
        {
            return produtoDAL.SearchNameAndCategory(palavra);
        }
    }
}
