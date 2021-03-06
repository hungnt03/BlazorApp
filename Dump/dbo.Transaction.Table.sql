USE [HungTest]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 2021/06/22 15:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
	[Type] [int] NOT NULL,
	[CustomerId] [int] NULL,
	[SuplierId] [int] NULL,
	[IsPayment] [bit] NOT NULL,
	[Amount] [int] NULL,
	[Payment] [int] NULL,
	[PayBack] [int] NULL,
	[BillNumber] [nvarchar](15) NULL,
	[Note] [varchar](255) NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Transaction] ON 

INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (17, CAST(N'2020-12-11T10:05:14.2911355' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, 39000, 40000, 1000, NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (20, CAST(N'2020-12-11T10:11:06.3660807' AS DateTime2), N'Administrator', NULL, NULL, 0, NULL, 0, 1, 630000, 630000, 0, NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (31, CAST(N'2020-12-21T16:12:46.9248655' AS DateTime2), N'Administrator', NULL, NULL, 0, NULL, 0, 1, 2937500, 3000000, 62500, NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (32, CAST(N'2020-12-22T10:44:15.4108130' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, 223600, 225000, 1400, NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (33, CAST(N'2020-12-22T10:44:26.7675216' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, 25000, 25000, 0, NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (34, CAST(N'2020-12-22T10:44:37.3838167' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, 15000, 15000, 0, NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (35, CAST(N'2020-12-25T08:47:17.9792944' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, 25000, 25000, 0, NULL, NULL)
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (36, CAST(N'2020-12-25T08:50:49.0361535' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, 30000, 50000, 20000, NULL, N'')
INSERT [dbo].[Transaction] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Type], [CustomerId], [SuplierId], [IsPayment], [Amount], [Payment], [PayBack], [BillNumber], [Note]) VALUES (37, CAST(N'2020-12-25T08:51:10.9948654' AS DateTime2), N'Administrator', NULL, NULL, 1, NULL, NULL, 1, 95000, 100000, 5000, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Transaction] OFF
