USE [vmap]
GO
/****** Object:  Table [dbo].[Obnizenie_d_PDB080]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obnizenie_d_PDB080](
	[Objid] [int] NOT NULL,
	[PFD] [smallint] NULL,
	[AOO] [float] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
