USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPGET_BatchPacking_LabourCost]    Script Date: 5/9/2014 2:31:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SPGET_BatchPacking_LabourCost]
(
	@BatchPackingID numeric(18,0)
)
AS
	SET NOCOUNT ON;
SELECT EmployeeID,Employee,SUM(LaborHours) AS LaborHours,SUM(LaborCost) AS LaborCost,CONVERT(numeric(18,2),AVG(OTRate)) AS OTRate,CONVERT(numeric(18,2),AVG(HourlyRate)) as HourlyRate  FROM (
SELECT        tblBatchLaourDetails.EmployeeID, CONVERT(numeric(18,2),SUM(dbo.GetTime(tblBatchLaourDetails.WorkStart, tblBatchLaourDetails.WorkStop)/60)) AS LaborHours, 
AVG(tblBatchLaourDetails.HourlyRate) AS HourlyRate, 
AVG(tblBatchLaourDetails.OTRate) AS OTRate, tblEmployee.EmpName AS Employee,
SUM(dbo.EmployeeCost(tblBatchLaourDetails.WorkStart, tblBatchLaourDetails.WorkStop,tblBatchLaourDetails.OTHours,tblBatchLaourDetails.OTRate,tblBatchLaourDetails.HourlyRate)) AS LaborCost
FROM            tblBatchActivity INNER JOIN
                         tblBatchLaourDetails ON tblBatchActivity.BatchActID = tblBatchLaourDetails.BatchActID INNER JOIN
                         tblEmployee ON tblBatchLaourDetails.EmployeeID = tblEmployee.EmpID
WHERE        (tblBatchActivity.BatchActID = @BatchPackingID)
GROUP BY tblBatchLaourDetails.EmployeeID, tblEmployee.EmpName) AS Table1
GROUP BY EmployeeID,Employee

GO

