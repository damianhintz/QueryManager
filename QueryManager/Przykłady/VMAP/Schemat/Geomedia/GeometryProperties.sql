USE [vmap]
GO
/****** Object:  Table [dbo].[GeometryProperties]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GeometryProperties](
	[IndexID] [int] NULL,
	[GeometryType] [smallint] NULL,
	[GCoordSystemGUID] [nvarchar](255) NULL,
	[PrimaryGeometryFlag] [bit] NOT NULL,
	[FieldDescription] [nvarchar](255) NULL
) ON [PRIMARY]

GO
