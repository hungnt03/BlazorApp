USE [HungTest]
GO
/****** Object:  View [dbo].[V_Revenue]    Script Date: 2021/06/22 15:39:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


  CREATE VIEW [dbo].[V_Revenue] AS
  select tb1.CreateAt, SUM(tb1.Amount) as Amount, sum(tb1.detailTotal) as DetailTotal, sum(tb1.interest) as Interest from
(
SELECT 
	  CONVERT(NVARCHAR,  trans.[CreatedAt], 111) as CreateAt
      ,trans.[Amount]
	  --,detail.[Barcode]
	  ,detail.[Amount] as detailTotal
	  ,(product.Price-product.PriceBuy) as interest
  FROM [HungTest].[dbo].[Transaction] as trans
  join [HungTest].[dbo].[TransactionDetail] as detail on trans.Id = detail.TracsactionId
  join [HungTest].[dbo].[Product] as product on detail.Barcode = product.Barcode
  where [Type] = 1
  ) as tb1
  group by CreateAt
GO
