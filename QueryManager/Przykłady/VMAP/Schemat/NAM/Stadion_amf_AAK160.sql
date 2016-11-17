USE [vmap]
GO
/****** Object:  Table [dbo].[Stadion_amf_AAK160]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stadion_amf_AAK160](
	[HGT] [smallint] NULL,
	[ZV2] [smallint] NULL,
	[NAM] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[Objid] [int] NOT NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
