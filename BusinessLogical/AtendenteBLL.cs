using DataAccess;
using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogical
{
    public class AtendenteBLL : BaseValidator<Atendente>, IAtendenteService
    {
        AtendenteDAL atendenteDAL = new AtendenteDAL();

        public override Response Validate(Atendente item)
        {
            //Coloca nome em PascalCase e valida comprimento do nome
            item.Usuario.Nome = Normatization.NormatizeString(item.Usuario.Nome);
            item.Usuario.Nome = CommonValidations.IsValidNome(item.Usuario.Nome);

            //Remove mascara do cpf e valida se é um cpf com regex
            item.CPF = item.CPF?.Trim().Replace("-", "").Replace(".", "");
            item.CPF = CommonValidations.IsCpf(item.CPF);

            //Valida se Atendente é maior de idade
            DateTime birthdate = item.DataNascimento;
            DateTime today = DateTime.Now;
            int age = today.Year - birthdate.Year;
            if (birthdate > today.AddYears(-age))
            {
                age--;
            }
            if (age < 18)
            {
                this.AddError("Idade inválida. Apenas maiores de 18 anos podem ter cadastro.\r\n");
            }

            //Valida email
            if (item.Usuario.Email.Length == 0 || item.Usuario.Email.Length > 100)
            {
                this.AddError("Email deve conter no máximo 100 caracteres\r\n");
            }
            string regex = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            bool isValid = Regex.IsMatch(item.Usuario.Email, regex);
            if (!isValid)
            {
                this.AddError("Email inválido.\r\n");
            }

            //Valida RG
            if (item.RG.Length == 0)
            {
                this.AddError("RG deve ser informado.\r\n");
            }
            if (item.RG.Length < 0 || item.RG.Length > 15)
            {
                this.AddError("RG deve conter no máximo 15 caracteres.\r\n");
            }

            //Valida Telefone
            if (item.TelefoneCelular.Length == 0 || item.TelefoneCelular.Length < 8 || item.TelefoneCelular.Length > 15)
            {
                this.AddError("Telefone deve ser informado e conter entre 10 e no máximo 15 caracteres.\r\n");
            }

            //Valida Cidade
            if (item.Cidade.Length == 0 || item.Cidade.Length > 20)
            {
                this.AddError("Cidade deve ser informada e conter no máximo 20 caracteres.\r\n");
            }

            //Valida Bairro
            if (item.Bairro.Length == 0 || item.Bairro.Length > 20)
            {
                this.AddError("Bairro deve ser informado e conter no máximo 20 caracteres.\r\n");
            }

            //Valida Rua
            if (item.Rua.Length == 0 || item.Rua.Length > 50)
            {
                this.AddError("Rua deve ser informado e conter no máximo 50 caracteres.\r\n");
            }

            //Valida Numero
            if (item.Numero == 0)
            {
                this.AddError("Numero deve ser informado.\r\n");
            }

            //Valida Salário
            if (item.Salario == 0)
            {
                this.AddError("Salário deve ser informado.\r\n");
            }

            //Valida Comissão
            if (item.Comissao == 0)
            {
                this.AddError("Comissão deve ser informado.\r\n");
            }

            //Valida Ativo (funcionario atual)
            if (!item.Ativo)
            {
                this.AddError("Para ser possível cadastrar este Atendente o campo 'ativo' deve estar marcado.\r\n");
            }

            return base.Validate(item);
        }
        public Response Insert(Atendente a)
        {
            Response r = this.Validate(a);
            if (!r.Success)
            {
                return r;
            }
            return atendenteDAL.Insert(a);
        }
        public DataResponse<Atendente> GetAll()
        {
            return atendenteDAL.GetAll();
        }
        public DataResponse<Atendente> Search(string palavra)
        {
            return atendenteDAL.Search(palavra);
        }
        public Response Update(Atendente a)
        {
            Response r = this.Validate(a);
            if (!r.Success)
            {
                return r;
            }
            return atendenteDAL.Update(a);
        }

        public SingleResponse<Atendente> GetPerson(int id)
        {
            return atendenteDAL.GetPerson(id);
        }

        public DataResponse<Atendente> SearchAtivos(string palavra)
        {
            return atendenteDAL.SearchAtivos(palavra);
        }

        public DataResponse<Atendente> SearchInativos(string palavra)
        {
            return atendenteDAL.SearchInativos(palavra);
        }
    }
}
