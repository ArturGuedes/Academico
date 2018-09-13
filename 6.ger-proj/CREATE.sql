/*
-- AREA [id, nome, descricao, situacao, versao]
*/
CREATE TABLE PMBOK_area(
	id NUMBER PRIMARY KEY,
	nome VARCHAR2(200),
	descricao VARCHAR2(2000),
	situacao NUMBER,
	versao NUMBER
);

/*
-- PROCESSO [id, nome, descricao, situacao, versao]
*/
CREATE TABLE PMBOK_processo(
	id NUMBER PRIMARY KEY,
	nome VARCHAR2(200),
	descricao VARCHAR2(2000),
	situacao NUMBER,
	versao NUMBER
);

/*
-- ETAPA [id, idArea, idProcesso, nome, descricao, situacao, versao]
*/
CREATE TABLE PMBOK_etapa(
	id NUMBER PRIMARY KEY,
	idArea NUMBER REFERENCES PMBOK_area(id),
	idProcesso NUMBER REFERENCES PMBOK_processo(id),
	nome VARCHAR2(200),
	descricao VARCHAR2(2000),
	situacao NUMBER,
	versao NUMBER
);

-- Entrada, ferramenta e saida [id, nome, descricao, versao]
CREATE TABLE PMBOK_entrada(
	id NUMBER PRIMARY KEY,
	nome VARCHAR2(200),
	descricao VARCHAR2(2000),
	versao NUMBER
);
CREATE TABLE PMBOK_ferramenta(
	id NUMBER PRIMARY KEY,
	nome VARCHAR2(200),
	descricao VARCHAR2(2000),
	versao NUMBER
);
CREATE TABLE PMBOK_saida(
	id NUMBER PRIMARY KEY,
	nome VARCHAR2(200),
	descricao VARCHAR2(2000),
	versao NUMBER
);


-- Tabelas associativas [idEtapa, id{Entrada,Ferramenta,Saida}]
CREATE TABLE PMBOK_etapa_entrada(
	idEtapa NUMBER REFERENCES PMBOK_etapa(id),
	idEntrada NUMBER REFERENCES PMBOK_entrada(id),
	PRIMARY KEY (identrada, idetapa)
);
CREATE TABLE PMBOK_etapa_ferramenta(
	idEtapa NUMBER  REFERENCES PMBOK_etapa(id),
	idFerramenta NUMBER REFERENCES PMBOK_ferramenta(id),
	PRIMARY KEY (idferramenta, idetapa)
);
CREATE TABLE PMBOK_etapa_saida(
	idEtapa NUMBER REFERENCES PMBOK_etapa(id),
	idSaida NUMBER REFERENCES PMBOK_saida(id),
	PRIMARY KEY (idsaida, idetapa)
);


/*
-- Tabelas de auditoria
*/
CREATE TABLE PMBOKaud_area(
  old_id NUMBER,
  old_nome VARCHAR2(200),
  old_descricao VARCHAR2(2000),
  old_situacao NUMBER,
  old_versao NUMBER,

  new_id NUMBER,
  new_nome VARCHAR2(200),
  new_descricao VARCHAR2(2000),
  new_situacao NUMBER,
  new_versao NUMBER,

  user0 VARCHAR2(100),
  data0 DATE
);

CREATE TABLE PMBOKaud_processo (
  old_id NUMBER,
  old_nome VARCHAR2(200),
  old_descricao VARCHAR2(2000),
  old_situacao NUMBER,
  old_versao NUMBER,

  new_id NUMBER,
  new_nome VARCHAR2(200),
  new_descricao VARCHAR2(2000),
  new_situacao NUMBER,
  new_versao NUMBER,

  user0 VARCHAR2(100),
  data0 DATE
);

CREATE TABLE PMBOKaud_etapa(
  old_id NUMBER,
  old_idarea NUMBER,
  old_idProcesso NUMBER,
  old_nome VARCHAR2(200),
  old_descricao VARCHAR2(2000),
  old_situacao NUMBER,
  old_versao NUMBER,

  new_id NUMBER,
  new_idarea NUMBER,
  new_idProcesso NUMBER,
  new_nome VARCHAR2(200),
  new_descricao VARCHAR2(2000),
  new_situacao NUMBER,
  new_versao NUMBER,

  user0 VARCHAR2(100),
  data0 DATE
);


