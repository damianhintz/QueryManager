USE [vmap]
GO
/****** Object:  Table [dbo].[Obszar_admi_AFA001]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obszar_admi_AFA001](
	[Objid] [int] NOT NULL,
	[NM3] [nvarchar](255) NULL,
	[NM4] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL,
	[NM5] [nvarchar](255) NULL,
	[NM6] [nvarchar](255) NULL,
	[NM7] [nvarchar](255) NULL,
	[IDN] [nvarchar](255) NULL,
	[SA3] [nvarchar](255) NULL,
	[SA5] [nvarchar](255) NULL,
	[SA6] [nvarchar](255) NULL,
	[SA7] [nvarchar](255) NULL,
	[USG] [nvarchar](255) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
