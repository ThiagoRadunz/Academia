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
    public class ProdutoDAL : IProdutoService
    {
        public Response Insert(Produto p)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"INSERT INTO PRODUTOS (NOME, DESCRICAO, PRECO_UNITARIO, QTD_ESTOQUE, CATEGORIAID)
                                                  VALUES (@NOME, @DESCRICAO, @PRECO_UNITARIO, @QTD_ESTOQUE, @CATEGORIAID)";

            command.Parameters.AddWithValue("@NOME", p.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", p.Descricao);
            command.Parameters.AddWithValue("@QTD_ESTOQUE", p.QtdEstoque);
            command.Parameters.AddWithValue("@PRECO_UNITARIO", p.PrecoUnitario);
            command.Parameters.AddWithValue("@CATEGORIAID", p.Categoria.ID);



            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Produto cadastrado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                if (ex.Message.Contains("UC_PRODUTOS"))
                {
                    resposta.Message = "Produto não pode ter mesmo nome e mesma descrição !";
                    return resposta;
                }
                resposta.Message = "Erro no banco de dados, contate o administrador !";
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }
        public DataResponse<Produto> GetAll()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT PRODUTO.ID IDProduto,
                                           PRODUTO.NOME Nome,
                                           CATEGORIA.NOME Categoria,
                                           PRODUTO.PRECO_UNITARIO PrecoUnitario,
                                           PRODUTO.QTD_ESTOQUE QtdEstoque,
                                           PRODUTO.DESCRICAO Descricao
                                      FROM PRODUTOS PRODUTO 
                                      JOIN CATEGORIAS CATEGORIA
                                        ON PRODUTO.CATEGORIAID = CATEGORIA.ID";

            DataResponse<Produto> resposta = new DataResponse<Produto>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Produto> produtos = new List<Produto>();
                while (reader.Read())
                {
                    Produto produto = new Produto();
                    produto.ID = Convert.ToInt32(reader["IDProduto"]);
                    produto.Nome = Convert.ToString(reader["Nome"]);
                    produto.Categoria.Nome = Convert.ToString(reader["Categoria"]);
                    produto.QtdEstoque = Convert.ToDouble(reader["QtdEstoque"]);
                    produto.PrecoUnitario = Convert.ToDouble(reader["PrecoUnitario"]);
                    produto.Descricao = Convert.ToString(reader["Descricao"]);
                    produtos.Add(produto);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = produtos;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador !";
                resposta.Data = new List<Produto>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }
        public Response Update(Produto p)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"UPDATE PRODUTOS SET NOME = @NOME, DESCRICAO = @DESCRICAO, QTD_ESTOQUE = @QTD_ESTOQUE, PRECO_UNITARIO = @PRECO_UNITARIO, CATEGORIAID = @CATEGORIAID
                                     WHERE ID = @ID";

            command.Parameters.AddWithValue("@ID", p.ID);
            command.Parameters.AddWithValue("@NOME", p.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", p.Descricao);
            command.Parameters.AddWithValue("@QTD_ESTOQUE", p.QtdEstoque);
            command.Parameters.AddWithValue("@PRECO_UNITARIO", p.PrecoUnitario);
            command.Parameters.AddWithValue("@CATEGORIAID", p.Categoria.ID);


            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Produto editado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;

                if (ex.Message.Contains("UC_PRODUTOS"))
                {
                    resposta.Message = "Produto não pode ter mesmo nome e mesma descrição !";
                    return resposta;
                }

                resposta.Message = "Erro no banco de dados, contate o administrador !";
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }
        public Response Delete(int id)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM PRODUTOS WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);

            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Produto excluído com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                if (ex.Message.Contains("FK_PROD_ITENS_VENDA"))
                {
                    resposta.Message = "Produto não pode ser excluído, pois existem vendas vinculados a ela!";
                    return resposta;
                }

                resposta.Message = "Erro no banco de dados, contate o administrador.";
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }
        public DataResponse<Produto> SearchName(string palavra)
        {
            Produto c = new Produto();

            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT PRODUTO.ID IDProduto,
                                           PRODUTO.NOME Nome,
                                           CATEGORIA.NOME Categoria,
                                           PRODUTO.PRECO_UNITARIO PrecoUnitario,
                                           PRODUTO.QTD_ESTOQUE QtdEstoque,
                                           PRODUTO.DESCRICAO Descricao
                                      FROM PRODUTOS PRODUTO
                                      JOIN CATEGORIAS CATEGORIA
                                        ON PRODUTO.CATEGORIAID = CATEGORIA.ID
                                     WHERE UPPER(PRODUTO.Nome) LIKE UPPER('%" + palavra + "%')";

            DataResponse<Produto> resposta = new DataResponse<Produto>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Produto> produtos = new List<Produto>();
                while (reader.Read())
                {
                    //Cada Loop deste while, faz com que o objeto "reader" aponte para um registro retornado pelo select
                    Produto produto = new Produto();
                    produto.ID = Convert.ToInt32(reader["IDProduto"]);
                    produto.Nome = Convert.ToString(reader["Nome"]);
                    produto.Categoria.Nome = Convert.ToString(reader["Categoria"]);
                    produto.QtdEstoque = Convert.ToDouble(reader["QtdEstoque"]);
                    produto.PrecoUnitario = Convert.ToDouble(reader["PrecoUnitario"]);
                    produto.Descricao = Convert.ToString(reader["Descricao"]);

                    produtos.Add(produto);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = produtos;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no SearchName do produto no banco de dados, contate o administrador." + ex.Message;
                resposta.Data = new List<Produto>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }
        public DataResponse<Produto> SearchCategory(string palavra)
        {
            Produto c = new Produto();

            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT PRODUTO.ID IDProduto,
                                           PRODUTO.NOME Nome,
                                           CATEGORIA.NOME Categoria,
                                           PRODUTO.PRECO_UNITARIO PrecoUnitario,
                                           PRODUTO.QTD_ESTOQUE QtdEstoque,
                                           PRODUTO.DESCRICAO Descricao
                                      FROM PRODUTOS PRODUTO
                                      JOIN CATEGORIAS CATEGORIA
                                        ON PRODUTO.CATEGORIAID = CATEGORIA.ID
                                     WHERE UPPER(CATEGORIA.NOME) LIKE UPPER('%" + palavra + "%')";

            DataResponse<Produto> resposta = new DataResponse<Produto>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Produto> produtos = new List<Produto>();
                while (reader.Read())
                {
                    //Cada Loop deste while, faz com que o objeto "reader" aponte para um registro retornado pelo select
                    Produto produto = new Produto();
                    produto.ID = Convert.ToInt32(reader["IDProduto"]);
                    produto.Nome = Convert.ToString(reader["Nome"]);
                    produto.Categoria.Nome = Convert.ToString(reader["Categoria"]);
                    produto.QtdEstoque = Convert.ToDouble(reader["QtdEstoque"]);
                    produto.PrecoUnitario = Convert.ToDouble(reader["PrecoUnitario"]);
                    produto.Descricao = Convert.ToString(reader["Descricao"]);

                    produtos.Add(produto);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = produtos;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no SearchCategory do produto no banco de dados, contate o administrador." + ex.Message;
                resposta.Data = new List<Produto>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Produto> SearchNameAndCategory(string palavra)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = SqlUtils.CONNECTION_STRING;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT PRODUTO.ID IDProduto,
                                           PRODUTO.NOME Nome,
                                           CATEGORIA.NOME Categoria,
                                           PRODUTO.PRECO_UNITARIO PrecoUnitario,
                                           PRODUTO.QTD_ESTOQUE QtdEstoque,
                                           PRODUTO.DESCRICAO Descricao
                                      FROM PRODUTOS PRODUTO
                                      JOIN CATEGORIAS CATEGORIA
                                        ON PRODUTO.CATEGORIAID = CATEGORIA.ID
                                     WHERE UPPER(CATEGORIA.NOME) LIKE UPPER('%" + palavra + "%') OR UPPER(PRODUTO.NOME) LIKE UPPER('%" + palavra + "%')";

            DataResponse<Produto> resposta = new DataResponse<Produto>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Produto> produtos = new List<Produto>();
                while (reader.Read())
                {
                    //Cada Loop deste while, faz com que o objeto "reader" aponte para um registro retornado pelo select
                    Produto produto = new Produto();
                    produto.ID = Convert.ToInt32(reader["IDProduto"]);
                    produto.Nome = Convert.ToString(reader["Nome"]);
                    produto.Categoria.Nome = Convert.ToString(reader["Categoria"]);
                    produto.QtdEstoque = Convert.ToDouble(reader["QtdEstoque"]);
                    produto.PrecoUnitario = Convert.ToDouble(reader["PrecoUnitario"]);
                    produto.Descricao = Convert.ToString(reader["Descricao"]);

                    produtos.Add(produto);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = produtos;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no SearchNameAndCategory do produto no banco de dados, contate o administrador." + ex.Message;
                resposta.Data = new List<Produto>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public SingleResponse<Produto> GetProduct(int id)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM PRODUTOS WHERE ID = @ID";

            command.Parameters.AddWithValue("@ID", id);

            SingleResponse<Produto> resposta = new SingleResponse<Produto>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Produto produto = new Produto();

                    produto.ID = Convert.ToInt32(reader["ID"]);
                    produto.Nome = Convert.ToString(reader["NOME"]);
                    produto.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    produto.PrecoUnitario = Convert.ToDouble(reader["PRECO_UNITARIO"]);
                    produto.Categoria.ID = Convert.ToInt32(reader["CATEGORIAID"]);
                    produto.QtdEstoque = Convert.ToDouble(reader["QTD_ESTOQUE"]);
                    resposta.Success = true;
                    resposta.Message = "Dados selecionados com sucesso!";
                    resposta.Item = produto;
                }
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no GetProduct no banco de dados, contate o administrador." + ex.Message;
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response StockUpdater(int id, double novoEstoque)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"UPDATE PRODUTOS 
                                       SET QTD_ESTOQUE = @QTD_ESTOQUE
                                     WHERE ID = @ID";

            command.Parameters.AddWithValue("@QTD_ESTOQUE", novoEstoque);
            command.Parameters.AddWithValue("@ID", id);

            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Produto editado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {

                resposta.Success = false;
                resposta.Message = "Erro no StockUpdater do produtoDAL no banco de dados, contate o administrador." + ex.Message;
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response PriceUpdater(int id, double precoUnitario)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE PRODUTOS SET PRECO_UNITARIO = @PRECO_UNITARIO WHERE ID = @ID";
            command.Parameters.AddWithValue("@PRECO_UNITARIO", precoUnitario);
            command.Parameters.AddWithValue("@ID", id);

            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Produto editado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;

                if (ex.Message.Contains("UC_PRODUTOS"))
                {
                    resposta.Message = "Produto e descrição não podem ser identicos, produto já cadastrado!";
                    return resposta;
                }

                resposta.Message = "Erro no PriceUpdater no produtoDAL do banco de dados, contate o administrador." + ex.Message;
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        
    }
}
