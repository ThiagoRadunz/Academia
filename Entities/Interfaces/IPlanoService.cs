using Entities.ViewModel;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IPlanoService
    {
        Response Insert(Plano p);
        DataResponse<PlanoQueryView> GetAll();
        Response Delete(int id);
        Response Exists(Plano p);
        DataResponse<Plano> GetAllPlansDuration();


    }
}
