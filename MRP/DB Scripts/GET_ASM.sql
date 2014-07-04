USE [MRP]
GO
/****** Object:  StoredProcedure [dbo].[SPGET_ASM]    Script Date: 7/3/2014 9:48:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_ASM]

AS
	SET NOCOUNT ON;

BEGIN

SELECT  a.[UserID],  b.EmpName
FROM [dbo].[tblUser] a , [dbo].[tblEmployee] b
WHERE a.EmpID=b.EmpID AND a.[UserRoleID] in ( SELECT [UserRoleID]
											  FROM [dbo].[tblUserRole]
											  WHERE [UserRole]='ASM' )

END
