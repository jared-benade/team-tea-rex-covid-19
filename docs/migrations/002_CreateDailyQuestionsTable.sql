USE [Covid19]
GO

/****** Object:  Table [dbo].[DailyQuestions]    Script Date: 6/4/2020 9:56:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DailyQuestions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](50) NOT NULL,
	[PeopleInteractedWith] [nvarchar](5) NOT NULL,
	[Fever] [bit] NOT NULL,
	[PersistentCough] [bit] NOT NULL,
	[UnusualFatigue] [bit] NOT NULL,
	[EatAnything] [bit] NOT NULL,
	[FeelNormalRightNow] [bit] NOT NULL,
	[LeaveHomeToday] [bit] NOT NULL,
	[Treatment] [nvarchar](50) NOT NULL,
	[Timestamp] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


