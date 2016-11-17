USE [vmap]
GO
/****** Object:  Table [dbo].[GFeatures]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GFeatures](
	[GeometryType] [int] NULL,
	[PrimaryGeometryFieldName] [nvarchar](255) NULL,
	[FeatureDescription] [nvarchar](255) NULL,
	[FeatureName] [nvarchar](255) NULL
) ON [PRIMARY]

GO
