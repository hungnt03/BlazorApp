USE [HungTest]
GO
/****** Object:  Table [dbo].[ConvertProduct]    Script Date: 2021/06/22 15:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConvertProduct](
	[Barcode1] [nvarchar](16) NOT NULL,
	[Quantity1] [int] NOT NULL,
	[Barcode2] [nvarchar](16) NOT NULL,
	[Quantity2] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](256) NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](256) NULL,
 CONSTRAINT [PK_Convert] PRIMARY KEY CLUSTERED 
(
	[Barcode1] ASC,
	[Barcode2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ConvertProduct] ([Barcode1], [Quantity1], [Barcode2], [Quantity2], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (N'9991335735726', 1, N'3110354325000', 10, NULL, NULL, NULL, NULL)
INSERT [dbo].[ConvertProduct] ([Barcode1], [Quantity1], [Barcode2], [Quantity2], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (N'9991989327852', 1, N'3110354325000', 201, NULL, NULL, NULL, NULL)
