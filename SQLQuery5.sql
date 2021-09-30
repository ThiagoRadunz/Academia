﻿SELECT ATENDENTE.ID IDAtendente,
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