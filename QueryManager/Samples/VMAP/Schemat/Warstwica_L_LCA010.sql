USE [vmap]
GO
/****** Object:  Table [dbo].[Warstwica_L_LCA010]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warstwica_L_LCA010](
	[Objid] [int] NOT NULL,
	[HQC] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL,
	[ZV2] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
