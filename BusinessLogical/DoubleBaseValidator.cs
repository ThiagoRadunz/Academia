using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogical
{
    /// <summary>
    /// Classe pai para validar 2 entidades para os BLL's do sistema
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="R"></typeparam>
    public class DoubleBaseValidator<T,R>
    {
        //Objeto que conterá todos os erros da entidade
        private StringBuilder erros = new StringBuilder();

        /// <summary>
        /// Método protegido que apenas quem herda de BaseValidator enxerga
        /// </summary>
        /// <param name="error"></param>
        protected void AddError(string error)
        {
            if (!string.IsNullOrWhiteSpace(error))
            {
                this.erros.AppendLine(error);
            }
        }

        public virtual Response DoubleValidate(T item, R item2)
        {
            Response response = new Response();
            if (this.erros.Length != 0)
            {
                response.Success = false;
                response.Message = this.erros.ToString();
                this.erros.Clear();
                return response;
            }

            response.Success = true;
            response.Message = "Validação de ambas entidades realizada com sucesso!";
            return response;
        }
    }
}
