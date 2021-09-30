                                    SELECT PRODUTO.ID IDProduto,
                                           PRODUTO.NOME Nome,
                                           CATEGORIA.NOME Categoria,
                                           PRODUTO.PRECO_UNITARIO PrecoUnitario,
                                           PRODUTO.QTD_ESTOQUE QtdEstoque,
                                           PRODUTO.DESCRICAO Descricao
                                      FROM PRODUTOS PRODUTO 
                                      JOIN CATEGORIAS CATEGORIA
                                        ON PRODUTO.CATEGORIAID = CATEGORIA.ID