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
    public class PlanoInstrutorClienteDAL : IPlanoInstrutorClienteService
    {
        public Response Insert(PlanoInstrutorCliente pic)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"INSERT INTO PLANOS_INSTRUTOR_CLIENTE (INSTRUTORID, PLANOID, CLIENTEID, FORMA_PAGAMENTOID, DATA_ADESAO_CONTRATO, DATA_TERMINO_CONTRATO)
                                    VALUES (@INSTRUTORID, @PLANOID, @CLIENTEID, @FORMA_PAGAMENTOID, @DATA_ADESAO_CONTRATO, @DATA_TERMINO_CONTRATO)";
            command.Parameters.AddWithValue("@INSTRUTORID", pic.IDInstrutor);
            command.Parameters.AddWithValue("@PLANOID", pic.IDPlano);
            command.Parameters.AddWithValue("@CLIENTEID", pic.IDCliente);
            command.Parameters.AddWithValue("@FORMA_PAGAMENTOID", pic.IDFormapagamento);
            command.Parameters.AddWithValue("@DATA_ADESAO_CONTRATO", pic.AdesaoContrato);
            command.Parameters.AddWithValue("@DATA_TERMINO_CONTRATO", pic.TerminoContrato);

            Response response = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Contrato registrado com sucesso";
                return response;
            }
            catch (Exception ex)
            {
                //instrutor setado automaticamente, impossivel extorar essa chave
                //portanto nao inclui as outras FK referentes a Plano, Cliente, Forma Pagamento
                response.Success = false;
                if (ex.Message.Contains("FK_INSTRUTORES"))
                {
                    response.Message = "Instrutor não cadastrado!";
                    return response;
                }
                response.Message = "Erro no banco de dados, contate o administrador !";
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<PlanoInstrutorClienteQueryView> GetAll()
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"  SELECT PIC.ID IDPIC,
                                             PIC.INSTRUTORID IDInstrutor,
                                             USUARIO.NOME NomeInstrutor,
                                             PIC.PLANOID IDPlano,
                                             PIC.CLIENTEID IDCliente,
                                             CLIENTE.NOME NomeCliente,
                                             PIC.FORMA_PAGAMENTOID IDFormapagamento,
                                             FORMA_PAGAMENTO.DESCRICAO FormaPagamento,
                                             C.NOME Modalidade,
                                             PLANO.QTDD_AULA_SEMANA QtdAulaSemana,
                                             PLANO.QTDD_MES QtdMesesDuracao,
                                             PLANO.VALOR Valor,
                                             PIC.DATA_ADESAO_CONTRATO AdesaoContrato,
                                             PIC.DATA_TERMINO_CONTRATO TerminoContrato
                                        FROM PLANOS_INSTRUTOR_CLIENTE PIC
                                        JOIN PLANOS PLANO
                                          ON PLANO.ID = PIC.PLANOID
                                        JOIN CATEGORIAS C 
                                          ON C.ID = PLANO.CATEGORIAID
                                        JOIN INSTRUTORES INSTRUTOR
                                          ON INSTRUTOR.ID = PIC.INSTRUTORID
                                        JOIN USUARIOS USUARIO
                                          ON USUARIO.ID = INSTRUTOR.USUARIOID
                                        JOIN CLIENTES CLIENTE
                                          ON CLIENTE.ID = PIC.CLIENTEID
                                        JOIN FORMAS_PAGAMENTO FORMA_PAGAMENTO
                                          ON FORMA_PAGAMENTO.ID = PIC.FORMA_PAGAMENTOID";

            DataResponse<PlanoInstrutorClienteQueryView> resposta = new DataResponse<PlanoInstrutorClienteQueryView>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<PlanoInstrutorClienteQueryView> PICQueryViewList = new List<PlanoInstrutorClienteQueryView>();
                while (reader.Read())
                {
                    //Cada Loop deste while, faz com que o objeto "reader" aponte para um registro retornado pelo select
                    PlanoInstrutorClienteQueryView picQv = new PlanoInstrutorClienteQueryView();

                    picQv.IDPIC = Convert.ToString(reader["IDPIC"]);
                    picQv.IDInstrutor = Convert.ToString(reader["IDInstrutor"]);
                    picQv.NomeInstrutor = Convert.ToString(reader["NomeInstrutor"]);
                    picQv.IDPlano = Convert.ToString(reader["IDPlano"]);
                    picQv.IDCliente = Convert.ToString(reader["IDCliente"]);
                    picQv.NomeCliente = Convert.ToString(reader["NomeCliente"]);
                    picQv.NomeCategoria = Convert.ToString(reader["Modalidade"]);
                    picQv.QtdAulaSemana = Convert.ToString(reader["QtdAulaSemana"]);
                    picQv.QtdMesesDuracao = Convert.ToString(reader["QtdMesesDuracao"]);
                    picQv.Valor = Convert.ToString(reader["Valor"]);
                    picQv.AdesaoContrato = Convert.ToDateTime(reader["AdesaoContrato"]);
                    picQv.TerminoContrato = Convert.ToDateTime(reader["TerminoContrato"]);
                    picQv.IDFormapagamento = Convert.ToString(reader["IDFormapagamento"]);
                    picQv.NomeFormapagamento = Convert.ToString(reader["FormaPagamento"]);
                    PICQueryViewList.Add(picQv);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = PICQueryViewList;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador !";
                resposta.Data = new List<PlanoInstrutorClienteQueryView>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<PlanoInstrutorClienteQueryView> GetAllbyIDInstrutor(int id)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"  SELECT PIC.ID IDPIC,
                                             PIC.INSTRUTORID IDInstrutor,
                                             USUARIO.NOME NomeInstrutor,
                                             PIC.PLANOID IDPlano,
                                             PIC.CLIENTEID IDCliente,
                                             CLIENTE.NOME NomeCliente,
                                             PIC.FORMA_PAGAMENTOID IDFormapagamento,
                                             FORMA_PAGAMENTO.DESCRICAO FormaPagamento,
                                             C.NOME Modalidade,
                                             PLANO.QTDD_AULA_SEMANA QtdAulaSemana,
                                             PLANO.QTDD_MES QtdMesesDuracao,
                                             PLANO.VALOR Valor,
                                             PIC.DATA_ADESAO_CONTRATO AdesaoContrato,
                                             PIC.DATA_TERMINO_CONTRATO TerminoContrato
                                        FROM PLANOS_INSTRUTOR_CLIENTE PIC
                                        JOIN PLANOS PLANO
                                          ON PLANO.ID = PIC.PLANOID
                                        JOIN CATEGORIAS C 
                                          ON C.ID = PLANO.CATEGORIAID
                                        JOIN INSTRUTORES INSTRUTOR
                                          ON INSTRUTOR.ID = PIC.INSTRUTORID
                                        JOIN USUARIOS USUARIO
                                          ON USUARIO.ID = INSTRUTOR.USUARIOID
                                        JOIN CLIENTES CLIENTE
                                          ON CLIENTE.ID = PIC.CLIENTEID
                                        JOIN FORMAS_PAGAMENTO FORMA_PAGAMENTO
                                          ON FORMA_PAGAMENTO.ID = PIC.FORMA_PAGAMENTOID
                                       WHERE INSTRUTOR.ID = @ID";
            command.Parameters.AddWithValue("@ID", id);

            DataResponse<PlanoInstrutorClienteQueryView> resposta = new DataResponse<PlanoInstrutorClienteQueryView>();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                List<PlanoInstrutorClienteQueryView> PICQueryViewList = new List<PlanoInstrutorClienteQueryView>();
                while (reader.Read())
                {
                    PlanoInstrutorClienteQueryView picQv = new PlanoInstrutorClienteQueryView();

                    picQv.IDPIC = Convert.ToString(reader["IDPIC"]);
                    picQv.IDInstrutor = Convert.ToString(reader["IDInstrutor"]);
                    picQv.NomeInstrutor = Convert.ToString(reader["NomeInstrutor"]);
                    picQv.IDPlano = Convert.ToString(reader["IDPlano"]);
                    picQv.IDCliente = Convert.ToString(reader["IDCliente"]);
                    picQv.NomeCliente = Convert.ToString(reader["NomeCliente"]);
                    picQv.NomeCategoria = Convert.ToString(reader["Modalidade"]);
                    picQv.QtdAulaSemana = Convert.ToString(reader["QtdAulaSemana"]);
                    picQv.QtdMesesDuracao = Convert.ToString(reader["QtdMesesDuracao"]);
                    picQv.Valor = Convert.ToString(reader["Valor"]);
                    picQv.AdesaoContrato = Convert.ToDateTime(reader["AdesaoContrato"]);
                    picQv.TerminoContrato = Convert.ToDateTime(reader["TerminoContrato"]);
                    picQv.IDFormapagamento = Convert.ToString(reader["IDFormapagamento"]);
                    picQv.NomeFormapagamento = Convert.ToString(reader["FormaPagamento"]);
                    PICQueryViewList.Add(picQv);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = PICQueryViewList;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador !";
                resposta.Data = new List<PlanoInstrutorClienteQueryView>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }
        public DataResponse<PlanoInstrutorClienteQueryView> GetAllbyIDCliente(int id)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"  SELECT PIC.ID IDPIC,
                                             PIC.INSTRUTORID IDInstrutor,
                                             USUARIO.NOME NomeInstrutor,
                                             PIC.PLANOID IDPlano,
                                             PIC.CLIENTEID IDCliente,
                                             CLIENTE.NOME NomeCliente,
                                             PIC.FORMA_PAGAMENTOID IDFormapagamento,
                                             FORMA_PAGAMENTO.DESCRICAO FormaPagamento,
                                             C.NOME Modalidade,
                                             PLANO.QTDD_AULA_SEMANA QtdAulaSemana,
                                             PLANO.QTDD_MES QtdMesesDuracao,
                                             PLANO.VALOR Valor,
                                             PIC.DATA_ADESAO_CONTRATO AdesaoContrato,
                                             PIC.DATA_TERMINO_CONTRATO TerminoContrato
                                        FROM PLANOS_INSTRUTOR_CLIENTE PIC
                                        JOIN PLANOS PLANO
                                          ON PLANO.ID = PIC.PLANOID
                                        JOIN CATEGORIAS C 
                                          ON C.ID = PLANO.CATEGORIAID
                                        JOIN INSTRUTORES INSTRUTOR
                                          ON INSTRUTOR.ID = PIC.INSTRUTORID
                                        JOIN USUARIOS USUARIO
                                          ON USUARIO.ID = INSTRUTOR.USUARIOID
                                        JOIN CLIENTES CLIENTE
                                          ON CLIENTE.ID = PIC.CLIENTEID
                                        JOIN FORMAS_PAGAMENTO FORMA_PAGAMENTO
                                          ON FORMA_PAGAMENTO.ID = PIC.FORMA_PAGAMENTOID
                                       WHERE CLIENTE.ID = @ID";
            command.Parameters.AddWithValue("@ID", id);

            DataResponse<PlanoInstrutorClienteQueryView> resposta = new DataResponse<PlanoInstrutorClienteQueryView>();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                List<PlanoInstrutorClienteQueryView> PICQueryViewList = new List<PlanoInstrutorClienteQueryView>();
                while (reader.Read())
                {
                    //Cada Loop deste while, faz com que o objeto "reader" aponte para um registro retornado pelo select
                    PlanoInstrutorClienteQueryView picQv = new PlanoInstrutorClienteQueryView();

                    picQv.IDPIC = Convert.ToString(reader["IDPIC"]);
                    picQv.IDInstrutor = Convert.ToString(reader["IDInstrutor"]);
                    picQv.NomeInstrutor = Convert.ToString(reader["NomeInstrutor"]);
                    picQv.IDPlano = Convert.ToString(reader["IDPlano"]);
                    picQv.IDCliente = Convert.ToString(reader["IDCliente"]);
                    picQv.NomeCliente = Convert.ToString(reader["NomeCliente"]);
                    picQv.NomeCategoria = Convert.ToString(reader["Modalidade"]);
                    picQv.QtdAulaSemana = Convert.ToString(reader["QtdAulaSemana"]);
                    picQv.QtdMesesDuracao = Convert.ToString(reader["QtdMesesDuracao"]);
                    picQv.Valor = Convert.ToString(reader["Valor"]);
                    picQv.AdesaoContrato = Convert.ToDateTime(reader["AdesaoContrato"]);
                    picQv.TerminoContrato = Convert.ToDateTime(reader["TerminoContrato"]);
                    picQv.IDFormapagamento = Convert.ToString(reader["IDFormapagamento"]);
                    picQv.NomeFormapagamento = Convert.ToString(reader["FormaPagamento"]);
                    PICQueryViewList.Add(picQv);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = PICQueryViewList;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no GetAllbyIDCliente do PICQueryView do banco de dados, contate o administrador.";
                resposta.Data = new List<PlanoInstrutorClienteQueryView>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }

        }
        public DataResponse<PlanoInstrutorClienteQueryView> GetAllbyIDModalidade(int id)
        {
            string connectionString = SqlUtils.CONNECTION_STRING;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"  SELECT PIC.ID IDPIC,
                                             PIC.INSTRUTORID IDInstrutor,
                                             USUARIO.NOME NomeInstrutor,
                                             PIC.PLANOID IDPlano,
                                             PIC.CLIENTEID IDCliente,
                                             CLIENTE.NOME NomeCliente,
                                             PIC.FORMA_PAGAMENTOID IDFormapagamento,
                                             FORMA_PAGAMENTO.DESCRICAO FormaPagamento,
                                             C.NOME Modalidade,
                                             PLANO.QTDD_AULA_SEMANA QtdAulaSemana,
                                             PLANO.QTDD_MES QtdMesesDuracao,
                                             PLANO.VALOR Valor,
                                             PIC.DATA_ADESAO_CONTRATO AdesaoContrato,
                                             PIC.DATA_TERMINO_CONTRATO TerminoContrato
                                        FROM PLANOS_INSTRUTOR_CLIENTE PIC
                                        JOIN PLANOS PLANO
                                          ON PLANO.ID = PIC.PLANOID
                                        JOIN CATEGORIAS C 
                                          ON C.ID = PLANO.CATEGORIAID
                                        JOIN INSTRUTORES INSTRUTOR
                                          ON INSTRUTOR.ID = PIC.INSTRUTORID
                                        JOIN USUARIOS USUARIO
                                          ON USUARIO.ID = INSTRUTOR.USUARIOID
                                        JOIN CLIENTES CLIENTE
                                          ON CLIENTE.ID = PIC.CLIENTEID
                                        JOIN FORMAS_PAGAMENTO FORMA_PAGAMENTO
                                          ON FORMA_PAGAMENTO.ID = PIC.FORMA_PAGAMENTOID
                                       WHERE C.ID = @ID";
            command.Parameters.AddWithValue("@ID", id);

            DataResponse<PlanoInstrutorClienteQueryView> resposta = new DataResponse<PlanoInstrutorClienteQueryView>();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                List<PlanoInstrutorClienteQueryView> PICQueryViewList = new List<PlanoInstrutorClienteQueryView>();
                while (reader.Read())
                {
                    //Cada Loop deste while, faz com que o objeto "reader" aponte para um registro retornado pelo select
                    PlanoInstrutorClienteQueryView picQv = new PlanoInstrutorClienteQueryView();

                    picQv.IDPIC = Convert.ToString(reader["IDPIC"]);
                    picQv.IDInstrutor = Convert.ToString(reader["IDInstrutor"]);
                    picQv.NomeInstrutor = Convert.ToString(reader["NomeInstrutor"]);
                    picQv.IDPlano = Convert.ToString(reader["IDPlano"]);
                    picQv.IDCliente = Convert.ToString(reader["IDCliente"]);
                    picQv.NomeCliente = Convert.ToString(reader["NomeCliente"]);
                    picQv.NomeCategoria = Convert.ToString(reader["Modalidade"]);
                    picQv.QtdAulaSemana = Convert.ToString(reader["QtdAulaSemana"]);
                    picQv.QtdMesesDuracao = Convert.ToString(reader["QtdMesesDuracao"]);
                    picQv.Valor = Convert.ToString(reader["Valor"]);
                    picQv.AdesaoContrato = Convert.ToDateTime(reader["AdesaoContrato"]);
                    picQv.TerminoContrato = Convert.ToDateTime(reader["TerminoContrato"]);
                    picQv.IDFormapagamento = Convert.ToString(reader["IDFormapagamento"]);
                    picQv.NomeFormapagamento = Convert.ToString(reader["FormaPagamento"]);
                    PICQueryViewList.Add(picQv);
                }

                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso!";
                resposta.Data = PICQueryViewList;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.Message = "Erro no GetAllbyIDModalidade do PICQueryView do banco de dados, contate o administrador.";
                resposta.Data = new List<PlanoInstrutorClienteQueryView>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }

        }

        public Response Update(PlanoInstrutorCliente pic)
        {
            throw new NotImplementedException();
        }

        public Response EndPlain(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