CREATE TABLE PMBOKaud_entrada(
  old_id NUMBER,
  old_nome VARCHAR2(200),
  old_descricao VARCHAR2(2000),
  old_versao NUMBER,

  new_id NUMBER,
  new_nome VARCHAR2(200),
  new_descricao VARCHAR2(2000),
  new_versao NUMBER,

  user0 VARCHAR2(100),
  data0 DATE
);

CREATE TABLE PMBOKaud_ferramenta(
  old_id NUMBER,
  old_nome VARCHAR2(200),
  old_descricao VARCHAR2(2000),
  old_versao NUMBER,

  new_id NUMBER,
  new_nome VARCHAR2(200),
  new_descricao VARCHAR2(2000),
  new_versao NUMBER,
  
  user0 VARCHAR2(100),
  data0 DATE
);

CREATE TABLE PMBOKaud_saida(
  old_id NUMBER,
  old_nome VARCHAR2(200),
  old_descricao VARCHAR2(2000),
  old_versao NUMBER,

  new_id NUMBER,
  new_nome VARCHAR2(200),
  new_descricao VARCHAR2(2000),
  new_versao NUMBER,
  
  user0 VARCHAR2(100),
  data0 DATE
);



CREATE TABLE PMBOKaud_etapa_entrada(
	old_idEtapa NUMBER,
	old_idEntrada NUMBER,
	new_idEtapa NUMBER,
	new_idEntrada NUMBER,
  	user0 VARCHAR2(100),
  	data0 DATE
);

CREATE TABLE PMBOKaud_etapa_ferramenta(
	old_idEtapa NUMBER,
	old_idFerramenta NUMBER,
	new_idEtapa NUMBER,
	new_idFerramenta NUMBER,
	user0 VARCHAR2(100),
  	data0 DATE
);

CREATE TABLE PMBOKaud_etapa_saida(
	old_idEtapa NUMBER,
	old_idSaida NUMBER,
	new_idEtapa NUMBER,
	new_idSaida NUMBER,
	user0 VARCHAR2(100),
  	data0 DATE
);


/*
-- TRIGGERS DE AUDITORIA
*/
CREATE OR REPLACE TRIGGER PMBOKaud_area
AFTER INSERT OR DELETE OR UPDATE ON PMBOK_area 
FOR EACH ROW
BEGIN
	INSERT INTO PMBOKaud_area VALUES (
		:OLD.id,
		:OLD.nome,
		:OLD.descricao,
		:OLD.situacao,
		:OLD.versao,
		:NEW.id,
		:NEW.nome,
		:NEW.descricao,
		:NEW.situacao,
		:NEW.versao,
		USER,
		SYSDATE);
END;

CREATE OR REPLACE TRIGGER PMBOKaud_processo
AFTER INSERT OR DELETE OR UPDATE ON PMBOK_processo 
FOR EACH ROW
BEGIN
	INSERT INTO PMBOKaud_processo VALUES (
		:OLD.id,
		:OLD.nome,
		:OLD.descricao,
		:OLD.situacao,
		:OLD.versao,
		:NEW.id,
		:NEW.nome,
		:NEW.descricao,
		:NEW.situacao,
		:NEW.versao,
		USER,
		SYSDATE);
END;

CREATE OR REPLACE TRIGGER PMBOKaud_etapa
AFTER INSERT OR DELETE OR UPDATE ON PMBOK_etapa
FOR EACH ROW
BEGIN
	INSERT INTO PMBOKaud_etapa VALUES (
		:OLD.id,
		:OLD.idArea,
		:OLD.idProcesso,
		:OLD.nome,
		:OLD.descricao,
		:OLD.situacao,
		:OLD.versao,
		:NEW.id,
		:NEW.idArea,
		:NEW.idProcesso,
		:NEW.nome,
		:NEW.descricao,
		:NEW.situacao,
		:NEW.versao,
		USER,
		SYSDATE);
END;

