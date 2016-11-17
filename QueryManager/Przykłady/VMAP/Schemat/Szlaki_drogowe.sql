USE [vmap]
GO
/****** Object:  Table [dbo].[Szlaki_drogowe]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Szlaki_drogowe](
	[ID] [int] NULL,
	[NUMER] [nvarchar](5) NULL,
	[Objid] [int] NOT NULL,
	[OPIS] [nvarchar](255) NULL
) ON [PRIMARY]

GO
