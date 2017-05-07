USE [AYS]
GO

/****** Object:  StoredProcedure [dbo].[spFaturaOrtakDaire]    Script Date: 8.05.2017 00:50:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[spFaturaOrtakDaire](@aboneNo nvarchar(50))
as
begin
declare @faturaId int= (select tbl_FaturaAboneNo.fatura_turu_id from tbl_FaturaAboneNo where tbl_FaturaAboneNo.fatura_abone_no=@aboneNo)
	SELECT       tbl_Daireler.daire_kapi_no as 'Daire Kapý No',
				 tbl_Daireler.daire_no as 'Daire No'

FROM            tbl_OrtakFatura INNER JOIN
                         tbl_Daireler ON tbl_OrtakFatura.daire_no = tbl_Daireler.daire_no INNER JOIN
						 tbl_FaturaAboneNo ON tbl_OrtakFatura.fatura_abone_no=tbl_FaturaAboneNo.fatura_abone_no
WHERE
				tbl_OrtakFatura.fatura_abone_no=@aboneNo and tbl_FaturaAboneNo.fatura_turu_id=@faturaId
end


GO


