USE [vmap]
GO
/****** Object:  Table [dbo].[Brod_L_LBH070]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brod_L_LBH070](
	[Objid] [int] NOT NULL,
	[LNTH] [smallint] NULL,
	[WVA] [float] NULL,
	[UMC] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[WDA] [float] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
