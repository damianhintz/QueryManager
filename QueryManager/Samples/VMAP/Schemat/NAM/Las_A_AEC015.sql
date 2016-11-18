USE [vmap]
GO
/****** Object:  Table [dbo].[Las_A_AEC015]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Las_A_AEC015](
	[objid] [int] NOT NULL,
	[NAM] [nvarchar](255) NULL,
	[PHT] [int] NULL,
	[TRE] [nvarchar](255) NULL,
	[VEG] [nvarchar](255) NULL,
	[VE2] [nvarchar](255) NULL,
	[TSC] [smallint] NULL,
	[Geometry1] [image] NULL,
	[RCD] [nvarchar](8) NULL,
	[SDS] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
