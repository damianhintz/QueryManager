USE [vmap]
GO
/****** Object:  Table [dbo].[Cmentarz_A_AAL030]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cmentarz_A_AAL030](
	[Objid] [int] NOT NULL,
	[VEG] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
