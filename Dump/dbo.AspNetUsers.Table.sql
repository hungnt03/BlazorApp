USE [HungTest]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2021/06/22 15:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5358fb42-b047-46f4-a4e9-e2a0d02a4e6b', N'hungnt03', N'HUNGNT03', N'hungnt.hut56@gmail.com', N'HUNGNT.HUT56@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAENGefkpCKf1mqan0rGroJZHWnfRSje+s3vM5Zeu2dLxSDbaY9BEnCVdIgUW4ZuCyIQ==', N'WVG6QBPRDD3M3FPA22KZ3D33EAV6IRAK', N'c79d74df-0ef5-4908-ac9b-e452a45666c1', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e3ba8f63-28da-41ec-9fcb-24cb18dc7993', N'hungnt.s18@gmail.com', N'HUNGNT.S18@GMAIL.COM', N'hungnt.s18@gmail.com', N'HUNGNT.S18@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEJ30AoiZcmDFjc64jxxnuWZWGP7GKJE5GYPOexnr4mdvdZazNtRZMNq8wmQ4C+9U7w==', N'3Y6A3L57A3I74GB6KBSAOTHOKHL3CDHO', N'fd6a916a-4909-4c5a-8687-ed76bfa01d6c', NULL, 0, 0, NULL, 0, 0)
