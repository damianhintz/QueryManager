USE [vmap]
GO
/****** Object:  Table [dbo].[Weryfikacja_terenowa]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Weryfikacja_terenowa](
	[Objid] [int] NOT NULL,
	[WER] [nvarchar](255) NULL,
	[NAM] [nvarchar](255) NULL,
	[RCD] [nvarchar](50) NULL,
	[Geometry1] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
