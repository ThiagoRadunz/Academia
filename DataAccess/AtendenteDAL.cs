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
using System.Transactions;


namespace DataAccess
{
    public class AtendenteDAL : IAtendenteService
    {
        public Response Insert(Atendente a)
        {
            

            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;


            SqlCommand ucommand = new SqlCommand();
            ucommand.Connection = connection;
            ucommand.CommandText = @"INSERT INTO USUARIOS (NOME, EMAIL, SENHA, FUNCAO)
                                    VALUES (@NOME, @EMAIL, @SENHA, @FUNCAO) SELECT SCOPE_IDENTITY()";
            ucommand.Parameters.AddWithValue("@NOME", a.Usuario.Nome);
            ucommand.Parameters.AddWithValue("@EMAIL", a.Usuario.Email);
            ucommand.Parameters.AddWithValue("@SENHA", a.Usuario.Senha);
            ucommand.Parameters.AddWithValue("@FUNCAO", a.Usuario.Funcao);

            Response response = new Response();
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    connection.Open();



                    int idUsuarioGerada = Convert.ToInt32(ucommand.ExecuteScalar());

                    SqlCommand acommand = new SqlCommand();
                    acommand.Connection = connection;
                    acommand.CommandText = @"INSERT INTO ATENDENTES (USUARIOID, FONE, CPF, DATA_NASCIMENTO, RG, ESTADO, CIDADE, BAIRRO, RUA, NUMERO, SALARIO, COMISSAO, ATIVO)
                                    VALUES (@USUARIOID, @FONE, @CPF, @DATA_NASCIMENTO, @RG, @ESTADO, @CIDADE, @BAIRRO, @RUA, @NUMERO, @SALARIO, @COMISSAO, @ATIVO) 
                                    ";
                    acommand.Parameters.AddWithValue("@USUARIOID", idUsuarioGerada);
                    acommand.Parameters.AddWithValue("@FONE", a.TelefoneCelular);
                    acommand.Parameters.AddWithValue("@CPF", a.CPF);
                    acommand.Parameters.AddWithValue("@DATA_NASCIMENTO", a.DataNascimento);
                    acommand.Parameters.AddWithValue("@RG", a.RG);
                    acommand.Parameters.AddWithValue("@ESTADO", a.Estado);
                    acommand.Parameters.AddWithValue("@CIDADE", a.Cidade);
                    acommand.Parameters.AddWithValue("@BAIRRO", a.Bairro);
                    acommand.Parameters.AddWithValue("@RUA", a.Rua);
                    acommand.Parameters.AddWithValue("@NUMERO", a.Numero);
                    acommand.Parameters.AddWithValue("@SALARIO", a.Salario);
                    acommand.Parameters.AddWithValue("@COMISSAO", a.Comissao);
                    acommand.Parameters.AddWithValue("@ATIVO", a.Ativo);
                    acommand.ExecuteNonQuery();

                    scope.Complete();
                    response.Success = true; 
                    response.Message = "Atendente cadastrado com sucesso";
                    return response;
                }
                catch (Exception ex)
                {
                    response.Success = false;
                    if (ex.Message.Contains("UC_ATENDENTES"))
                    {
                        response.Message = "CPF ou RG já cadastrado!";
                        return response;
                    }

                    response.Message = "Erro no banco de dados contate o administrador ! ";
                    return response;
                }
                finally
                {
                    connection.Dispose();
                }
            }
        }
        public DataResponse<Atendente> GetAll()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT ATENDENTE.ID IDAtendente,
                                           ATENDENTE.USUARIOID UsuarioID,
                                           USUARIO.NOME Nome,
                                           USUARIO.EMAIL Email,
                                           USUARIO.FUNCAO Funcao,
                                           ATENDENTE.FONE TelefoneCelular,
                                           ATENDENTE.CPF CPF,
                                           ATENDENTE.DATA_NASCIMENTO DataNascimento,
                                           ATENDENTE.RG RG,
                                           ATENDENTE.ESTADO Estado,
                                           ATENDENTE.CIDADE Cidade,
                                           ATENDENTE.BAIRRO Bairro,
                                           ATENDENTE.RUA Rua,
                                           ATENDENTE.NUMERO Numero,
                                           ATENDENTE.SALARIO Salario,
                                           ATENDENTE.COMISSAO Comissao,
                                           ATENDENTE.ATIVO Ativo
                                      FROM ATENDENTES ATENDENTE
                                      JOIN USUARIOS USUARIO
                                        ON ATENDENTE.USUARIOID = USUARIO.ID";

            DataResponse<Atendente> response = new DataResponse<Atendente>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Atendente> listAtendentes = new List<Atendente>();
                while (reader.Read())
                {
                    Atendente a = new Atendente();

                    a.IDAtendente = Convert.ToInt32(reader["IDAtendente"]);
                    a.IDUsuario = Convert.ToInt32(reader["UsuarioID"]);
                    a.Usuario = new Usuario();
                    a.Usuario.Nome = Convert.ToString(reader["Nome"]);
                    a.Usuario.Email = Convert.ToString(reader["Email"]);
                    a.Usuario.Funcao = (Papel)reader["Funcao"];
                    a.TelefoneCelular = Convert.ToString(reader["TelefoneCelular"]);
                    a.CPF = Convert.ToString(reader["CPF"]);
                    a.DataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                    a.RG = Convert.ToString(reader["RG"]);
                    a.Estado = Convert.ToString(reader["Estado"]);
                    a.Cidade = Convert.ToString(reader["Cidade"]);
                    a.Bairro = Convert.ToString(reader["Bairro"]);
                    a.Rua = Convert.ToString(reader["Rua"]);
                    a.Numero = Convert.ToInt32(reader["Numero"]);
                    a.Salario = Convert.ToDouble(reader["Salario"]);
                    a.Comissao = Convert.ToDouble(reader["Comissao"]);
                    a.Ativo = Convert.ToBoolean(reader["Ativo"]);
                    listAtendentes.Add(a);
                }

                response.Success = true;
                response.Message = "Dados selecionados com sucesso";
                response.Data = listAtendentes;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados contate o administrador ! ";
                response.Data = new List<Atendente>();
                return response;
            }
        }
        public Response Update(Atendente a)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"UPDATE USUARIOS SET NOME = @NOME,
                                                            EMAIL = @EMAIL
                                                        WHERE ID = @ID";
            command.Parameters.AddWithValue("@NOME", a.Usuario.Nome);
            command.Parameters.AddWithValue("@EMAIL", a.Usuario.Email);
            command.Parameters.AddWithValue("@ID", a.Usuario.IDUsuario);

            Response response = new Response();

            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    command = new SqlCommand();
                    command.Connection = connection;
                    
                    command.CommandText = @"UPDATE ATENDENTES SET FONE = @FONE,
                                                           ESTADO = @ESTADO,
                                                           CIDADE = @CIDADE,
                                                           BAIRRO = @BAIRRO,
                                                           RUA = @RUA,
                                                           NUMERO = @NUMERO,
                                                           SALARIO = @SALARIO,
                                                           COMISSAO = @COMISSAO,
                                                           ATIVO = @ATIVO
                                                        WHERE ID = @IDAtendente";
                    command.Parameters.AddWithValue("@FONE", a.TelefoneCelular);
                    command.Parameters.AddWithValue("@ESTADO", a.Estado);
                    command.Parameters.AddWithValue("@CIDADE", a.Cidade);
                    command.Parameters.AddWithValue("@BAIRRO", a.Bairro);
                    command.Parameters.AddWithValue("@RUA", a.Rua);
                    command.Parameters.AddWithValue("@NUMERO", a.Numero);
                    command.Parameters.AddWithValue("@SALARIO", a.Salario);
                    command.Parameters.AddWithValue("@COMISSAO", a.Comissao);
                    command.Parameters.AddWithValue("@IDAtendente", a.IDAtendente);
                    command.Parameters.AddWithValue("@ATIVO", a.Ativo);

                    command.ExecuteNonQuery();

                    scope.Complete();
                    response.Success = true; response.Message = "Instrutor editado com sucesso";
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
                    response.Message = "Erro no banco de dados contate o administrador ! ";
                    return response;
                }
                finally
                {
                    connection.Dispose();
                }
            }
        }

        public DataResponse<Atendente> Search(string palavra)
        {
            Atendente a = new Atendente();

            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT ATENDENTE.ID IDAtendente,
                                           ATENDENTE.USUARIOID UsuarioID,
                                           USUARIO.NOME Nome,
                                           USUARIO.EMAIL Email,
                                           USUARIO.FUNCAO Funcao,
                                           ATENDENTE.FONE TelefoneCelular,
                                           ATENDENTE.CPF CPF,
                                           ATENDENTE.DATA_NASCIMENTO DataNascimento,
                                           ATENDENTE.RG RG,
                                           ATENDENTE.ESTADO Estado,
                                           ATENDENTE.CIDADE Cidade,
                                           ATENDENTE.BAIRRO Bairro,
                                           ATENDENTE.RUA Rua,
                                           ATENDENTE.NUMERO Numero,
                                           ATENDENTE.SALARIO Salario,
                                           ATENDENTE.COMISSAO Comissao,
                                           ATENDENTE.ATIVO Ativo
                                      FROM ATENDENTES ATENDENTE
                                      JOIN USUARIOS USUARIO
                                        ON ATENDENTE.USUARIOID = USUARIO.ID
                                     WHERE UPPER(USUARIO.NOME) LIKE UPPER('%" + palavra + "%')";

            DataResponse<Atendente> response = new DataResponse<Atendente>();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                List<Atendente> listAtendente = new List<Atendente>();
                while (reader.Read())
                {
                    Atendente atendente = new Atendente();

                    atendente.IDAtendente = Convert.ToInt32(reader["IDAtendente"]);
                    atendente.IDUsuario = Convert.ToInt32(reader["UsuarioID"]);
                    atendente.Usuario.Nome = Convert.ToString(reader["Nome"]);
                    atendente.Usuario.Email = Convert.ToString(reader["Email"]);
                    atendente.Usuario.Funcao = (Papel)(reader["Funcao"]);
                    atendente.TelefoneCelular = Convert.ToString(reader["TelefoneCelular"]);
                    atendente.CPF = Convert.ToString(reader["CPF"]);
                    atendente.DataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                    atendente.RG = Convert.ToString(reader["RG"]);
                    atendente.Estado = Convert.ToString(reader["Estado"]);
                    atendente.Cidade = Convert.ToString(reader["Cidade"]);
                    atendente.Bairro = Convert.ToString(reader["Bairro"]);
                    atendente.Rua = Convert.ToString(reader["Rua"]);
                    atendente.Numero = Convert.ToInt32(reader["Numero"]);
                    atendente.Salario = Convert.ToDouble(reader["Salario"]);
                    atendente.Comissao = Convert.ToDouble(reader["Comissao"]);
                    atendente.Ativo = Convert.ToBoolean(reader["Ativo"]);

                    listAtendente.Add(atendente);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso";
                response.Data = listAtendente;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados contate o administrador ! ";
                response.Data = new List<Atendente>();
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public SingleResponse<Atendente> GetPerson(int id)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT ATENDENTE.ID IDAtendente,
                                           ATENDENTE.USUARIOID UsuarioID,
                                           USUARIO.NOME Nome,
                                           USUARIO.EMAIL Email,
                                           USUARIO.FUNCAO Funcao,
                                           ATENDENTE.FONE TelefoneCelular,
                                           ATENDENTE.CPF CPF,
                                           ATENDENTE.DATA_NASCIMENTO DataNascimento,
                                           ATENDENTE.RG RG,
                                           ATENDENTE.ESTADO Estado,
                                           ATENDENTE.CIDADE Cidade,
                                           ATENDENTE.BAIRRO Bairro,
                                           ATENDENTE.RUA Rua,
                                           ATENDENTE.NUMERO Numero,
                                           ATENDENTE.SALARIO Salario,
                                           ATENDENTE.COMISSAO Comissao,
                                           ATENDENTE.ATIVO Ativo
                                      FROM ATENDENTES ATENDENTE
                                RIGHT JOIN USUARIOS USUARIO
                                        ON ATENDENTE.USUARIOID = USUARIO.ID
                                     WHERE USUARIO.ID = @USUARIOID";
            command.Parameters.AddWithValue("@USUARIOID", id);

            SingleResponse<Atendente> response = new SingleResponse<Atendente>();
            response.Success = false;
            response.Message = "Dados não encontrados !";

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    response.Item = new Atendente();

                    response.Item.IDAtendente = Convert.ToInt32(reader["IDAtendente"]);
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
            catch (Exception)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados contate o administrador ! ";
                return response;
            }
        }

        public DataResponse<Atendente> SearchAtivos(string palavra)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT ATENDENTE.ID IDAtendente,
                                           ATENDENTE.USUARIOID UsuarioID,
                                           USUARIO.NOME Nome,
                                           USUARIO.EMAIL Email,
                                           USUARIO.FUNCAO Funcao,
                                           ATENDENTE.FONE TelefoneCelular,
                                           ATENDENTE.CPF CPF,
                                           ATENDENTE.DATA_NASCIMENTO DataNascimento,
                                           ATENDENTE.RG RG,
                                           ATENDENTE.ESTADO Estado,
                                           ATENDENTE.CIDADE Cidade,
                                           ATENDENTE.BAIRRO Bairro,
                                           ATENDENTE.RUA Rua,
                                           ATENDENTE.NUMERO Numero,
                                           ATENDENTE.SALARIO Salario,
                                           ATENDENTE.COMISSAO Comissao,
                                           ATENDENTE.ATIVO Ativo
                                      FROM ATENDENTES ATENDENTE
                                      JOIN USUARIOS USUARIO
                                        ON ATENDENTE.USUARIOID = USUARIO.ID
                                     WHERE UPPER(USUARIO.NOME) LIKE UPPER('%" + palavra + "%') AND ATIVO = 1";

            DataResponse<Atendente> response = new DataResponse<Atendente>();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                List<Atendente> listAtendente = new List<Atendente>();
                while (reader.Read())
                {
                    Atendente atendente = new Atendente();

                    atendente.IDAtendente = Convert.ToInt32(reader["IDAtendente"]);
                    atendente.IDUsuario = Convert.ToInt32(reader["UsuarioID"]);
                    atendente.Usuario.Nome = Convert.ToString(reader["Nome"]);
                    atendente.Usuario.Email = Convert.ToString(reader["Email"]);
                    atendente.Usuario.Funcao = (Papel)(reader["Funcao"]);
                    atendente.TelefoneCelular = Convert.ToString(reader["TelefoneCelular"]);
                    atendente.CPF = Convert.ToString(reader["CPF"]);
                    atendente.DataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                    atendente.RG = Convert.ToString(reader["RG"]);
                    atendente.Estado = Convert.ToString(reader["Estado"]);
                    atendente.Cidade = Convert.ToString(reader["Cidade"]);
                    atendente.Bairro = Convert.ToString(reader["Bairro"]);
                    atendente.Rua = Convert.ToString(reader["Rua"]);
                    atendente.Numero = Convert.ToInt32(reader["Numero"]);
                    atendente.Salario = Convert.ToDouble(reader["Salario"]);
                    atendente.Comissao = Convert.ToDouble(reader["Comissao"]);
                    atendente.Ativo = Convert.ToBoolean(reader["Ativo"]);

                    listAtendente.Add(atendente);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso";
                response.Data = listAtendente;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados contate o administrador ! ";
                response.Data = new List<Atendente>();
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Atendente> SearchInativos(string palavra)
        {
            Atendente a = new Atendente();

            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT ATENDENTE.ID IDAtendente,
                                           ATENDENTE.USUARIOID UsuarioID,
                                           USUARIO.NOME Nome,
                                           USUARIO.EMAIL Email,
                                           USUARIO.FUNCAO Funcao,
                                           ATENDENTE.FONE TelefoneCelular,
                                           ATENDENTE.CPF CPF,
                                           ATENDENTE.DATA_NASCIMENTO DataNascimento,
                                           ATENDENTE.RG RG,
                                           ATENDENTE.ESTADO Estado,
                                           ATENDENTE.CIDADE Cidade,
                                           ATENDENTE.BAIRRO Bairro,
                                           ATENDENTE.RUA Rua,
                                           ATENDENTE.NUMERO Numero,
                                           ATENDENTE.SALARIO Salario,
                                           ATENDENTE.COMISSAO Comissao,
                                           ATENDENTE.ATIVO Ativo
                                      FROM ATENDENTES ATENDENTE
                                      JOIN USUARIOS USUARIO
                                        ON ATENDENTE.USUARIOID = USUARIO.ID
                                     WHERE UPPER(USUARIO.NOME) LIKE UPPER('%" + palavra + "%') AND ATIVO = 0";

            DataResponse<Atendente> response = new DataResponse<Atendente>();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                List<Atendente> listAtendente = new List<Atendente>();
                while (reader.Read())
                {
                    Atendente atendente = new Atendente();

                    atendente.IDAtendente = Convert.ToInt32(reader["IDAtendente"]);
                    atendente.IDUsuario = Convert.ToInt32(reader["UsuarioID"]);
                    atendente.Usuario.Nome = Convert.ToString(reader["Nome"]);
                    atendente.Usuario.Email = Convert.ToString(reader["Email"]);
                    atendente.Usuario.Funcao = (Papel)(reader["Funcao"]);
                    atendente.TelefoneCelular = Convert.ToString(reader["TelefoneCelular"]);
                    atendente.CPF = Convert.ToString(reader["CPF"]);
                    atendente.DataNascimento = Convert.ToDateTime(reader["DataNascimento"]);
                    atendente.RG = Convert.ToString(reader["RG"]);
                    atendente.Estado = Convert.ToString(reader["Estado"]);
                    atendente.Cidade = Convert.ToString(reader["Cidade"]);
                    atendente.Bairro = Convert.ToString(reader["Bairro"]);
                    atendente.Rua = Convert.ToString(reader["Rua"]);
                    atendente.Numero = Convert.ToInt32(reader["Numero"]);
                    atendente.Salario = Convert.ToDouble(reader["Salario"]);
                    atendente.Comissao = Convert.ToDouble(reader["Comissao"]);
                    atendente.Ativo = Convert.ToBoolean(reader["Ativo"]);

                    listAtendente.Add(atendente);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso";
                response.Data = listAtendente;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados contate o administrador ! ";
                response.Data = new List<Atendente>();
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}