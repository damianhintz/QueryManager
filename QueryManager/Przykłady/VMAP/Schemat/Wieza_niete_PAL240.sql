USE [vmap]
GO
/****** Object:  Table [dbo].[Wieza_niete_PAL240]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wieza_niete_PAL240](
	[Objid] [int] NOT NULL,
	[EXS] [nvarchar](255) NULL,
	[HGT] [smallint] NULL,
	[TTC] [nvarchar](255) NULL,
	[ZV2] [smallint] NULL,
	[AOO] [float] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
