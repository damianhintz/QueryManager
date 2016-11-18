USE [vmap]
GO
/****** Object:  Table [dbo].[Wrota_sluzy_PBI040]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wrota_sluzy_PBI040](
	[Objid] [int] NOT NULL,
	[TUC] [nvarchar](255) NULL,
	[HDT] [float] NULL,
	[LSC] [smallint] NULL,
	[WID] [smallint] NULL,
	[AOO] [float] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
