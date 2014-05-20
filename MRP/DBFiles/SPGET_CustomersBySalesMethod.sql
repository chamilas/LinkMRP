USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPGET_CustomersBySalesMethod]    Script Date: 5/20/2014 11:03:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SPGET_CustomersBySalesMethod]
(
	@SalesMethod varchar(50)
)
AS
	SET NOCOUNT ON;

BEGIN



SELECT CustomerID+' - '+Name as Customer, CustomerID, Name, ProductType
FROM tblCustomer
WHERE SalesMethod=@SalesMethod

END




GO

