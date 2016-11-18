USE [vmap]
GO
/****** Object:  Table [dbo].[Kontrola]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kontrola](
	[Objiid] [int] NOT NULL,
	[Geometry1] [image] NULL,
	[NRK] [nvarchar](50) NULL,
	[TYP] [nvarchar](50) NULL,
	[TXT] [nvarchar](max) NULL,
	[ODP] [nvarchar](max) NULL,
	[Geometry1_sk] [nvarchar](15) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
