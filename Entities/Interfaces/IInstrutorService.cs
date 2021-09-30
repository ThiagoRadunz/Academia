using Entities.ViewModel;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IInstrutorService
    {
        Response Insert(Instrutor i);
        DataResponse<Instrutor> GetAll();
        DataResponse<Instrutor> GetAllAtivos();
        DataResponse<Instrutor> GetAllInativos();
        Response Update(Instrutor i);
        DataResponse<Instrutor> Search(string palavra);
        DataResponse<Instrutor> SearchAtivos(string palavra);
        DataResponse<Instrutor> SearchInativos(string palavra);
        SingleResponse<Instrutor> GetPerson(int id);
    }
}
