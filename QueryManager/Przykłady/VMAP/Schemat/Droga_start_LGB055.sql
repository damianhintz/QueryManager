USE [vmap]
GO
/****** Object:  Table [dbo].[Droga_start_LGB055]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Droga_start_LGB055](
	[EXS] [nvarchar](255) NULL,
	[RST] [nvarchar](255) NULL,
	[WID] [smallint] NULL,
	[ZV3] [smallint] NULL,
	[LNTH] [smallint] NULL,
	[Geometry1] [image] NULL,
	[Objid] [int] NOT NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
