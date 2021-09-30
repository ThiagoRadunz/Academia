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
    public class CategoriaBLL : BaseValidator<Categoria>, ICategoriaService
    {
        private CategoriaDAL categoriaDAL = new CategoriaDAL();
        public override Response Validate(Categoria item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))
            {
                this.AddError("Categoria deve ser informada.");
            }
            else
            {
                item.Nome = Normatization.NormatizeString(item.Nome);
                if (item.Nome.Length < 3 || item.Nome.Length > 30)
                {
                    this.AddError("Nome da Categoria deve conter de 3 até 30 caracteres.");
                }
            }

            return base.Validate(item);
        }

        public Response Insert(Categoria c)
        {
            Response response = this.Validate(c);
            if (!response.Success)
            {
                return response;
            }
            return categoriaDAL.Insert(c);
        }

        public DataResponse<Categoria> GetAll()
        {
            return categoriaDAL.GetAll();
        }
        public Response Update(Categoria c)
        {
            Response response = this.Validate(c);
            if (!response.Success)
            {
                //Se a validação da Categoria falhou, retorne a interface gráfica :(
                return response;
            }

            //Se chegou aqui, nosso objeto Categoria está correto e pronto pra ser editado no banco de dados!
            return categoriaDAL.Update(c);
        }
        public Response Delete(int id)
        {
            return categoriaDAL.Delete(id);
        }

        public List<string> GetAllCategories()
        {
            return categoriaDAL.GetAllCategories();
        }

        
    }
}
