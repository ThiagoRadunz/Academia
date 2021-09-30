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
    public class ClienteBLL : BaseValidator<Cliente>, IClienteService
    {
        ClienteDAL clienteDAL = new ClienteDAL();
        
        public override Response Validate(Cliente item)
        {
            //Coloca nome em PascalCase e valida comprimento do nome
            item.Nome = Normatization.NormatizeString(item.Nome);
            item.Nome = CommonValidations.IsValidNome(item.Nome);

            //Remove mascara do cpf e valida se é um cpf com regex
            item.CPF = item.CPF?.Trim().Replace("-", "").Replace(".", "");
            item.CPF = CommonValidations.IsCpf(item.CPF);

            //Valida se Cliente é maior de 14 anos
            DateTime birthdate = item.DataNascimento;
            DateTime today = DateTime.Now;
            int age = today.Year - birthdate.Year;
            if (birthdate > today.AddYears(-age))
            {
                age--;
            }
            if (age < 14)
            {
                this.AddError("Idade inválida. Apenas maiores de 14 anos podem ter cadastro.\r\n");
            }

            //Valida email
            if (item.Email.Length == 0 || item.Email.Length > 100)
            {
                this.AddError("Email deve conter no máximo 100 caracteres\r\n");
            }
            string regex = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            bool isValid = Regex.IsMatch(item.Email, regex);
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

            //Valida Telefone Celular
            if (item.FoneCelular.Length == 0 || item.FoneCelular.Length < 8 || item.FoneCelular.Length > 15)
            {
                this.AddError("Telefone deve ser informado e conter entre 10 e no máximo 15 caracteres.\r\n");
            }

            //Valida Telefone Fixo
            if (item.FoneFixo.Length == 0 || item.FoneFixo.Length < 8 || item.FoneFixo.Length > 15)
            {
                this.AddError("Telefone deve ser informado e conter entre 10 e no máximo 15 caracteres.\r\n");
            }

            //Valida Ativo (funcionario atual)
            if (item.Ativo)
            {
                this.AddError("Para ser possível cadastrar este Instrutor o campo 'ativo' deve estar marcado.\r\n");
            }

            return base.Validate(item);
        }
        public Response Insert(Cliente c)
        {
            Response r = this.Validate(c);
            if (!r.Success)
            {
                return r;
            }
            c.Ativo = true;
            return clienteDAL.Insert(c);
        }
        public DataResponse<Cliente> GetAll()
        {
            return clienteDAL.GetAll();
        }
        public Response Update(Cliente c)
        {
            Response response = this.Validate(c);
            if (!response.Success)
            {
                return response;
            }

            return clienteDAL.Update(c);
        }
        public DataResponse<Cliente> Search(string palavra)
        {
            return clienteDAL.Search(palavra);
        }
        public DataResponse<Cliente> SearchInatives(string palavra)
        {
            return clienteDAL.SearchInatives(palavra);
        }
        public DataResponse<Cliente> SearchAtives(string palavra)
        {
            return clienteDAL.SearchAtives(palavra);
        }
    }
}
