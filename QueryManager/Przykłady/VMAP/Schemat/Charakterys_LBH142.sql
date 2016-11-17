USE [vmap]
GO
/****** Object:  Table [dbo].[Charakterys_LBH142]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Charakterys_LBH142](
	[Objid] [int] NOT NULL,
	[WID] [smallint] NULL,
	[UMC] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL,
	[HDP] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
