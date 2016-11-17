USE [vmap]
GO
/****** Object:  Table [dbo].[Budynek_A_AAL015]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Budynek_A_AAL015](
	[Objid] [int] NOT NULL,
	[BFC] [nvarchar](255) NULL,
	[TXT] [nvarchar](255) NULL,
	[EXS] [nvarchar](255) NULL,
	[HGT] [smallint] NULL,
	[HWT] [nvarchar](255) NULL,
	[LMC] [nvarchar](255) NULL,
	[ZV2] [smallint] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
