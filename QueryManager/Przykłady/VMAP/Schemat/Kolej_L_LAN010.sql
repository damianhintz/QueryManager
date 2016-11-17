USE [vmap]
GO
/****** Object:  Table [dbo].[Kolej_L_LAN010]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kolej_L_LAN010](
	[Objid] [int] NOT NULL,
	[EXS] [nvarchar](255) NULL,
	[LOC] [nvarchar](255) NULL,
	[LTN] [smallint] NULL,
	[RGC] [nvarchar](255) NULL,
	[RRA] [nvarchar](255) NULL,
	[RRC] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
