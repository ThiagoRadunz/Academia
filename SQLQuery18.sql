﻿SELECT PIC.ID IDPIC,
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
                                       WHERE C.ID = 4