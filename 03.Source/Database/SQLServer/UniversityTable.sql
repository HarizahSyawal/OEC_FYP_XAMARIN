USE [OnlineEduConsultation]
GO

/****** Object:  Table [dbo].[University]    Script Date: 7/27/2022 11:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[University](
	[ÌD] [int] NULL,
	[UnivName] [varchar](50) NULL,
	[UnivPhoto] [varchar](50) NULL,
	[UnivAddress] [varchar](50) NULL,
	[UnivDetails] [varchar](500) NULL
) ON [PRIMARY]
GO


