USE [vmap]
GO
/****** Object:  Table [dbo].[Opis_text_cu_TZD040]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Opis_text_cu_TZD040](
	[Objid] [int] NOT NULL,
	[Geometry1] [image] NULL,
	[INS] [nvarchar](255) NULL,
	[TXT] [nvarchar](255) NULL,
	[RCD] [nvarchar](8) NULL,
	[AOO] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
