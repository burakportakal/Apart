USE [AYS]
GO

/****** Object:  StoredProcedure [dbo].[spGelirListesi]    Script Date: 24.04.2017 01:38:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spGelirListesi]
as
begin
SELECT        tbl_Binalar.bina_adi, tbl_Daireler.daire_kapi_no, tbl_Musteriler.musteri_adi, tbl_Musteriler.musteri_soyadi, tbl_Gelir.gelir_tutari, tbl_Gelir.gelir_tarihi, tbl_GelirTuru.gelir_adi
FROM            tbl_GelirTuru INNER JOIN
                         tbl_Gelir ON tbl_GelirTuru.gelir_turu_id = tbl_Gelir.gelir_turu_id INNER JOIN
                         tbl_Musteriler ON tbl_Gelir.musteri_tc_kimlik_no = tbl_Musteriler.musteri_tc_kimlik_no INNER JOIN
                         tbl_Binalar INNER JOIN
                         tbl_Daireler ON tbl_Binalar.bina_id = tbl_Daireler.bina_id ON tbl_Musteriler.daire_no = tbl_Daireler.daire_no
end
GO


