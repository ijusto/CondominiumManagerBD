
use condomanagerdb
go



Create procedure showcomplaints (@endereco as varchar(40)) as
begin
	select * from condomanager.Reclamacao where endereco = @endereco 
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

create trigger timepaid
on condomanager.pagamento_servicos
After insert
as
	update condomanager.Pagamento_Servicos
	set Data = GETDATE()
	where ID in (Select max(id) from condomanager.Pagamento_Servicos)

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






create trigger log_meetings on condomanager.reuniao after insert, update, delete as
begin 
		DECLARE @operation CHAR(6)
		SET @operation = CASE
				WHEN EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted)
					THEN 'Update'
				WHEN EXISTS(SELECT * FROM inserted)
					THEN 'Insert'
				WHEN EXISTS(SELECT * FROM deleted)
					THEN 'Delete'
				ELSE NULL
		end
			IF @operation = 'Delete'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Apagada reunião com o id', STR(d.id))
			FROM deleted d
 
			IF @operation = 'Insert'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Criada reunião com o id', STR(i.id))
			FROM inserted i
 
			IF @operation = 'Update'
			INSERT INTO condomanager.logs (Command, data, descricao)
				SELECT @operation, GETDATE(), Concat('Modificada reunião com o id ', STR(d.id), 'Para o id: ', STR(i.id))
			FROM deleted d, inserted i
END
GO



