USE [vmap]
GO
/****** Object:  Table [dbo].[Granicznik_PZB030]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Granicznik_PZB030](
	[Objid] [int] NOT NULL,
	[NAM] [nvarchar](255) NULL,
	[AOO] [float] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO