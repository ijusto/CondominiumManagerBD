--use p2g8
use condomanagerdb
go

create function condomanager.calcquota (@ref_fracao as varchar(5), @endereco as varchar(40)) returns money as
begin
	declare @valorquota money
	select @valorquota = (Orcam_Anual*(Permilagem /1000)) from condomanager.Fracao join 
	condomanager.Condominio on condomanager.fracao.Endereco=condomanager.Condominio.Endereco where Ref_fracao = @ref_fracao and condomanager.fracao.Endereco = @endereco
	Return @valorquota;
end;
go

create function condomanager.authenticate (@nif as varchar(9), @password as varchar(256)) returns bit as
begin
	declare @authed bit; 
	IF exists( select * from condomanager.Gestor_Condominio where nif=@nif and hashed_pass = @password)
		set @authed = 1
	else
		set @authed = 0
	return @authed
end;
go