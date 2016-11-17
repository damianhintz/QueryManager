USE [vmap]
GO
/****** Object:  Table [dbo].[Metadane]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metadane](
	[Objid] [int] NOT NULL,
	[Geometry1] [image] NULL,
	[Meta_binary] [image] NULL,
	[Godlo] [nvarchar](12) NULL,
	[Wydanie] [nvarchar](10) NULL,
	[Data_wydania] [nvarchar](20) NULL,
	[Data_aktualnosci] [nvarchar](20) NULL,
	[Data_druku] [nvarchar](20) NULL,
	[Materialy_zrodlowe] [nvarchar](255) NULL,
	[Dokladnosc_pozioma] [smallint] NULL,
	[Dokladnosc_pionowa] [smallint] NULL,
	[Uwagi] [nvarchar](255) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
