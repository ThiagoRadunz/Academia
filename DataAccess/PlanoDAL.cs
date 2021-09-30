using Entities;
using Entities.Interfaces;
using Entities.ViewModel;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PlanoDAL : IPlanoService
    {
        public Response Insert(Plano p)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"INSERT INTO PLANOS (CATEGORIAID, VALOR, QTDD_AULA_SEMANA, QTDD_MES)
                                    VALUES (@CATEGORIAID, @VALOR, @QTDD_AULA_SEMANA, @QTDD_MES)";
            command.Parameters.AddWithValue("@CATEGORIAID", p.IDCategoria);
            command.Parameters.AddWithValue("@VALOR", p.PrecoPlano);
            command.Parameters.AddWithValue("@QTDD_AULA_SEMANA", p.QtdAulaSemana);
            command.Parameters.AddWithValue("@QTDD_MES", p.DuracaoPlano);

            Response response = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Plano cadastrado com sucesso";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("FK_CATEGORIAS"))
                {
                    response.Message = "Categoria informada para este plano inválida!";
                    return response;
                }
                response.Message = "Erro no banco de dados, contate o administrador";
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<PlanoQueryView> GetAll()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT P.ID,
                                           C.NOME, 
                                           P.QTDD_AULA_SEMANA, 
                                           P.QTDD_MES, 
                                           P.VALOR
                                    FROM PLANOS P INNER JOIN
                                         CATEGORIAS C ON
                                           P.CATEGORIAID = C.ID";

            DataResponse<PlanoQueryView> resposta = new DataResponse<PlanoQueryView>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<PlanoQueryView> planos = new List<PlanoQueryView>();
                while (reader.Read())
                {
                    //Cada Loop deste while, faz com que o objeto "reader" aponte para um registro retornado pelo select
                    PlanoQueryView pqv = new PlanoQueryView();
                    pqv.IDPlano = Convert.ToInt32(reader["ID"]);
                    pqv.Categoria = Convert.ToString(reader["NOME"]);
                    pqv.QtdAulaSemana = Convert.ToInt32(reader["QTDD_AULA_SEMANA"]);
                    pqv.PrecoPlano = Convert.ToDouble(reader["VALOR"]);
                    pqv.DuracaoPlano = Convert.ToInt32(reader["QTDD_MES"]);
                    planos.Add(pqv);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = planos;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<PlanoQueryView>();
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
            command.CommandText = "DELETE FROM PLANOS WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);



            Response response = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Plano excluído com sucesso";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;

                if (ex.Message.Contains("FK_PLANOS"))
                {
                    response.Message = "Plano não pode ser excluido, devido possuir registros vinculados a ele!";
                    return response;
                }
                response.Message = "Plano não pode ser excluido, devido possuir registros vinculados a ele!";
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Exists(Plano p)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT P.ID FROM PLANOS WHERE CATEGORIAID = @CATEGORIA AND
                                                                  QTDD_AULA_SEMANA = @QTDAULA AND
                                                                  QTDD_MES = @QTDMES AND
                                                                  VALOR = @VALOR";
            command.Parameters.AddWithValue("@CATEGORIA", p.IDCategoria);
            command.Parameters.AddWithValue("@QTDAULA", p.QtdAulaSemana);
            command.Parameters.AddWithValue("@QTDMES", p.DuracaoPlano);
            command.Parameters.AddWithValue("@VALOR", p.PrecoPlano);

            Response resposta = new Response();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    resposta.Success = false;
                    resposta.Message = "Já existe um plano com estas configurações.";
                    return resposta;
                }

                resposta.Success = true;
                resposta.Message = "Plano único!";
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }


        }

        public DataResponse<Plano> GetAllPlansDuration()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT DISTINCT QTDD_MES FROM PLANOS";

            DataResponse<Plano> resposta = new DataResponse<Plano>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Plano> distinctDurationsList = new List<Plano>();
                while (reader.Read())
                {
                    Plano plano = new Plano();
                    plano.DuracaoPlano = Convert.ToInt32(reader["QTDD_MES"]);
                    distinctDurationsList.Add(plano);
                }

                resposta.Success = true;
                resposta.Message = "Duração de planos distintas selecionadas com sucesso!";
                resposta.Data = distinctDurationsList;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<Plano>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
