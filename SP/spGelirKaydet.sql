USE [AYS]
GO

/****** Object:  StoredProcedure [dbo].[spGelirKaydet]    Script Date: 24.04.2017 01:36:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		Burak Portakal
-- Create date: 23/04/2017
-- Description:	Gelir kaydetme işlemi. @gelirAdi ="Elektrik,su,doğalgaz,kira", @daireKapiNo = müşterinin kaldığı dairenin kapı nosu
-- @binaAdi= "Lale1,Lale2"
-- =============================================
CREATE PROCEDURE [dbo].[spGelirKaydet](@gelirAdi nvarchar(50),@gelirTutari float
,@gelirTarihi Datetime,@daireKapiNo int,@binaAdi nvarchar(50),@gelirAciklama nvarchar(512),@gelirKayitTarihi datetime,@gelirKayitEdenYoneticiId int,@kiraDonemi nvarchar(50))
AS
BEGIN
declare @daireNo int
declare @tcKimlikNo nvarchar(11)
declare @odenmesiGerekenKira float
set @daireNo=(select tbl_Daireler.daire_no 
					 from tbl_Daireler
					 where tbl_Daireler.daire_kapi_no=@daireKapiNo 
					 and tbl_Daireler.bina_id=
							(select bina_id 
							from tbl_Binalar 
							where bina_adi=@binaAdi))
set @tcKimlikNo = (select tbl_Musteriler.musteri_tc_kimlik_no
			from tbl_Musteriler 
			where tbl_Musteriler.daire_no=@daireNo	 
			and tbl_Musteriler.musteri_yetki=1)
set @odenmesiGerekenKira =(select tbl_Musteriler.musteri_kira_tutari from tbl_Musteriler where tbl_Musteriler.musteri_tc_kimlik_no=@tcKimlikNo)
INSERT INTO [dbo].[tbl_Gelir]
           ([gelir_turu_id]
           ,[gelir_tutari]
           ,[gelir_tarihi]
           ,[musteri_tc_kimlik_no]
           ,[gelir_aciklama]
           ,[gelir_kayit_tarihi]
           ,[gelir_kayit_eden_yonetici_id])
     VALUES
           ((select gelir_turu_id from tbl_GelirTuru where tbl_GelirTuru.gelir_adi=@gelirAdi),
		   @gelirTutari,
		   @gelirTarihi,
		   @tcKimlikNo,
		   @gelirAciklama,
		   @gelirKayitTarihi,
		   @gelirKayitEdenYoneticiId
		   )
if (@gelirAdi='Kira')
begin
UPDATE [dbo].[tbl_Kiralar]
   SET [kira_durumu] = CASE WHEN @odenmesiGerekenKira=@gelirTutari THEN 1 ELSE 0 END,
	   [kira_odenen_tutar] = @gelirTutari,
	   [kira_aciklama] =@gelirAciklama
 WHERE tbl_Kiralar.daire_no=@daireNo and tbl_Kiralar.kira_donemi=@kiraDonemi	   
 end
end


GO


