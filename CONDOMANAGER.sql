use master
go
drop database condomanagerdb
go

create database condomanagerdb
go
use condomanagerdb
go

create schema condomanager
go


CREATE TABLE CONDOMANAGER.Gestor_Condominio(
	NIF VARCHAR(9),
	Nome VARCHAR(40) NOT NULL,
	Telemovel VARCHAR(9) NOT NULL UNIQUE,
	Email VARCHAR(40) NOT NULL UNIQUE,
	hashed_pass VARCHAR(40) NOT NULL,

	PRIMARY KEY(NIF)
)

 CREATE TABLE CONDOMANAGER.Condominio(
	Endereco VARCHAR(40),
	Orcam_Anual MONEY,
	nif_gestor varchar(9),
	PRIMARY KEY(Endereco),
	foreign key(nif_gestor) references CONDOMANAGER.Gestor_Condominio(nif)
 )

 CREATE TABLE CONDOMANAGER.Fracao(
	Ref_fracao varchar(5),
	Endereco varchar(40),
	Permilagem money not null,
	piso varchar(5) not null,
	leitura_gas float,
	leitura_luz float,
	leitura_agua float,
	PRIMARY KEY(Ref_fracao, Endereco), 
	FOREIGN KEY(Endereco) references CONDOMANAGER.Condominio(Endereco)
 )

 CREATE TABLE CONDOMANAGER.Condomino(
	NIF varchar(9),
	Nome VARCHAR(40) NOT NULL,
	Telemovel VARCHAR(9) NOT NULL UNIQUE,
	Email VARCHAR(40) NOT NULL UNIQUE,
	endereco varchar(40),
	ref_fracao varchar(5),
	PRIMARY KEY(NIF),
	foreign key(ref_fracao, endereco) references condomanager.Fracao(ref_fracao, endereco)
 )


 CREATE TABLE CONDOMANAGER.Reclamacao(
	Id int not null Identity(1,1),
	Data date,
	Descricao varchar(100),
	nif_condomino varchar(9),
	nif_gestor varchar(9),
	endereco varchar(40),
	ref_fracao varchar(5)
	PRIMARY KEY(Id),
	foreign key (nif_condomino) references CONDOMANAGER.condomino(nif),
	foreign key (nif_gestor) references CONDOMANAGER.gestor_condominio(nif),
	foreign key (ref_fracao, endereco) references CONDOMANAGER.fracao(ref_fracao, endereco)
 )

 CREATE TABLE CONDOMANAGER.Reuniao(
	Id int not null Identity(1,1),
	Nome varchar(40),
	Data date,
	Descricao varchar(100),
	localizacao varchar(40),
	nif_gestor varchar(9),
	PRIMARY KEY(Id),
	foreign key(nif_gestor) references CONDOMANAGER.Gestor_Condominio(nif)
 )

 CREATE TABLE CONDOMANAGER.Reparacao(
	Id int not null Identity(1,1),
	Nome varchar(40),
	Data date,
	Descricao varchar(100),
	Danificado varchar(50),
	nif_gestor varchar(9),
	PRIMARY KEY(Id),
	foreign key(nif_gestor) references condomanager.gestor_condominio(nif)
 )

  CREATE TABLE CONDOMANAGER.Tipo_Fornecedor(
	Id int,
	Descricao varchar(40),
	PRIMARY KEY(Id)
 )

 CREATE TABLE CONDOMANAGER.Fornecedor_Servicos(
	NIF varchar(9),
	Nome varchar(15),
	Telemovel varchar(9),
	Morada varchar(40),
	tipo int
	PRIMARY KEY(NIF)
	foreign key(tipo) references condomanager.tipo_fornecedor(id)
 )


 CREATE TABLE CONDOMANAGER.Pagamento_Quotas(
	Id int not null Identity(1,1),
	Data date,
	NIF_condomino varchar(9),
	Descricao varchar(100),
	Valor money,
	PRIMARY KEY(Id),
	foreign key(nif_condomino) references condomanager.condomino(nif)
 )
 CREATE TABLE CONDOMANAGER.Fatura_Quotas(
	Id_Fatura int not null Identity(1,1),
	Data date,
	nif_gestor varchar(9),
	nif_Consumidor varchar(9),
	id_pagamento int,
	Quantia money,

	PRIMARY KEY(Id_Fatura),
	foreign key(nif_gestor) references condomanager.gestor_condominio(nif),
	foreign key(nif_consumidor) references condomanager.condomino(nif),
	foreign key(id_pagamento) references condomanager.pagamento_quotas(id)
 )

  CREATE TABLE CONDOMANAGER.Pagamento_Servicos(
	Id int not null Identity(1,1),
	Data date,
	NIF_gestor varchar(9),
	Descricao varchar(40),
	Valor money,

	PRIMARY KEY(Id),
	foreign key(nif_gestor) references condomanager.gestor_condominio(nif)

 )


 CREATE TABLE CONDOMANAGER.Fatura_Servicos(
	Id_Fatura int not null identity(1,1),
	Data date,
	Id_Fornec varchar(9),
	Id_Consumidor varchar(9),
	id_pagamento int,
	Quantia money,

	PRIMARY KEY(Id_Fatura),
	foreign key(id_fornec) references condomanager.fornecedor_servicos(nif),
	foreign key (id_consumidor) references condomanager.gestor_condominio(nif),
	foreign key( id_pagamento) references condomanager.pagamento_servicos(id)

 )



