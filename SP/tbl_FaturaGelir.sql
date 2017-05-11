USE [AYS]
GO

/****** Object:  Table [dbo].[tbl_FaturaGelir]    Script Date: 11.05.2017 03:02:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_FaturaGelir](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fatura_abone_no] [nvarchar](50) NOT NULL,
	[fatura_odenen_tutar] [float] NOT NULL,
	[daire_no] [nvarchar](50) NULL,
	[fatura_donemi] [nvarchar](50) NOT NULL,
	[fatura_odeme_tarihi] [datetime] NOT NULL,
	[gelir_kaydeden_yonetici_id] [int] NOT NULL,
 CONSTRAINT [PK_tblFaturaGelir] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


