﻿ALTER TABLE PRODUTOS ADD CONSTRAINT UC_PRODUTOS UNIQUE (NOME,DESCRICAO)

ALTER TABLE PRODUTOS DROP CONSTRAINT UC_PRODUTOS