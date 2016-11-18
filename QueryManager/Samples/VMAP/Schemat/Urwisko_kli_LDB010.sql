USE [vmap]
GO
/****** Object:  Table [dbo].[Urwisko_kli_LDB010]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urwisko_kli_LDB010](
	[Objid] [int] NOT NULL,
	[PFH] [smallint] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
