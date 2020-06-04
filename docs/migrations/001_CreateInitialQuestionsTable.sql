USE [Covid19]
GO

/****** Object:  Table [dbo].[InitialQuestions]    Script Date: 6/4/2020 9:57:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InitialQuestions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](50) NOT NULL,
	[SelectedProvince] [nvarchar](255) NOT NULL,
	[Suburb] [nvarchar](255) NOT NULL,
	[SelectedAgeGroup] [nvarchar](10) NOT NULL,
	[IsSmoker] [bit] NOT NULL,
	[IsDrinker] [bit] NOT NULL,
	[DoesShareLivingSpace] [bit] NOT NULL,
	[TransportType] [nvarchar](255) NOT NULL,
	[Timestamp] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


