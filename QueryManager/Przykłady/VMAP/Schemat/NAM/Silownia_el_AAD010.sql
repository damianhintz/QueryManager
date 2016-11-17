USE [vmap]
GO
/****** Object:  Table [dbo].[Silownia_el_AAD010]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Silownia_el_AAD010](
	[Objid] [int] NOT NULL,
	[HGT] [smallint] NULL,
	[NAM] [nvarchar](255) NULL,
	[PPC] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
