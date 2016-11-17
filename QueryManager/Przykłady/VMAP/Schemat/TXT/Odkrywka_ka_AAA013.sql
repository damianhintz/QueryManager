USE [vmap]
GO
/****** Object:  Table [dbo].[Odkrywka_ka_AAA013]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odkrywka_ka_AAA013](
	[Objid] [int] NOT NULL,
	[EXS] [nvarchar](255) NULL,
	[PRO] [nvarchar](255) NULL,
	[TXT] [nvarchar](255) NULL,
	[PFD] [smallint] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
