USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPGET_PlanMaterial]    Script Date: 5/22/2014 10:06:08 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SPGET_PlanMaterial]
(
	@Year int,
	@Month varchar(50),
	@Type varchar(50)
	
)
AS
BEGIN
	SET NOCOUNT OFF;


SELECT        tblPlanMaterials.Year, tblPlanMaterials.Month, tblPlanMaterials.RevisionID, tblPlanMaterials.WeekID, tblPlanMaterials.MaterialCode, tblPlanMaterials.Qty, tblPlanMaterials.Type, tblPlanMaterials.Status, 
                         tblUnit.UnitCode
FROM            tblPlanMaterials INNER JOIN
                         tblMaterial ON tblPlanMaterials.MaterialCode = tblMaterial.MaterialCode INNER JOIN
                         tblUnit ON tblMaterial.UnitID = tblUnit.UnitID 
WHERE        ([Year] = @Year) AND ([Month] = @Month) AND Type=@Type

END


GO

