
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




