using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface ICategoriaService
    {
        Response Insert(Categoria c);
        DataResponse<Categoria> GetAll();
        Response Update(Categoria c);
        Response Delete(int id);
        List<string> GetAllCategories();

       
    }
}
