using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IAtendenteService
    {
        Response Insert(Atendente a);
        DataResponse<Atendente> GetAll();
        DataResponse<Atendente> Search(string palavra);
        DataResponse<Atendente> SearchAtivos(string palavra);
        DataResponse<Atendente> SearchInativos(string palavra);
        Response Update(Atendente a);
        SingleResponse<Atendente> GetPerson(int id);
        
    }
}
