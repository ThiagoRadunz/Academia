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
    public class FormaPagamentoBLL : BaseValidator<FormaPagamento>, IFormaPagamentoService
    {
        private FormaPagamentoDAL formaPagamentoDAL = new FormaPagamentoDAL();

        public override Response Validate(FormaPagamento item)
        {
            if (string.IsNullOrWhiteSpace(item.Descricao))
            {
                this.AddError("Forma de pagamento deve ser informada");
            }
            else
            {
                item.Descricao = Normatization.NormatizeString(item.Descricao);
                if (item.Descricao.Length < 3 || item.Descricao.Length > 30)
                {
                    this.AddError("Forma de pagamento deve conter entre 3 e 30 caracteres");
                }
            }

            return base.Validate(item);
        }
        public Response Insert(FormaPagamento fp)
        {
            Response response = this.Validate(fp);
            if (!response.Success)
            {
                return response;
            }

            return formaPagamentoDAL.Insert(fp);
        }
       
        public DataResponse<FormaPagamento> GetAll()
        {
            return formaPagamentoDAL.GetAll();
        }

        public Response Update(FormaPagamento fp)
        {
            Response response = this.Validate(fp);
            if (!response.Success)
            {
                return response;
            }
            return formaPagamentoDAL.Update(fp);
        }

        public Response Delete(int id)
        {
            return formaPagamentoDAL.Delete(id);
        }
    }
}
