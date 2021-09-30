using Entities;
using Entities.Enums;
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
    public class UsuarioDAL : IUsuarioService
    {
        public SingleResponse<Usuario> Authenticate(string email, string senha)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM USUARIOS WHERE EMAIL = @EMAIL AND SENHA = @SENHA";
            command.Parameters.AddWithValue("@EMAIL", email);
            command.Parameters.AddWithValue("@SENHA", senha);

            command.Connection = connection;

            SingleResponse<Usuario> response = new SingleResponse<Usuario>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Usuario u = new Usuario();
                    u.IDUsuario = Convert.ToInt32(reader["ID"]);
                    u.Nome = Convert.ToString(reader["NOME"]);
                    u.Email = Convert.ToString(reader["EMAIL"]);
                    u.Senha = Convert.ToString(reader["SENHA"]);
                    u.Funcao = (Papel)(reader["FUNCAO"]);
                    response.Success = true;
                    response.Message = "Autenticação realizada com sucesso.";
                    response.Item = u;
                    return response;
                }
                response.Success = false;
                response.Message = "Usuário e/ou senha inválidos.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados, contate o administrador.";
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Insert(Usuario u)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"INSERT INTO USUARIOS (NOME, EMAIL, SENHA, FUNCAO)
                                    VALUES (@NOME, @EMAIL, @SENHA, @FUNCAO)";
            command.Parameters.AddWithValue("@NOME", u.Nome);
            command.Parameters.AddWithValue("@EMAIL", u.Email);
            command.Parameters.AddWithValue("@SENHA", u.Senha);
            command.Parameters.AddWithValue("@FUNCAO", u.Funcao);

            Response response = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Usuário cadastrado com sucesso";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("UC_USUARIOS"))
                {
                    response.Message = "Este email já foi cadastrado!";
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

        public DataResponse<Usuario> GetAll()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM USUARIOS ORDER BY ID";

            DataResponse<Usuario> resposta = new DataResponse<Usuario>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Usuario> userList = new List<Usuario>();
                while (reader.Read())
                {
                    Usuario user = new Usuario();
                    user.IDUsuario = Convert.ToInt32(reader["ID"]);
                    user.Nome = Convert.ToString(reader["NOME"]);
                    user.Email = Convert.ToString(reader["EMAIL"]);
                    user.Funcao = (Papel)(reader["FUNCAO"]);
                    userList.Add(user);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = userList;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<Usuario>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }

        }

        public Response Update(Usuario u)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"UPDATE USUARIOS SET SENHA = @SENHA
                                                  WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", u.IDUsuario);
            command.Parameters.AddWithValue("@SENHA", u.Senha);


            Response resposta = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                resposta.Success = true;
                resposta.Message = "Usuario editado com sucesso!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Success = false;

                if (ex.Message.Contains("UC_USUARIOS"))
                {
                    resposta.Message = "Email já cadastrado!";
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

        public DataResponse<Usuario> Search(string palavra)
        {

            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT USUARIO.ID IDUsuario,
                                           USUARIO.NOME Nome,
                                           USUARIO.EMAIL Email,
                                           USUARIO.FUNCAO Funcao
                                      FROM USUARIOS USUARIO
                                     WHERE UPPER(USUARIO.NOME) LIKE UPPER('%" + palavra + "%')";

            DataResponse<Usuario> response = new DataResponse<Usuario>();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                List<Usuario> listUsuarios = new List<Usuario>();
                while (reader.Read())
                {
                    Usuario usuario = new Usuario();

                    usuario.IDUsuario = Convert.ToInt32(reader["IDUsuario"]);
                    usuario.Nome = Convert.ToString(reader["Nome"]);
                    usuario.Email = Convert.ToString(reader["Email"]);
                    usuario.Funcao = (Papel)(reader["Funcao"]);


                    listUsuarios.Add(usuario);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso";
                response.Data = listUsuarios;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados contate o administrador !";
                response.Data = new List<Usuario>();
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}