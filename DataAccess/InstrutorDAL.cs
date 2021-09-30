using Entities;
using Entities.Enums;
using Entities.Interfaces;
using Entities.ViewModel;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccess
{
    public class InstrutorDAL : IInstrutorService
    {
        public Response Insert(Instrutor i)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;


            SqlCommand ucommand = new SqlCommand();
            ucommand.Connection = connection;
            ucommand.CommandText = @"INSERT INTO USUARIOS (NOME, EMAIL, SENHA, FUNCAO)
                                    VALUES (@NOME, @EMAIL, @SENHA, @FUNCAO) SELECT SCOPE_IDENTITY()";
            ucommand.Parameters.AddWithValue("@NOME", i.Usuario.Nome);
            ucommand.Parameters.AddWithValue("@EMAIL", i.Usuario.Email);
            ucommand.Parameters.AddWithValue("@SENHA", i.Usuario.Senha);
            ucommand.Parameters.AddWithValue("@FUNCAO", i.Usuario.Funcao);

            Response response = new Response();
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    connection.Open();

                    int idUsuarioGerada = Convert.ToInt32(ucommand.ExecuteScalar());

                    SqlCommand icommand = new SqlCommand();
                    icommand.Connection = connection;
                    icommand.CommandText = @"INSERT INTO INSTRUTORES (USUARIOID, FONE, CPF, DATA_NASCIMENTO, RG, ESTADO, CIDADE, BAIRRO, RUA, NUMERO, SALARIO, COMISSAO, ATIVO)
                                    VALUES (@USUARIOID, @FONE, @CPF, @DATA_NASCIMENTO, @RG, @ESTADO, @CIDADE, @BAIRRO, @RUA, @NUMERO, @SALARIO, @COMISSAO, @ATIVO) 
                                    ";
                    icommand.Parameters.AddWithValue("@USUARIOID", idUsuarioGerada);
                    icommand.Parameters.AddWithValue("@FONE", i.TelefoneCelular);
                    icommand.Parameters.AddWithValue("@CPF", i.CPF);
                    icommand.Parameters.AddWithValue("@DATA_NASCIMENTO", i.DataNascimento);
                    icommand.Parameters.AddWithValue("@RG", i.RG);
                    icommand.Parameters.AddWithValue("@ESTADO", i.Estado);
                    icommand.Parameters.AddWithValue("@CIDADE", i.Cidade);
                    icommand.Parameters.AddWithValue("@BAIRRO", i.Bairro);
                    icommand.Parameters.AddWithValue("@RUA", i.Rua);
                    icommand.Parameters.AddWithValue("@NUMERO", i.Numero);
                    icommand.Parameters.AddWithValue("@SALARIO", i.Salario);
                    icommand.Parameters.AddWithValue("@COMISSAO", i.Comissao);
                    icommand.Parameters.AddWithValue("@ATIVO", i.Ativo);
                    icommand.ExecuteNonQuery();

                    scope.Complete();
                    response.Success = true; response.Message = "Instrutor cadastrado com sucesso";
                    return response;
                }
                catch (Exception ex)
                {
                    response.Success = false;
                    if (ex.Message.Contains("UC_INSTRUTORES"))
                    {
                        response.Message = "CPF ou RG já cadastrado!";
                        return response;
                    }

                    response.Message = "Erro no banco de dados contate o administrador !";
                    return response;
                }
                finally
                {
                    connection.Dispose();
                }
            }
        }
        public DataResponse<Instrutor> GetAll()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT U.NOME,
                                           U.EMAIL,
                                           U.FUNCAO,
                                           I.FONE,
                                           I.CPF, 
                                           I.DATA_NASCIMENTO, 
                                           I.RG, 
                                           I.ESTADO,
                                           I.CIDADE,
                                           I.BAIRRO,
                                           I.RUA,
                                           I.NUMERO,
                                           I.SALARIO,
                                           I.COMISSAO,
                                           I.ATIVO,
                                           I.ID,
                                           I.USUARIOID
                                    FROM INSTRUTORES I INNER JOIN
                                         USUARIOS U ON
                                           I.USUARIOID = U.ID";

            DataResponse<Instrutor> resposta = new DataResponse<Instrutor>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Instrutor> Instrutores = new List<Instrutor>();
                while (reader.Read())
                {
                    Instrutor instrutor = new Instrutor();
                    instrutor.Usuario.Nome = Convert.ToString(reader["NOME"]);
                    instrutor.Usuario.Email = Convert.ToString(reader["EMAIL"]);
                    instrutor.Usuario.IDUsuario = Convert.ToInt32(reader["USUARIOID"]);
                    instrutor.Usuario.Funcao = (Papel)(reader["FUNCAO"]);
                    instrutor.TelefoneCelular = Convert.ToString(reader["FONE"]);
                    instrutor.CPF = Convert.ToString(reader["CPF"]);
                    instrutor.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    instrutor.RG = Convert.ToString(reader["RG"]);
                    instrutor.Estado = Convert.ToString(reader["ESTADO"]);
                    instrutor.Cidade = Convert.ToString(reader["CIDADE"]);
                    instrutor.Bairro = Convert.ToString(reader["BAIRRO"]);
                    instrutor.Rua = Convert.ToString(reader["RUA"]);
                    instrutor.Numero = Convert.ToInt32(reader["NUMERO"]);
                    instrutor.Salario = Convert.ToDouble(reader["SALARIO"]);
                    instrutor.Comissao = Convert.ToDouble(reader["COMISSAO"]);
                    instrutor.Ativo = Convert.ToBoolean(reader["ATIVO"]);
                    instrutor.IDUsuario = Convert.ToInt32(reader["USUARIOID"]);
                    instrutor.IDInstrutor = Convert.ToInt32(reader["ID"]);
                    Instrutores.Add(instrutor);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = Instrutores;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<Instrutor>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }
        public Response Update(Instrutor i)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"UPDATE USUARIOS SET NOME = @NOME,
                                                        EMAIL = @EMAIL
                                                        WHERE ID = @ID";
            command.Parameters.AddWithValue("@NOME", i.Usuario.Nome);
            command.Parameters.AddWithValue("@EMAIL", i.Usuario.Email);
            command.Parameters.AddWithValue("@ID", i.Usuario.IDUsuario);

            Response response = new Response();

            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    command = new SqlCommand();
                    command.Connection = connection;

                    command.CommandText = @"UPDATE INSTRUTORES SET FONE = @FONE,
                                                           ESTADO = @ESTADO,
                                                           CIDADE = @CIDADE,
                                                           BAIRRO = @BAIRRO,
                                                           RUA = @RUA,
                                                           NUMERO = @NUMERO,
                                                           SALARIO = @SALARIO,
                                                           COMISSAO = @COMISSAO,
                                                           ATIVO = @ATIVO
                                                        WHERE ID = @IDInstrutor";
                    command.Parameters.AddWithValue("@FONE", i.TelefoneCelular);
                    command.Parameters.AddWithValue("@ESTADO", i.Estado);
                    command.Parameters.AddWithValue("@CIDADE", i.Cidade);
                    command.Parameters.AddWithValue("@BAIRRO", i.Bairro);
                    command.Parameters.AddWithValue("@RUA", i.Rua);
                    command.Parameters.AddWithValue("@NUMERO", i.Numero);
                    command.Parameters.AddWithValue("@SALARIO", i.Salario);
                    command.Parameters.AddWithValue("@COMISSAO", i.Comissao);
                    command.Parameters.AddWithValue("@IDInstrutor", i.IDInstrutor);
                    command.Parameters.AddWithValue("@ATIVO", i.Ativo);

                    command.ExecuteNonQuery();
                    

                    scope.Complete();
                    response.Success = true;
                    response.Message = "Instrutor editado com sucesso";
                    return response;
                }
                catch (Exception ex)
                {
                    response.Success = false;
                    if (ex.Message.Contains("truncated"))
                    {
                        response.Message = "Dados inválidos!";
                        return response;
                    }
                    response.Message = "Erro no banco de dados contate o administrador !";
                    return response;
                }
                finally
                {
                    connection.Dispose();
                }
            }
            
        }
        public DataResponse<Instrutor> Search(string palavra)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT INSTRUTOR.ID IDInstrutor,
                                           INSTRUTOR.USUARIOID UsuarioID,
                                           USUARIO.NOME Nome,
                                           USUARIO.EMAIL Email,
                                           USUARIO.FUNCAO Funcao,
                                           INSTRUTOR.FONE TelefoneCelular,
                                           INSTRUTOR.CPF CPF,
                                           INSTRUTOR.DATA_NASCIMENTO DataNascimento,
                                           INSTRUTOR.RG RG,
                                           INSTRUTOR.ESTADO Estado,
                                           INSTRUTOR.CIDADE Cidade,
                                           INSTRUTOR.BAIRRO Bairro,
                                           INSTRUTOR.RUA Rua,
                                           INSTRUTOR.NUMERO Numero,
                                           INSTRUTOR.SALARIO Salario,
                                           INSTRUTOR.COMISSAO Comissao,
                                           INSTRUTOR.ATIVO Ativo
                                      FROM INSTRUTORES INSTRUTOR
                                      JOIN USUARIOS USUARIO
                                        ON INSTRUTOR.USUARIOID = USUARIO.ID
                                     WHERE UPPER(USUARIO.NOME) LIKE UPPER('%" + palavra + "%')";

            DataResponse<Instrutor> response = new DataResponse<Instrutor>();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                List<Instrutor> listInstrutores = new List<Instrutor>();
                while (reader.Read())
                {
                    Instrutor instrutor = new Instrutor();

                    instrutor.IDInstrutor = Convert.ToInt32(reader["IDInstrutor"]);
                    instrutor.IDUsuario = Convert.ToInt32(reader["UsuarioID"]);
                    instrutor.Usuario.Nome = Convert.ToString(reader["Nome"]);
                    instrutor.Usuario.Email = Convert.ToString(reader["Email"]);
                    instrutor.Usuario.Funcao = (Papel)(reader["Funcao"]);
                    instrutor.TelefoneCelular = Convert.ToString(reader["TelefoneCelular"]);
                    instrutor.CPF = Convert.ToString(reader["CPF"]);
                    instrutor.DataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                    instrutor.RG = Convert.ToString(reader["RG"]);
                    instrutor.Estado = Convert.ToString(reader["Estado"]);
                    instrutor.Cidade = Convert.ToString(reader["Cidade"]);
                    instrutor.Bairro = Convert.ToString(reader["Bairro"]);
                    instrutor.Rua = Convert.ToString(reader["Rua"]);
                    instrutor.Numero = Convert.ToInt32(reader["Numero"]);
                    instrutor.Salario = Convert.ToDouble(reader["Salario"]);
                    instrutor.Comissao = Convert.ToDouble(reader["Comissao"]);
                    instrutor.Ativo = Convert.ToBoolean(reader["Ativo"]);

                    listInstrutores.Add(instrutor);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso";
                response.Data = listInstrutores;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados contate o administrador !";
                response.Data = new List<Instrutor>();
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<Instrutor> GetPerson(int id)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT INSTRUTOR.ID IDInstrutor,
                                           INSTRUTOR.USUARIOID UsuarioID,
                                           USUARIO.NOME Nome,
                                           USUARIO.EMAIL Email,
                                           USUARIO.FUNCAO Funcao,
                                           INSTRUTOR.FONE TelefoneCelular,
                                           INSTRUTOR.CPF CPF,
                                           INSTRUTOR.DATA_NASCIMENTO DataNascimento,
                                           INSTRUTOR.RG RG,
                                           INSTRUTOR.ESTADO Estado,
                                           INSTRUTOR.CIDADE Cidade,
                                           INSTRUTOR.BAIRRO Bairro,
                                           INSTRUTOR.RUA Rua,
                                           INSTRUTOR.NUMERO Numero,
                                           INSTRUTOR.SALARIO Salario,
                                           INSTRUTOR.COMISSAO Comissao,
                                           INSTRUTOR.ATIVO Ativo
                                      FROM INSTRUTORES INSTRUTOR
                                RIGHT JOIN USUARIOS USUARIO
                                        ON INSTRUTOR.USUARIOID = USUARIO.ID
                                     WHERE USUARIO.ID = @USUARIOID";
            command.Parameters.AddWithValue("@USUARIOID", id);

            SingleResponse<Instrutor> response = new SingleResponse<Instrutor>();
            response.Success = false;
            response.Message = "Dados não encontrados !";

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    response.Item = new Instrutor();

                    response.Item.IDInstrutor = Convert.ToInt32(reader["IDInstrutor"]);
                    response.Item.IDUsuario = Convert.ToInt32(reader["UsuarioID"]);
                    response.Item.Usuario = new Usuario();
                    response.Item.Usuario.Nome = Convert.ToString(reader["Nome"]);
                    response.Item.Usuario.Email = Convert.ToString(reader["Email"]);
                    response.Item.Usuario.Funcao = (Papel)reader["Funcao"];
                    response.Item.TelefoneCelular = Convert.ToString(reader["TelefoneCelular"]);
                    response.Item.CPF = Convert.ToString(reader["CPF"]);
                    response.Item.DataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                    response.Item.RG = Convert.ToString(reader["RG"]);
                    response.Item.Estado = Convert.ToString(reader["Estado"]);
                    response.Item.Cidade = Convert.ToString(reader["Cidade"]);
                    response.Item.Bairro = Convert.ToString(reader["Bairro"]);
                    response.Item.Rua = Convert.ToString(reader["Rua"]);
                    response.Item.Numero = Convert.ToInt32(reader["Numero"]);
                    response.Item.Salario = Convert.ToDouble(reader["Salario"]);
                    response.Item.Comissao = Convert.ToDouble(reader["Comissao"]);
                    response.Item.Ativo = Convert.ToBoolean(reader["Ativo"]);

                    response.Success = true;
                    response.Message = "Dados selecionados com sucesso !";

                }



                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Deu ruim no get person !" + ex.Message;
                return response;
            }
        }

        public DataResponse<Instrutor> GetAllAtivos()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT U.NOME,
                                           U.EMAIL,
                                           U.FUNCAO,
                                           I.FONE,
                                           I.CPF, 
                                           I.DATA_NASCIMENTO, 
                                           I.RG, 
                                           I.ESTADO,
                                           I.CIDADE,
                                           I.BAIRRO,
                                           I.RUA,
                                           I.NUMERO,
                                           I.SALARIO,
                                           I.COMISSAO,
                                           I.ATIVO,
                                           I.ID,
                                           I.USUARIOID
                                      FROM INSTRUTORES I
                                INNER JOIN USUARIOS U 
                                        ON I.USUARIOID = U.ID
                                     WHERE I.ATIVO = 1";

            DataResponse<Instrutor> resposta = new DataResponse<Instrutor>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Instrutor> Instrutores = new List<Instrutor>();
                while (reader.Read())
                {
                    //Cada Loop deste while, faz com que o objeto "reader" aponte para um registro retornado pelo select
                    Instrutor instrutor = new Instrutor();
                    instrutor.Usuario.Nome = Convert.ToString(reader["NOME"]);
                    instrutor.Usuario.Email = Convert.ToString(reader["EMAIL"]);
                    instrutor.Usuario.IDUsuario = Convert.ToInt32(reader["USUARIOID"]);
                    instrutor.Usuario.Funcao = (Papel)(reader["FUNCAO"]);
                    instrutor.TelefoneCelular = Convert.ToString(reader["FONE"]);
                    instrutor.CPF = Convert.ToString(reader["CPF"]);
                    instrutor.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    instrutor.RG = Convert.ToString(reader["RG"]);
                    instrutor.Estado = Convert.ToString(reader["ESTADO"]);
                    instrutor.Cidade = Convert.ToString(reader["CIDADE"]);
                    instrutor.Bairro = Convert.ToString(reader["BAIRRO"]);
                    instrutor.Rua = Convert.ToString(reader["RUA"]);
                    instrutor.Numero = Convert.ToInt32(reader["NUMERO"]);
                    instrutor.Salario = Convert.ToDouble(reader["SALARIO"]);
                    instrutor.Comissao = Convert.ToDouble(reader["COMISSAO"]);
                    instrutor.Ativo = Convert.ToBoolean(reader["ATIVO"]);
                    instrutor.IDUsuario = Convert.ToInt32(reader["USUARIOID"]);
                    instrutor.IDInstrutor = Convert.ToInt32(reader["ID"]);
                    Instrutores.Add(instrutor);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = Instrutores;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<Instrutor>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Instrutor> GetAllInativos()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT U.NOME,
                                           U.EMAIL,
                                           U.FUNCAO,
                                           I.FONE,
                                           I.CPF, 
                                           I.DATA_NASCIMENTO, 
                                           I.RG, 
                                           I.ESTADO,
                                           I.CIDADE,
                                           I.BAIRRO,
                                           I.RUA,
                                           I.NUMERO,
                                           I.SALARIO,
                                           I.COMISSAO,
                                           I.ATIVO,
                                           I.ID,
                                           I.USUARIOID
                                      FROM INSTRUTORES I
                                INNER JOIN USUARIOS U 
                                        ON I.USUARIOID = U.ID
                                     WHERE I.ATIVO = 0";

            DataResponse<Instrutor> resposta = new DataResponse<Instrutor>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Instrutor> Instrutores = new List<Instrutor>();
                while (reader.Read())
                {
                    //Cada Loop deste while, faz com que o objeto "reader" aponte para um registro retornado pelo select
                    Instrutor instrutor = new Instrutor();
                    instrutor.Usuario.Nome = Convert.ToString(reader["NOME"]);
                    instrutor.Usuario.Email = Convert.ToString(reader["EMAIL"]);
                    instrutor.Usuario.IDUsuario = Convert.ToInt32(reader["USUARIOID"]);
                    instrutor.Usuario.Funcao = (Papel)(reader["FUNCAO"]);
                    instrutor.TelefoneCelular = Convert.ToString(reader["FONE"]);
                    instrutor.CPF = Convert.ToString(reader["CPF"]);
                    instrutor.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    instrutor.RG = Convert.ToString(reader["RG"]);
                    instrutor.Estado = Convert.ToString(reader["ESTADO"]);
                    instrutor.Cidade = Convert.ToString(reader["CIDADE"]);
                    instrutor.Bairro = Convert.ToString(reader["BAIRRO"]);
                    instrutor.Rua = Convert.ToString(reader["RUA"]);
                    instrutor.Numero = Convert.ToInt32(reader["NUMERO"]);
                    instrutor.Salario = Convert.ToDouble(reader["SALARIO"]);
                    instrutor.Comissao = Convert.ToDouble(reader["COMISSAO"]);
                    instrutor.Ativo = Convert.ToBoolean(reader["ATIVO"]);
                    instrutor.IDUsuario = Convert.ToInt32(reader["USUARIOID"]);
                    instrutor.IDInstrutor = Convert.ToInt32(reader["ID"]);
                    Instrutores.Add(instrutor);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = Instrutores;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<Instrutor>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Instrutor> SearchAtivos(string palavra)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT INSTRUTOR.ID IDInstrutor,
                                           INSTRUTOR.USUARIOID UsuarioID,
                                           USUARIO.NOME Nome,
                                           USUARIO.EMAIL Email,
                                           USUARIO.FUNCAO Funcao,
                                           INSTRUTOR.FONE TelefoneCelular,
                                           INSTRUTOR.CPF CPF,
                                           INSTRUTOR.DATA_NASCIMENTO DataNascimento,
                                           INSTRUTOR.RG RG,
                                           INSTRUTOR.ESTADO Estado,
                                           INSTRUTOR.CIDADE Cidade,
                                           INSTRUTOR.BAIRRO Bairro,
                                           INSTRUTOR.RUA Rua,
                                           INSTRUTOR.NUMERO Numero,
                                           INSTRUTOR.SALARIO Salario,
                                           INSTRUTOR.COMISSAO Comissao,
                                           INSTRUTOR.ATIVO Ativo
                                      FROM INSTRUTORES INSTRUTOR
                                      JOIN USUARIOS USUARIO
                                        ON INSTRUTOR.USUARIOID = USUARIO.ID
                                     WHERE UPPER(USUARIO.NOME) LIKE UPPER('%" + palavra + "%') AND ATIVO = 1";

            DataResponse<Instrutor> response = new DataResponse<Instrutor>();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                List<Instrutor> listInstrutores = new List<Instrutor>();
                while (reader.Read())
                {
                    Instrutor instrutor = new Instrutor();

                    instrutor.IDInstrutor = Convert.ToInt32(reader["IDInstrutor"]);
                    instrutor.IDUsuario = Convert.ToInt32(reader["UsuarioID"]);
                    instrutor.Usuario.Nome = Convert.ToString(reader["Nome"]);
                    instrutor.Usuario.Email = Convert.ToString(reader["Email"]);
                    instrutor.Usuario.Funcao = (Papel)(reader["Funcao"]);
                    instrutor.TelefoneCelular = Convert.ToString(reader["TelefoneCelular"]);
                    instrutor.CPF = Convert.ToString(reader["CPF"]);
                    instrutor.DataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                    instrutor.RG = Convert.ToString(reader["RG"]);
                    instrutor.Estado = Convert.ToString(reader["Estado"]);
                    instrutor.Cidade = Convert.ToString(reader["Cidade"]);
                    instrutor.Bairro = Convert.ToString(reader["Bairro"]);
                    instrutor.Rua = Convert.ToString(reader["Rua"]);
                    instrutor.Numero = Convert.ToInt32(reader["Numero"]);
                    instrutor.Salario = Convert.ToDouble(reader["Salario"]);
                    instrutor.Comissao = Convert.ToDouble(reader["Comissao"]);
                    instrutor.Ativo = Convert.ToBoolean(reader["Ativo"]);

                    listInstrutores.Add(instrutor);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso";
                response.Data = listInstrutores;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados contate o administrador !";
                response.Data = new List<Instrutor>();
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Instrutor> SearchInativos(string palavra)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT INSTRUTOR.ID IDInstrutor,
                                           INSTRUTOR.USUARIOID UsuarioID,
                                           USUARIO.NOME Nome,
                                           USUARIO.EMAIL Email,
                                           USUARIO.FUNCAO Funcao,
                                           INSTRUTOR.FONE TelefoneCelular,
                                           INSTRUTOR.CPF CPF,
                                           INSTRUTOR.DATA_NASCIMENTO DataNascimento,
                                           INSTRUTOR.RG RG,
                                           INSTRUTOR.ESTADO Estado,
                                           INSTRUTOR.CIDADE Cidade,
                                           INSTRUTOR.BAIRRO Bairro,
                                           INSTRUTOR.RUA Rua,
                                           INSTRUTOR.NUMERO Numero,
                                           INSTRUTOR.SALARIO Salario,
                                           INSTRUTOR.COMISSAO Comissao,
                                           INSTRUTOR.ATIVO Ativo
                                      FROM INSTRUTORES INSTRUTOR
                                      JOIN USUARIOS USUARIO
                                        ON INSTRUTOR.USUARIOID = USUARIO.ID
                                     WHERE UPPER(USUARIO.NOME) LIKE UPPER('%" + palavra + "%') AND ATIVO = 0";

            DataResponse<Instrutor> response = new DataResponse<Instrutor>();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                List<Instrutor> listInstrutores = new List<Instrutor>();
                while (reader.Read())
                {
                    Instrutor instrutor = new Instrutor();

                    instrutor.IDInstrutor = Convert.ToInt32(reader["IDInstrutor"]);
                    instrutor.IDUsuario = Convert.ToInt32(reader["UsuarioID"]);
                    instrutor.Usuario.Nome = Convert.ToString(reader["Nome"]);
                    instrutor.Usuario.Email = Convert.ToString(reader["Email"]);
                    instrutor.Usuario.Funcao = (Papel)(reader["Funcao"]);
                    instrutor.TelefoneCelular = Convert.ToString(reader["TelefoneCelular"]);
                    instrutor.CPF = Convert.ToString(reader["CPF"]);
                    instrutor.DataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                    instrutor.RG = Convert.ToString(reader["RG"]);
                    instrutor.Estado = Convert.ToString(reader["Estado"]);
                    instrutor.Cidade = Convert.ToString(reader["Cidade"]);
                    instrutor.Bairro = Convert.ToString(reader["Bairro"]);
                    instrutor.Rua = Convert.ToString(reader["Rua"]);
                    instrutor.Numero = Convert.ToInt32(reader["Numero"]);
                    instrutor.Salario = Convert.ToDouble(reader["Salario"]);
                    instrutor.Comissao = Convert.ToDouble(reader["Comissao"]);
                    instrutor.Ativo = Convert.ToBoolean(reader["Ativo"]);

                    listInstrutores.Add(instrutor);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso";
                response.Data = listInstrutores;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados contate o administrador !";
                response.Data = new List<Instrutor>();
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
