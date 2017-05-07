USE [AYS]
GO

/****** Object:  StoredProcedure [dbo].[spKiraSorgula]    Script Date: 8.05.2017 00:52:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spKiraSorgula](@kiraDonemi varchar(50),@kiraDurumu bit,@binaAdi nvarchar(50),@yetkili bit,@daireNo int)
AS
BEGIN
SELECT        
			  tbl_Kiralar.kira_donemi as 'Kira Dönemi',
			  tbl_Musteriler.musteri_tc_kimlik_no as 'TC Kimlik No',
			  tbl_Musteriler.musteri_adi as 'Adý',
			  tbl_Musteriler.musteri_soyadi as 'Soyadý',
			  tbl_Musteriler.musteri_telefon_no as 'Telefon',
			  tbl_Musteriler.musteri_email as 'Email', 
			  tbl_Binalar.bina_adi as 'Apart Adý',
			  tbl_Daireler.daire_kapi_no as 'Daire Kapý No',
			  tbl_Kiralar.kira_durumu as 'Kira Durumu',
			  tbl_Musteriler.musteri_kira_tutari as 'Kira Miktarý',
			  tbl_Kiralar.kira_odenen_tutar as 'Odenen Tutar',
			  tbl_Musteriler.musteri_yetki as 'Yetkili'
			  
FROM            tbl_Kiralar INNER JOIN
                         tbl_Daireler ON tbl_Kiralar.daire_no = tbl_Daireler.daire_no INNER JOIN
						 tbl_Binalar ON tbl_Daireler.bina_id = tbl_Binalar.bina_id INNER JOIN
                         tbl_Musteriler ON tbl_Kiralar.daire_no = tbl_Musteriler.daire_no
Where
			kira_donemi=CASE WHEN @kiraDonemi='' THEN kira_donemi ELSE @kiraDonemi END --and kira_durumu=@kiraDurumu
			 and
			bina_adi=CASE WHEN @binaAdi='' THEN bina_adi ELSE @binaAdi END and musteri_yetki= CASE WHEN @yetkili=1 THEN @yetkili ELSE musteri_yetki END
				  and daire_kapi_no= CASE WHEN @daireNo=0 THEN daire_kapi_no ELSE @daireNo END 
Order by kira_donemi
END

GO


