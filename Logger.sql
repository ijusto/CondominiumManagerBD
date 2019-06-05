use condomanagerdb
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

create trigger log_repairs on condomanager.reuniao after insert, update, delete as
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
			SELECT @operation, GETDATE(), Concat('Apagada reparação com o id', STR(d.id))
			FROM deleted d
 
			IF @operation = 'Insert'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Criada reparação com o id', STR(i.id))
			FROM inserted i
 
			IF @operation = 'Update'
			INSERT INTO condomanager.logs (Command, data, descricao)
				SELECT @operation, GETDATE(), Concat('Modificada reparação com o id ', STR(d.id), 'Para o id: ', STR(i.id))
			FROM deleted d, inserted i
END
GO

create trigger log_condo on condomanager.condominio after insert, update, delete as
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
			SELECT @operation, GETDATE(), Concat('Apagado condominio', d.Endereco)
			FROM deleted d
 
			IF @operation = 'Insert'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Criado condominio', i.Endereco)
			FROM inserted i
 
			IF @operation = 'Update'
			INSERT INTO condomanager.logs (Command, data, descricao)
				SELECT @operation, GETDATE(), Concat('Modificado condominio', d.Endereco)
			FROM deleted d, inserted i
END
GO

create trigger log_condomino on condomanager.condomino after insert, update, delete as
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
			SELECT @operation, GETDATE(), Concat('Apagado condomino com o nif', d.NIF)
			FROM deleted d
 
			IF @operation = 'Insert'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Criado condomino com o nif', i.NIF)
			FROM inserted i
 
			IF @operation = 'Update'
			INSERT INTO condomanager.logs (Command, data, descricao)
				SELECT @operation, GETDATE(), Concat('Modificada reparação com o id ', d.NIF)
			FROM deleted d, inserted i
END

GO
create trigger log_fracao on condomanager.fracao after insert, update, delete as
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
			SELECT @operation, GETDATE(), Concat('Apagada fracao', d.Ref_fracao, 'do condominio', d.Endereco)
			FROM deleted d
 
			IF @operation = 'Insert'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Criada fracao', i.Ref_fracao, 'do condominio', i.Endereco)
			FROM inserted i
 
			IF @operation = 'Update'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Modificada fracao', i.Ref_fracao, 'do condominio', i.Endereco)
			FROM deleted d, inserted i
END
GO

create trigger log_servicos on condomanager.fornecedor_servicos after insert, update, delete as
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
			SELECT @operation, GETDATE(), Concat('Apagado fornecedor com o NIF', d.NIF)
			FROM deleted d
 
			IF @operation = 'Insert'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Criado fornecedor com o NIF', i.NIF)
			FROM inserted i
 
			IF @operation = 'Update'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Modificado fornecedor com o NIF', i.NIF)
			FROM deleted d, inserted i
END
GO

create trigger log_fatura_quotas on condomanager.fatura_quotas after insert, update, delete as
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
			SELECT @operation, GETDATE(), Concat('Apagada Fatura de quotas com o ID', d.Id_Fatura)
			FROM deleted d
 
			IF @operation = 'Insert'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Criada Fatura de quotas com o ID', i.Id_Fatura)
			FROM inserted i
 
			IF @operation = 'Update'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Modificada Fatura de quotas com o ID', i.Id_Fatura)
			FROM deleted d, inserted i
END
GO

create trigger log_pagamento_quotas on condomanager.pagamento_quotas after insert, update, delete as
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
			SELECT @operation, GETDATE(), Concat('Paga Fatura de quotas com o ID', d.Id_Fatura)
			FROM deleted d
 
			IF @operation = 'Insert'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('De paga a não paga a Fatura de quotas com o ID', i.Id_Fatura)
			FROM inserted i
 
			IF @operation = 'Update'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Modificado o pagamento da Fatura de quotas com o ID', i.Id_Fatura)
			FROM deleted d, inserted i
END
GO

create trigger log_fatura_servicos on condomanager.fatura_servicos after insert, update, delete as
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
			SELECT @operation, GETDATE(), Concat('Apagada Fatura de serviços com o ID', d.Id_Fatura)
			FROM deleted d
 
			IF @operation = 'Insert'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Criada Fatura de serviços com o ID', i.Id_Fatura)
			FROM inserted i
 
			IF @operation = 'Update'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Modificada Fatura de serviços com o ID', i.Id_Fatura)
			FROM deleted d, inserted i
END
GO

create trigger log_pagamento_servicos on condomanager.pagamento_servicos after insert, update, delete as
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
			SELECT @operation, GETDATE(), Concat('Paga Fatura de serviços com o ID', d.Id_Fatura)
			FROM deleted d
 
			IF @operation = 'Insert'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('De paga a não paga a Fatura de serviços com o ID', i.Id_Fatura)
			FROM inserted i
 
			IF @operation = 'Update'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Modificado o pagamento da Fatura de serviços com o ID', i.Id_Fatura)
			FROM deleted d, inserted i
END
GO

create trigger log_fotosprediais on condomanager.fotosprediais after insert, update, delete as
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
			SELECT @operation, GETDATE(), Concat('Adicionada foto para o prédio: ', d.endereco)
			FROM deleted d
 
			IF @operation = 'Insert'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Removida foto do prédio', i.endereco)
			FROM inserted i
 
			IF @operation = 'Update'
			INSERT INTO condomanager.logs (Command, data, descricao)
			SELECT @operation, GETDATE(), Concat('Modificada a foto do prédio', i.endereco)
			FROM deleted d, inserted i
END
GO