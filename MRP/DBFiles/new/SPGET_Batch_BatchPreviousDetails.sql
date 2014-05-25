USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPGET_Batch_BatchPreviousDetails]    Script Date: 5/23/2014 9:02:10 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_Batch_BatchPreviousDetails]
(
	@BasicProduct varchar(50)

)
AS
	SET NOCOUNT ON;

SELECT        tblBatch.BatchID, View_Employee.Employee, tblBatch.BatchGeneratedDate, tblBatch.BatchStatus, tblBatch.BatchSize
FROM            tblBatch INNER JOIN View_Employee ON tblBatch.BatchGeneratedBy = View_Employee.EmpID
where BatchID like '%'+@BasicProduct+'%' AND tblBatch.BatchStatus in(1,2,3)
order by tblBatch.BatchID desc 

GO

