USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPUPDATE_BatchSecondaryPacking_Cost]    Script Date: 5/20/2014 11:44:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SPUPDATE_BatchSecondaryPacking_Cost]
(
 @BatchPackingID numeric(18,0)


)
AS
 SET NOCOUNT OFF;
BEGIN

DECLARE @theCount int
DECLARE @FinalQty numeric(18,2)
DECLARE @PrimaryUnitPrice numeric(18,2)

select @theCount=count(*) from tblBatchCost_Packing where BatchActID=@BatchPackingID

select @FinalQty=StopQty from tblBatchActivity where BatchActID=@BatchPackingID

------------
SELECT @PrimaryUnitPrice=ISNULL(UnitCost,0)
FROM   tblBatchCost_Packing
where BatchActID = (SELECT PrimaryBatchActID FROM  [MRP].[dbo].[tblBatchActivity] where BatchActID=@BatchPackingID)

----------

IF @theCount>0
BEGIN

UPDATE tblBatchCost_Packing SET LabourCost = dbo.Packing_LabourCost(@BatchPackingID),
								MachineCost= dbo.Packing_MachineCost(@BatchPackingID),
								MaterialCost= dbo.Packing_MaterialCost(@BatchPackingID),
								OHCost= dbo.Packing_OverheadCost(@BatchPackingID),
								LabourCost_Manf=0,
								MachineCost_Manf=0,
								MaterialCost_Manf=0,
								OHCost_Manf=0,
								TotalCost=dbo.Packing_LabourCost(@BatchPackingID)+dbo.Packing_MachineCost(@BatchPackingID)+ dbo.Packing_MaterialCost(@BatchPackingID)+dbo.Packing_OverheadCost(@BatchPackingID)+dbo.Packing_LabourCost_Manf(@BatchPackingID)+dbo.Packing_MachineCost_Manf(@BatchPackingID)+dbo.Packing_MaterialCost_Manf(@BatchPackingID)+dbo.Packing_OverheadCost_Manf(@BatchPackingID),
								UnitCost=(dbo.Packing_LabourCost(@BatchPackingID)+dbo.Packing_MachineCost(@BatchPackingID)+ dbo.Packing_MaterialCost(@BatchPackingID)+dbo.Packing_OverheadCost(@BatchPackingID)+@PrimaryUnitPrice*@FinalQty)/ @FinalQty,
								WaterCost=0,ExtractionLabourCost=0
WHERE (BatchActID = @BatchPackingID)

END
ELSE 
BEGIN
INSERT INTO [dbo].tblBatchCost_Packing   ([BatchActID],[LabourCost],[MachineCost],[MaterialCost],[OHCost],[LabourCost_Manf],[MachineCost_Manf],[MaterialCost_Manf],[OHCost_Manf],[TotalCost],[UnitCost],[WaterCost],[ExtractionLabourCost])
VALUES   (@BatchPackingID,dbo.Packing_LabourCost(@BatchPackingID),
dbo.Packing_MachineCost(@BatchPackingID),
dbo.Packing_MaterialCost(@BatchPackingID),
dbo.Packing_OverheadCost(@BatchPackingID),
 0,
 0,
 0,
 0,
 dbo.Packing_LabourCost(@BatchPackingID)+dbo.Packing_MachineCost(@BatchPackingID)+ dbo.Packing_MaterialCost(@BatchPackingID)+dbo.Packing_OverheadCost(@BatchPackingID),
(dbo.Packing_LabourCost(@BatchPackingID)+dbo.Packing_MachineCost(@BatchPackingID)+ dbo.Packing_MaterialCost(@BatchPackingID)+dbo.Packing_OverheadCost(@BatchPackingID)+@PrimaryUnitPrice*@FinalQty)/ @FinalQty,
0,0)

END
END


GO

