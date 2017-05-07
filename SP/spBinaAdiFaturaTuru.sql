USE [AYS]
GO
/****** Object:  StoredProcedure [dbo].[spFatura]    Script Date: 7.05.2017 23:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spBinaAdiFaturaTuru](@apartAdi nvarchar(50),@faturaTuru nvarchar(50))
as
begin
declare @binaId int =(select tbl_Binalar.bina_id from tbl_Binalar where tbl_Binalar.bina_adi=@apartAdi)
declare @faturaTuruýd int =(select tbl_FaturaTuru.fatura_turu_id from tbl_FaturaTuru where tbl_FaturaTuru.fatura_adi=@faturaTuru)
	SELECT     
					tbl_FaturaAboneNo.fatura_abone_no as 'Abone No'

	FROM			tbl_FaturaAboneNo 

	WHERE			tbl_FaturaAboneNo.bina_id=@binaId and tbl_FaturaAboneNo.fatura_turu_id=@faturaTuruýd
end

