USE [AYS]
GO

/****** Object:  StoredProcedure [dbo].[spGelirKaydet]    Script Date: 8.05.2017 00:51:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		Burak Portakal
-- Create date: 23/04/2017
-- Description:	Gelir kaydetme iþlemi. @gelirAdi ="Elektrik,su,doðalgaz,kira", @daireKapiNo = müþterinin kaldýðý dairenin kapý nosu
-- @binaAdi= "Lale1,Lale2"
-- =============================================
CREATE PROCEDURE [dbo].[spGelirKaydet](@gelirAdi nvarchar(50),@gelirTutari float
,@gelirTarihi Datetime,@daireKapiNo int,@binaAdi nvarchar(50),@tcKimlikNo nvarchar(11),@gelirAciklama nvarchar(512),@gelirKayitTarihi datetime,@gelirKayitEdenYoneticiId int,@kiraDonemi nvarchar(50),
 @sonuc int output)
AS
BEGIN
declare @daireNo int
declare @odenmesiGerekenKira float
declare @odenenKira float
set @daireNo=(select tbl_Daireler.daire_no 
					 from tbl_Daireler
					 where tbl_Daireler.daire_kapi_no=@daireKapiNo 
					 and tbl_Daireler.bina_id=
							(select bina_id 
							from tbl_Binalar 
							where bina_adi=@binaAdi))
set @odenmesiGerekenKira =(select tbl_Musteriler.musteri_kira_tutari from tbl_Musteriler where tbl_Musteriler.musteri_tc_kimlik_no=@tcKimlikNo)
set @odenenKira =(select tbl_Kiralar.kira_odenen_tutar from tbl_Kiralar where tbl_Kiralar.daire_no=@daireNo and tbl_Kiralar.kira_donemi=@kiraDonemi)
if(@odenmesiGerekenKira=@odenenKira)
 begin
 set @sonuc = 0
 return
end
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
   SET [kira_durumu] = CASE WHEN @odenmesiGerekenKira=@gelirTutari+@odenenKira THEN 1 ELSE 0 END,
	   [kira_odenen_tutar] = @gelirTutari+@odenenKira,
	   [kira_aciklama] =@gelirAciklama
 WHERE tbl_Kiralar.daire_no=@daireNo and tbl_Kiralar.kira_donemi=@kiraDonemi	   
 end
set @sonuc = 1
return
end


GO


