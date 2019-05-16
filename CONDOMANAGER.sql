CREATE SCHEMA [CONDOMANAGER]
GO

CREATE TABLE CONDOMANAGER.Gestor_Condominio(
	NIF INT,
	Nome VARCHAR(40) NOT NULL,
	Telemovel VARCHAR(9) NOT NULL UNIQUE,
	Email VARCHAR(40) NOT NULL UNIQUE,
	password VARCHAR(40) NOT NULL,

	PRIMARY KEY(NIF)
)

-- CREATE TABLE CONDOMANAGER.Condominio(
--	Endereco 
--	Orcam_Anual
--
--	PRIMARY KEY(Endereco)
-- )

-- CREATE TABLE CONDOMANAGER.Fracao(
--	Ref
--	Endereco 
--	Permilagem
--
--	PRIMARY KEY(Ref, Endereco), FOREIGN KEY(Endereco)
-- )

-- CREATE TABLE CONDOMANAGER.Condomino(
--	NIF INT,
--	Nome VARCHAR(40) NOT NULL,
--	Telemovel VARCHAR(9) NOT NULL UNIQUE,
--	Email VARCHAR(40) NOT NULL UNIQUE,
--
--	PRIMARY KEY(NIF)
-- )

-- CREATE TABLE CONDOMANAGER.Reclamacao(
--	Id
--	Data
--	Descricao
--
--	PRIMARY KEY(Id)
-- )

-- CREATE TABLE CONDOMANAGER.Evento(
--	Id
--	Nome
--	Data
--	Descricao
--
--	PRIMARY KEY(Id)
-- )

-- CREATE TABLE CONDOMANAGER.Reparacao(
--	Id
--	Nome
--	Data
--	Descricao
--	Danificado
--
--	PRIMARY KEY(Id)
-- )

-- CREATE TABLE CONDOMANAGER.Reuniao(
--	Id
--	Nome
--	Data
--	Descricao
--	Local
--
--	PRIMARY KEY(Id)
-- )

-- CREATE TABLE CONDOMANAGER.Fatura_Quotas(
--	Id_Fatura
--	Data
--	Id_Fornec
--	Id_Consumidor
--	Quantia
--
--	PRIMARY KEY(Id_Fatura)
-- )

-- CREATE TABLE CONDOMANAGER.Pagamento_Quotas(
--	Id
--	Data
--	NIF
--	Descricao
--	Valor
--
--	PRIMARY KEY(Id)
-- )

-- CREATE TABLE CONDOMANAGER.Fatura_Servicos(
--	Id_Fatura
--	Data
--	Id_Fornec
--	Id_Consumidor
--	Quantia
--
--	PRIMARY KEY(Id_Fatura)
-- )

-- CREATE TABLE CONDOMANAGER.Pagamento_Servicos(
--	Id
--	Data
--	NIF
--	Descricao
--	Valor
--
--	PRIMARY KEY(Id)
-- )

-- CREATE TABLE CONDOMANAGER.Fornecedor_Servicos(
--	NIF
--	Nome
--	Telemovel
--	Morada
--
--	PRIMARY KEY(NIF)
-- )

-- CREATE TABLE CONDOMANAGER.Tipo_Fornecedor(
--	Id
--	Descricao
--
--	PRIMARY KEY(Id)
-- )