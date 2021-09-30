using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class VendaDAL : IVendaService
    {
        public Response SellProducts(Venda saidaProdutos)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"INSERT INTO VENDAS (DATA_SAIDA, VALORTOTAL, USUARIOID, CLIENTEID)
                                         VALUES (@DATA_SAIDA, @VALORTOTAL, @USUARIOID, @CLIENTEID) SELECT SCOPE_IDENTITY()";

            command.Parameters.AddWithValue("@DATA_SAIDA", saidaProdutos.DataVenda);
            command.Parameters.AddWithValue("@VALORTOTAL", saidaProdutos.ValorTotal);
            command.Parameters.AddWithValue("@USUARIOID", saidaProdutos.IDUsuario);
            command.Parameters.AddWithValue("@CLIENTEID", saidaProdutos.IDCliente);


            Response response = new Response();
            try
            {
                connection.Open();
                saidaProdutos.IDVenda = Convert.ToInt32(command.ExecuteScalar());
                response.Success = true; response.Message = "Venda realizada com sucesso";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                
                response.Message = "Erro no banco de dados contate o administrador !";
                return response;
            }
            finally
            {
                connection.Dispose();
            }


        }

        public Response SellItem(ItensVenda itensVenda)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;


            command.CommandText = @"INSERT INTO ITENS_VENDA (VENDAID, PRODUTOID, QUANTIDADE, VALOR_UNITARIO)
                                                VALUES  (@VENDAID, @PRODUTOID, @QUANTIDADE, @VALOR_UNITARIO)";
            command.Parameters.AddWithValue("@VENDAID", itensVenda.IDItensVenda);
            command.Parameters.AddWithValue("@PRODUTOID", itensVenda.IDProduto);
            command.Parameters.AddWithValue("@QUANTIDADE", itensVenda.Quantidade);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", itensVenda.PrecoUnitario);


            Response response = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true;
                response.Message = "Venda realizada com sucesso";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados contate o administrador !";
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
