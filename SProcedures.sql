
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
	
	insert into condomanager.pagamento_servicos(id_fatura, data, quantia, descricao, nif_gestor)
	select id_fatura, data, quantia, descricao, id_consumidor from condomanager.Fatura_servicos where id_fatura = @id_to

update condomanager.fatura_servicos
	set id_pagamento = 
	(select condomanager.pagamento_servicos.id from condomanager.pagamento_servicos join condomanager.fatura_servicos on 
		condomanager.pagamento_servicos.id_fatura=condomanager.fatura_servicos.id_fatura where condomanager.Fatura_Servicos.Id_Fatura = @id_to)
	where id_fatura = @id_to
end;
go




