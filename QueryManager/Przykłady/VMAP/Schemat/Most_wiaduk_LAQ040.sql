USE [vmap]
GO
/****** Object:  Table [dbo].[Most_wiaduk_LAQ040]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Most_wiaduk_LAQ040](
	[Objid] [int] NOT NULL,
	[EXS] [nvarchar](255) NULL,
	[LNTH] [float] NULL,
	[WID] [float] NULL,
	[MLC] [float] NULL,
	[BVC] [nvarchar](255) NULL,
	[TUC] [nvarchar](255) NULL,
	[MCC] [nvarchar](255) NULL,
	[MC3] [nvarchar](255) NULL,
	[BOT] [nvarchar](255) NULL,
	[OHC] [float] NULL,
	[SHC] [float] NULL,
	[MV1] [float] NULL,
	[MV2] [float] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
