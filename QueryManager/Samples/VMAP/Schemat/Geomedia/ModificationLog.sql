USE [vmap]
GO
/****** Object:  Table [dbo].[ModificationLog]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModificationLog](
	[ModificationNumber] [int] NOT NULL,
	[Type] [tinyint] NULL,
	[ModifiedTableID] [int] NULL,
	[SESSIONID] [int] NULL,
	[KeyValue1] [nvarchar](255) NULL,
	[KeyValue2] [nvarchar](255) NULL,
	[KeyValue3] [nvarchar](255) NULL,
	[KeyValue4] [nvarchar](255) NULL,
	[KeyValue5] [nvarchar](255) NULL,
	[KeyValue6] [nvarchar](255) NULL,
	[KeyValue7] [nvarchar](255) NULL,
	[KeyValue8] [nvarchar](255) NULL,
	[KeyValue9] [nvarchar](255) NULL,
	[KeyValue10] [nvarchar](255) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO
