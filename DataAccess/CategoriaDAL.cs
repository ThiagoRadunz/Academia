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
    public class CategoriaDAL : ICategoriaService
    {
        public Response Insert(Categoria c)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO CATEGORIAS (NOME) VALUES (@NOME)";
            command.Parameters.AddWithValue("@NOME", c.Nome);

            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Categoria cadastrada com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                if (ex.Message.Contains("UC_CATEGORIAS"))
                {
                    resposta.Message = "Categoria já cadastrada!";
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

        public DataResponse<Categoria> GetAll()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM CATEGORIAS ORDER BY ID";

            DataResponse<Categoria> resposta = new DataResponse<Categoria>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Categoria> categorias = new List<Categoria>();
                while (reader.Read())
                {
                    //Cada Loop deste while, faz com que o objeto "reader" aponte para um registro retornado pelo select
                    Categoria categoria = new Categoria();
                    categoria.ID = Convert.ToInt32(reader["ID"]);
                    categoria.Nome = Convert.ToString(reader["NOME"]);
                    categorias.Add(categoria);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = categorias;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<Categoria>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }


        //UPDATE
        public Response Update(Categoria c)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE CATEGORIAS SET NOME = @NOME WHERE ID = @ID";
            command.Parameters.AddWithValue("@NOME", c.Nome);
            command.Parameters.AddWithValue("@ID", c.ID);

            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Cadastro editado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                if (ex.Message.Contains("UC_CATEGORIAS"))
                {
                    resposta.Message = "Categoria já cadastrada!";
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

        public Response Delete(int id)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM CATEGORIAS WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);

            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Categoria excluída com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                if (ex.Message.Contains("FK_CATEGORIAS"))
                {
                    resposta.Message = "Categoria não pode ser excluída, pois existem planos vinculados a ela!";
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

        public List<string> GetAllCategories()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT DISTINCT NOME FROM CATEGORIAS";

            DataResponse<string> resposta = new DataResponse<string>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<string> distinctcategories = new List<string>();
                while (reader.Read())
                {
                    


                    string categoria = Convert.ToString(reader["NOME"]);
                    distinctcategories.Add(categoria);
                }

                resposta.Success = true;
                resposta.Message = "Categorias distintas selecionadas com sucesso!";
                resposta.Data = distinctcategories;
                return distinctcategories;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<string>();
                return resposta.Data;
            }
            finally
            {
                connection.Dispose();
            }
        }

       
        
    }
}

