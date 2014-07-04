USE [MRP]
GO
/****** Object:  StoredProcedure [dbo].[SPGET_SalesRep]    Script Date: 7/3/2014 10:14:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_SalesRep]

AS
	SET NOCOUNT ON;

BEGIN

SELECT  a.[UserID],  b.EmpName
FROM [dbo].[tblUser] a , [dbo].[tblEmployee] b
WHERE a.EmpID=b.EmpID AND a.[UserRoleID] in ( SELECT [UserRoleID]
											  FROM [dbo].[tblUserRole]
											  WHERE [UserRole]='SalesPerson' )

END
