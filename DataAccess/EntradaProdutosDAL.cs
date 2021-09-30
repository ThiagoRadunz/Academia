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
    public class EntradaProdutosDAL : IEntradaProdutosService
    {
        public Response Includer(EntradaProdutos entradaProdutos)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"INSERT INTO ENTRADAS_PRODUTO_CX (DATA_ENTRADA, VALORTOTAL, USUARIOID)
                                         VALUES (@DATA_ENTRADA, @VALORTOTAL, @USUARIOID) SELECT SCOPE_IDENTITY()";

            command.Parameters.AddWithValue("@DATA_ENTRADA", entradaProdutos.DataEntrada);
            command.Parameters.AddWithValue("@VALORTOTAL", entradaProdutos.ValorTotal);
            command.Parameters.AddWithValue("@USUARIOID", entradaProdutos.IDUsuario);


            Response response = new Response();
            try
            {
                connection.Open();
                entradaProdutos.IDEntradaProdutos = Convert.ToInt32(command.ExecuteScalar());
                response.Success = true; response.Message = "Entrada de produtos cadastrada com sucesso";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("UQ__ENTRADA_PROD"))
                {
                    response.Message = "Entrada de produtos já cadastrada!";
                    return response;
                }
                response.Message = "Erro no Includer do entradaProdutosDAL no banco de dados, contate o administrador" + ex.Message;
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response IncluderItem(ItensEntrada itensEntrada)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;


            command.CommandText = @"INSERT INTO ITENS_CAIXA_ENTRADA (ENTRADAID, PRODUTOID, QUANTIDADE, VALOR_UNITARIO)
                                                VALUES  (@ENTRADAID, @PRODUTOID, @QUANTIDADE, @VALOR_UNITARIO)";
            command.Parameters.AddWithValue("@ENTRADAID", itensEntrada.IDItensEntrada);
            command.Parameters.AddWithValue("@PRODUTOID", itensEntrada.IDProduto);
            command.Parameters.AddWithValue("@QUANTIDADE", itensEntrada.Quantidade);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", itensEntrada.PrecoUnitario);


            Response response = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; 
                response.Message = "Entrada de produtos cadastrada com sucesso";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("UQ__ENTRADA_PROD"))
                {
                    response.Message = "Entrada de produtos já cadastrada!";
                    return response;
                }
                response.Message = "Erro no IncluderItens do EntradaProdutos no banco de dados, contate o administrador" + ex.Message;
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