CREATE OR REPLACE TRIGGER PMBOKaud_entrada
AFTER INSERT OR DELETE OR UPDATE ON PMBOK_entrada 
FOR EACH ROW
BEGIN
	INSERT INTO PMBOKaud_entrada VALUES (
		:OLD.id,
		:OLD.nome,
		:OLD.descricao,
		:OLD.versao,
		:NEW.id,
		:NEW.nome,
		:NEW.descricao,
		:NEW.versao,
		USER, 
		SYSDATE);
END;

CREATE OR REPLACE TRIGGER PMBOKaud_ferramenta
AFTER INSERT OR DELETE OR UPDATE ON PMBOK_ferramenta 
FOR EACH ROW
BEGIN
	INSERT INTO PMBOKaud_ferramenta VALUES (
		:OLD.id,
		:OLD.nome,
		:OLD.descricao,
		:OLD.versao,
		:NEW.id,
		:NEW.nome,
		:NEW.descricao,
		:NEW.versao,
		USER, 
		SYSDATE);
END;

CREATE OR REPLACE TRIGGER PMBOKaud_saida
AFTER INSERT OR DELETE OR UPDATE ON PMBOK_saida 
FOR EACH ROW
BEGIN
	INSERT INTO PMBOKaud_saida VALUES (
		:OLD.id,
		:OLD.nome,
		:OLD.descricao,
		:OLD.versao,
		:NEW.id,
		:NEW.nome,
		:NEW.descricao,
		:NEW.versao,
		USER, 
		SYSDATE);
END;



CREATE OR REPLACE TRIGGER PMBOKaud_etapa_entrada
AFTER INSERT OR DELETE OR UPDATE ON PMBOK_etapa_entrada 
FOR EACH ROW
BEGIN
	INSERT INTO PMBOKaud_etapa_entrada VALUES (
		:OLD.idEtapa,
		:OLD.idEntrada,
		:NEW.idEtapa,
		:NEW.IdEntrada,
		USER, 
		SYSDATE);
END;

CREATE OR REPLACE TRIGGER PMBOKaud_etapa_ferramenta
AFTER INSERT OR DELETE OR UPDATE ON PMBOK_etapa_ferramenta 
FOR EACH ROW
BEGIN
	INSERT INTO PMBOKaud_etapa_ferramenta VALUES (
		:OLD.idEtapa,
		:OLD.idFerramenta,
		:NEW.idEtapa,
		:NEW.IdFerramenta,
		USER, 
		SYSDATE);
END;

CREATE OR REPLACE TRIGGER PMBOKaud_etapa_saida
AFTER INSERT OR DELETE OR UPDATE ON PMBOK_etapa_saida 
FOR EACH ROW
BEGIN
	INSERT INTO PMBOKaud_etapa_saida VALUES (
		:OLD.idEtapa,
		:OLD.idSaida,
		:NEW.idEtapa,
		:NEW.IdSaida,
		USER, 
		SYSDATE);
END;



























--@Procedures

/*
Procedures de inserção
*/
--Área
create or replace PROCEDURE PMBOK_ins_area(
Pid IN PMBOK_area.id%TYPE,
Pno IN PMBOK_area.nome%TYPE,
Pde IN PMBOK_area.descricao%TYPE,
Psi IN PMBOK_area.situacao%TYPE,
Pve IN PMBOK_area.versao%TYPE)
IS
BEGIN
INSERT INTO PMBOK_area VALUES (Pid, Pno, Pde, Psi, Pve);
END PMBOK_ins_area;

--Processo
create or replace PROCEDURE PMBOK_ins_processo(
Pid IN PMBOK_processo.id%TYPE,
Pno IN PMBOK_processo.nome%TYPE,
Pde IN PMBOK_processo.descricao%TYPE,
Psi IN PMBOK_processo.situacao%TYPE,
Pve IN PMBOK_processo.versao%TYPE)
IS
BEGIN
INSERT INTO PMBOK_processo VALUES (Pid, Pno, Pde, Psi, Pve);
END PMBOK_ins_processo;

