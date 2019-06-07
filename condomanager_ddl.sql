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
	hashed_pass VARCHAR(256) NOT NULL,

	PRIMARY KEY(NIF)
)

 CREATE TABLE CONDOMANAGER.Condominio(
	Endereco VARCHAR(40),
	Orcam_Anual MONEY,
	nif_gestor varchar(9),
	PRIMARY KEY(Endereco),
	foreign key(nif_gestor) references CONDOMANAGER.Gestor_Condominio(nif)
 )

 CREATE TABLE CONDOMANAGER.Condomino(
	NIF varchar(9),
	Nome VARCHAR(40) NOT NULL,
	Telemovel VARCHAR(9) NOT NULL UNIQUE,
	Email VARCHAR(40) NOT NULL UNIQUE,
	PRIMARY KEY(NIF),
)

 CREATE TABLE CONDOMANAGER.Fracao(
	Ref_fracao varchar(5),
	Endereco varchar(40),
	Permilagem money not null,
	piso varchar(5) not null,
	leitura_gas float,
	leitura_luz float,
	leitura_agua float,
	nif_condomino varchar(9),
	PRIMARY KEY(Ref_fracao, Endereco), 
	FOREIGN KEY(Endereco) references CONDOMANAGER.Condominio(Endereco),
	foreign key(nif_condomino) references condomanager.condomino(nif)
	on update cascade on delete set null
 )


 create table condomanager.tipo_reclamacao(
	tipo int not null,
	descricao varchar(100),
	primary key(tipo)
 )


 CREATE TABLE CONDOMANAGER.Reclamacao(
	Id int not null Identity(0,1),
	Data datetime,
	Descricao varchar(100),
	nif_condomino varchar(9),
	endereco varchar(40),
	ref_fracao varchar(5),
	tipo int not null
	PRIMARY KEY(Id),
	foreign key (nif_condomino) references CONDOMANAGER.condomino(nif),
	foreign key (ref_fracao, endereco) references CONDOMANAGER.fracao(ref_fracao, endereco),
	foreign key(tipo) references condomanager.tipo_reclamacao(tipo)
 )

 CREATE TABLE CONDOMANAGER.Reuniao(
	Id int not null Identity(0,1),
	Nome varchar(40),
	Data datetime,
	Descricao varchar(100),
	localizacao varchar(40),
	endereco varchar(40),
	PRIMARY KEY(Id),
	foreign key(endereco) references condomanager.condominio(endereco)
 )

 CREATE TABLE CONDOMANAGER.Reparacao(
	Id int not null Identity(0,1),
	Nome varchar(40),
	Data datetime,
	Descricao varchar(100),
	Danificado varchar(50),
	endereco varchar(40),
	PRIMARY KEY(Id),
	foreign key(endereco) references condomanager.condominio(endereco)
 )

  CREATE TABLE CONDOMANAGER.Tipo_Fornecedor(
	Id int,
	Descricao varchar(40),
	PRIMARY KEY(Id)
 )

 CREATE TABLE CONDOMANAGER.Fornecedor_Servicos(
	NIF varchar(9),
	Nome varchar(20),
	Telemovel varchar(9),
	Morada varchar(40),
	tipo int
	PRIMARY KEY(NIF)
	foreign key(tipo) references condomanager.tipo_fornecedor(id)
 )

  CREATE TABLE CONDOMANAGER.Fatura_Quotas(
	Id_Fatura int not null Identity(0,1),
	Data datetime,
	descricao varchar(100),
	ref_fracao varchar(5),
	endereco varchar(40),
	Quantia money,
	PRIMARY KEY(Id_Fatura),
	foreign key(ref_fracao,endereco) references condomanager.fracao(ref_fracao, endereco)
 )

 CREATE TABLE CONDOMANAGER.Pagamento_Quotas(
	Id int not null Identity(0,1),
	Data datetime,
	Descricao varchar(100),
	Valor money,
	id_fatura int,
	PRIMARY KEY(Id),
	foreign key(id_fatura) references condomanager.fatura_quotas(id_fatura)
 )

  CREATE TABLE CONDOMANAGER.Fatura_Servicos(
	Id_Fatura int not null identity(0,1),
	Data datetime,
	nif_Fornec varchar(9),
	endereco varchar(40),
	descricao varchar(100),
	Quantia money,

	PRIMARY KEY(Id_Fatura),
	foreign key(nif_fornec) references condomanager.fornecedor_servicos(nif) on delete cascade,
	foreign key(endereco) references condomanager.condominio(endereco) on delete cascade

 )

  CREATE TABLE CONDOMANAGER.Pagamento_Servicos(
	Id int not null Identity(0,1),
	Data datetime,
	Descricao varchar(100),
	Quantia money,
	id_fatura int,
	PRIMARY KEY(Id),
	foreign key(id_fatura) references condomanager.fatura_servicos(id_fatura) on delete cascade

 )



 Create table condomanager.fotosprediais(
	endereco varchar(40),
	localizacao varchar(256),
	primary key(localizacao),
	foreign key(endereco) references condomanager.condominio(endereco)
 
 )

 create table condomanager.logs(
	id  int not null Identity(1,1),
	data datetime not null,
	command varchar(10),
	descricao varchar(100),
	primary key(id)
 )




