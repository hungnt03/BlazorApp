USE [HungTest]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2021/06/22 15:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1fb6c99f-6fe9-4164-8715-6fd29c7a6be6', N'employee', N'EMPLOYEE', N'8e0f6b43-be9e-48d5-8bd8-985cd24c57b6')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'e9aaf1c8-540c-434f-b8fc-122c85d49b75', N'user', N'USER', N'9a873bbd-1215-4085-b62e-9817f0363278')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ef9ac322-6edf-4e35-a7a9-29b54289da72', N'admin', N'ADMIN', N'283eed1d-b7fb-44d0-806b-3817b526078f')
