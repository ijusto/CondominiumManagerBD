	
--use [p2g8]
use condomanagerdb
go


Create procedure condomanager.showphoto (@endereco as varchar(40)) as
begin
	select localizacao from condomanager.fotosprediais
	 where endereco = @endereco
end;
go

create view condomanager.getsupplierview as 
	select NIF, Nome, telemovel, morada, descricao from condomanager.Fornecedor_Servicos join condomanager.Tipo_Fornecedor on tipo = Id
go

create view condomanager.view_condos as
	select endereco from condomanager.Condominio
go

Create procedure condomanager.showcomplaints (@endereco as varchar(40)) as
begin
	select * from condomanager.Reclamacao left outer join condomanager.Condomino on nif_condomino=nif
	 where endereco = @endereco
end;
go

create procedure condomanager.showcontacts (@endereco as varchar(40)) as
begin
	Select distinct(NIF), nome, telemovel, email, ref_fracao, endereco from condomanager.condomino join condomanager.fracao on nif=nif_condomino where endereco = @endereco
end;
go


create procedure condomanager.markaspaid (@id_to as int)  as
begin
	
	insert into condomanager.pagamento_servicos(id_fatura, data, quantia, descricao)
		select id_fatura, data, quantia, descricao from condomanager.Fatura_servicos where id_fatura = @id_to

end;
go

create procedure condomanager.markaspaidquota (@id_to as int)  as
begin
	
	insert into condomanager.pagamento_quotas(id_fatura, data, valor, descricao)
		select id_fatura, data, quantia, descricao from condomanager.Fatura_quotas where id_fatura = @id_to

end;
go

create procedure condomanager.showmeetings (@date as date, @condo as varchar(40)) as
begin
	select * from condomanager.Reuniao where data = @date and endereco = @condo
end;
go

create procedure condomanager.showrepairs (@date as date, @condo as varchar(40)) as
begin
	select * from condomanager.Reparacao where data = @date and endereco = @condo
end;
go

create procedure condomanager.getpiso(@ref_fracao as varchar(5), @endereco as varchar(40), @strpiso as varchar(10) output) as
begin
	select @strpiso = piso from condomanager.Fracao where Ref_fracao=@ref_fracao and Endereco=@endereco
	return
end;
go

create procedure condomanager.getinfo(@id_complaint as int) as
begin
	select Nome, Telemovel from condomanager.Reclamacao join condomanager.Condomino on nif_condomino = nif where id = @id_complaint
end;
go


create procedure condomanager.getsupplier as
begin
	select NIF, Nome, telemovel, morada, descricao from condomanager.Fornecedor_Servicos join condomanager.Tipo_Fornecedor on tipo = Id
end;
go

create procedure condomanager.getsuppliernif(@nif as varchar(9)) as
begin
	select NIF, Nome, telemovel, morada, descricao from condomanager.Fornecedor_Servicos join condomanager.Tipo_Fornecedor on tipo = Id
	 where condomanager.Fornecedor_Servicos.NIF = @nif
end;
go


create procedure condomanager.insertmeeting (@nome as varchar(40), @data as date, @descricao as varchar(100), @localizacao as varchar(40), @endereco as varchar(40)) as
begin
	insert into condomanager.Reuniao(Nome, Data, Descricao, localizacao, endereco) values
		(@nome, @data, @descricao, @localizacao, @endereco)
end;
go

create procedure condomanager.insertrepair (@nome as varchar(40), @data as date, @descricao as varchar(100), @danificado as varchar(40), @endereco as varchar(40)) as
begin
	insert into condomanager.Reparacao(Nome, Data, Descricao, Danificado, endereco) values
		(@nome, @data, @descricao, @danificado, @endereco)
end;
go

create procedure condomanager.getfaturaquota (@endereco as varchar(40)) as
begin
	select id_fatura, data, descricao, ref_fracao, endereco, quantia from condomanager.fatura_quotas where endereco = @endereco
end;
go

create procedure condomanager.getfaturaservico(@endereco as varchar(40)) as
begin
	select id_fatura, data, nif_fornec, endereco, quantia, descricao from condomanager.fatura_servicos where endereco = @endereco
end;
go


create procedure condomanager.gettenantnifname(@ref_fracao as varchar(5), @endereco as varchar(40)) as
begin
	select condomanager.condomino.nif as nif, nome from condomanager.fracao join condomanager.condomino on nif_condomino = nif where ref_fracao = @ref_fracao and endereco = @endereco
end;
go

create procedure condomanager.getreadings (@endereco as varchar(40)) as
begin
	select ref_fracao,permilagem, endereco, piso, leitura_gas, leitura_luz, leitura_agua, nome, email, telemovel from
	condomanager.Fracao join condomanager.Condomino on nif_condomino = NIF
	where endereco = @endereco
end;
go

