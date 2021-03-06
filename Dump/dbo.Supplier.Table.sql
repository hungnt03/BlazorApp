USE [HungTest]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 2021/06/22 15:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[Name] [nvarchar](250) NULL,
	[Address] [nvarchar](250) NULL,
	[Contact1] [nvarchar](250) NULL,
	[Contact2] [nvarchar](250) NULL,
	[Note] [nvarchar](256) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact1], [Contact2], [Note]) VALUES (9, NULL, NULL, NULL, NULL, N'xxx', N'xxxxx', N'0123456789', NULL, NULL)
INSERT [dbo].[Supplier] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact1], [Contact2], [Note]) VALUES (10, NULL, NULL, NULL, NULL, N'Nguyễn Thị Thuỷ(bibica)', N'183 Hoàng Hoa Thám, Ngọc Hồ, Ba Đình, Hà Nội', N'02437281476', NULL, NULL)
INSERT [dbo].[Supplier] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Address], [Contact1], [Contact2], [Note]) VALUES (11, NULL, NULL, NULL, NULL, N'Nguyễn Đức Cảnh(ĐL cấp 1)', N'25 Văn Miếu, Đống Đa, Hà Nội, Vietnam', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Supplier] OFF
