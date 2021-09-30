using Entities.ViewModel;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IPlanoInstrutorClienteService
    {
        Response Insert(PlanoInstrutorCliente pic);
        DataResponse<PlanoInstrutorClienteQueryView> GetAll();
        Response Update(PlanoInstrutorCliente pic);
        Response EndPlain(int id);
    }
}
