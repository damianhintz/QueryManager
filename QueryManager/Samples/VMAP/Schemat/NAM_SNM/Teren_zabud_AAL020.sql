USE [vmap]
GO
/****** Object:  Table [dbo].[Teren_zabud_AAL020]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teren_zabud_AAL020](
	[Objid] [int] NOT NULL,
	[NAM] [nvarchar](255) NULL,
	[IDN] [nvarchar](255) NULL,
	[SNM] [nvarchar](255) NULL,
	[USG] [nvarchar](255) NULL,
	[US2] [nvarchar](255) NULL,
	[BAC] [nvarchar](255) NULL,
	[PIT] [float] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
