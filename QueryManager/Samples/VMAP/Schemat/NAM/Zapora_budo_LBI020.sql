USE [vmap]
GO
/****** Object:  Table [dbo].[Zapora_budo_LBI020]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zapora_budo_LBI020](
	[Objid] [int] NOT NULL,
	[EXS] [nvarchar](255) NULL,
	[LNTH] [smallint] NULL,
	[MC4] [nvarchar](255) NULL,
	[MC5] [nvarchar](255) NULL,
	[NAM] [nvarchar](255) NULL,
	[TUC] [nvarchar](255) NULL,
	[WID] [smallint] NULL,
	[HGU] [float] NULL,
	[LFP] [smallint] NULL,
	[OHB] [float] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
