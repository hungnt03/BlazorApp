USE [HungTest]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2021/06/22 15:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Barcode] [nvarchar](16) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[Name] [nvarchar](250) NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[SupplierId] [int] NOT NULL,
	[Pin] [bit] NULL,
	[Enable] [bit] NOT NULL,
	[ExpirationDate] [datetime2](7) NULL,
	[Unit] [int] NOT NULL,
	[Img] [nvarchar](max) NULL,
	[PriceBuy] [int] NULL,
	[Interest] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Barcode] ASC,
	[Unit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'3110354325000', CAST(N'2020-07-10T09:39:16.0418435' AS DateTime2), N'administrator', CAST(N'2020-12-21T16:12:46.9558325' AS DateTime2), N'Administrator', N'Thuốc lá Thăng Long(bao)', 685, 10000, 3, 1, 0, 1, CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), 28, N'3110354325000.jpg', 8000, 2000)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8004800008152', CAST(N'2020-07-10T09:39:16.0418541' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9726185' AS DateTime2), N'Administrator', N'Bánh Sampa Balocco Savoiardi 200g', 80, 59000, 1, 2, 0, 1, CAST(N'2021-10-29T00:00:00.0000000' AS DateTime2), 19, N'8004800008152.jpg', 55000, 4000)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8934637514871', CAST(N'2020-07-10T09:39:16.0418548' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9736199' AS DateTime2), N'Administrator', N'Sốt ướp thịt nướng', 30, 16000, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418544' AS DateTime2), 27, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8934752060109', CAST(N'2020-07-10T09:39:16.0418552' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9736199' AS DateTime2), N'Administrator', N'Dấm trung thành 500ml', 50, 10400, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418550' AS DateTime2), 18, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8934804004044', CAST(N'2020-07-10T09:39:16.0418555' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9746199' AS DateTime2), N'Administrator', N'Dầu hào 350g', 30, 21000, 1, 2, 0, 1, CAST(N'2022-03-10T09:39:16.0418553' AS DateTime2), 18, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8934988021028', CAST(N'2020-07-10T09:39:16.0418558' AS DateTime2), N'administrator', CAST(N'2020-12-21T16:12:46.9558325' AS DateTime2), N'Administrator', N'Dầu ăn simply 2l', 42, 140000, 1, 11, 0, 1, CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), 18, NULL, 118200, 21800)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8935009922225', CAST(N'2020-07-10T09:39:16.0418562' AS DateTime2), N'administrator', CAST(N'2020-12-21T16:12:46.9568346' AS DateTime2), N'Administrator', N'Kẹo gấu thiên hồng 1kg', 25, 95000, 1, 9, 0, 1, CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), 19, NULL, 90300, 4700)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8936017364113', CAST(N'2020-07-10T09:39:16.0418565' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9756194' AS DateTime2), N'Administrator', N'Nước mắm Cá cốt ABC', 9, 12000, 1, 2, 0, 1, CAST(N'2022-03-10T09:39:16.0418563' AS DateTime2), 18, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8936017367046', CAST(N'2020-07-10T09:39:16.0418568' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9756194' AS DateTime2), N'Administrator', N'Tương cà chinsu 250g', 50, 12000, 1, 1, 0, 1, CAST(N'2022-03-10T09:39:16.0418566' AS DateTime2), 18, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8936028040426', CAST(N'2020-07-10T09:39:16.0418571' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9766193' AS DateTime2), N'Administrator', N'Sốt gia vị chinsu', 92, 15000, 1, 1, 1, 1, CAST(N'2022-03-10T09:39:16.0418569' AS DateTime2), 18, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8936124472008', CAST(N'2020-07-10T09:39:16.0418574' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9766193' AS DateTime2), N'Administrator', N'Đậu phộng nước cốt dừa Tân Tân gói 75g', 23, 10000, 1, 1, 1, 1, CAST(N'2022-03-10T09:39:16.0418572' AS DateTime2), 19, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'8938503112147', CAST(N'2020-07-10T09:39:16.0418578' AS DateTime2), N'administrator', CAST(N'2020-12-15T13:10:49.9776188' AS DateTime2), N'Administrator', N'Mít sấy Vinamit gói 500g', 14, 143600, 1, 1, 1, 1, CAST(N'2022-03-10T09:39:16.0418575' AS DateTime2), 19, NULL, 0, 0)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'9991294713579', CAST(N'2020-11-07T10:15:28.0261900' AS DateTime2), N'Administrator', CAST(N'2020-12-15T13:10:49.9776188' AS DateTime2), N'Administrator', N'Mi tom hh', 9, 3000, 1, 1, 1, 1, CAST(N'2021-05-12T10:14:40.0000000' AS DateTime2), 19, NULL, 2800, 200)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'9991335735726', CAST(N'2020-12-14T14:12:26.0591473' AS DateTime2), N'Administrator', CAST(N'2020-12-21T16:12:46.9568346' AS DateTime2), N'Administrator', N'Thuốc lá Thăng Long(cây)', 28, 80000, 3, 10, 1, 1, CAST(N'2022-12-19T00:00:00.0000000' AS DateTime2), 30, NULL, 65400, 14600)
INSERT [dbo].[Product] ([Barcode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Name], [Quantity], [Price], [CategoryId], [SupplierId], [Pin], [Enable], [ExpirationDate], [Unit], [Img], [PriceBuy], [Interest]) VALUES (N'9991989327852', CAST(N'2020-12-14T14:15:50.6585787' AS DateTime2), N'Administrator', CAST(N'2020-12-15T13:10:49.9786199' AS DateTime2), N'Administrator', N'Thuốc lá Thăng Long(thùng)', 1, 1500000, 3, 2, 1, 1, CAST(N'2021-07-21T14:12:39.0000000' AS DateTime2), 16, NULL, 1400000, 0)
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [PriceBuy]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [Interest]
GO
