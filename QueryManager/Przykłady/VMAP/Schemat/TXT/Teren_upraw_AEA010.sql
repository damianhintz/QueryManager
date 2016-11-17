USE [vmap]
GO
/****** Object:  Table [dbo].[Teren_upraw_AEA010]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teren_upraw_AEA010](
	[Objid] [int] NOT NULL,
	[VEG] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[TXT] [nvarchar](255) NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
