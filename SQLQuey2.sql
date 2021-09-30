SELECT * FROM INSTRUTORES WHERE ATIVO = 1

SELECT INSTRUTOR.ID IDInstrutor,
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
                                     WHERE UPPER(USUARIO.NOME) LIKE UPPER('%L%') AND ATIVO = 0