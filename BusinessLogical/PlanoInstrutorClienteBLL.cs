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
    
    public class PlanoInstrutorClienteBLL : BaseValidator<PlanoInstrutorCliente>, IPlanoInstrutorClienteService
    {
        PlanoInstrutorClienteDAL picDAL = new PlanoInstrutorClienteDAL();

        public override Response Validate(PlanoInstrutorCliente item)
        {
            if (item.AdesaoContrato == null || item.TerminoContrato == null)
            {
                this.AddError("Favor informar a duração do plano, confirmando a seleção do plano (botão 'Confirmar' abaixo da tela de Modalidade).\r\n");
            }
            if (item.AdesaoContrato > item.TerminoContrato)
            {
                this.AddError("Erro na data de termino de contrato, favor verificar! Obrigado.\r\n");
            }
            if (item.IDPlano == 0)
            {
                this.AddError("Favor selecionar um plano, confirmando a seleção do plano (botão 'Confirmar' abaixo da tela de Modalidade).\r\n");
            }
            if (item.IDFormapagamento == 0)
            {
                this.AddError("Favor selecionar uma forma de pagamento, confirmando a seleção (botão 'Confirmar' abaixo da tela de FormaPagamento), Obrigado.\r\n");
            }

            return base.Validate(item);
        }
        public Response Insert(PlanoInstrutorCliente pic)
        {
            Response r = this.Validate(pic);
            if (!r.Success)
            {
                return r;
            }
            return picDAL.Insert(pic);
        }

        public DataResponse<PlanoInstrutorClienteQueryView> GetAll()
        {
            return picDAL.GetAll();
        }

        public Response Update(PlanoInstrutorCliente pic)
        {
            throw new NotImplementedException();
        }

        public Response EndPlain(int id)
        {
            throw new NotImplementedException();
        }

        public DataResponse<PlanoInstrutorClienteQueryView> GetAllbyIDInstrutor(int id)
        {
            return picDAL.GetAllbyIDInstrutor(id);
        }

        public DataResponse<PlanoInstrutorClienteQueryView> GetAllbyIDCliente(int id)
        {
            return picDAL.GetAllbyIDCliente(id);
        }

        public DataResponse<PlanoInstrutorClienteQueryView> GetAllbyIDModalidade(int id)
        {
            return picDAL.GetAllbyIDModalidade(id);
        }


    }
}
