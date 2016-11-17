USE [vmap]
GO
/****** Object:  Table [dbo].[Bocznica_sl_LAN050]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bocznica_sl_LAN050](
	[Objid] [int] NOT NULL,
	[EXS] [nvarchar](255) NULL,
	[RGC] [nvarchar](255) NULL,
	[RRA] [nvarchar](255) NULL,
	[RSA] [nvarchar](50) NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