--Etapa
create or replace PROCEDURE PMBOK_ins_etapa(
Pid IN PMBOK_etapa.id%TYPE,
PidAr IN PMBOK_etapa.idArea%TYPE,
PidPr IN PMBOK_etapa.idProcesso%TYPE,
Pno IN PMBOK_etapa.nome%TYPE,
Pde IN PMBOK_etapa.descricao%TYPE,
Psi IN PMBOK_etapa.situacao%TYPE,
Pve IN PMBOK_etapa.versao%TYPE)
IS
BEGIN
INSERT INTO PMBOK_etapa VALUES (Pid, PidAr, PidPr, Pno, Pde, Psi, Pve);
END PMBOK_ins_etapa;

--Entrada
create or replace PROCEDURE PMBOK_ins_entrada(
Pid IN PMBOK_entrada.id%TYPE,
Pno IN PMBOK_entrada.nome%TYPE,
Pde IN PMBOK_entrada.descricao%TYPE,
Pve IN PMBOK_entrada.versao%TYPE)
IS
BEGIN
INSERT INTO PMBOK_entrada VALUES (Pid, Pno, Pde, Pve);
END PMBOK_ins_entrada;

--Ferramenta
create or replace PROCEDURE PMBOK_ins_ferramenta(
Pid IN PMBOK_ferramenta.id%TYPE,
Pno IN PMBOK_ferramenta.nome%TYPE,
Pde IN PMBOK_ferramenta.descricao%TYPE,
Pve IN PMBOK_ferramenta.versao%TYPE)
IS
BEGIN
INSERT INTO PMBOK_ferramenta VALUES (Pid, Pno, Pde, Pve);
END PMBOK_ins_ferramenta;

--Saída
create or replace PROCEDURE PMBOK_ins_saida(
Pid IN PMBOK_saida.id%TYPE,
Pno IN PMBOK_saida.nome%TYPE,
Pde IN PMBOK_saida.descricao%TYPE,
Pve IN PMBOK_saida.versao%TYPE)
IS
BEGIN
INSERT INTO PMBOK_saida VALUES (Pid, Pno, Pde, Pve);
END PMBOK_ins_saida;


--etapa_entrada
create or replace PROCEDURE PMBOK_ins_etapa_entrada(
PidEt IN PMBOK_etapa_entrada.idEtapa%TYPE,
PidEn IN PMBOK_etapa_entrada.identrada%TYPE)
IS
BEGIN
INSERT INTO PMBOK_etapa_entrada VALUES (PidEt, PidEn);
END PMBOK_ins_etapa_entrada;

--etapa_ferramenta
create or replace PROCEDURE PMBOK_ins_etapa_ferramenta(
PidEt IN PMBOK_etapa_ferramenta.idEtapa%TYPE,
PidFe IN PMBOK_etapa_ferramenta.idFerramenta%TYPE)
IS
BEGIN
INSERT INTO PMBOK_etapa_ferramenta VALUES (PidEt, PidFe);
END PMBOK_ins_etapa_ferramenta;

--etapa_saida
create or replace PROCEDURE PMBOK_ins_etapa_saida(
PidEt IN PMBOK_etapa_saida.idEtapa%TYPE,
PidSa IN PMBOK_etapa_saida.idsaida%TYPE)
IS
BEGIN
INSERT INTO PMBOK_etapa_saida VALUES (PidEt, PidSa);
END PMBOK_ins_etapa_saida;


/*
Scripts de DELETE
*/

--Área
create or replace PROCEDURE PMBOK_del_area(
Pid IN PMBOK_area.id%TYPE)
IS
BEGIN
DELETE FROM PMBOK_area WHERE id = Pid;
END PMBOK_del_area;

--Processo
create or replace PROCEDURE PMBOK_del_processo
(Pid IN PMBOK_processo.id%TYPE)
IS
BEGIN
DELETE FROM PMBOK_processo WHERE id = Pid;
END PMBOK_del_processo;

--Etapa
create or replace PROCEDURE PMBOK_del_etapa
(Pid IN PMBOK_etapa.id%TYPE)
IS
BEGIN
DELETE FROM PMBOK_etapa WHERE id = Pid;
END PMBOK_del_etapa;

