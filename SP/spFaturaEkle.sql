USE [AYS]
GO

/****** Object:  StoredProcedure [dbo].[spFaturaEkle]    Script Date: 8.05.2017 00:50:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[spFaturaEkle](@faturaTuru nvarchar(50),@binaAdi nvarchar(50),@aboneNo varchar(50),@ortak1 int,@ortak2 int,@sonuc int output)
as
begin
	declare @faturaTuruId int =(select fatura_turu_id from tbl_FaturaTuru where fatura_adi=@faturaTuru)
	declare @binaId int =(select bina_id from tbl_Binalar where bina_adi=@binaAdi)
	declare @daireNo1 int =(select daire_no from tbl_Daireler where bina_id=@binaId and daire_kapi_no= @ortak1)
	declare @daireNo2 int =CASE when @ortak2=0 Then 0 else (select daire_no from tbl_Daireler where bina_id=@binaId and daire_kapi_no= @ortak2) end

	INSERT INTO [dbo].[tbl_FaturaAboneNo]
           ([fatura_abone_no]
           ,[bina_id]
           ,[fatura_turu_id])
     VALUES
           (@aboneNo,@binaId,@faturaTuruId)

	INSERT INTO [dbo].[tbl_OrtakFatura]
           ([fatura_abone_no]
           ,[daire_no])
     VALUES
           (@aboneNo,@daireNo1)

	if @daireNo2 != 0
	begin
	INSERT INTO [dbo].[tbl_OrtakFatura]
           ([fatura_abone_no]
           ,[daire_no])
     VALUES
           (@aboneNo,@daireNo2)
	end
	set @sonuc = (select tbl_FaturaAboneNo.fatura_id from tbl_FaturaAboneNo where tbl_FaturaAboneNo.fatura_abone_no=@aboneNo)
	return
end


GO


