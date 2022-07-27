USE [OnlineEduConsultation]
GO

/****** Object:  Table [dbo].[Announcement]    Script Date: 7/27/2022 11:19:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Announcement](
	[ID] [int] NULL,
	[Title] [varchar](50) NULL,
	[Photo] [varchar](50) NULL,
	[Description] [varchar](200) NULL
) ON [PRIMARY]
GO


