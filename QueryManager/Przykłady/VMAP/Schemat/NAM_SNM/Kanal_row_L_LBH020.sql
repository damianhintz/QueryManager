USE [vmap]
GO
/****** Object:  Table [dbo].[Kanal_row_L_LBH020]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kanal_row_L_LBH020](
	[Objid] [int] NOT NULL,
	[HYC] [nvarchar](255) NULL,
	[NAM] [nvarchar](255) NULL,
	[IDN] [nvarchar](255) NULL,
	[SNM] [nvarchar](255) NULL,
	[WWR] [nvarchar](255) NULL,
	[OPS] [nvarchar](255) NULL,
	[WVA] [float] NULL,
	[Geometry1] [image] NULL,
	[HAT] [nvarchar](255) NULL,
	[RCD] [nvarchar](8) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
