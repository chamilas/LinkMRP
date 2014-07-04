USE [MRP]
GO
/****** Object:  StoredProcedure [dbo].[SPUPDATE_StockReserve]    Script Date: 7/3/2014 11:15:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPUPDATE_StockReserve]
(
	@ID varchar(50),
	@Quantity int
)
AS
	SET NOCOUNT OFF;

UPDATE [dbo].[tblStock]
SET [StockReservedQty]=[StockReservedQty]-@Quantity
WHERE [StockFinishProduct]=@ID