--Entrada
create or replace PROCEDURE PMBOK_del_entrada
(Pid IN PMBOK_entrada.id%TYPE)
IS
BEGIN
DELETE FROM PMBOK_entrada WHERE id = Pid;
END PMBOK_del_entrada;

--Ferramenta
create or replace PROCEDURE PMBOK_del_ferramenta
(Pid IN PMBOK_ferramenta.id%TYPE)
IS
BEGIN
DELETE FROM PMBOK_ferramenta WHERE id = Pid;
END PMBOK_del_ferramenta;

--Saída
create or replace PROCEDURE PMBOK_del_saida
(Pid IN PMBOK_saida.id%TYPE)
IS
BEGIN
DELETE FROM PMBOK_saida WHERE id = Pid;
END PMBOK_del_saida;

--etapa_entrada
create or replace PROCEDURE PMBOK_del_etapa_entrada(
PidEt IN PMBOK_etapa_entrada.idEtapa%TYPE,
PidEn IN PMBOK_etapa_entrada.idEntrada%TYPE)
IS
BEGIN
DELETE FROM PMBOK_etapa_entrada WHERE idEtapa = PidEt AND idEntrada = PidEn;
END PMBOK_del_etapa_entrada;

--etapa_ferramenta
create or replace PROCEDURE PMBOK_del_etapa_ferramenta(
PidEt IN PMBOK_etapa_ferramenta.idEtapa%TYPE,
PidFe IN PMBOK_etapa_ferramenta.idFerramenta%TYPE)
IS
BEGIN
DELETE FROM PMBOK_etapa_ferramenta WHERE idEtapa = PidEt AND idFerramenta = PidFe;
END PMBOK_del_etapa_ferramenta;

--etapa_saida
create or replace PROCEDURE PMBOK_del_etapa_saida(
PidEt IN PMBOK_etapa_saida.idEtapa%TYPE,
PidSa IN PMBOK_etapa_saida.idSaida%TYPE)
IS
BEGIN
DELETE FROM PMBOK_etapa_saida WHERE idEtapa = PidEt AND idSaida = PidSa;
END PMBOK_del_etapa_saida;



/*Procedures de UPDATE
inserir campos chave para a seleção do registro, em seguida os demais atributos (incluindo a própria chave primária)
*/

--Área
create or replace PROCEDURE PMBOK_upd_area(
Pid IN PMBOK_area.id%TYPE,
Pno IN PMBOK_area.nome%TYPE,
Pde IN PMBOK_area.descricao%TYPE,
Psi IN PMBOK_area.situacao%TYPE,
Pve IN PMBOK_area.versao%TYPE)
IS
BEGIN
UPDATE PMBOK_area SET nome = Pno, descricao = Pde, situacao = Psi, versao = Pve WHERE id = Pid;
END PMBOK_upd_area;

--Processo
create or replace PROCEDURE PMBOK_upd_processo(
Pid IN PMBOK_processo.id%TYPE,
Pno IN PMBOK_processo.nome%TYPE,
Pde IN PMBOK_processo.descricao%TYPE,
Psi IN PMBOK_processo.situacao%TYPE,
Pve IN PMBOK_processo.versao%TYPE)
IS
BEGIN
UPDATE PMBOK_processo SET nome = Pno, descricao = Pde, situacao = Psi, versao = Pve WHERE id = Pid;
END PMBOK_upd_processo;


--Etapa
create or replace PROCEDURE PMBOK_upd_etapa(
Pid IN PMBOK_etapa.id%TYPE,
PidAr IN PMBOK_etapa.idArea%TYPE,
PidPr IN PMBOK_etapa.idProcesso%TYPE,
Pno IN PMBOK_etapa.nome%TYPE,
Pde IN PMBOK_etapa.descricao%TYPE,
Psi IN PMBOK_etapa.situacao%TYPE,
Pve IN PMBOK_etapa.versao%TYPE)
IS
BEGIN
UPDATE PMBOK_etapa SET idArea = PidAr, idProcesso = PidPr, nome = Pno, descricao = Pde, situacao = Psi, versao = Pve WHERE id = Pid;
END PMBOK_upd_etapa;

