using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IClienteService
    {
        Response Insert(Cliente c);
        DataResponse<Cliente> GetAll();
        Response Update(Cliente c);
        DataResponse<Cliente> Search(string palavra);
        DataResponse<Cliente> SearchInatives(string palavra);
        DataResponse<Cliente> SearchAtives(string palavra);
    }
}
