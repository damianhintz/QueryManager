USE [vmap]
GO
/****** Object:  Table [dbo].[Granica_adm_LFA000]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Granica_adm_LFA000](
	[Objid] [int] NOT NULL,
	[NM3] [nvarchar](255) NULL,
	[NM4] [nvarchar](255) NULL,
	[USG] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
