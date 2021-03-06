USE [HungTest]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 2021/06/22 15:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Unit] ON 

INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (16, N'thùng', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (17, N'bịch', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (18, N'chai', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (19, N'gói', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (20, N'túi', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (21, N'viên', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (22, N'kg', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (23, N'gram', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (24, N'lạng', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (25, N'lít', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (26, N'ml', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (27, N'lọ', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (28, N'bao', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (29, N'cái', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (30, N'cây', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
INSERT [dbo].[Unit] ([Id], [Name], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (31, N'điếu', CAST(N'2022-10-21T09:39:16.0415131' AS DateTime2), N'administrator', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Unit] OFF
