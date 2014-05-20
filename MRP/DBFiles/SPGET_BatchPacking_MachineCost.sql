USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPGET_BatchPacking_MachineCost]    Script Date: 5/9/2014 2:35:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SPGET_BatchPacking_MachineCost]
(
	@BatchPackingID numeric(18,0)
)
AS
	SET NOCOUNT ON;

SELECT MachineCode,Machine,SUM(MachineHours) AS MachineHours,CONVERT(numeric(18,2),AVG(HourlyRate)) as HourlyRate,SUM(MachineCost) AS MachineCost from (
SELECT        tblBatchMachineDetails.MachineCode,CONVERT(numeric(18,2),SUM(dbo.GetTime(tblBatchMachineDetails.MachineStart, tblBatchMachineDetails.MachineStop))/60) AS MachineHours, 
AVG(tblBatchMachineDetails.HourlyRate) AS HourlyRate, 
SUM(dbo.MachineCost(tblBatchMachineDetails.HourlyRate,tblBatchMachineDetails.MachineStart, tblBatchMachineDetails.MachineStop)) AS MachineCost,
                         tblMachine.MachineName AS Machine
FROM            tblBatchActivity INNER JOIN
                          tblBatchMachineDetails ON tblBatchActivity.BatchActID = tblBatchMachineDetails.BatchActID INNER JOIN
                         tblMachine ON tblBatchMachineDetails.MachineCode = tblMachine.MachineCode
WHERE        (tblBatchActivity.BatchActID = @BatchPackingID)
GROUP BY tblBatchMachineDetails.MachineCode, tblMachine.MachineName, tblBatchMachineDetails.MachineStart, tblBatchMachineDetails.MachineStop, tblBatchMachineDetails.HourlyRate 
) as table1
GROUP BY MachineCode,Machine

GO

