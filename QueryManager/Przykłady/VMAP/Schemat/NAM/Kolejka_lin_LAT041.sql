USE [vmap]
GO
/****** Object:  Table [dbo].[Kolejka_lin_LAT041]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kolejka_lin_LAT041](
	[Objid] [int] NOT NULL,
	[EXS] [nvarchar](255) NULL,
	[NAM] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
