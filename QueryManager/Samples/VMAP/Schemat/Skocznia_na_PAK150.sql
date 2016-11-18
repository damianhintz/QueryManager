USE [vmap]
GO
/****** Object:  Table [dbo].[Skocznia_na_PAK150]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skocznia_na_PAK150](
	[Objid] [int] NOT NULL,
	[HGT] [smallint] NULL,
	[ZV2] [smallint] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL,
	[AOO] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
