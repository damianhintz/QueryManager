USE [vmap]
GO
/****** Object:  Table [dbo].[Szosa_droga_LAP030]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Szosa_droga_LAP030](
	[Objid] [int] NOT NULL,
	[EXS] [nvarchar](255) NULL,
	[LOC] [nvarchar](255) NULL,
	[NAM] [nvarchar](255) NULL,
	[RST] [nvarchar](255) NULL,
	[RTT] [nvarchar](255) NULL,
	[TUC] [nvarchar](255) NULL,
	[USG] [nvarchar](255) NULL,
	[WD1] [float] NULL,
	[WD2] [float] NULL,
	[MCC] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
