USE [vmap]
GO
/****** Object:  Table [dbo].[Komin_P_PAF010]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Komin_P_PAF010](
	[Objid] [int] NOT NULL,
	[EXS] [nvarchar](255) NULL,
	[HGT] [smallint] NULL,
	[ZV2] [smallint] NULL,
	[AOO] [float] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
