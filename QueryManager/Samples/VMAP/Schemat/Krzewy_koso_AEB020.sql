USE [vmap]
GO
/****** Object:  Table [dbo].[Krzewy_koso_AEB020]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Krzewy_koso_AEB020](
	[Objid] [int] NOT NULL,
	[Geometry1] [image] NULL,
	[VEG] [nvarchar](255) NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
