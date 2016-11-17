USE [vmap]
GO
/****** Object:  Table [dbo].[Zaklad_prze_AAC000]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zaklad_prze_AAC000](
	[Objid] [int] NOT NULL,
	[BFC] [nvarchar](255) NULL,
	[TXT] [nvarchar](255) NULL,
	[EXS] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
