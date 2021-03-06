USE [HungTest]
GO
/****** Object:  Table [dbo].[TransactionDetail]    Script Date: 2021/06/22 15:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionDetail](
	[Barcode] [nvarchar](16) NOT NULL,
	[TracsactionId] [int] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[SuplierId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[IsPayment] [bit] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[Unit] [int] NULL,
	[IsDiscount] [bit] NULL,
 CONSTRAINT [PK_TransactionDetail] PRIMARY KEY CLUSTERED 
(
	[Barcode] ASC,
	[TracsactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'3110354325000', 20, CAST(N'2020-12-11T10:11:11.3552866' AS DateTime2), N'Administrator', NULL, NULL, 0, 100, 1, CAST(80000.00 AS Decimal(18, 2)), 28, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'3110354325000', 31, CAST(N'2020-12-21T16:12:46.9558325' AS DateTime2), N'Administrator', NULL, NULL, 0, 2, 0, CAST(16000.00 AS Decimal(18, 2)), 28, 1)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8004800008152', 20, CAST(N'2020-12-11T10:11:11.3562857' AS DateTime2), N'Administrator', NULL, NULL, 0, 10, 1, CAST(550000.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8934988021028', 31, CAST(N'2020-12-21T16:12:46.9548332' AS DateTime2), N'Administrator', NULL, NULL, 0, 11, 1, CAST(1300000.00 AS Decimal(18, 2)), 18, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8935009922225', 31, CAST(N'2020-12-21T16:12:46.9568346' AS DateTime2), N'Administrator', NULL, NULL, 0, 10, 1, CAST(902500.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8936017364113', 17, CAST(N'2020-12-11T10:05:14.3161378' AS DateTime2), N'Administrator', NULL, NULL, 0, 2, 1, CAST(24000.00 AS Decimal(18, 2)), 18, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8936028040426', 17, CAST(N'2020-12-11T10:05:14.3171355' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(15000.00 AS Decimal(18, 2)), 18, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8936028040426', 33, CAST(N'2020-12-22T10:44:26.7775368' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(15000.00 AS Decimal(18, 2)), 18, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8936028040426', 35, CAST(N'2020-12-25T08:47:18.1792925' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(15000.00 AS Decimal(18, 2)), 18, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8936124472008', 33, CAST(N'2020-12-22T10:44:26.7785200' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(10000.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8936124472008', 35, CAST(N'2020-12-25T08:47:18.1802962' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(10000.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8936124472008', 36, CAST(N'2020-12-25T08:50:49.1768403' AS DateTime2), N'Administrator', NULL, NULL, 0, 3, 1, CAST(30000.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'8938503112147', 32, CAST(N'2020-12-22T10:44:15.4581045' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(143600.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'9991294713579', 34, CAST(N'2020-12-22T10:44:37.3998554' AS DateTime2), N'Administrator', NULL, NULL, 0, 5, 1, CAST(15000.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'9991294713579', 37, CAST(N'2020-12-25T08:51:11.0038577' AS DateTime2), N'Administrator', NULL, NULL, 0, 5, 1, CAST(15000.00 AS Decimal(18, 2)), 19, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'9991335735726', 31, CAST(N'2020-12-21T16:12:46.9558325' AS DateTime2), N'Administrator', NULL, NULL, 0, 11, 1, CAST(735000.00 AS Decimal(18, 2)), 30, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'9991335735726', 32, CAST(N'2020-12-22T10:44:15.4591054' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(80000.00 AS Decimal(18, 2)), 30, NULL)
INSERT [dbo].[TransactionDetail] ([Barcode], [TracsactionId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [SuplierId], [Quantity], [IsPayment], [Amount], [Unit], [IsDiscount]) VALUES (N'9991335735726', 37, CAST(N'2020-12-25T08:51:11.0038577' AS DateTime2), N'Administrator', NULL, NULL, 0, 1, 1, CAST(80000.00 AS Decimal(18, 2)), 30, NULL)
