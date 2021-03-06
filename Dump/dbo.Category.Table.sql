USE [HungTest]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2021/06/22 15:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[Name] [nvarchar](250) NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (1, CAST(N'2020-07-10T09:39:16.0383993' AS DateTime2), N'administrator', NULL, NULL, N'Thực phẩm', N'Các loại hàng về Thực phẩm')
INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (2, CAST(N'2020-07-10T09:39:16.0399686' AS DateTime2), N'administrator', NULL, NULL, N'Rượu bia', N'Các loại hàng về Rượu bia')
INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (3, CAST(N'2020-07-10T09:39:16.0399714' AS DateTime2), N'administrator', NULL, NULL, N'Thuốc lá', N'Các loại hàng về Thuốc lá')
INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (4, CAST(N'2020-07-10T09:39:16.0399716' AS DateTime2), N'administrator', CAST(N'2020-09-28T11:34:06.7690996' AS DateTime2), N'administrator', N'Mỹ phẩm2', N'hàng về Mỹ phẩm')
INSERT [dbo].[Category] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Description]) VALUES (7, CAST(N'2020-09-28T11:43:41.5675390' AS DateTime2), N'administrator', CAST(N'2020-09-28T11:45:31.3207012' AS DateTime2), N'administrator', N'Nguyễn Trọng Hưng2', N'testtesttest2')
SET IDENTITY_INSERT [dbo].[Category] OFF
