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
    public class ClienteDAL : IClienteService
    {
        public Response Insert(Cliente c)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"INSERT INTO CLIENTES (NOME, CPF, RG, DATA_NASCIMENTO, EMAIL, FONE_CELULAR, FONE_FIXO, DATA_MATRICULA, ATIVO)
                                    VALUES (@NOME, @CPF, @RG, @DATA_NASCIMENTO, @EMAIL, @FONE_CELULAR, @FONE_FIXO, @DATA_MATRICULA, @ATIVO)";
            command.Parameters.AddWithValue("@NOME", c.Nome);
            command.Parameters.AddWithValue("@CPF", c.CPF);
            command.Parameters.AddWithValue("@RG", c.RG);
            command.Parameters.AddWithValue("@DATA_NASCIMENTO", c.DataNascimento);
            command.Parameters.AddWithValue("@EMAIL", c.Email);
            command.Parameters.AddWithValue("@FONE_CELULAR", c.FoneCelular);
            command.Parameters.AddWithValue("@FONE_FIXO", c.FoneFixo);
            command.Parameters.AddWithValue("@DATA_MATRICULA", c.DataMatricula);
            command.Parameters.AddWithValue("@ATIVO", c.Ativo);
            

            Response response = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Cliente cadastrado com sucesso";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("UC_CLIENTES"))
                {
                    response.Message = "Cliente já cadastrado!";
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
        public DataResponse<Cliente> GetAll()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM CLIENTES ORDER BY ID";

            DataResponse<Cliente> response = new DataResponse<Cliente>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> listcli = new List<Cliente>();
                while (reader.Read())
                {
                    Cliente cli = new Cliente();
                    cli.IDCliente = Convert.ToInt32(reader["ID"]);
                    cli.Nome = Convert.ToString(reader["NOME"]);
                    cli.CPF = Convert.ToString(reader["CPF"]);
                    cli.RG = Convert.ToString(reader["RG"]);
                    cli.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    cli.Email = Convert.ToString(reader["EMAIL"]);
                    cli.FoneCelular = Convert.ToString(reader["FONE_CELULAR"]);
                    cli.FoneFixo = Convert.ToString(reader["FONE_FIXO"]);
                    cli.DataMatricula = Convert.ToDateTime(reader["DATA_MATRICULA"]);
                    cli.Ativo = Convert.ToBoolean(reader["ATIVO"]);
                    listcli.Add(cli);
                }

                response.Success = true;
                response.Message = "Dados selecionados com sucesso";
                response.Data = listcli;
                return response;
            }
            catch (Exception)
            {
                response.Success = false; response.Message = "Erro no banco de dados contate o admistrador";
                response.Data = new List<Cliente>();
                return response;
            }
        }
        public Response Update(Cliente c)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"UPDATE CLIENTES SET NOME = @NOME,
                                                        EMAIL = @EMAIL,
                                                        FONE_CELULAR = @FONE_CELULAR,
                                                        FONE_FIXO = @FONE_FIXO,
                                                        ATIVO = @ATIVO
                                                        WHERE ID = @ID";
            command.Parameters.AddWithValue("@NOME", c.Nome);
            command.Parameters.AddWithValue("@EMAIL", c.Email);
            command.Parameters.AddWithValue("@FONE_CELULAR", c.FoneCelular);
            command.Parameters.AddWithValue("@FONE_FIXO", c.FoneFixo);
            command.Parameters.AddWithValue("@ATIVO", c.Ativo);
            command.Parameters.AddWithValue("@ID", c.IDCliente);

            Response response = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Cliente editado com sucesso";
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
                response.Message = "Erro no banco de dados, contate o administrador";
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }
        public DataResponse<Cliente> Search(string palavra)
        {
            Cliente c = new Cliente();

            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT * FROM CLIENTES WHERE UPPER(NOME) LIKE UPPER('%"+ palavra +"%')";

            DataResponse<Cliente> response = new DataResponse<Cliente>();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> listcli = new List<Cliente>();
                while (reader.Read())
                {
                    Cliente cli = new Cliente();
                    cli.IDCliente = Convert.ToInt32(reader["ID"]);
                    cli.Nome = Convert.ToString(reader["NOME"]);
                    cli.CPF = Convert.ToString(reader["CPF"]);
                    cli.RG = Convert.ToString(reader["RG"]);
                    cli.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    cli.Email = Convert.ToString(reader["EMAIL"]);
                    cli.FoneCelular = Convert.ToString(reader["FONE_CELULAR"]);
                    cli.FoneFixo = Convert.ToString(reader["FONE_FIXO"]);
                    cli.DataMatricula = Convert.ToDateTime(reader["DATA_MATRICULA"]);
                    cli.Ativo = Convert.ToBoolean(reader["ATIVO"]);
                    listcli.Add(cli);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso";
                response.Data = listcli;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Deu erro!" + ex.Message;
                response.Data = new List<Cliente>();
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }
        public DataResponse<Cliente> SearchInatives(string palavra)
        {
            Cliente c = new Cliente();

            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT * FROM CLIENTES WHERE UPPER(NOME) LIKE UPPER('%" + palavra + "%') AND ATIVO = 0";

            DataResponse<Cliente> response = new DataResponse<Cliente>();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> listcli = new List<Cliente>();
                while (reader.Read())
                {
                    Cliente cli = new Cliente();
                    cli.IDCliente = Convert.ToInt32(reader["ID"]);
                    cli.Nome = Convert.ToString(reader["NOME"]);
                    cli.CPF = Convert.ToString(reader["CPF"]);
                    cli.RG = Convert.ToString(reader["RG"]);
                    cli.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    cli.Email = Convert.ToString(reader["EMAIL"]);
                    cli.FoneCelular = Convert.ToString(reader["FONE_CELULAR"]);
                    cli.FoneFixo = Convert.ToString(reader["FONE_FIXO"]);
                    cli.DataMatricula = Convert.ToDateTime(reader["DATA_MATRICULA"]);
                    cli.Ativo = Convert.ToBoolean(reader["ATIVO"]);
                    listcli.Add(cli);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso";
                response.Data = listcli;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Deu erro!" + ex.Message;
                response.Data = new List<Cliente>();
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }
        public DataResponse<Cliente> SearchAtives(string palavra)
        {
            Cliente c = new Cliente();

            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT * FROM CLIENTES WHERE UPPER(NOME) LIKE UPPER('%" + palavra + "%') AND ATIVO = 1";

            DataResponse<Cliente> response = new DataResponse<Cliente>();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> listcli = new List<Cliente>();
                while (reader.Read())
                {
                    Cliente cli = new Cliente();
                    cli.IDCliente = Convert.ToInt32(reader["ID"]);
                    cli.Nome = Convert.ToString(reader["NOME"]);
                    cli.CPF = Convert.ToString(reader["CPF"]);
                    cli.RG = Convert.ToString(reader["RG"]);
                    cli.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    cli.Email = Convert.ToString(reader["EMAIL"]);
                    cli.FoneCelular = Convert.ToString(reader["FONE_CELULAR"]);
                    cli.FoneFixo = Convert.ToString(reader["FONE_FIXO"]);
                    cli.DataMatricula = Convert.ToDateTime(reader["DATA_MATRICULA"]);
                    cli.Ativo = Convert.ToBoolean(reader["ATIVO"]);
                    listcli.Add(cli);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso";
                response.Data = listcli;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Deu erro!" + ex.Message;
                response.Data = new List<Cliente>();
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
