USE [vmap]
GO
/****** Object:  Table [dbo].[Tunel_L_LAQ130]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tunel_L_LAQ130](
	[Objid] [int] NOT NULL,
	[LNTH] [float] NULL,
	[TUC] [nvarchar](255) NULL,
	[WID] [float] NULL,
	[EXS] [nvarchar](255) NULL,
	[OHC] [float] NULL,
	[MV2] [float] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
