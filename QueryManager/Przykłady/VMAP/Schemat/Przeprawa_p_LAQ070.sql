USE [vmap]
GO
/****** Object:  Table [dbo].[Przeprawa_p_LAQ070]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Przeprawa_p_LAQ070](
	[Objid] [int] NOT NULL,
	[EXS] [nvarchar](255) NULL,
	[FCL] [smallint] NULL,
	[LNTH] [smallint] NULL,
	[TUC] [nvarchar](255) NULL,
	[WID] [smallint] NULL,
	[MLC] [smallint] NULL,
	[FER] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
