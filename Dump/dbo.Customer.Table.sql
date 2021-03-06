USE [HungTest]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2021/06/22 15:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[Name] [nvarchar](250) NULL,
	[Address] [nvarchar](250) NULL,
	[Contact] [nvarchar](250) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (1, CAST(N'2020-07-10T09:39:16.0413281' AS DateTime2), N'administrator', NULL, NULL, N'Nguyễn Hữu Hoà', N'11b Cát Linh, Quốc Tử Giám, Đống Đa, Hà Nội', N'02438267984')
INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (2, CAST(N'2020-07-10T09:39:16.0413347' AS DateTime2), N'administrator', NULL, NULL, N'Trần Danh Mạnh', N'59 Quang Trung, Nguyễn Du, Hai Bà Trưng, Hà Nội', N'02438226676')
INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (3, CAST(N'2020-07-10T09:39:16.0413349' AS DateTime2), N'administrator', NULL, NULL, N'Hoàng Tố Như', N'35 Lô 1A, đường, Trung Yên 11B, Trung Hoà, Cầu Giấy, Hà Nội', N'02436230311')
INSERT [dbo].[Customer] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact]) VALUES (4, CAST(N'2020-07-10T11:47:57.2482026' AS DateTime2), NULL, CAST(N'2020-07-10T11:56:18.4419081' AS DateTime2), N'administrator', N'Nguyễn Trường Linh', N'tòa nhà Hòa Bình, KCN Hoàng Mai, Hoàng Mai, Hà Nội', N'0963123192')
SET IDENTITY_INSERT [dbo].[Customer] OFF
