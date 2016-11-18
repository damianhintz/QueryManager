USE [vmap]
GO
/****** Object:  Table [dbo].[Rezerwuar_z_ABH130]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezerwuar_z_ABH130](
	[Objid] [int] NOT NULL,
	[EXS] [nvarchar](255) NULL,
	[NAM] [nvarchar](255) NULL,
	[Geometry1] [image] NULL,
	[IDN] [nvarchar](255) NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
