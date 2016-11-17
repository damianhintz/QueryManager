USE [vmap]
GO
/****** Object:  Table [dbo].[Wawoz_L_LDB200]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wawoz_L_LDB200](
	[Objid] [int] NOT NULL,
	[NAM] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[WWG] [nvarchar](255) NULL,
	[PFD] [smallint] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
