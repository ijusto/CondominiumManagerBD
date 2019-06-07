
use condomanagerdb
go



Create procedure showcomplaints (@endereco as varchar(40)) as
begin
	select * from condomanager.Reclamacao left outer join condomanager.Condomino on nif_condomino=nif
	 where endereco = @endereco or endereco_cond = @endereco
end;
go

create procedure showcontacts (@endereco as varchar(40)) as
begin
	Select distinct(NIF), nome, telemovel, email from condomanager.condomino join condomanager.fracao on nif=nif_condomino where endereco = @endereco

end;
go

create procedure showreadings (@endereco as varchar(40), @piso as varchar(10)) as
begin
	select * from condomanager.condomino join condomanager.fracao on nif=nif_condomino where endereco=@endereco and piso=@piso
end;
go

create procedure markaspaid (@id_to as int)  as
begin
	
	insert into condomanager.pagamento_servicos(id_fatura, data, quantia, descricao)
		select id_fatura, data, quantia, descricao from condomanager.Fatura_servicos where id_fatura = @id_to

end;
go

create procedure markaspaidquota (@id_to as int)  as
begin
	
	insert into condomanager.pagamento_quotas(id_fatura, data, valor, descricao)
		select id_fatura, data, quantia, descricao from condomanager.Fatura_quotas where id_fatura = @id_to

end;
go

create trigger timepaid
on condomanager.pagamento_servicos
After insert
as
	update condomanager.Pagamento_Servicos
	set Data = GETDATE()
	where ID in (Select max(id) from condomanager.Pagamento_Servicos)

go
create trigger timepaidquotas
on condomanager.pagamento_quotas
After insert
as
	update condomanager.Pagamento_quotas
	set Data = GETDATE()
	where ID in (Select max(id) from condomanager.Pagamento_quotas)

go


create procedure showmeetings (@date as date, @condo as varchar(40)) as
begin
	select * from condomanager.Reuniao where data = @date and endereco = @condo
end;
go

create procedure showrepairs (@date as date, @condo as varchar(40)) as
begin
	select * from condomanager.Reparacao where data = @date and endereco = @condo
end;
go

create procedure getpiso(@ref_fracao as varchar(5), @endereco as varchar(40), @strpiso as varchar(10) output) as
begin
	select @strpiso = piso from condomanager.Fracao where Ref_fracao=@ref_fracao and Endereco=@endereco
	return
end;
go

create procedure getinfo(@id_complaint as int) as
begin
	select Nome, Telemovel from condomanager.Reclamacao join condomanager.Condomino on nif_condomino = nif where id = @id_complaint
end;
go


create procedure getsupplier as
begin
	select NIF, Nome, telemovel, morada, descricao from condomanager.Fornecedor_Servicos join condomanager.Tipo_Fornecedor on tipo = Id
end;
go

create procedure getsuppliernif(@nif as varchar(9)) as
begin
	select NIF, Nome, telemovel, morada, descricao from condomanager.Fornecedor_Servicos join condomanager.Tipo_Fornecedor on tipo = Id
	 where condomanager.Fornecedor_Servicos.NIF = @nif
end;
go

create function calcquota (@ref_fracao as varchar(5), @endereco as varchar(40)) returns money as
begin
	declare @valorquota money
	select @valorquota = (Orcam_Anual*(Permilagem /1000)) from condomanager.Fracao join 
	condomanager.Condominio on condomanager.fracao.Endereco=condomanager.Condominio.Endereco where Ref_fracao = @ref_fracao and condomanager.fracao.Endereco = @endereco
	Return @valorquota;
end;
go


create procedure insertmeeting (@nome as varchar(40), @data as date, @descricao as varchar(100), @localizacao as varchar(40), @endereco as varchar(40)) as
begin
	insert into condomanager.Reuniao(Nome, Data, Descricao, localizacao, endereco) values
		(@nome, @data, @descricao, @localizacao, @endereco)
end;
go

create procedure insertrepair (@nome as varchar(40), @data as date, @descricao as varchar(100), @danificado as varchar(40), @endereco as varchar(40)) as
begin
	insert into condomanager.Reparacao(Nome, Data, Descricao, Danificado, endereco) values
		(@nome, @data, @descricao, @danificado, @endereco)
end;
go

