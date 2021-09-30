using DataAccess;
using Entities;
using Entities.Interfaces;
using Entities.ViewModel;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogical
{
    public class PlanoBLL : BaseValidator<Plano>, IPlanoService
    {
        private PlanoDAL planoDAL = new PlanoDAL();

        //EXISTS DO PLANO NAO PERMITE FAZER INSERT DO PLANO
        //EXISTS RETORNA UMA ID. E SE A ID JA EXISTE O BASE.VALIDATE NAO PERMITE O INSERT, LOGO NAO FAZ SUA FUNCAO CORRETAMENTE QUE SERIA GARANTIR QUE UM PLANO (CATEGORIAID,QTDD_AULA_SEMANA,QDD_MES,VALOR) SEJA UNICO
        public override Response Validate(Plano item)
        {
            //Validação da categoria do plano
            if (string.IsNullOrWhiteSpace(item.IDCategoria.ToString()))
            {
                this.AddError("Categoria do plano deve ser informada.\r\n");
            }

            //Validação dos dias por semana
            if (item.QtdAulaSemana == 0 || item.QtdAulaSemana > 7 || item.QtdAulaSemana < 0)
            {
                this.AddError("Quantidade de aulas por semana inválida.\r\n");
            }

            //Validação dos meses por ano
            if (item.DuracaoPlano == 0 || item.DuracaoPlano > 12 || item.DuracaoPlano < 0)
            {
                this.AddError("Duração do plano inválida.\r\n");
            }

            //Validação do valor do plano
            if (item.PrecoPlano == 0 || item.PrecoPlano < 0)
            {
                this.AddError("Preço do plano inválido, consulte o Administrador da Academia.\r\n");
            }

            return base.Validate(item);
        }

        public DataResponse<PlanoQueryView> GetAll()
        {
            return planoDAL.GetAll();
        }

        public Response Delete(int id)
        {
            return planoDAL.Delete(id);
        }

        public Response Insert(Plano p)
        {
            Response response = this.Validate(p);

            if (!response.Success)
            {
                return response;
            }

            return planoDAL.Insert(p);
        }

        public Response Exists(Plano p)
        {
            return planoDAL.Exists(p);
        }

        public DataResponse<Plano> GetAllPlansDuration()
        {
            return planoDAL.GetAllPlansDuration();
        }

    }
}