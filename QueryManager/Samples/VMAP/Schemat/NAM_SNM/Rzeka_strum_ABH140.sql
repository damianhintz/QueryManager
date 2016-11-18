USE [vmap]
GO
/****** Object:  Table [dbo].[Rzeka_strum_ABH140]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rzeka_strum_ABH140](
	[Objid] [int] NOT NULL,
	[HYC] [nvarchar](255) NULL,
	[NAM] [nvarchar](255) NULL,
	[IDN] [nvarchar](255) NULL,
	[SNM] [nvarchar](255) NULL,
	[WID] [smallint] NULL,
	[OPS] [nvarchar](255) NULL,
	[WVA] [float] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