--Entrada
create or replace PROCEDURE PMBOK_upd_entrada(
Pid IN PMBOK_entrada.id%TYPE,
Pno IN PMBOK_entrada.nome%TYPE,
Pde IN PMBOK_entrada.descricao%TYPE,
Pve IN PMBOK_entrada.versao%TYPE)
IS
BEGIN
UPDATE PMBOK_entrada SET nome = Pno, descricao = Pde, versao = Pve WHERE id = Pid;
END PMBOK_upd_entrada;

--Ferramenta
create or replace PROCEDURE PMBOK_upd_ferramenta(
Pid IN PMBOK_ferramenta.id%TYPE,
Pno IN PMBOK_ferramenta.nome%TYPE,
Pde IN PMBOK_ferramenta.descricao%TYPE,
Pve IN PMBOK_ferramenta.versao%TYPE)
IS
BEGIN
UPDATE PMBOK_ferramenta SET nome = Pno, descricao = Pde, versao = Pve WHERE id = Pid;
END PMBOK_upd_ferramenta;

--Saída
create or replace PROCEDURE PMBOK_upd_saida(
Pid IN PMBOK_saida.id%TYPE,
Pno IN PMBOK_saida.nome%TYPE,
Pde IN PMBOK_saida.descricao%TYPE,
Pve IN PMBOK_saida.versao%TYPE)
IS
BEGIN
UPDATE PMBOK_saida SET nome = Pno, descricao = Pde, versao = Pve WHERE id = Pid;
END PMBOK_upd_saida;

--Entrada
create or replace PROCEDURE PMBOK_upd_etapa_entrada(
PidEt1 IN PMBOK_etapa_entrada.idEtapa%TYPE,
PidEn1 IN PMBOK_etapa_entrada.idEntrada%TYPE,
PidEt IN PMBOK_etapa_entrada.idEtapa%TYPE,
PidEn IN PMBOK_etapa_entrada.idEntrada%TYPE)
IS
BEGIN
PMBOK_DEL_ETAPA_ENTRADA(PidEt1, PidEn1);
PMBOK_INS_ETAPA_ENTRADA(PidEt, PidEn);
END PMBOK_upd_etapa_entrada;

--etapa_ferramenta
create or replace PROCEDURE PMBOK_upd_etapa_ferramenta(
PidEt1 IN PMBOK_etapa_ferramenta.idEtapa%TYPE,
PidFe1 IN PMBOK_etapa_ferramenta.idFerramenta%TYPE,
PidEt IN PMBOK_etapa_ferramenta.idEtapa%TYPE,
PidFe IN PMBOK_etapa_ferramenta.idFerramenta%TYPE)
IS
BEGIN
PMBOK_DEL_ETAPA_FERRAMENTA(PidEt1, PidFe1);
PMBOK_INS_ETAPA_FERRAMENTA(PidEt, PidFe);
END PMBOK_upd_etapa_ferramenta;

--etapa_saída
create or replace PROCEDURE PMBOK_upd_etapa_saida(
PidEt1 IN PMBOK_etapa_saida.idEtapa%TYPE,
PidSa1 IN PMBOK_etapa_saida.idsaida%TYPE,
PidEt IN PMBOK_etapa_saida.idEtapa%TYPE,
PidSa IN PMBOK_etapa_saida.idsaida%TYPE)
IS
BEGIN
PMBOK_DEL_ETAPA_SAIDA(PidEt1, PidSa1);
PMBOK_INS_ETAPA_SAIDA(PidEt, PidSa);
END PMBOK_upd_etapa_saida;






drop table pmbok_area;
drop table pmbok_processo;
drop table pmbok_etapa;
drop table pmbok_entrada;
drop table pmbok_ferramenta;
drop table pmbok_saida;
drop table pmbok_etapa_entrada;
drop table pmbok_etapa_ferramenta;
drop table pmbok_etapa_saida;
drop table pmbokaud_area;
drop table pmbokaud_processo;
drop table pmbokaud_etapa;
drop table pmbokaud_entrada;
drop table pmbokaud_ferramenta;
drop table pmbokaud_saida;
drop table pmbokaud_etapa_entrada;
drop table pmbokaud_etapa_ferramenta;
drop table pmbokaud_etapa_saida;
drop table pmbok_area;