
use condomanagerdb
go



Create procedure showcomplaints (@endereco as varchar(40)) as
begin
	select * from condomanager.Reclamacao where endereco = @endereco 
end;
go

create procedure showcontacts (@endereco as varchar(40)) as
begin
	select * from condomanager.condomino join condomanager.fracao on nif=nif_condomino where endereco=@endereco
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

create trigger timepaid
on condomanager.pagamento_servicos
After insert
as
	update condomanager.Pagamento_Servicos
	set Data = GETDATE()
	where ID in (Select max(id) from condomanager.Pagamento_Servicos)

go

create procedure showevents (@date as date, @condo as varchar(40)) as
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