create procedure getfaturaquota (@endereco as varchar(40)) as
begin
	select id_fatura, data, descricao, ref_fracao, endereco, quantia from condomanager.fatura_quotas where endereco = @endereco
end;
go

create procedure getfaturaservico(@endereco as varchar(40)) as
begin
	select id_fatura, data, nif_fornec, endereco, quantia, descricao from condomanager.fatura_servicos where endereco = @endereco
end;
go


create procedure gettenantnifname(@ref_fracao as varchar(5), @endereco as varchar(40)) as
begin
	select condomanager.condomino.nif as nif, nome from condomanager.fracao join condomanager.condomino on nif_condomino = nif where ref_fracao = @ref_fracao and endereco = @endereco
end;
go

create procedure getreadings (@endereco as varchar(40)) as
begin
	select ref_fracao,permilagem, endereco, piso, leitura_gas, leitura_luz, leitura_agua, nome, email, telemovel from
	condomanager.Fracao join condomanager.Condomino on nif_condomino = NIF
	where endereco = @endereco
end;
go

create procedure ispaidquotas (@id_fatura as int) as
begin
	select * from condomanager.pagamento_quotas where id_fatura = @id_fatura
end;
go

create procedure ispaidservicos (@id_fatura as int) as
begin
	select * from condomanager.pagamento_servicos where id_fatura = @id_fatura
end;
go

create procedure getmanager (@endereco as varchar(40)) as
begin
	select * from condomanager.condominio where endereco = @endereco
end;
go

create procedure addtenant(@NIF as varchar(9), @Nome as VARCHAR(40), @Telemovel as VARCHAR(9) , @Email as VARCHAR(40)) as
begin
	insert into condomanager.Condomino(nif, nome, telemovel, email) values
		(@nif, @nome, @telemovel, @email)
end;
go

create procedure edittenant(@NIF as varchar(9), @Nome as VARCHAR(40), @Telemovel as VARCHAR(9) , @Email as VARCHAR(40)) as
begin
	update condomanager.Condomino
	set nome=@Nome, Telemovel=@Telemovel, Email=@Email
	where NIF = @NIF
end;
go

create procedure deletetenant(@NIF as varchar(9)) as
begin
	delete from condomanager.Condomino where NIF = @NIF
end;
go

create procedure addsp(@NIF as varchar(9), @Nome as varchar(20), @Telemovel as varchar(9), @Morada as varchar(40), @tipo as int) as
begin
	insert into condomanager.Fornecedor_Servicos(nif, nome, Telemovel, Morada, tipo) values
		(@nif, @nome, @Telemovel, @Morada, @tipo)
end;
go

create procedure editsp(@NIF as varchar(9), @Nome as varchar(20), @Telemovel as varchar(9), @Morada as varchar(40)) as
begin
	update condomanager.Fornecedor_Servicos
	set nome=@nome, Telemovel=@Telemovel, Morada = @morada
	where NIF = @NIF
end;
go

create procedure deletesp(@NIF as varchar(9)) as
begin
	delete from condomanager.Fornecedor_Servicos where nif = @nif
end;
go

create procedure deleterec(@id as int) as
begin
	delete from condomanager.Reclamacao where id = @id
end;
go

create procedure deletemeeting(@id as int) as
begin
	delete from condomanager.Reuniao where id = @id
end;
go

create procedure deleterepair(@id as int) as 
begin
	delete from condomanager.Reparacao where id=@id
end;
go

create procedure editmeeting(@id as int, @nome as varchar(40), @localizacao as varchar(40), @descricao as varchar(100)) as
begin
	update condomanager.Reuniao
	set nome = @nome, localizacao=@localizacao, Descricao=@descricao
	where id = @id
end;
go

create procedure editrepair(@id as int, @nome as varchar(40), @danificado as varchar(40), @descricao as varchar(100)) as
begin
		update condomanager.Reparacao
		set nome = @nome, danificado=@danificado, Descricao=@descricao
		where id = @id
end;
go
	

create function authenticate (@nif as varchar(9), @password as varchar(256)) returns bit as
begin
	declare @authed bit; 
	IF exists( select * from condomanager.Gestor_Condominio where nif=@nif and hashed_pass = @password)
	set @authed = 1
	else
		set @authed = 0
	return @authed
end;
go



	









