using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IFormaPagamentoService
    {
        Response Insert(FormaPagamento fp);
        Response Update(FormaPagamento fp);
        Response Delete(int id);
        DataResponse<FormaPagamento> GetAll();
    }
}
