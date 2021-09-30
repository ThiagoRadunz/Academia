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
    public class UsuarioBLL : BaseValidator<Usuario>, IUsuarioService
    {
        private UsuarioDAL _usuarioDAL = new UsuarioDAL();

        public override Response Validate(Usuario item)
        {
            return base.Validate(item);
        }

        public SingleResponse<Usuario> Authenticate(string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                this.AddError("Email deve ser informado.");
            }
            if (string.IsNullOrWhiteSpace(senha))
            {
                this.AddError("Senha deve ser informada.");
            }
            //se chamar o this.Validate(), todas as validações seriam repetidas! Não queremos isso, queremos apenas validar
            //o que está neste método de autenticação e chamar o método da classe pai que transforma os erros em um response!
            Response response = base.Validate(null);
            if (response.Success)
            {
                SingleResponse<Usuario> responseFuncionario = _usuarioDAL.Authenticate(email, senha);
                if (responseFuncionario.Success)
                {
                    SystemParameters.Authenticate(responseFuncionario.Item);
                }
                return responseFuncionario;
            }
            return new SingleResponse<Usuario>()
            {
                Message = response.Message,
                Success = false
            };
        }

        public Response Insert(Usuario u)
        {
            Response r = this.Validate(u);
            if (!r.Success)
            {
                return r;
            }
            return _usuarioDAL.Insert(u);
        }

        public DataResponse<Usuario> GetAll()
        {
            return _usuarioDAL.GetAll();
        }

        public Response Exists(Usuario u)
        {
            throw new NotImplementedException();
        }

        public Response Update(Usuario u)
        {
            return _usuarioDAL.Update(u);
        }

        public DataResponse<Usuario> Search(string palavra)
        {
            return _usuarioDAL.Search(palavra);
        }
    }
}
