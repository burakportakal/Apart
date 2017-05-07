USE [AYS]
GO

/****** Object:  StoredProcedure [dbo].[spFaturaGuncelle]    Script Date: 8.05.2017 00:50:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[spFaturaGuncelle](@faturaId int,@ortak1Id int,@ortak2Id int,@faturaTuru nvarchar(50),@binaAdi nvarchar(50),@aboneNo varchar(50),@ortak1 int,@ortak2 int,@sonuc int output)
as
begin
	
	declare @faturaTuruId int =(select fatura_turu_id from tbl_FaturaTuru where fatura_adi=@faturaTuru)
	declare @binaId int =(select bina_id from tbl_Binalar where bina_adi=@binaAdi)
	declare @daireNo1 int =(select daire_no from tbl_Daireler where bina_id=@binaId and daire_kapi_no= @ortak1)
	declare @daireNo2 int =CASE when @ortak2=0 Then 0 else (select daire_no from tbl_Daireler where bina_id=@binaId and daire_kapi_no= @ortak2) end

	UPDATE [dbo].[tbl_FaturaAboneNo]
            set [fatura_abone_no] =@aboneNo
           ,[bina_id]=@binaId
           ,[fatura_turu_id]=@faturaTuruId
    where tbl_FaturaAboneNo.fatura_id=@faturaId

	UPDATE [dbo].[tbl_OrtakFatura]
           set [fatura_abone_no]=@aboneNo
           ,[daire_no] =@daireNo1
		where tbl_OrtakFatura.id=@ortak1Id

	if @daireNo2 != 0
	begin
	UPDATE[dbo].[tbl_OrtakFatura]
           set [fatura_abone_no]=@aboneNo
           ,[daire_no]=@daireNo2
     where
          tbl_OrtakFatura.id=@ortak2Id
	end
	else
	begin
		delete from tbl_OrtakFatura where tbl_OrtakFatura.id=@ortak2Id
	end
	set @sonuc = (select tbl_FaturaAboneNo.fatura_id from tbl_FaturaAboneNo where tbl_FaturaAboneNo.fatura_abone_no=@aboneNo)
	return
end


GO


