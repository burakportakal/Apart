USE [AYS]
GO

/****** Object:  StoredProcedure [dbo].[spFatura]    Script Date: 8.05.2017 00:49:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[spFatura]
as
begin
	SELECT       tbl_FaturaAboneNo.fatura_id as 'Fatura Id',
				 tbl_FaturaTuru.fatura_adi as 'Fatura Adý',
				  tbl_FaturaAboneNo.fatura_abone_no as 'Abone No',
				  tbl_Binalar.bina_adi as 'Apart Adý'

FROM            tbl_FaturaTuru INNER JOIN
                         tbl_FaturaAboneNo ON tbl_FaturaTuru.fatura_turu_id = tbl_FaturaAboneNo.fatura_turu_id INNER JOIN
                         tbl_Binalar ON tbl_FaturaAboneNo.bina_id = tbl_Binalar.bina_id
end


GO


