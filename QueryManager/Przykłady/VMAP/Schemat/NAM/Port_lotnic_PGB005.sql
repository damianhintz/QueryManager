USE [vmap]
GO
/****** Object:  Table [dbo].[Port_lotnic_PGB005]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Port_lotnic_PGB005](
	[Objid] [int] NOT NULL,
	[TAP] [nvarchar](255) NULL,
	[EXS] [nvarchar](255) NULL,
	[NAM] [nvarchar](255) NULL,
	[USG] [nvarchar](255) NULL,
	[ZV3] [smallint] NULL,
	[AOO] [float] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
