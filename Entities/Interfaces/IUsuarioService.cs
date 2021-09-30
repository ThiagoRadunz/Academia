using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IUsuarioService
    {
        SingleResponse<Usuario> Authenticate(string email, string senha);
        Response Insert(Usuario u);
        DataResponse<Usuario> GetAll();
        Response Update(Usuario u);
        DataResponse<Usuario> Search(string palavra);


    }
}