create procedure condomanager.ispaidquotas (@id_fatura as int) as
begin
	select * from condomanager.pagamento_quotas where id_fatura = @id_fatura
end;
go

create procedure condomanager.ispaidservicos (@id_fatura as int) as
begin
	select * from condomanager.pagamento_servicos where id_fatura = @id_fatura
end;
go

create procedure condomanager.getmanager (@endereco as varchar(40)) as
begin
	select * from condomanager.condominio where endereco = @endereco
end;
go

create procedure condomanager.addtenant(@NIF as varchar(9), @Nome as VARCHAR(40), @Telemovel as VARCHAR(9) , @Email as VARCHAR(40), @endereco as varchar(40), @ref_fracao as varchar(5)) as
begin
	insert into condomanager.Condomino(nif, nome, telemovel, email) values
		(@nif, @nome, @telemovel, @email)
	update condomanager.Fracao
	set nif_condomino = @nif
	where endereco = @endereco and ref_fracao = @ref_fracao
end;
go

create procedure condomanager.edittenant(@NIF as varchar(9), @Nome as VARCHAR(40), @Telemovel as VARCHAR(9) , @Email as VARCHAR(40)) as
begin
	update condomanager.Condomino
	set nome=@Nome, Telemovel=@Telemovel, Email=@Email
	where NIF = @NIF
end;
go

create procedure condomanager.deletetenant(@NIF as varchar(9)) as
begin
	delete from condomanager.Condomino where NIF = @NIF
end;
go

create procedure condomanager.addsp(@NIF as varchar(9), @Nome as varchar(20), @Telemovel as varchar(9), @Morada as varchar(40), @tipo as int) as
begin
	insert into condomanager.Fornecedor_Servicos(nif, nome, Telemovel, Morada, tipo) values
		(@nif, @nome, @Telemovel, @Morada, @tipo)
end;
go

create procedure condomanager.editsp(@NIF as varchar(9), @Nome as varchar(20), @Telemovel as varchar(9), @Morada as varchar(40)) as
begin
	update condomanager.Fornecedor_Servicos
	set nome=@nome, Telemovel=@Telemovel, Morada = @morada
	where NIF = @NIF
end;
go

create procedure condomanager.deletesp(@NIF as varchar(9)) as
begin
	delete from condomanager.Fornecedor_Servicos where nif = @nif
end;
go

create procedure condomanager.deleterec(@id as int) as
begin
	delete from condomanager.Reclamacao where id = @id
end;
go

create procedure condomanager.deletemeeting(@id as int) as
begin
	delete from condomanager.Reuniao where id = @id
end;
go

create procedure condomanager.deleterepair(@id as int) as 
begin
	delete from condomanager.Reparacao where id=@id
end;
go

create procedure condomanager.editmeeting(@id as int, @nome as varchar(40), @localizacao as varchar(40), @descricao as varchar(100)) as
begin
	update condomanager.Reuniao
	set nome = @nome, localizacao=@localizacao, Descricao=@descricao
	where id = @id
end;
go

create procedure condomanager.editrepair(@id as int, @nome as varchar(40), @danificado as varchar(40), @descricao as varchar(100)) as
begin
		update condomanager.Reparacao
		set nome = @nome, danificado=@danificado, Descricao=@descricao
		where id = @id
end;
go


create procedure condomanager.createquota(@ref_fracao as varchar(5), @endereco as varchar(40), @descricao as varchar(100)) as
begin
	declare @quantia as money
	set @quantia = condomanager.calcquota(@ref_fracao, @endereco)
	insert into condomanager.Fatura_Quotas(ref_fracao, endereco, descricao, Quantia) values
	(@ref_fracao, @endereco, @descricao, @quantia)
end;
go
	

create procedure condomanager.getfreeref(@endereco as varchar(40)) as 
begin
	select ref_fracao, piso from condomanager.Fracao where nif_condomino is null and Endereco=@endereco;
end;
go

create procedure condomanager.deletequota(@id_fatura as int) as
begin
	delete from condomanager.Fatura_Quotas where Id_Fatura=@id_fatura
end;
go

create procedure condomanager.deleteservicos(@id_fatura as int) as
begin
	delete from condomanager.Fatura_Servicos where Id_Fatura=@id_fatura
end;
go

create procedure condomanager.showcontactssearch(@endereco as varchar(40), @search as varchar(50)) as 
begin
	
	Select distinct(NIF), nome, telemovel, email, ref_fracao, endereco from condomanager.condomino join condomanager.fracao on nif=nif_condomino where endereco = @endereco and
	 (nome like '%'+@search+'%' or nif like '%'+@search+'%')
end;
go

create procedure condomanager.showspsearch(@search as varchar(50)) as
begin
	select NIF, Nome, telemovel, morada, descricao from condomanager.Fornecedor_Servicos join condomanager.Tipo_Fornecedor on tipo = Id where nome like '%'+@search+'%' or nif like '%'+@search+'%'
end;
go