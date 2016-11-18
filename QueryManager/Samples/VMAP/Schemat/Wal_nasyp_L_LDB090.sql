USE [vmap]
GO
/****** Object:  Table [dbo].[Wal_nasyp_L_LDB090]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wal_nasyp_L_LDB090](
	[Objid] [int] NOT NULL,
	[PFH] [smallint] NULL,
	[TUC] [nvarchar](255) NULL,
	[USG] [nvarchar](255) NULL,
	[WID] [smallint] NULL,
	[CET] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
