USE [vmap]
GO
/****** Object:  Table [dbo].[Punkt_osnow_PZB060]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Punkt_osnow_PZB060](
	[Objid] [int] NOT NULL,
	[CPA] [nvarchar](255) NULL,
	[PSP] [nvarchar](255) NULL,
	[NAM] [nvarchar](255) NULL,
	[CSC] [nvarchar](255) NULL,
	[ZV2] [float] NULL,
	[AOO] [float] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
