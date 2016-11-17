USE [vmap]
GO
/****** Object:  Table [dbo].[Wielki_glaz_PDB510]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wielki_glaz_PDB510](
	[Objid] [int] NOT NULL,
	[LMC] [nvarchar](255) NULL,
	[PFH] [smallint] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL,
	[MCC] [nvarchar](255) NULL,
	[AOO] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
