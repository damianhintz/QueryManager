USE [vmap]
GO
/****** Object:  Table [dbo].[Pomnik_P_PAL130]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pomnik_P_PAL130](
	[Objid] [int] NOT NULL,
	[HGT] [smallint] NULL,
	[ZV2] [smallint] NULL,
	[AOO] [float] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
