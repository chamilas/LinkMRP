USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPGET_Batch_MachineCost]    Script Date: 5/8/2014 9:29:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[SPGET_Batch_MachineCost]
(
	@BatchID varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        tblBatchMachineDetails.MachineCode,CONVERT(numeric(18,2),SUM(dbo.GetTime(tblBatchMachineDetails.MachineStart, tblBatchMachineDetails.MachineStop)/60)) AS MachineHours, 
CONVERT(numeric(18,2),AVG(tblBatchMachineDetails.HourlyRate)) AS HourlyRate, 
SUM(dbo.MachineCost(tblBatchMachineDetails.HourlyRate,tblBatchMachineDetails.MachineStart, tblBatchMachineDetails.MachineStop)) AS MachineCost,
                         tblMachine.MachineName AS Machine
FROM            tblBatch INNER JOIN
                         tblBatchActivity ON tblBatch.BatchID = tblBatchActivity.BatchID INNER JOIN
                         tblBatchMachineDetails ON tblBatchActivity.BatchActID = tblBatchMachineDetails.BatchActID INNER JOIN
                         tblMachine ON tblBatchMachineDetails.MachineCode = tblMachine.MachineCode
WHERE        (tblBatch.BatchID = @BatchID) AND (tblBatchActivity.ActType='Manufacturing')
GROUP BY tblBatchMachineDetails.MachineCode, tblMachine.MachineName
GO

