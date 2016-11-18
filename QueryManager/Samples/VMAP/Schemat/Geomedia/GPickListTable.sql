USE [vmap]
GO
/****** Object:  Table [dbo].[GPickListTable]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GPickListTable](
	[FeatureName] [nvarchar](255) NULL,
	[FieldName] [nvarchar](255) NULL,
	[PickListTableName] [nvarchar](255) NULL,
	[ValueFieldName] [nvarchar](255) NULL,
	[DescriptionFieldName] [nvarchar](255) NULL,
	[FilterClause] [nvarchar](255) NULL
) ON [PRIMARY]

GO
