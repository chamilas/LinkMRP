USE [MRP-Live]
GO

/*Script created at 6/6/2014 9:17 AM.
Please back up your database before running this script.*/

PRINT N'Synchronizing objects from MRP to MRP-Live'
GO

SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS OFF
SET ANSI_PADDING, ANSI_NULLS, QUOTED_IDENTIFIER, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, XACT_ABORT ON
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

BEGIN TRANSACTION
GO

ALTER TABLE [dbo].[tblPckingType]
DROP CONSTRAINT [FK_tblPckingType_tblForm]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

DROP STATISTICS [dbo].[tblActivity].[_WA_Sys_00000004_4CCEAB11]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

DROP STATISTICS [dbo].[tblActivity].[_WA_Sys_00000005_4CCEAB11]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

DROP STATISTICS [dbo].[tblActivity].[_WA_Sys_00000006_4CCEAB11]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

DROP STATISTICS [dbo].[tblActivity].[_WA_Sys_00000008_4CCEAB11]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

DROP STATISTICS [dbo].[tblActivity].[_WA_Sys_00000009_4CCEAB11]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

DROP STATISTICS [dbo].[tblActivity].[_WA_Sys_0000000A_4CCEAB11]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

DROP STATISTICS [dbo].[tblActivity].[_WA_Sys_0000000B_4CCEAB11]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

DROP STATISTICS [dbo].[tblFinishProduct].[_WA_Sys_0000000C_61A803EE]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

DROP STATISTICS [dbo].[tblMachine].[_WA_Sys_0000000D_13CB37DF]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

DROP STATISTICS [dbo].[tblPckingType].[_WA_Sys_00000003_66161CA2]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

DROP STATISTICS [dbo].[tblSupplier].[_WA_Sys_0000000D_77B90916]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_1UnitOf_BasicProduct_To_MaterialOnly]
AS
SELECT CAST(NULL AS varchar(50)) AS [FormulaMaterialCode], CAST(NULL AS numeric(25,11)) AS [Qty], CAST(NULL AS varchar(50)) AS [BasicProductCode]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_1UnitOf_BasicProduct_To_SemiFinishedOnly]
AS
SELECT CAST(NULL AS varchar(50)) AS [BasicProductCode], CAST(NULL AS varchar(50)) AS [FormulaSemiFinisedProductCode], CAST(NULL AS numeric(25,11)) AS [Qty], CAST(NULL AS numeric(18,0)) AS [FormulaID]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_BasicProduct_MaterialTotal]
AS
SELECT CAST(NULL AS varchar(50)) AS [FormulaMaterialCode], CAST(NULL AS numeric(25,11)) AS [Qty], CAST(NULL AS varchar(50)) AS [BasicProductCode]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementFirstWeek]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [FormulaMaterialCode], CAST(NULL AS numeric(38,6)) AS [Qty]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementFirstWeek_PRPD]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [MaterialCode], CAST(NULL AS numeric(38,2)) AS [Qty]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementFirstWeek_Store]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [MaterialCode], CAST(NULL AS numeric(38,2)) AS [Qty]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementFourthWeek]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [FormulaMaterialCode], CAST(NULL AS numeric(38,6)) AS [Qty]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementFourthWeek_PRPD]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [MaterialCode], CAST(NULL AS numeric(38,2)) AS [Qty]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementFourthWeek_Store]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [MaterialCode], CAST(NULL AS numeric(38,2)) AS [Qty]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementMonth]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(500)) AS [MaterialName], CAST(NULL AS varchar(50)) AS [MaterialType], CAST(NULL AS numeric(18,0)) AS [UnitID], CAST(NULL AS numeric(38,6)) AS [Qty1], CAST(NULL AS numeric(38,6)) AS [Qty2], CAST(NULL AS numeric(38,6)) AS [Qty3], CAST(NULL AS numeric(38,6)) AS [Qty4], CAST(NULL AS varchar(50)) AS [MaterialCode]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementMonth_BasicOnly]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [MaterialCode], CAST(NULL AS varchar(500)) AS [MaterialName], CAST(NULL AS numeric(38,6)) AS [Qty1], CAST(NULL AS numeric(38,6)) AS [Qty2], CAST(NULL AS numeric(38,6)) AS [Qty3], CAST(NULL AS numeric(38,6)) AS [Qty4], CAST(NULL AS numeric(18,0)) AS [UnitID]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementMonth_Intermediate_ToBasic]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [MaterialCode], CAST(NULL AS varchar(500)) AS [MaterialName], CAST(NULL AS numeric(18,0)) AS [UnitID], CAST(NULL AS numeric(38,6)) AS [Qty1], CAST(NULL AS numeric(38,6)) AS [Qty2], CAST(NULL AS numeric(38,6)) AS [Qty3], CAST(NULL AS numeric(38,6)) AS [Qty4]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementMonth_IntermediateOnly]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [MaterialCode], CAST(NULL AS varchar(500)) AS [MaterialName], CAST(NULL AS numeric(38,6)) AS [Qty1], CAST(NULL AS numeric(38,6)) AS [Qty2], CAST(NULL AS numeric(38,6)) AS [Qty3], CAST(NULL AS numeric(38,6)) AS [Qty4], CAST(NULL AS numeric(18,0)) AS [UnitID]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementMonth_PRPD]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [MaterialCode], CAST(NULL AS varchar(500)) AS [MaterialName], CAST(NULL AS varchar(50)) AS [MaterialType], CAST(NULL AS numeric(18,0)) AS [UnitID], CAST(NULL AS numeric(38,6)) AS [Qty1], CAST(NULL AS numeric(38,6)) AS [Qty2], CAST(NULL AS numeric(38,6)) AS [Qty3], CAST(NULL AS numeric(38,6)) AS [Qty4], CAST(NULL AS numeric(10,2)) AS [BasicQty]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementSecondWeek]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [FormulaMaterialCode], CAST(NULL AS numeric(38,6)) AS [Qty]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementSecondWeek_PRPD]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [MaterialCode], CAST(NULL AS numeric(38,2)) AS [Qty]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementSecondWeek_Store]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [MaterialCode], CAST(NULL AS numeric(38,2)) AS [Qty]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementThirdWeek]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [FormulaMaterialCode], CAST(NULL AS numeric(38,6)) AS [Qty]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementThirdWeek_PRPD]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [MaterialCode], CAST(NULL AS numeric(38,2)) AS [Qty]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialRequirementThirdWeek_Store]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [MaterialCode], CAST(NULL AS numeric(38,2)) AS [Qty]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialsListMonth]
AS
SELECT CAST(NULL AS varchar(50)) AS [FormulaMaterialCode], CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE VIEW [dbo].[Plan_MaterialsListMonth_PRPD]
AS
SELECT CAST(NULL AS int) AS [Year], CAST(NULL AS varchar(50)) AS [Month], CAST(NULL AS varchar(50)) AS [MaterialCode]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER VIEW [dbo].[View_FinishProduct]
AS
SELECT CAST(NULL AS varchar(50)) AS [FinishProductCode], CAST(NULL AS varchar(2053)) AS [FinishProduct], CAST(NULL AS varchar(50)) AS [BasicProductCode], CAST(NULL AS numeric(18,0)) AS [FinishProdutFormulaID], CAST(NULL AS numeric(18,0)) AS [FinishProdutPackingTypeID], CAST(NULL AS varchar(50)) AS [PackingTitle], CAST(NULL AS numeric(18,2)) AS [PackingQty], CAST(NULL AS varchar(103)) AS [Packing], CAST(NULL AS varchar(2000)) AS [FinishProdutDescription], CAST(NULL AS numeric(18,4)) AS [FinishProdutBasicQty], CAST(NULL AS numeric(10,2)) AS [FinishProdutAvgCost], CAST(NULL AS bit) AS [FinishProdutStatus], CAST(NULL AS varchar(2000)) AS [BasicProductDescription], CAST(NULL AS numeric(18,0)) AS [UnitID], CAST(NULL AS varchar(50)) AS [UnitName], CAST(NULL AS varchar(50)) AS [UnitCode], CAST(NULL AS varchar(50)) AS [PrimaryFinishProductCode], CAST(NULL AS numeric(18,0)) AS [PrimaryFinishProductQty], CAST(NULL AS varchar(50)) AS [FinishProductType]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER VIEW [dbo].[View_MR]
AS
SELECT CAST(NULL AS numeric(8,0)) AS [MRNO], CAST(NULL AS varchar(50)) AS [MRStore], CAST(NULL AS datetime) AS [MRDate], CAST(NULL AS varchar(50)) AS [MRApprovedBy], CAST(NULL AS datetime) AS [MRApproveDate], CAST(NULL AS varchar(50)) AS [MREnterdBy], CAST(NULL AS numeric(18,0)) AS [MRFromDepID], CAST(NULL AS varchar(50)) AS [MRIssuedBy], CAST(NULL AS datetime) AS [MRIssuedDate], CAST(NULL AS varchar(50)) AS [MRReceivedBy], CAST(NULL AS datetime) AS [MRReceivedDate], CAST(NULL AS varchar(5000)) AS [MRRemarks], CAST(NULL AS int) AS [MRStatus], CAST(NULL AS int) AS [MRType], CAST(NULL AS varchar(500)) AS [EnterdBy], CAST(NULL AS varchar(500)) AS [ApprovedBy], CAST(NULL AS varchar(500)) AS [IssuedBy], CAST(NULL AS varchar(500)) AS [ReceivedBy], CAST(NULL AS varchar(500)) AS [StoreName], CAST(NULL AS varchar(500)) AS [DepName], CAST(NULL AS numeric(18,0)) AS [MRSectionID], CAST(NULL AS bit) AS [MRPrint], CAST(NULL AS bit) AS [MRBulkPrint], CAST(NULL AS int) AS [OriginType], CAST(NULL AS varchar(2000)) AS [MRDescription]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER VIEW [dbo].[View_MTN]
AS
SELECT CAST(NULL AS numeric(8,0)) AS [MTNNO], CAST(NULL AS varchar(50)) AS [MTNBatchID], CAST(NULL AS datetime) AS [MTNDate], CAST(NULL AS varchar(50)) AS [MTNApprovedBy], CAST(NULL AS varchar(553)) AS [MTNApprovedByName], CAST(NULL AS datetime) AS [MTNApproveDate], CAST(NULL AS varchar(50)) AS [MTNEnterdBy], CAST(NULL AS varchar(553)) AS [MTNEnterdByName], CAST(NULL AS numeric(18,0)) AS [MTNFromDepID], CAST(NULL AS varchar(500)) AS [FromDepName], CAST(NULL AS numeric(18,0)) AS [MTNToDepID], CAST(NULL AS varchar(500)) AS [DepNameTo], CAST(NULL AS varchar(50)) AS [MTNReceivedBy], CAST(NULL AS varchar(553)) AS [MTNReceivedByName], CAST(NULL AS datetime) AS [MTNReceivedDate], CAST(NULL AS int) AS [MTNStatus], CAST(NULL AS int) AS [MTNType], CAST(NULL AS int) AS [MTNItemType], CAST(NULL AS varchar(50)) AS [MTNStore], CAST(NULL AS varchar(500)) AS [StoreName], CAST(NULL AS varchar(50)) AS [MTNPRPDBatchID], CAST(NULL AS numeric(18,0)) AS [MTNPackingBatch], CAST(NULL AS varchar(50)) AS [MTNBudgetCostBy], CAST(NULL AS datetime) AS [MTNBudgetCostDate], CAST(NULL AS numeric(8,0)) AS [GRNNO], CAST(NULL AS datetime) AS [GRNDate], CAST(NULL AS varchar(50)) AS [GRNEnterdBy], CAST(NULL AS varchar(553)) AS [GRNEnterdByName], CAST(NULL AS datetime) AS [GRNApproveDate], CAST(NULL AS varchar(50)) AS [GRNApprovedBy], CAST(NULL AS varchar(553)) AS [GRNApprovedByName]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER VIEW [dbo].[View_WIP_PackingStock]
AS
SELECT CAST(NULL AS numeric(18,0)) AS [MRSectionID], CAST(NULL AS varchar(5000)) AS [SectionName], CAST(NULL AS varchar(50)) AS [MaterialCode], CAST(NULL AS numeric(18,2)) AS [StartQty], CAST(NULL AS numeric(18,2)) AS [MRUnitRate]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

DROP PROCEDURE [dbo].[SPGET_FinishProduct_DataView_By_ReworkBatchCAP]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

DROP PROCEDURE [dbo].[SPGET_WIPPacking_Files_BySectionID]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Get_PlanMaterialWeek]
(
	-- Add the parameters for the function here
	@Year int,
	@Month varchar(50),
	@RevisionID int,
	@Material varchar(50),
	@WeekID int
)
RETURNS numeric(18,2)
AS
BEGIN
	-- Declare the return variable here
DECLARE @Qty numeric(18,2)

-- Add the T-SQL statements to compute the return value here

select @Qty=ISNULL(Qty,0) from tblPlanMaterials where [Year]=@Year AND [Month]=@Month AND RevisionID=@RevisionID AND MaterialCode=@Material AND WeekID=@WeekID

---------GRN Records

RETURN ISNULL(@Qty,0)

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Get_ProductManforPack]
(
	-- Add the parameters for the function here
	@BasicProductCode varchar(50),
	@Type varchar(50)
)
RETURNS numeric(18,0)
AS
BEGIN
	-- Declare the return variable here
DECLARE @ID numeric(18,0)



	-- Add the T-SQL statements to compute the return value here
IF @Type='Pack'
BEGIN
select @ID=SectionID from tblProductManufacturing where ProductCode=@BasicProductCode and Type=@Type
END
ELSE
BEGIN
select @ID=DepID from tblProductManufacturing where ProductCode=@BasicProductCode and Type=@Type
END

RETURN ISNULL(@ID,0)

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Plan_BasicMaterial]
(
	-- Add the parameters for the function here
	@MaterialCode varchar(50)
)
RETURNS varchar(50)
AS
BEGIN
	-- Declare the return variable here

DECLARE @MatCode varchar(50)

select @MatCode=BasicMaterialCode from tblMaterial where MaterialCode=@MaterialCode
--select @MatCode=BasicProductCode from tblBasicProduct where BasicProductCode=@MaterialCode

RETURN @MatCode

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Plan_BasicQty]
(
	-- Add the parameters for the function here
	@MaterialCode varchar(50),
	@Qty numeric(18,2),
	@Type varchar(50)
)
RETURNS numeric(18,2)
AS
BEGIN
	-- Declare the return variable here

DECLARE @BasicQty numeric(18,2)

select @BasicQty=BasicQty*@Qty from tblMaterial where MaterialCode=@MaterialCode


RETURN ISNULL(@BasicQty,0)

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:  <Author,,Name>
-- ALTER date: <ALTER Date, ,>
-- Description: <Description, ,>
-- =============================================
ALTER FUNCTION [dbo].[Get_GRN_Stock]
(
 -- Add the parameters for the function here
 @MaterialCode varchar(50),
 @StoreID1 varchar(50),
 @StoreID2 varchar(50),
 @GRNStatus_Approved int
)
RETURNS numeric(18,2)
AS
BEGIN
 -- Declare the return variable here
DECLARE @Qty_GRN numeric(18,2)
DECLARE @MatCount int
DECLARE @BPCount int
DECLARE @FGCount int


SELECT @MatCount=count(*) from tblMaterial where MaterialCode=@MaterialCode
SELECT @BPCount=count(*) from tblBasicProduct where BasicProductCode=@MaterialCode
SELECT @FGCount=count(*) from tblFinishProduct where FinishProductCode=@MaterialCode

IF @MatCount>0
BEGIN
DECLARE @MatTypeID varchar(50)
 -- Add the T-SQL statements to compute the return value here

select @MatTypeID=MatTypeID from tblMaterial where MaterialCode=@MaterialCode

---------GRN Records
select @Qty_GRN=SUM(ISNULL(StockQty,0)) from tblStock where StockMaterialID In (select MaterialCode from tblMaterial where MatTypeID=@MatTypeID and MatMainType<>'Intermediate') 
and (StoreID=@StoreID1 OR StoreID=@StoreID2)
END

IF @BPCount>0
BEGIN
-- Add the T-SQL statements to compute the return value here
---------GRN Records
select @Qty_GRN=SUM(ISNULL(StockQty,0)) from tblStock where StockBasicProduct In 
(select BasicProductCode from tblBasicProduct where BasicProductCode=@MaterialCode) 
and (StoreID=@StoreID1 OR StoreID=@StoreID2)
END

IF @FGCount>0
BEGIN
-- Add the T-SQL statements to compute the return value here
---------GRN Records
select @Qty_GRN=SUM(ISNULL(StockQty,0)) from tblStock where StockFinishProduct In 
(select FinishProductCode from tblFinishProduct where FinishProductCode=@FGCount) 
and (StoreID=@StoreID1 OR StoreID=@StoreID2)
END




RETURN ISNULL(@Qty_GRN,0)

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblBasicProduct]
 ADD [STDBatchSize] numeric(18, 2) NULL
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblBatchPackingMR]
 ADD [SectionID] int NULL
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000005_675EAD09]
ON [dbo].[tblBatchPackingMR] ([StartQty])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_0000000E_675EAD09]
ON [dbo].[tblBatchPackingMR] ([SectionID])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblFinishProduct]
DROP COLUMN [SKUID]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_0000000A_29856ED4]
ON [dbo].[tblGRN] ([GRNType])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblMaterialType]
 ADD [ProductOf] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000014_0A0CC37B]
ON [dbo].[tblMTN] ([MTNCostDate])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000009_22DE9A33]
ON [dbo].[tblOptionalFormula] ([Quantity])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000004_22DE9A33]
ON [dbo].[tblOptionalFormula] ([ProductType])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblPckingType]
 ADD [Type] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblPckingType]
DROP COLUMN [PackingFormID]
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000006_66161CA2]
ON [dbo].[tblPckingType] ([Type])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblUser]
 ADD [ExpiryDate] datetime NULL,
	[Online] bit NULL,
	[LastLoggedIn] datetime NULL
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_0000000B_3398E8F3]
ON [dbo].[tblUser] ([LastLoggedIn])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_0000000A_3398E8F3]
ON [dbo].[tblUser] ([Online])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000009_3398E8F3]
ON [dbo].[tblUser] ([ExpiryDate])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblBatchActivityMachineDetails] (
	[ID] int IDENTITY(1, 1),
	[BatchID] numeric(18, 0) NOT NULL,
	[MachineID] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[InputQty] numeric(18, 2) NULL,
	[OutputQty] numeric(18, 2) NULL,
	[RejectedQty] numeric(18, 2) NULL
) ON [PRIMARY]
WITH(DATA_COMPRESSION = NONE)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblBatchActivityMachineDetails] SET(LOCK_ESCALATION = TABLE)

GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000002_14FF533A]
ON [dbo].[tblBatchActivityMachineDetails] ([BatchID])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCustomer] (
	[CustomerID] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Name] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Address] varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Telephone] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ProductType] varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[SalesMethod] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Territory] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT [PK_tblCustomers] PRIMARY KEY ([CustomerID] ASC) WITH (FILLFACTOR=100,
		DATA_COMPRESSION = NONE) ON [PRIMARY]
)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblCustomer] SET(LOCK_ESCALATION = TABLE)

GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000006_1EF2D1C8]
ON [dbo].[tblCustomer] ([SalesMethod])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCustomerTerritoryList] (
	[ID] numeric(18, 0) IDENTITY(1, 1),
	[TerritoryID] numeric(18, 0) NULL,
	[CustomerID] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TerritoryName] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT [PK_tblCustomerTerritoryList] PRIMARY KEY ([ID] ASC) WITH (FILLFACTOR=100,
		DATA_COMPRESSION = NONE) ON [PRIMARY]
)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblCustomerTerritoryList] SET(LOCK_ESCALATION = TABLE)

GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000003_278817C9]
ON [dbo].[tblCustomerTerritoryList] ([CustomerID])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblDispatchIssueList] (
	[DispatchID] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[GRNID] numeric(8, 0) NOT NULL,
	[Status] int NULL,
	[IssuDate] datetime NOT NULL,
	[IssuedQty] numeric(20, 3) NULL,
	CONSTRAINT [PK_tblDispatchIssueList] PRIMARY KEY ([DispatchID] ASC, [GRNID] ASC) WITH (FILLFACTOR=100,
		DATA_COMPRESSION = NONE) ON [PRIMARY]
)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblDispatchIssueList] SET(LOCK_ESCALATION = TABLE)

GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblFinishGoodsReturn] (
	[GRNNo] numeric(18, 0) NOT NULL,
	[CustomerID] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[TerritoryID] nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT [PK_ReturnFinishGoods] PRIMARY KEY ([GRNNo] ASC) WITH (FILLFACTOR=100,
		DATA_COMPRESSION = NONE) ON [PRIMARY]
)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblFinishGoodsReturn] SET(LOCK_ESCALATION = TABLE)

GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPlanBatch] (
	[Year] int NOT NULL,
	[Month] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[RevisionID] int NOT NULL,
	[ProductCode] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[WeekID] int NOT NULL,
	[BatchSize] decimal(18, 2) NOT NULL,
	[Nos] int NULL,
	[Status] int NULL,
	[BatchLevel] int NULL,
	CONSTRAINT [PK_tblPlanBatch] PRIMARY KEY ([Year] ASC, [Month] ASC, [RevisionID] ASC, [ProductCode] ASC, [WeekID] ASC) WITH (FILLFACTOR=100,
		DATA_COMPRESSION = NONE) ON [PRIMARY]
)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblPlanBatch] SET(LOCK_ESCALATION = TABLE)

GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000005_5E4E3CCE]
ON [dbo].[tblPlanBatch] ([WeekID])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000003_5E4E3CCE]
ON [dbo].[tblPlanBatch] ([RevisionID])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000002_5E4E3CCE]
ON [dbo].[tblPlanBatch] ([Month])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000004_5E4E3CCE]
ON [dbo].[tblPlanBatch] ([ProductCode])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000007_5E4E3CCE]
ON [dbo].[tblPlanBatch] ([Nos])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000006_5E4E3CCE]
ON [dbo].[tblPlanBatch] ([BatchSize])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000009_5E4E3CCE]
ON [dbo].[tblPlanBatch] ([BatchLevel])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPlanMaterials] (
	[Year] int NOT NULL,
	[Month] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[RevisionID] int NOT NULL,
	[WeekID] int NOT NULL,
	[MaterialCode] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Type] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Qty] numeric(18, 2) NULL,
	[Status] int NULL,
	CONSTRAINT [PK_tblPlanMaterials] PRIMARY KEY ([Year] ASC, [Month] ASC, [RevisionID] ASC, [WeekID] ASC, [MaterialCode] ASC, [Type] ASC) WITH (FILLFACTOR=100,
		DATA_COMPRESSION = NONE) ON [PRIMARY]
)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblPlanMaterials] SET(LOCK_ESCALATION = TABLE)

GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000006_2A998E9E]
ON [dbo].[tblPlanMaterials] ([Type])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000002_2A998E9E]
ON [dbo].[tblPlanMaterials] ([Month])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000004_2A998E9E]
ON [dbo].[tblPlanMaterials] ([WeekID])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000003_2A998E9E]
ON [dbo].[tblPlanMaterials] ([RevisionID])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000005_2A998E9E]
ON [dbo].[tblPlanMaterials] ([MaterialCode])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000008_2A998E9E]
ON [dbo].[tblPlanMaterials] ([Status])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000007_2A998E9E]
ON [dbo].[tblPlanMaterials] ([Qty])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPlanWeeks] (
	[Year] int NOT NULL,
	[Month] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[WeekID] int NOT NULL,
	[RevisionID] int NOT NULL,
	[FromDate] date NULL,
	[ToDate] date NULL,
	[State] int NULL,
	CONSTRAINT [PK_tblPlanWeeks] PRIMARY KEY ([Year] ASC, [Month] ASC, [WeekID] ASC, [RevisionID] ASC) WITH (FILLFACTOR=100,
		DATA_COMPRESSION = NONE) ON [PRIMARY]
)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblPlanWeeks] SET(LOCK_ESCALATION = TABLE)

GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000002_60368540]
ON [dbo].[tblPlanWeeks] ([Month])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000004_60368540]
ON [dbo].[tblPlanWeeks] ([RevisionID])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000003_60368540]
ON [dbo].[tblPlanWeeks] ([WeekID])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000007_60368540]
ON [dbo].[tblPlanWeeks] ([State])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblProjectMaterials] (
	[ID] int IDENTITY(1, 1),
	[ProjectID] int NULL,
	[MaterialCode] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[BasicProductCode] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FinishProductCode] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[UsedQty] numeric(18, 3) NULL,
	[DamagedQty] numeric(18, 3) NULL,
	[GRNNO] numeric(8, 0) NULL,
	[UnitPrice] numeric(18, 2) NULL,
	[EnteredBy] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[EnteredDate] datetime NULL,
	CONSTRAINT [PK_tblProjectMaterials] PRIMARY KEY ([ID] ASC) WITH (FILLFACTOR=100,
		DATA_COMPRESSION = NONE) ON [PRIMARY]
)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblProjectMaterials] SET(LOCK_ESCALATION = TABLE)

GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblProjects] (
	[ProjectID] int NOT NULL,
	[ProjectName] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DepID] numeric(18, 0) NULL,
	[Status] int NULL,
	[ProjectType] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT [PK_tblProjects] PRIMARY KEY ([ProjectID] ASC) WITH (FILLFACTOR=100,
		DATA_COMPRESSION = NONE) ON [PRIMARY]
)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblProjects] SET(LOCK_ESCALATION = TABLE)

GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000003_36FF6583]
ON [dbo].[tblProjects] ([DepID])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblSalesForecast] (
	[ID] int IDENTITY(1, 1),
	[RevisionNo] int NULL,
	[Year] int NULL,
	[Month] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[WeekID] int NULL,
	[Date] date NULL,
	[Accuracy] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[State] int NULL,
	[EnteredBy] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[EnteredDate] datetime NULL,
	CONSTRAINT [PK_tblSalesForecast] PRIMARY KEY ([ID] ASC) WITH (FILLFACTOR=100,
		DATA_COMPRESSION = NONE) ON [PRIMARY]
)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblSalesForecast] SET(LOCK_ESCALATION = TABLE)

GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000008_598987B1]
ON [dbo].[tblSalesForecast] ([State])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000004_598987B1]
ON [dbo].[tblSalesForecast] ([Month])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000003_598987B1]
ON [dbo].[tblSalesForecast] ([Year])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000005_598987B1]
ON [dbo].[tblSalesForecast] ([WeekID])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000009_598987B1]
ON [dbo].[tblSalesForecast] ([EnteredBy])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblSalesForecastDetails] (
	[SalesForecastID] int NOT NULL,
	[RevisionID] int NOT NULL,
	[ProductCode] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Qty] int NULL,
	CONSTRAINT [PK_tblSalesForecastDetails] PRIMARY KEY ([SalesForecastID] ASC, [RevisionID] ASC, [ProductCode] ASC) WITH (FILLFACTOR=100,
		DATA_COMPRESSION = NONE) ON [PRIMARY]
)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblSalesForecastDetails] SET(LOCK_ESCALATION = TABLE)

GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000002_5A7DABEA]
ON [dbo].[tblSalesForecastDetails] ([RevisionID])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

CREATE STATISTICS [_WA_Sys_00000003_5A7DABEA]
ON [dbo].[tblSalesForecastDetails] ([ProductCode])
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblSalesMethod] (
	[SalesMethodID] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[SMDesctiption] varchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT [PK_tblSalesMethod] PRIMARY KEY ([SalesMethodID] ASC) WITH (FILLFACTOR=100,
		DATA_COMPRESSION = NONE) ON [PRIMARY]
)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblSalesMethod] SET(LOCK_ESCALATION = TABLE)

GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[Plan_1UnitOf_BasicProduct_To_MaterialOnly]
AS
SELECT        dbo.tblFormulaMaterial.FormulaMaterialCode, dbo.tblFormulaMaterial.FormulaQty / 1000 AS Qty, dbo.tblBasicProduct.BasicProductCode
FROM            dbo.tblBasicProduct INNER JOIN
                         dbo.tblFormulaMaterial ON dbo.tblBasicProduct.BasicProductFormulaID = dbo.tblFormulaMaterial.FormulaID
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[Plan_1UnitOf_BasicProduct_To_SemiFinishedOnly]
AS
SELECT        dbo.tblBasicProduct.BasicProductCode, dbo.tblFormulaBasicProduct.FormulaBasicProductCode AS FormulaSemiFinisedProductCode, 
                         dbo.tblFormulaBasicProduct.FormulaProductQty / 1000 AS Qty, tblBasicProduct_1.BasicProductFormulaID AS FormulaID
FROM            dbo.tblBasicProduct INNER JOIN
                         dbo.tblFormulaBasicProduct ON dbo.tblBasicProduct.BasicProductFormulaID = dbo.tblFormulaBasicProduct.FormulaID INNER JOIN
                         dbo.tblBasicProduct AS tblBasicProduct_1 ON dbo.tblFormulaBasicProduct.FormulaBasicProductCode = tblBasicProduct_1.BasicProductCode
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[Plan_BasicProduct_MaterialTotal]
AS
SELECT        FormulaMaterialCode, Qty, BasicProductCode
FROM            dbo.Plan_1UnitOf_BasicProduct_To_MaterialOnly
UNION
SELECT        FormulaSemiFinisedProductCode AS FormulaMaterialCode, Qty, BasicProductCode
FROM            dbo.Plan_1UnitOf_BasicProduct_To_SemiFinishedOnly
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementFirstWeek
AS
SELECT        dbo.tblPlanBatch.Year, dbo.tblPlanBatch.Month, dbo.Plan_BasicProduct_MaterialTotal.FormulaMaterialCode, SUM(ISNULL(dbo.Plan_BasicProduct_MaterialTotal.Qty, 0) 
                         * dbo.tblPlanBatch.BatchSize * dbo.tblPlanBatch.Nos) AS Qty
FROM            dbo.tblPlanBatch INNER JOIN
                         dbo.Plan_BasicProduct_MaterialTotal ON dbo.tblPlanBatch.ProductCode = dbo.Plan_BasicProduct_MaterialTotal.BasicProductCode
WHERE        (dbo.tblPlanBatch.WeekID = 1) AND (dbo.tblPlanBatch.BatchLevel = 0)
GROUP BY dbo.tblPlanBatch.Year, dbo.tblPlanBatch.Month, dbo.tblPlanBatch.WeekID, dbo.tblPlanBatch.RevisionID, dbo.Plan_BasicProduct_MaterialTotal.FormulaMaterialCode
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementFirstWeek_PRPD
AS
SELECT        Year, Month, dbo.Plan_BasicMaterial(FormulaMaterialCode) AS MaterialCode, SUM(dbo.Plan_BasicQty(FormulaMaterialCode, Qty, 'PRPD')) AS Qty
FROM            dbo.Plan_MaterialRequirementFirstWeek
GROUP BY Year, Month, dbo.Plan_BasicMaterial(FormulaMaterialCode)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementFirstWeek_Store
AS
SELECT        Year, Month, dbo.Plan_BasicMaterial(MaterialCode) AS MaterialCode, SUM(dbo.Plan_BasicQty(MaterialCode, Qty, 'Store')) AS Qty
FROM            dbo.Plan_MaterialRequirementFirstWeek_PRPD
GROUP BY Year, Month, dbo.Plan_BasicMaterial(MaterialCode)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementFourthWeek
AS
SELECT        dbo.tblPlanBatch.Year, dbo.tblPlanBatch.Month, dbo.Plan_BasicProduct_MaterialTotal.FormulaMaterialCode, SUM(ISNULL(dbo.Plan_BasicProduct_MaterialTotal.Qty, 0) 
                         * dbo.tblPlanBatch.BatchSize * dbo.tblPlanBatch.Nos) AS Qty
FROM            dbo.tblPlanBatch INNER JOIN
                         dbo.Plan_BasicProduct_MaterialTotal ON dbo.tblPlanBatch.ProductCode = dbo.Plan_BasicProduct_MaterialTotal.BasicProductCode
WHERE        (dbo.tblPlanBatch.WeekID = 4) AND (dbo.tblPlanBatch.BatchLevel = 0)
GROUP BY dbo.tblPlanBatch.Year, dbo.tblPlanBatch.Month, dbo.tblPlanBatch.WeekID, dbo.tblPlanBatch.RevisionID, dbo.Plan_BasicProduct_MaterialTotal.FormulaMaterialCode
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementFourthWeek_PRPD
AS
SELECT        Year, Month, dbo.Plan_BasicMaterial(FormulaMaterialCode) AS MaterialCode, SUM(dbo.Plan_BasicQty(FormulaMaterialCode, Qty, 'PRPD')) AS Qty
FROM            dbo.Plan_MaterialRequirementFourthWeek
GROUP BY Year, Month, dbo.Plan_BasicMaterial(FormulaMaterialCode)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementFourthWeek_Store
AS
SELECT        Year, Month, dbo.Plan_BasicMaterial(MaterialCode) AS MaterialCode, SUM(dbo.Plan_BasicQty(MaterialCode, Qty, 'Store')) AS Qty
FROM            dbo.Plan_MaterialRequirementFourthWeek_PRPD
GROUP BY Year, Month, dbo.Plan_BasicMaterial(MaterialCode)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementSecondWeek
AS
SELECT        dbo.tblPlanBatch.Year, dbo.tblPlanBatch.Month, dbo.Plan_BasicProduct_MaterialTotal.FormulaMaterialCode, SUM(ISNULL(dbo.Plan_BasicProduct_MaterialTotal.Qty, 0) 
                         * dbo.tblPlanBatch.BatchSize * dbo.tblPlanBatch.Nos) AS Qty
FROM            dbo.tblPlanBatch INNER JOIN
                         dbo.Plan_BasicProduct_MaterialTotal ON dbo.tblPlanBatch.ProductCode = dbo.Plan_BasicProduct_MaterialTotal.BasicProductCode
WHERE        (dbo.tblPlanBatch.WeekID = 2) AND (dbo.tblPlanBatch.BatchLevel = 0)
GROUP BY dbo.tblPlanBatch.Year, dbo.tblPlanBatch.Month, dbo.tblPlanBatch.WeekID, dbo.tblPlanBatch.RevisionID, dbo.Plan_BasicProduct_MaterialTotal.FormulaMaterialCode
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementSecondWeek_PRPD
AS
SELECT        Year, Month, dbo.Plan_BasicMaterial(FormulaMaterialCode) AS MaterialCode, SUM(dbo.Plan_BasicQty(FormulaMaterialCode, Qty, 'PRPD')) AS Qty
FROM            dbo.Plan_MaterialRequirementSecondWeek
GROUP BY Year, Month, dbo.Plan_BasicMaterial(FormulaMaterialCode)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementSecondWeek_Store
AS
SELECT        Year, Month, dbo.Plan_BasicMaterial(MaterialCode) AS MaterialCode, SUM(dbo.Plan_BasicQty(MaterialCode, Qty, 'Store')) AS Qty
FROM            dbo.Plan_MaterialRequirementSecondWeek_PRPD
GROUP BY Year, Month, dbo.Plan_BasicMaterial(MaterialCode)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementThirdWeek
AS
SELECT        dbo.tblPlanBatch.Year, dbo.tblPlanBatch.Month, dbo.Plan_BasicProduct_MaterialTotal.FormulaMaterialCode, SUM(ISNULL(dbo.Plan_BasicProduct_MaterialTotal.Qty, 0) 
                         * dbo.tblPlanBatch.BatchSize * dbo.tblPlanBatch.Nos) AS Qty
FROM            dbo.tblPlanBatch INNER JOIN
                         dbo.Plan_BasicProduct_MaterialTotal ON dbo.tblPlanBatch.ProductCode = dbo.Plan_BasicProduct_MaterialTotal.BasicProductCode
WHERE        (dbo.tblPlanBatch.WeekID = 3) AND (dbo.tblPlanBatch.BatchLevel = 0)
GROUP BY dbo.tblPlanBatch.Year, dbo.tblPlanBatch.Month, dbo.tblPlanBatch.WeekID, dbo.tblPlanBatch.RevisionID, dbo.Plan_BasicProduct_MaterialTotal.FormulaMaterialCode
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementThirdWeek_PRPD
AS
SELECT        Year, Month, dbo.Plan_BasicMaterial(FormulaMaterialCode) AS MaterialCode, SUM(dbo.Plan_BasicQty(FormulaMaterialCode, Qty, 'PRPD')) AS Qty
FROM            dbo.Plan_MaterialRequirementThirdWeek
GROUP BY Year, Month, dbo.Plan_BasicMaterial(FormulaMaterialCode)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementThirdWeek_Store
AS
SELECT        Year, Month, dbo.Plan_BasicMaterial(MaterialCode) AS MaterialCode, SUM(dbo.Plan_BasicQty(MaterialCode, Qty, 'Store')) AS Qty
FROM            dbo.Plan_MaterialRequirementThirdWeek_PRPD
GROUP BY Year, Month, dbo.Plan_BasicMaterial(MaterialCode)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialsListMonth
AS
SELECT        FormulaMaterialCode, Year, Month
FROM            dbo.Plan_MaterialRequirementFirstWeek
UNION
SELECT        FormulaMaterialCode, Year, Month
FROM            dbo.Plan_MaterialRequirementSecondWeek
UNION
SELECT        FormulaMaterialCode, Year, Month
FROM            dbo.Plan_MaterialRequirementThirdWeek
UNION
SELECT        FormulaMaterialCode, Year, Month
FROM            dbo.Plan_MaterialRequirementFourthWeek
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[View_FinishProduct]
AS
SELECT     dbo.tblFinishProduct.FinishProductCode, dbo.tblFinishProduct.FinishProductCode + ' - ' + dbo.tblFinishProduct.FinishProdutDescription AS FinishProduct, 
                      dbo.tblFinishProduct.BasicProductCode, dbo.tblFinishProduct.FinishProdutFormulaID, dbo.tblFinishProduct.FinishProdutPackingTypeID, 
                      dbo.tblPckingType.PackingTitle, dbo.tblPckingType.PackingQty, dbo.tblPckingType.PackingTitle + ' - ' + CAST(dbo.tblPckingType.PackingQty AS VARCHAR(50)) 
                      AS Packing, dbo.tblFinishProduct.FinishProdutDescription, dbo.tblFinishProduct.FinishProdutBasicQty, dbo.tblFinishProduct.FinishProdutAvgCost, 
                      dbo.tblFinishProduct.FinishProdutStatus, dbo.tblBasicProduct.BasicProductDescription, dbo.tblUnit.UnitID, dbo.tblUnit.UnitName, dbo.tblUnit.UnitCode, 
                      dbo.tblFinishProduct.PrimaryFinishProductCode, dbo.tblFinishProduct.PrimaryFinishProductQty, dbo.tblFinishProduct.FinishProductType
FROM         dbo.tblFinishProduct INNER JOIN
                      dbo.tblBasicProduct ON dbo.tblFinishProduct.BasicProductCode = dbo.tblBasicProduct.BasicProductCode INNER JOIN
                      dbo.tblPckingType ON dbo.tblFinishProduct.FinishProdutPackingTypeID = dbo.tblPckingType.PackingID INNER JOIN
                      dbo.tblUnit ON dbo.tblPckingType.PackingUnitID = dbo.tblUnit.UnitID
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[View_MR]
AS
SELECT        tblMR.MRNO, tblMR.MRStore, tblMR.MRDate, tblMR.MRApprovedBy, tblMR.MRApproveDate, tblMR.MREnterdBy, tblMR.MRFromDepID, tblMR.MRIssuedBy, tblMR.MRIssuedDate, tblMR.MRReceivedBy, 
                         tblMR.MRReceivedDate, tblMR.MRRemarks, tblMR.MRStatus, tblMR.MRType, EnterdBy.EmpName AS EnterdBy, ApprovedBy.EmpName AS ApprovedBy, IssuedBy.EmpName AS IssuedBy, 
                         ReceivedBy.EmpName AS ReceivedBy, tblStore.StoreName, tblDepartment.DepName, tblMR.MRSectionID, tblMR.MRPrint, tblMR.MRBulkPrint, tblMR.OriginType, tblMRMaterial.MRDescription
FROM            tblMR INNER JOIN
                         tblStore ON tblMR.MRStore = tblStore.StoreID INNER JOIN
                         tblDepartment ON tblMR.MRFromDepID = tblDepartment.DepID INNER JOIN
                         tblMRMaterial ON tblMR.MRNO = tblMRMaterial.MRNO LEFT OUTER JOIN
                         tblEmployee AS ApprovedBy ON tblMR.MRApprovedBy = ApprovedBy.EmpID LEFT OUTER JOIN
                         tblEmployee AS EnterdBy ON tblMR.MREnterdBy = EnterdBy.EmpID LEFT OUTER JOIN
                         tblEmployee AS IssuedBy ON tblMR.MRIssuedBy = IssuedBy.EmpID LEFT OUTER JOIN
                         tblEmployee AS ReceivedBy ON tblMR.MRReceivedBy = ReceivedBy.EmpID
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[View_MTN]
AS
SELECT        tblMTN.MTNNO, tblMTN.MTNBatchID, tblMTN.MTNDate, tblMTN.MTNApprovedBy, View_Employee_2.Employee AS MTNApprovedByName, tblMTN.MTNApproveDate, tblMTN.MTNEnterdBy, 
                         View_Employee_1.Employee AS MTNEnterdByName, tblMTN.MTNFromDepID, tblDepartment_1.DepName AS FromDepName, tblMTN.MTNToDepID, tblDepartment.DepName AS DepNameTo, 
                         tblMTN.MTNReceivedBy, View_Employee_3.Employee AS MTNReceivedByName, tblMTN.MTNReceivedDate, tblMTN.MTNStatus, tblMTN.MTNType, tblMTN.MTNItemType, tblMTN.MTNStore, tblStore.StoreName, 
                         tblMTN.MTNPRPDBatchID, tblMTN.MTNPackingBatch, tblMTN.MTNBudgetCostBy, tblMTN.MTNBudgetCostDate, tblGRN.GRNNO, tblGRN.GRNDate, tblGRN.GRNEnterdBy, View_Employee.Employee as GRNEnterdByName, 
                         tblGRN.GRNApproveDate, tblGRN.GRNApprovedBy, View_Employee_4.Employee AS GRNApprovedByName
FROM            tblMTN INNER JOIN
                         tblDepartment ON tblMTN.MTNToDepID = tblDepartment.DepID INNER JOIN
                         tblGRN ON tblMTN.MTNNO = tblGRN.GRNMTNNO INNER JOIN
                         View_Employee ON tblGRN.GRNEnterdBy = View_Employee.EmpID INNER JOIN
                         View_Employee AS View_Employee_4 ON tblGRN.GRNApprovedBy = View_Employee_4.EmpID LEFT OUTER JOIN
                         tblStore ON tblGRN.GRNStoreID = tblStore.StoreID AND tblMTN.MTNStore = tblStore.StoreID LEFT OUTER JOIN
                         tblDepartment AS tblDepartment_1 ON tblMTN.MTNFromDepID = tblDepartment_1.DepID LEFT OUTER JOIN
                         View_Employee AS View_Employee_3 ON tblMTN.MTNReceivedBy = View_Employee_3.EmpID LEFT OUTER JOIN
                         View_Employee AS View_Employee_1 ON tblMTN.MTNEnterdBy = View_Employee_1.EmpID LEFT OUTER JOIN
                         View_Employee AS View_Employee_2 ON tblMTN.MTNApprovedBy = View_Employee_2.EmpID
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.View_WIP_PackingStock
AS
SELECT        dbo.tblMR.MRSectionID, dbo.tblSection.SectionName, dbo.tblBatchPackingMR.MaterialCode, dbo.tblBatchPackingMR.StartQty, 
                         dbo.tblMRMaterial.MRUnitRate
FROM            dbo.tblBatchPackingMR INNER JOIN
                         dbo.tblMR ON dbo.tblBatchPackingMR.MRNO = dbo.tblMR.MRNO INNER JOIN
                         dbo.tblMRMaterial ON dbo.tblBatchPackingMR.MRNO = dbo.tblMRMaterial.MRNO AND 
                         dbo.tblBatchPackingMR.MaterialCode = dbo.tblMRMaterial.MRMaterialCode INNER JOIN
                         dbo.tblSection ON dbo.tblMR.MRSectionID = dbo.tblSection.SectionID
WHERE        (dbo.tblBatchPackingMR.State = 0)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementMonth
AS
SELECT        TOP (100) PERCENT dbo.Plan_MaterialsListMonth.Year, dbo.Plan_MaterialsListMonth.Month, dbo.tblMaterial.MaterialDescription AS MaterialName, 
                         dbo.tblMaterial.MatMainType AS MaterialType, dbo.tblMaterial.UnitID, SUM(ISNULL(dbo.Plan_MaterialRequirementFirstWeek.Qty, 0)) AS Qty1, 
                         SUM(ISNULL(dbo.Plan_MaterialRequirementSecondWeek.Qty, 0)) AS Qty2, SUM(ISNULL(dbo.Plan_MaterialRequirementThirdWeek.Qty, 0)) AS Qty3, 
                         SUM(ISNULL(dbo.Plan_MaterialRequirementFourthWeek.Qty, 0)) AS Qty4, dbo.tblMaterial.MaterialCode
FROM            dbo.Plan_MaterialRequirementFirstWeek RIGHT OUTER JOIN
                         dbo.Plan_MaterialRequirementSecondWeek RIGHT OUTER JOIN
                         dbo.tblMaterial INNER JOIN
                         dbo.Plan_MaterialsListMonth ON dbo.tblMaterial.MaterialCode = dbo.Plan_MaterialsListMonth.FormulaMaterialCode ON 
                         dbo.Plan_MaterialRequirementSecondWeek.Year = dbo.Plan_MaterialsListMonth.Year AND 
                         dbo.Plan_MaterialRequirementSecondWeek.Month = dbo.Plan_MaterialsListMonth.Month AND 
                         dbo.Plan_MaterialRequirementSecondWeek.FormulaMaterialCode = dbo.Plan_MaterialsListMonth.FormulaMaterialCode LEFT OUTER JOIN
                         dbo.Plan_MaterialRequirementFourthWeek ON dbo.Plan_MaterialsListMonth.Year = dbo.Plan_MaterialRequirementFourthWeek.Year AND 
                         dbo.Plan_MaterialsListMonth.Month = dbo.Plan_MaterialRequirementFourthWeek.Month AND 
                         dbo.Plan_MaterialsListMonth.FormulaMaterialCode = dbo.Plan_MaterialRequirementFourthWeek.FormulaMaterialCode LEFT OUTER JOIN
                         dbo.Plan_MaterialRequirementThirdWeek ON dbo.Plan_MaterialsListMonth.Year = dbo.Plan_MaterialRequirementThirdWeek.Year AND 
                         dbo.Plan_MaterialRequirementThirdWeek.Month = dbo.Plan_MaterialRequirementThirdWeek.Month AND 
                         dbo.Plan_MaterialsListMonth.FormulaMaterialCode = dbo.Plan_MaterialRequirementThirdWeek.FormulaMaterialCode ON 
                         dbo.Plan_MaterialRequirementFirstWeek.Year = dbo.Plan_MaterialsListMonth.Year AND 
                         dbo.Plan_MaterialRequirementFirstWeek.Month = dbo.Plan_MaterialsListMonth.Month AND 
                         dbo.Plan_MaterialRequirementFirstWeek.FormulaMaterialCode = dbo.Plan_MaterialsListMonth.FormulaMaterialCode
GROUP BY dbo.Plan_MaterialsListMonth.Year, dbo.Plan_MaterialsListMonth.Month, dbo.tblMaterial.MaterialCode, dbo.tblMaterial.MaterialDescription, 
                         dbo.tblMaterial.MatMainType, dbo.tblMaterial.UnitID
ORDER BY dbo.Plan_MaterialsListMonth.Year, dbo.Plan_MaterialsListMonth.Month
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementMonth_BasicOnly
AS
SELECT        Year, Month, MaterialCode, MaterialName, Qty1, Qty2, Qty3, Qty4, UnitID
FROM            dbo.Plan_MaterialRequirementMonth
WHERE        (MaterialType = 'Basic')
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementMonth_IntermediateOnly
AS
SELECT        Year, Month, MaterialCode, MaterialName, Qty1, Qty2, Qty3, Qty4, UnitID
FROM            dbo.Plan_MaterialRequirementMonth
WHERE        (MaterialType = 'Intermediate') OR
                         (MaterialType = 'Processed')
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementMonth_Intermediate_ToBasic
AS
SELECT        dbo.Plan_MaterialRequirementMonth_IntermediateOnly.Year, dbo.Plan_MaterialRequirementMonth_IntermediateOnly.Month, 
                         dbo.tblMaterial.BasicMaterialCode AS MaterialCode, tblMaterials_1.MaterialDescription AS MaterialName, tblMaterials_1.UnitID, 
                         ISNULL(dbo.tblMaterial.BasicQty * dbo.Plan_MaterialRequirementMonth_IntermediateOnly.Qty1, 0) AS Qty1, 
                         ISNULL(dbo.tblMaterial.BasicQty * dbo.Plan_MaterialRequirementMonth_IntermediateOnly.Qty2, 0) AS Qty2, 
                         ISNULL(dbo.tblMaterial.BasicQty * dbo.Plan_MaterialRequirementMonth_IntermediateOnly.Qty3, 0) AS Qty3, 
                         ISNULL(dbo.tblMaterial.BasicQty * dbo.Plan_MaterialRequirementMonth_IntermediateOnly.Qty4, 0) AS Qty4
FROM            dbo.Plan_MaterialRequirementMonth_IntermediateOnly INNER JOIN
                         dbo.tblMaterial ON dbo.Plan_MaterialRequirementMonth_IntermediateOnly.MaterialCode = dbo.tblMaterial.MaterialCode INNER JOIN
                         dbo.tblMaterial AS tblMaterials_1 ON dbo.tblMaterial.BasicMaterialCode = tblMaterials_1.MaterialCode
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialsListMonth_PRPD
AS
SELECT        Plan_MaterialRequirementMonth_BasicOnly.Year, 
                         Plan_MaterialRequirementMonth_BasicOnly.Month, 
                         Plan_MaterialRequirementMonth_BasicOnly.MaterialCode AS MaterialCode
FROM            Plan_MaterialRequirementMonth_BasicOnly
UNION
SELECT           Plan_MaterialRequirementMonth_Intermediate_ToBasic.Year, 
                         Plan_MaterialRequirementMonth_Intermediate_ToBasic.Month, 
                         Plan_MaterialRequirementMonth_Intermediate_ToBasic.MaterialCode AS MaterialCode
FROM            Plan_MaterialRequirementMonth_Intermediate_ToBasic
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW dbo.Plan_MaterialRequirementMonth_PRPD
AS
SELECT        dbo.Plan_MaterialsListMonth_PRPD.Year, dbo.Plan_MaterialsListMonth_PRPD.Month, dbo.Plan_MaterialsListMonth_PRPD.MaterialCode, 
                         dbo.tblMaterial.MaterialDescription AS MaterialName, dbo.tblMaterial.MatMainType AS MaterialType, dbo.tblMaterial.UnitID, 
                         SUM(ISNULL(dbo.Plan_MaterialRequirementMonth_BasicOnly.Qty1, 0)) + SUM(ISNULL(dbo.Plan_MaterialRequirementMonth_Intermediate_ToBasic.Qty1, 0)) 
                         AS Qty1, SUM(ISNULL(dbo.Plan_MaterialRequirementMonth_BasicOnly.Qty2, 0)) 
                         + SUM(ISNULL(dbo.Plan_MaterialRequirementMonth_Intermediate_ToBasic.Qty2, 0)) AS Qty2, 
                         SUM(ISNULL(dbo.Plan_MaterialRequirementMonth_BasicOnly.Qty3, 0)) + SUM(ISNULL(dbo.Plan_MaterialRequirementMonth_Intermediate_ToBasic.Qty3, 0)) 
                         AS Qty3, SUM(ISNULL(dbo.Plan_MaterialRequirementMonth_BasicOnly.Qty4, 0)) 
                         + SUM(ISNULL(dbo.Plan_MaterialRequirementMonth_Intermediate_ToBasic.Qty4, 0)) AS Qty4, dbo.tblMaterial.BasicQty
FROM            dbo.Plan_MaterialsListMonth_PRPD INNER JOIN
                         dbo.tblMaterial ON dbo.Plan_MaterialsListMonth_PRPD.MaterialCode = dbo.tblMaterial.MaterialCode LEFT OUTER JOIN
                         dbo.Plan_MaterialRequirementMonth_BasicOnly ON dbo.Plan_MaterialsListMonth_PRPD.Year = dbo.Plan_MaterialRequirementMonth_BasicOnly.Year AND 
                         dbo.Plan_MaterialsListMonth_PRPD.Month = dbo.Plan_MaterialRequirementMonth_BasicOnly.Month AND 
                         dbo.Plan_MaterialsListMonth_PRPD.MaterialCode = dbo.Plan_MaterialRequirementMonth_BasicOnly.MaterialCode LEFT OUTER JOIN
                         dbo.Plan_MaterialRequirementMonth_Intermediate_ToBasic ON 
                         dbo.Plan_MaterialsListMonth_PRPD.Year = dbo.Plan_MaterialRequirementMonth_Intermediate_ToBasic.Year AND 
                         dbo.Plan_MaterialsListMonth_PRPD.Month = dbo.Plan_MaterialRequirementMonth_Intermediate_ToBasic.Month AND 
                         dbo.Plan_MaterialsListMonth_PRPD.MaterialCode = dbo.Plan_MaterialRequirementMonth_Intermediate_ToBasic.MaterialCode
GROUP BY dbo.Plan_MaterialsListMonth_PRPD.Year, dbo.Plan_MaterialsListMonth_PRPD.Month, dbo.Plan_MaterialsListMonth_PRPD.MaterialCode, 
                         dbo.tblMaterial.MaterialDescription, dbo.tblMaterial.MatMainType, dbo.tblMaterial.UnitID, dbo.tblMaterial.BasicQty
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_BatchActivityMachineDetails]
(

	@BatchID numeric(18, 0),
	@MachineID varchar(50),
	@InputQty numeric(18, 2),
	@OutputQty numeric(18, 2),
	@RejectedQty numeric(18, 2),
	@outParam numeric(18, 0) OUT
)
AS
	SET NOCOUNT OFF;
BEGIN
INSERT INTO tblBatchActivityMachineDetails
                         (BatchID, MachineID, InputQty, OutputQty, RejectedQty)
VALUES        (@BatchID,@MachineID,@InputQty,@OutputQty,@RejectedQty)
SET @outParam = SCOPE_IDENTITY()
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_Customer]
(

	@CustomerID varchar(20),
	@Name varchar(50),
	@Address varchar(100),
	@Telephone varchar(20),
	@ProductType varchar(30),
	@SalesMethod varchar(30),
	@Territory varchar(20),
	@outParam int out

)
AS
	SET NOCOUNT OFF;

BEGIN



INSERT INTO tblCustomer
                         (CustomerID, Name, Address, Telephone, ProductType, Territory, SalesMethod)
VALUES        (@CustomerID,@Name,@Address,@Telephone,@ProductType,@Territory, @SalesMethod)
SET @outParam = SCOPE_IDENTITY()

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_CustomerTerritoryList]
(

	@CustomerID varchar(20),
	@TerritoryName varchar(50),
	@TerritoryID int,
	@outParam int out

)
AS
	SET NOCOUNT OFF;

BEGIN

INSERT INTO tblCustomerTerritoryList
            (CustomerID, TerritoryName,TerritoryID)
VALUES      (@CustomerID,@TerritoryName,@TerritoryID)

SET @outParam = SCOPE_IDENTITY()

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_FinishGoodsReturn]
(

	@GRNNo numeric(18, 0),
	@CustomerID varchar(50),
	@TerritoryID numeric(18, 0)

)
AS
	SET NOCOUNT OFF;

BEGIN

INSERT INTO tblFinishGoodsReturn (GRNNo, CustomerID, TerritoryID)
VALUES        (@GRNNo,@CustomerID,@TerritoryID)

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_MTN_FinishedGoodsReturns]
(

	@MTNEnterdBy varchar(50),
	@MTNFromDepID numeric(18, 0),
	@MTNToDepID numeric(18, 0),
	@MTNStatus int,
	@MTNType int,
	@MTNItemType int,
	@Store varchar(50),
	@outParam int output

)
AS
	SET NOCOUNT OFF;
BEGIN
INSERT INTO tblMTN
                         (MTNDate, MTNEnterdBy, MTNFromDepID, MTNToDepID, MTNStatus, MTNType, MTNItemType, MTNStore)
VALUES        (GETDATE(),@MTNEnterdBy,@MTNFromDepID,@MTNToDepID,@MTNStatus,@MTNType,@MTNItemType,@Store)

SELECT @outParam=CONVERT(int,ISNULL(SCOPE_IDENTITY(),0))

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_MTN_FinishProduct]
(
	@MTNNO numeric(8, 0),
	@MTNFinishProductID varchar(50),
	@MTNTransferQty numeric(20, 6),
	@MTNUnitRate numeric(18, 2),
	@MTNRceivedQty numeric(20, 6),
	@MTNUnitRate_Budget numeric(18, 2)
)
AS
	SET NOCOUNT OFF;
	
INSERT INTO tblMTNFinishProduct (MTNNO, MTNFinishProductID, MTNTransferQty, MTNUnitRate, MTNRceivedQty, MTNUnitRate_Budget)
VALUES							(@MTNNO,@MTNFinishProductID,@MTNTransferQty,@MTNUnitRate,@MTNRceivedQty,@MTNUnitRate_Budget)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_MTN_Other]
(

	@MTNEnterdBy varchar(50),
	@MTNFromDepID numeric(18, 0),
	@MTNToDepID numeric(18, 0),
	@MTNStatus int,
	@MTNType int,
	@MTNItemType int,
	@outParam int output

)
AS
	SET NOCOUNT OFF;
BEGIN
INSERT INTO tblMTN
                      (MTNDate, MTNEnterdBy, MTNFromDepID, MTNToDepID, MTNStatus, MTNType, MTNItemType)
VALUES     (GETDATE(),@MTNEnterdBy,@MTNFromDepID,@MTNToDepID,@MTNStatus,@MTNType,@MTNItemType)

SELECT @outParam=CONVERT(int,ISNULL(SCOPE_IDENTITY(),0))

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_PackingType]
(
	@PackingID numeric(18, 0),
	@PackingTitle varchar(50),
	@PackingUnitID  numeric(18, 0),
	@PackingQty numeric(18, 4),
	@Type varchar(50)

)
AS
	SET NOCOUNT OFF;
DECLARE @theCount int

	SELECT @theCount=count(*) from tblPckingType where PackingID=@PackingID

	IF @theCount>0
	BEGIN
	update tblPckingType set PackingQty=@PackingQty,PackingUnitID=@PackingUnitID,PackingTitle=@PackingTitle,Type=@Type where PackingID=@PackingID
	END
	ELSE
	BEGIN
INSERT INTO [dbo].[tblPckingType]
           ([PackingTitle]
           ,[PackingUnitID]
           ,[PackingQty])
     VALUES
           (@PackingTitle
           ,@PackingUnitID
           ,@PackingQty)
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_PackType]
(
	@PackingTitle numeric(18, 0),
	@PackingUnitID  numeric(18, 0),
	@PackingQty numeric(18, 4)

)
AS
	SET NOCOUNT OFF;

	
INSERT INTO [dbo].[tblPckingType]
           ([PackingTitle]
           ,[PackingUnitID]
           ,[PackingQty])
     VALUES
           (@PackingTitle
           ,@PackingUnitID
           ,@PackingQty)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_PlanBatch]
	(
	@Year numeric(18, 0),
	@Month varchar(50),
	@RevisionID numeric(18, 0),
	@ProductCode varchar(50),
	@WeekID numeric(18, 0),
	@BatchSize numeric(18, 2),
	@Nos numeric(18, 0),
	@Status numeric(18, 0),
	@BatchLevel numeric(18, 0)
    )

AS

SET NOCOUNT OFF;
BEGIN

DELETE FROM tblPlanBatch WHERE Year=@Year AND Month=@Month AND WeekID=@WeekID AND ProductCode=@ProductCode AND BatchLevel=1

INSERT INTO tblPlanBatch
                         (Year, Month, RevisionID, ProductCode, WeekID, BatchSize, Nos, Status, BatchLevel)
VALUES        (@Year,@Month,@RevisionID,@ProductCode,@WeekID,@BatchSize,@Nos,@Status,@BatchLevel)

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_PlanMaterial]
(
	@Year int,
	@Month varchar(50),
	@Type varchar(50),
	@Status int
	
)
AS
BEGIN
	SET NOCOUNT OFF;

DECLARE @RevisionID int

-----Week 1 Records insert------------------
DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=1 AND Type=@Type

SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=1

INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,[Type],[Status]) 
SELECT  [Year], [Month],@RevisionID,1, FormulaMaterialCode, Qty,@Type,@Status
FROM            Plan_MaterialRequirementFirstWeek
WHERE        ([Year] = @Year) AND ([Month] = @Month)


-----Week 2 Records insert------------------
DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=2 AND Type=@Type


SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=2

INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,[Type],[Status]) 
SELECT  [Year], [Month],@RevisionID,2, FormulaMaterialCode, Qty,@Type,@Status
FROM            Plan_MaterialRequirementSecondWeek
WHERE        ([Year] = @Year) AND ([Month] = @Month)

-----Week 3 Records insert------------------

DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=3 AND Type=@Type


SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=3

INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,[Type],[Status]) 
SELECT  [Year], [Month],@RevisionID,3, FormulaMaterialCode, Qty,@Type,@Status
FROM            Plan_MaterialRequirementThirdWeek
WHERE        ([Year] = @Year) AND ([Month] = @Month)


-----Week 4 Records insert------------------

DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=4 AND Type=@Type


SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=4

INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,[Type],[Status]) 
SELECT  [Year], [Month],@RevisionID,4, FormulaMaterialCode, Qty,@Type,@Status
FROM            Plan_MaterialRequirementFourthWeek
WHERE        ([Year] = @Year) AND ([Month] = @Month)



END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_PlanMaterial_PRPD_TepmStore]
(
	@Year int,
	@Month varchar(50),
	@Type varchar(50),
	@Status int
	
)
AS
BEGIN
	SET NOCOUNT OFF;

DECLARE @RevisionID int

-----Week 1 Records insert------------------
DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=1 AND Type=@Type

SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=1

INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,Type,Status)
SELECT Year,Month,@RevisionID,1,Plan_MaterialRequirementFirstWeek_PRPD.MaterialCode,Qty,'PRPD',0 FROM Plan_MaterialRequirementFirstWeek_PRPD INNER JOIN tblMaterial ON Plan_MaterialRequirementFirstWeek_PRPD.MaterialCode = tblMaterial.MaterialCode
WHERE        ([Year] = @Year) AND ([Month] = @Month)

-----Week 2 Records insert------------------
DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=2 AND Type=@Type

SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=2 

INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,Type,Status)
SELECT Year,Month,@RevisionID,2,Plan_MaterialRequirementSecondWeek_PRPD.MaterialCode,Qty,'PRPD',0 FROM Plan_MaterialRequirementSecondWeek_PRPD INNER JOIN tblMaterial ON Plan_MaterialRequirementSecondWeek_PRPD.MaterialCode = tblMaterial.MaterialCode
WHERE        ([Year] = @Year) AND ([Month] = @Month)

-----Week 3 Records insert------------------

DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=3 AND Type=@Type

SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=3 


INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,Type,Status)
SELECT Year,Month,@RevisionID,3,Plan_MaterialRequirementThirdWeek_PRPD.MaterialCode,Qty,'PRPD',0 FROM Plan_MaterialRequirementThirdWeek_PRPD INNER JOIN tblMaterial ON Plan_MaterialRequirementThirdWeek_PRPD.MaterialCode = tblMaterial.MaterialCode
WHERE        ([Year] = @Year) AND ([Month] = @Month)


-----Week 4 Records insert------------------

DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=4 AND Type=@Type

SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=4 

INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,Type,Status)
SELECT Year,Month,@RevisionID,4,Plan_MaterialRequirementFourthWeek_PRPD.MaterialCode,Qty,'PRPD',0 FROM Plan_MaterialRequirementFourthWeek_PRPD INNER JOIN tblMaterial ON Plan_MaterialRequirementFourthWeek_PRPD.MaterialCode = tblMaterial.MaterialCode
WHERE        ([Year] = @Year) AND ([Month] = @Month)




END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_PlanMaterial_PRPD]
(
	@Year int,
	@Month varchar(50),
	@Type varchar(50),
	@Status int
	
)
AS
BEGIN
	SET NOCOUNT OFF;

DECLARE @RevisionID int

-----Week 1 Records insert------------------
DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=1 AND Type='PRPD-temp'

SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=1

INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,Type,Status)
SELECT Year,Month,@RevisionID,1,Plan_MaterialRequirementFirstWeek_PRPD.MaterialCode,Qty,'PRPD-temp',0 FROM Plan_MaterialRequirementFirstWeek_PRPD INNER JOIN tblMaterial ON Plan_MaterialRequirementFirstWeek_PRPD.MaterialCode = tblMaterial.MaterialCode
WHERE        ([Year] = @Year) AND ([Month] = @Month) AND (tblMaterial.MatMainType='Processed')

-----Week 2 Records insert------------------
DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=2 AND Type='PRPD-temp' 

SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=2 

INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,Type,Status)
SELECT Year,Month,@RevisionID,2,Plan_MaterialRequirementSecondWeek_PRPD.MaterialCode,Qty,'PRPD-temp',0 FROM Plan_MaterialRequirementSecondWeek_PRPD INNER JOIN tblMaterial ON Plan_MaterialRequirementSecondWeek_PRPD.MaterialCode = tblMaterial.MaterialCode
WHERE        ([Year] = @Year) AND ([Month] = @Month) AND (tblMaterial.MatMainType='Processed')

-----Week 3 Records insert------------------

DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=3 AND Type='PRPD-temp'

SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=3 


INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,Type,Status)
SELECT Year,Month,@RevisionID,3,Plan_MaterialRequirementThirdWeek_PRPD.MaterialCode,Qty,'PRPD-temp',0 FROM Plan_MaterialRequirementThirdWeek_PRPD INNER JOIN tblMaterial ON Plan_MaterialRequirementThirdWeek_PRPD.MaterialCode = tblMaterial.MaterialCode
WHERE        ([Year] = @Year) AND ([Month] = @Month) AND (tblMaterial.MatMainType='Processed')


-----Week 4 Records insert------------------

DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=4 AND Type='PRPD-temp'

SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=4 

INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,Type,Status)
SELECT Year,Month,@RevisionID,4,Plan_MaterialRequirementFourthWeek_PRPD.MaterialCode,Qty,'PRPD-temp',0 FROM Plan_MaterialRequirementFourthWeek_PRPD INNER JOIN tblMaterial ON Plan_MaterialRequirementFourthWeek_PRPD.MaterialCode = tblMaterial.MaterialCode
WHERE        ([Year] = @Year) AND ([Month] = @Month) AND (tblMaterial.MatMainType='Processed')

Exec [dbo].[SPADD_PlanMaterial_PRPD_TepmStore] @Year=@Year, @Month=@Month, @Type=@Type, @Status=@Status

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_PlanMaterial_Store]
(
	@Year int,
	@Month varchar(50),
	@Type varchar(50),
	@Status int
	
)
AS
BEGIN
	SET NOCOUNT OFF;

DECLARE @RevisionID int

-----Week 1 Records insert------------------
DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=1 AND Type=@Type

SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=1

INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,Type,Status)
SELECT Year,Month,@RevisionID,1,Plan_MaterialRequirementFirstWeek_Store.MaterialCode,Qty,'Store',0 FROM Plan_MaterialRequirementFirstWeek_Store INNER JOIN tblMaterial ON Plan_MaterialRequirementFirstWeek_Store.MaterialCode = tblMaterial.MaterialCode
WHERE        ([Year] = @Year) AND ([Month] = @Month)

-----Week 2 Records insert------------------
DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=2 AND Type=@Type 

SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=2 

INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,Type,Status)
SELECT Year,Month,@RevisionID,2,Plan_MaterialRequirementSecondWeek_Store.MaterialCode,Qty,'Store',0 FROM Plan_MaterialRequirementSecondWeek_Store INNER JOIN tblMaterial ON Plan_MaterialRequirementSecondWeek_Store.MaterialCode = tblMaterial.MaterialCode
WHERE        ([Year] = @Year) AND ([Month] = @Month)

-----Week 3 Records insert------------------

DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=3 AND Type=@Type

SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=3 


INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,Type,Status)
SELECT Year,Month,@RevisionID,3,Plan_MaterialRequirementThirdWeek_Store.MaterialCode,Qty,'Store',0 FROM Plan_MaterialRequirementThirdWeek_Store INNER JOIN tblMaterial ON Plan_MaterialRequirementThirdWeek_Store.MaterialCode = tblMaterial.MaterialCode
WHERE        ([Year] = @Year) AND ([Month] = @Month)


-----Week 4 Records insert------------------

DELETE from tblPlanMaterials where Month=@Month and Year=@Year and WeekID=4 AND Type=@Type

SELECT @RevisionID=Max(RevisionID) from tblPlanWeeks where Month=@Month and Year=@Year and WeekID=4 

INSERT INTO tblPlanMaterials (Year,Month,RevisionID,WeekID,MaterialCode,Qty,Type,Status)
SELECT Year,Month,@RevisionID,4,Plan_MaterialRequirementFourthWeek_Store.MaterialCode,Qty,'Store',0 FROM Plan_MaterialRequirementFourthWeek_Store INNER JOIN tblMaterial ON Plan_MaterialRequirementFourthWeek_Store.MaterialCode = tblMaterial.MaterialCode
WHERE        ([Year] = @Year) AND ([Month] = @Month)


END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_PlanWeeks]
(
	@Year int,
	@Month varchar(50),
	@WeekID int,
	@FromDate datetime,
	@ToDate datetime,
	@State int
)
AS
	SET NOCOUNT OFF;
	
DECLARE @Count int
DECLARE @RevisionID int
	
SELECT @Count=count(*) FROM tblPlanWeeks WHERE Year=@Year AND Month=@Month AND WeekID=@WeekID


IF(@Count>0)
BEGIN

SELECT @Count=max(RevisionID)+1 FROM tblPlanWeeks WHERE Year=@Year AND Month=@Month AND WeekID=@WeekID
	
INSERT INTO tblPlanWeeks (Year,Month ,WeekID,RevisionID, FromDate, ToDate, State) VALUES (@Year,@Month ,@WeekID,@RevisionID, @FromDate, @ToDate, @State);

END
ELSE
BEGIN
INSERT INTO tblPlanWeeks (Year,Month ,WeekID,RevisionID, FromDate, ToDate, State) VALUES (@Year,@Month ,@WeekID,0, @FromDate, @ToDate, @State);
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_Project]
(

	@ProjectName varchar(50),
	@DepID numeric(18, 0),
	@ProjectType varchar(50),
	@outParam int out

)
AS
	SET NOCOUNT OFF;

BEGIN


INSERT INTO tblProjects (ProjectName,DepID, Status, ProjectType)
VALUES (@ProjectName,@DepID,0,@ProjectType)

SET @outParam = SCOPE_IDENTITY()

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_ProjectMaterials]
(

	@ProjectID varchar(50),
	@ItemCode varchar(50),
	@UsedQty numeric(18, 2),
	@DamagedQty numeric(18, 2),
	@EnteredBy varchar(50),
	@ItemTypeName varchar(50),
	@UnitPrice numeric(18, 2),
	@outParam int out

)
AS
	SET NOCOUNT OFF;

BEGIN

IF @ItemTypeName = 'Material'
BEGIN

INSERT INTO tblProjectMaterials(ProjectID, MaterialCode, BasicProductCode, FinishProductCode, UsedQty, DamagedQty, GRNNO, UnitPrice, EnteredBy, EnteredDate)
VALUES (@ProjectID,@ItemCode,null,null,@UsedQty,@DamagedQty,null,@UnitPrice,@EnteredBy,getdate())

END
ELSE IF @ItemTypeName = 'Finish Product' 
BEGIN 

INSERT INTO tblProjectMaterials(ProjectID, MaterialCode, BasicProductCode, FinishProductCode, UsedQty, DamagedQty, GRNNO, UnitPrice, EnteredBy, EnteredDate)
VALUES (@ProjectID,null,null,@ItemCode,@UsedQty,@DamagedQty,null,@UnitPrice,@EnteredBy,getdate())

END
ELSE 
BEGIN

INSERT INTO tblProjectMaterials(ProjectID, MaterialCode, BasicProductCode, FinishProductCode, UsedQty, DamagedQty, GRNNO, UnitPrice, EnteredBy, EnteredDate)
VALUES (@ProjectID,null,@ItemCode,null,@UsedQty,@DamagedQty,null,@UnitPrice,@EnteredBy,getdate())

END
SET @outParam = SCOPE_IDENTITY()

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_SalesMethod]
(

	@SalesMethodID varchar(50),
	@SMDesctiption varchar(200),
	@outParam int out

)
AS
	SET NOCOUNT OFF;

BEGIN

INSERT INTO tblSalesMethod (SMDesctiption, SalesMethodID)
VALUES        (@SMDesctiption,@SalesMethodID)

SET @outParam = SCOPE_IDENTITY()

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPDELETE_Customer]
(
	@CustomerID varchar(50)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [tblCustomer] WHERE (([CustomerID] = @CustomerID))
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPDELETE_CustomerTerritoryList]
(
	@CustomerID varchar(50)
)
AS
	SET NOCOUNT OFF;


DELETE FROM tblCustomerTerritoryList  WHERE ([CustomerID] = @CustomerID)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPDELETE_PlanBatch]
	(
	@Year numeric(18, 0),
	@Month varchar(50),
	@RevisionID numeric(18, 0),
	@ProductCode varchar(50),
	@WeekID numeric(18, 0)

    )

AS

SET NOCOUNT OFF;
BEGIN

DELETE FROM tblPlanBatch 
WHERE [Year]= @Year and [Month]=@Month and WeekID=@WeekID and RevisionID=@RevisionID and ProductCode=@ProductCode

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPDELETE_SalesMethod]
(
	@SalesMethodID varchar(50)
)
AS
	SET NOCOUNT OFF;

DELETE FROM [tblSalesMethod] WHERE (([SalesMethodID] = @SalesMethodID))
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_BasicProductForecast]
(

	@prmBasicProductCode varchar(50),
	@prmYear int,
	@prmMonth varchar(50),
	--@prmweekID int,
	@outParam int=0 output
)
AS
	SET NOCOUNT ON;
BEGIN

DECLARE @FinishProductCode varchar(50) ,@TotalQty int,@OriFinishProdutBasicQty numeric(18, 4),@OriFinishProductType varchar(30),
		@TotalWeight numeric(18, 4),@OriPrimaryFinishProductCode varchar(50),@OriPrimaryFinishProductQty numeric(18, 4),@FinalTotal  numeric(18, 4),
		@unitName varchar(10)
SET @TotalQty=0;
SET @TotalWeight=0;
SET @FinalTotal=0;

DECLARE @tep_table table
(
  FinishProductCode varchar(50),
  BasicProductCode varchar(50),
  FinishProdutFormulaID numeric(18, 0),
  FinishProdutPackingTypeID numeric(18, 0),
  FinishProduct varchar(2000),
  FinishProdutBasicQty numeric(18, 4),
  FinishProdutAvgCost numeric(10, 2),
  FinishProdutStatus bit,
  PrimaryFinishProductCode varchar(50),
  PrimaryFinishProductQty numeric(18, 0),
  FinishProductType varchar(50)
)

Insert into @tep_table
Exec [dbo].[SPGET_FinishProduct_ByBasicProduct] @BasicProductCode=@prmBasicProductCode

--SELECT  @unitName=tblUnit.UnitName
--FROM    tblBasicProduct INNER JOIN tblUnit ON tblBasicProduct.BasicProductUnitID = tblUnit.UnitID
--WHERE	tblBasicProduct.BasicProductCode=@prmBasicProductCode

DECLARE FinishProduct_Cursor CURSOR FOR
Select FinishProductCode, FinishProdutBasicQty,PrimaryFinishProductCode,PrimaryFinishProductQty ,FinishProductType From @tep_table

	OPEN FinishProduct_Cursor
	FETCH NEXT FROM FinishProduct_Cursor
	INTO @FinishProductCode, @OriFinishProdutBasicQty, @OriPrimaryFinishProductCode,@OriPrimaryFinishProductQty,@OriFinishProductType
	WHILE @@FETCH_STATUS = 0
	BEGIN
	
		SELECT @TotalQty= ISNULL(SUM(tblSalesForecastDetails.Qty),0)
		FROM tblSalesForecastDetails INNER JOIN tblSalesForecast ON tblSalesForecastDetails.SalesForecastID = tblSalesForecast.ID
		WHERE tblSalesForecast.Year=@prmYear AND tblSalesForecast.Month=@prmMonth AND tblSalesForecastDetails.ProductCode=@FinishProductCode AND State=1	--AND tblSalesForecast.WeekID=@prmweekID

		IF @OriFinishProductType='Secondary'--Secondary Primary
			BEGIN
			
				SELECT @OriFinishProdutBasicQty=FinishProdutBasicQty
				FROM tblFinishProduct
				Where FinishProductCode=@OriPrimaryFinishProductCode
				SET @FinalTotal =@FinalTotal + (@OriPrimaryFinishProductQty * @OriFinishProdutBasicQty*@TotalQty)

			END
		ELSE
			BEGIN
				
				SET @FinalTotal =@FinalTotal +(@OriFinishProdutBasicQty*@TotalQty)
			END

			FETCH NEXT FROM FinishProduct_Cursor
			INTO @FinishProductCode, @OriFinishProdutBasicQty, @OriPrimaryFinishProductCode,@OriPrimaryFinishProductQty,@OriFinishProductType
	END

	CLOSE FinishProduct_Cursor
	DEALLOCATE FinishProduct_Cursor
	SELECT @outParam=  @FinalTotal
END
--return @TotalQty
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_Batch_BatchPreviousDetails]
(
	@BasicProduct varchar(50)

)
AS
	SET NOCOUNT ON;

SELECT     TOP 10   tblBatch.BatchID, View_Employee.Employee, tblBatch.BatchGeneratedDate, tblBatch.BatchStatus, tblBatch.BatchSize
FROM            tblBatch INNER JOIN View_Employee ON tblBatch.BatchGeneratedBy = View_Employee.EmpID
where BatchID like '%'+@BasicProduct+'%'-- AND tblBatch.BatchStatus in(1,2,3)
order by tblBatch.BatchID desc
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_BatchActivityMachineDetails]
(
	@BatchActID varchar(10)
)
AS
	SET NOCOUNT ON;

SELECT        MachineID, InputQty, OutputQty, RejectedQty
FROM            tblBatchActivityMachineDetails
where	BatchID in (SELECT BatchActID FROM  tblBatchActivity where BatchID=@BatchActID)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_BatchMachineDetails_By_SecondaryBatchActID]
(
	@BatchActID int
)
AS
	SET NOCOUNT ON;
SELECT     tblBatchMachineDetails.MachineRecID,  tblBatchMachineDetails.MachineCode, tblBatchMachineDetails.MachineStart, 
                      tblBatchMachineDetails.MachineStop, tblBatchMachineDetails.HourlyRate, tblMachine.MachineName
FROM         tblBatchMachineDetails INNER JOIN
                      tblMachine ON tblBatchMachineDetails.MachineCode = tblMachine.MachineCode
WHERE tblBatchMachineDetails.BatchActID=(SELECT PrimaryBatchActID FROM   tblBatchActivity WHERE  BatchActID=@BatchActID)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_BatchPackingMR_MaterialList]
(


@BasicProductCode varchar(50)
)

AS
	SET NOCOUNT OFF;


BEGIN


DECLARE @SectionID int

SELECT @SectionID=ISNULL(SectionID,0) from tblProductManufacturing where ProductCode=@BasicProductCode AND Type='Pack'

SELECT DISTINCT tblBatchPackingMR.MaterialCode, tblBatchPackingMR.MaterialCode+'-'+tblMaterial.MaterialDescription AS Material
FROM            tblBatchPackingMR INNER JOIN
                         tblMaterial ON tblBatchPackingMR.MaterialCode = tblMaterial.MaterialCode
WHERE        (tblBatchPackingMR.SectionID = @SectionID) AND (BatchNO LIKE @BasicProductCode+'%')
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_BatchPackingMR_MaterialStock]
(


@BasicProductCode varchar(50),
@MaterialCode varchar(50)

)

AS
	SET NOCOUNT OFF;


BEGIN


DECLARE @SectionID int

SELECT @SectionID=ISNULL(SectionID,0) from tblProductManufacturing where ProductCode=@BasicProductCode AND Type='Pack'

SELECT DISTINCT tblBatchPackingMR.MaterialCode, tblBatchPackingMR.MaterialCode+'-'+tblMaterial.MaterialDescription AS Material,
SUM(tblBatchPackingMR.StartQty) AS StockQty
FROM            tblBatchPackingMR INNER JOIN
                         tblMaterial ON tblBatchPackingMR.MaterialCode = tblMaterial.MaterialCode
WHERE        (tblBatchPackingMR.SectionID = @SectionID) AND (tblBatchPackingMR.MaterialCode=@MaterialCode) AND (State=0)
GROUP BY tblBatchPackingMR.MaterialCode,tblMaterial.MaterialDescription 


END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_Customers]

AS
	SET NOCOUNT ON;

BEGIN



SELECT CustomerID, Name, Address, Telephone, ProductType, SalesMethod
FROM tblCustomer

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_CustomerTerritory_ByID]
(

	@CustomerID varchar(20)
)
AS
	SET NOCOUNT ON;

BEGIN

SELECT        TerritoryID, TerritoryName
FROM            tblCustomerTerritoryList
WHERE (CustomerID=@CustomerID)

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_DistributorTerritoryList]
(
	@Category varchar(20)
)
AS
	SET NOCOUNT ON;

BEGIN

SELECT        Name, TerritoryID
FROM            RDSales.dbo.tblTerritory

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_FinishProduct_Availability]
(
	--@DispatchID  varchar(50),
	@FinishProductID varchar(50),
	@IssuedQty numeric(20, 6)
	--@StoreID varchar(50)
)
AS
	SET NOCOUNT OFF;

BEGIN

--BEGIN TRAN

DECLARE @GRNNO numeric,@ItemCode varchar(50),@NetQty numeric(20, 6),@StockID numeric(18,0),@Remains bit,
			@RemainQty numeric(20, 6),@Difference numeric(20, 6),@StockQty numeric(20, 6),@Ori_MRIssuedQty numeric(20, 6),
			@StockDuration numeric(18,2),@StoreID varchar(50)

DECLARE @IssuedStockList TABLE(GRNID varchar(50),StockID varchar(50),StoreID varchar(50),Qty numeric )

SELECT @Remains = 0
SELECT @Ori_MRIssuedQty = @IssuedQty


SELECT    @StockID = StockID, @StockQty = StockQty , @StoreID = StoreID
FROM         tblStock
WHERE     (StockFinishProduct = @FinishProductID)

IF @StockQty >= @IssuedQty
BEGIN

--SELECT @UnitPrice1 = dbo.StockUnitPrice_FinishProduct(@StockID)

DECLARE GRNFinishProduct_Cursor CURSOR FOR
SELECT     tblGRNFinishProduct.GRNNO, tblGRNFinishProduct.FinishProductCode, tblGRNFinishProduct.NetQty
FROM         tblGRNFinishProduct INNER JOIN
                      tblGRN ON tblGRNFinishProduct.GRNNO = tblGRN.GRNNO
WHERE     (tblGRNFinishProduct.FinishProductCode = @FinishProductID) AND (tblGRNFinishProduct.GRNNO IN
                          (SELECT     GRNNO
                            FROM          tblGRN AS tblGRN_1
                            WHERE      (GRNStoreID = @StoreID))) AND (tblGRN.GRNStatus = 1)
ORDER BY tblGRNFinishProduct.GRNNO

	OPEN GRNFinishProduct_Cursor
	FETCH NEXT FROM GRNFinishProduct_Cursor
	INTO @GRNNO,@ItemCode,@NetQty
	WHILE @@FETCH_STATUS = 0
	BEGIN
		DECLARE @TotalIssuedQty numeric(20, 6)

		SELECT @TotalIssuedQty = ISNULL(SUM(StockIssuedQty),0)
		FROM tblStockGRN
		WHERE StockGRNNO = @GRNNO AND StockID = @StockID

		IF @Remains = 1
		BEGIN
			SELECT @IssuedQty = @RemainQty
			SELECT @Remains = 0
		END

			SELECT @Difference = @NetQty - @TotalIssuedQty


		IF @Difference > 0
			BEGIN

				DECLARE @COUNT int
				IF @IssuedQty > @Difference
					BEGIN

					SELECT @COUNT = COUNT(*)
							FROM tblStockGRN
							WHERE StockID = @StockID AND StockGRNNO = @GRNNO

						IF @COUNT > 0
							BEGIN
--								UPDATE tblStockGRN SET StockIssuedQty = StockIssuedQty + @Difference
--								WHERE StockID = @StockID AND StockGRNNO = @GRNNO				
-----------------								INSERT INTO [dbo].[tblDispatchIssueList] ([DispatchID],[GRNID],[Status],[IssuDate],[IssuedQty]) VALUES (@DispatchID,@GRNNO,0,GETDATE(),@Difference)
								INSERT INTO @IssuedStockList (GRNID,StockID,StoreID,Qty )
								values (@GRNNO,@StockID,@StoreID,@Difference)

							END
						ELSE
							BEGIN
--								INSERT INTO tblStockGRN VALUES(@StockID,@GRNNO,GETDATE(),@Difference)				
-----------------								INSERT INTO [dbo].[tblDispatchIssueList] ([DispatchID],[GRNID],[Status],[IssuDate],[IssuedQty]) VALUES (@DispatchID,@GRNNO,0,GETDATE(),@Difference)
								INSERT INTO @IssuedStockList (GRNID,StockID,StoreID,Qty )
								values (@GRNNO,@StockID,@StoreID,@Difference)

							END

						SELECT @Remains = 1
						SELECT @RemainQty = @IssuedQty - @Difference
--						SELECT @Cost = @Cost + ((@UnitPrice+dbo.StockHoldingCost(@GRNNO,@UnitPrice))* @Difference)
					END
				ELSE
				BEGIN
						SELECT @COUNT = COUNT(*)
						FROM tblStockGRN
						WHERE StockID = @StockID AND StockGRNNO = @GRNNO
					IF @COUNT > 0
						BEGIN
--							UPDATE tblStockGRN SET StockIssuedQty = StockIssuedQty + @IssuedQty
--							WHERE StockID = @StockID AND StockGRNNO = @GRNNO			
-----------------							INSERT INTO [dbo].[tblDispatchIssueList] ([DispatchID],[GRNID],[Status],[IssuDate],[IssuedQty]) VALUES (@DispatchID,@GRNNO,0,GETDATE(),@IssuedQty)
							INSERT INTO @IssuedStockList (GRNID,StockID,StoreID,Qty )
								values (@GRNNO,@StockID,@StoreID,@IssuedQty)

						END
					ELSE
						BEGIN
--							INSERT INTO tblStockGRN VALUES(@StockID,@GRNNO,GETDATE(),@IssuedQty)			
-----------------							INSERT INTO [dbo].[tblDispatchIssueList] ([DispatchID],[GRNID],[Status],[IssuDate],[IssuedQty]) VALUES (@DispatchID,@GRNNO,0,GETDATE(),@IssuedQty)
							INSERT INTO @IssuedStockList (GRNID,StockID,StoreID,Qty )
							values (@GRNNO,@StockID,@StoreID,@IssuedQty)
						END
					BREAK
				END



			END

--------Fetch the next Record
		FETCH NEXT FROM GRNFinishProduct_Cursor
		INTO @GRNNO,@ItemCode,@NetQty
	END
	CLOSE GRNFinishProduct_Cursor
	DEALLOCATE GRNFinishProduct_Cursor

--	UPDATE tblStock
--	SET StockQty = StockQty - @Ori_MRIssuedQty
--	WHERE StockID = @StockID
SELECT GRNID,StockID,StoreID,Qty FROM @IssuedStockList

--IF @@ERROR <> 0
--BEGIN
 --ROLLBACK TRAN
--END
--ELSE
--BEGIN
--	COMMIT TRAN
--END

	RETURN 1

END -- @stock > @IssuedQty
ELSE
BEGIN
	RETURN -1
END

END
--------------------
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_FinishProduct_SecondaryProductList_All]
(

	@FinishProduct varchar(50)

)
AS
BEGIN

SET NOCOUNT ON;


SELECT        tblFinishProduct.PrimaryFinishProductCode, tblFinishProduct.FinishProductCode, tblFinishProduct.FinishProdutFormulaID, 
                         tblFinishProduct.FinishProdutPackingTypeID, 
                         tblFinishProduct.FinishProdutDescription + ' - ' + tblFinishProduct.FinishProductCode AS FinishProdutDescription, tblFinishProduct.FinishProdutBasicQty, 
                         tblFinishProduct.FinishProdutAvgCost, tblFinishProduct.FinishProdutStatus, tblFinishProduct.PrimaryFinishProductQty, tblFinishProduct.FinishProductType, 
                          tblFinishProduct.BasicProductCode, tblPckingType.PackingTitle AS Packing
FROM            tblFinishProduct INNER JOIN
                         tblPckingType ON tblFinishProduct.FinishProdutPackingTypeID = tblPckingType.PackingID
WHERE        (tblFinishProduct.PrimaryFinishProductCode = @FinishProduct) AND 
                         (tblFinishProduct.FinishProductType = 'Secondary')

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_FinishProduct_TertiaryProductList]
(

	@FinishProduct varchar(50)

)
AS
BEGIN

SET NOCOUNT ON;
SELECT        tblFinishProduct.PrimaryFinishProductCode, tblFinishProduct.FinishProductCode, tblFinishProduct.FinishProdutFormulaID, 
                         tblFinishProduct.FinishProdutPackingTypeID, 
                         tblFinishProduct.FinishProdutDescription + ' - ' + tblFinishProduct.FinishProductCode AS FinishProdutDescription, tblFinishProduct.FinishProdutBasicQty, 
                         tblFinishProduct.FinishProdutAvgCost, tblFinishProduct.FinishProdutStatus, tblFinishProduct.PrimaryFinishProductQty, tblFinishProduct.FinishProductType, 
                         tblFinishProduct.BasicProductCode, tblPckingType.PackingTitle AS Packing
FROM            tblFinishProduct INNER JOIN
                         tblPckingType ON tblFinishProduct.FinishProdutPackingTypeID = tblPckingType.PackingID
WHERE        (tblFinishProduct.PrimaryFinishProductCode = @FinishProduct) AND (tblFinishProduct.FinishProdutStatus = 'True') AND 
                         (tblFinishProduct.FinishProductType = 'Tertiary')

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_FinishProduct_TertiaryProductList_All]
(

	@FinishProduct varchar(50)

)
AS
BEGIN

SET NOCOUNT ON;
SELECT        tblFinishProduct.PrimaryFinishProductCode, tblFinishProduct.FinishProductCode, tblFinishProduct.FinishProdutFormulaID, 
                         tblFinishProduct.FinishProdutPackingTypeID, 
                         tblFinishProduct.FinishProdutDescription + ' - ' + tblFinishProduct.FinishProductCode AS FinishProdutDescription, tblFinishProduct.FinishProdutBasicQty, 
                         tblFinishProduct.FinishProdutAvgCost, tblFinishProduct.FinishProdutStatus, tblFinishProduct.PrimaryFinishProductQty, tblFinishProduct.FinishProductType, 
                         tblFinishProduct.BasicProductCode, tblPckingType.PackingTitle AS Packing
FROM            tblFinishProduct INNER JOIN
                         tblPckingType ON tblFinishProduct.FinishProdutPackingTypeID = tblPckingType.PackingID
WHERE        (tblFinishProduct.PrimaryFinishProductCode = @FinishProduct) AND 
                         (tblFinishProduct.FinishProductType = 'Tertiary')

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_GRN_DataviewByTypeAndStatus]
(
	@Status int,
	@Type int
)
AS
	SET NOCOUNT ON;
SELECT        tblGRN.GRNNO, ISNULL(CAST(tblGRN.GRNMTNNO AS VARCHAR(50)), '') + ISNULL(CAST(tblGRN.GRNMRNO AS VARCHAR(50)), '') 
                         + ISNULL(CAST(tblGRN.GRNRPDBatchID AS VARCHAR(50)), '') AS Doc, tblGRN.GRNDate, tblGRN.GRNApprovedBy, tblGRN.GRNApproveDate, tblGRN.GRNEnterdBy, 
                         tblGRN.GRNStoreID, tblGRN.GRNType, tblGRN.GRNStatus, tblEmployee.EmpName AS EnterdByName, tblGRN.GRNCategory, tblGRN.GRNPrint, 
                         tblGRN.GRNBulkPrint, tblGRN.DeliverNoteID, dbo.Get_TGRN_Remarks(tblGRN.GRNNO) AS Remarks, ISNULL(tblSupplier.SupName,'N/A') AS SupName, ISNULL(tblDeliverNote.DeliverPONO,'N/A') AS PONO
FROM            tblSupplier INNER JOIN
                         tblDeliverNote ON tblSupplier.SupplierID = tblDeliverNote.SupplierCode RIGHT OUTER JOIN
                         tblGRN INNER JOIN
                         tblEmployee ON tblGRN.GRNEnterdBy = tblEmployee.EmpID ON tblDeliverNote.DeliverNoteNo = tblGRN.DeliverNoteID
WHERE        (tblGRN.GRNStatus = @Status) AND (tblGRN.GRNType = @Type)
ORDER BY tblGRN.GRNNO desc
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_Packing_PrimaryBatchRemainningQty]
(
	@BatchActStatus_Finished int,
	@BatchActStatus_Secondary int,
	@PrimaryBatchID numeric(18,0)
	--@outParam int OUT
)
AS
BEGIN

	SET NOCOUNT ON;
	DECLARE @v int
SELECT dbo.GetRemaining_ToPackSecondary_ByBatchAct(@PrimaryBatchID,@BatchActStatus_Finished,@BatchActStatus_Secondary) AS RemainningQty
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_PackingMaterialsForecast]
(
	@prmYear int,
	@prmMonth varchar(50)
	--@prmweekID int
)
AS
	SET NOCOUNT ON;
BEGIN

DECLARE @FinishProductCode varchar(50) ,@OriFinishProdutBasicQty numeric(18, 4),@OriFinishProductType varchar(30),
		@OriPrimaryFinishProductCode varchar(50),@OriPrimaryFinishProductQty numeric(18, 4),
		@OriFinishProdutFormulaID varchar(50),@neededQty numeric(18, 4),@FormulaUnit varchar(50)='',@FormulaQty numeric(18, 2)

DECLARE @tep_table2 table
(
  ProductCode varchar(50),
  Qty int
)

DECLARE @tep_table3 table
(
  FormulaMaterialCode varchar(50),
  FormulaQty numeric(18, 4),
  MaterialDescription varchar(500)
  --FormulaUnit varchar(10)
)
/*
		Insert into @tep_table2
		SELECT tblSalesForecastDetails.ProductCode, tblSalesForecastDetails.Qty
		FROM tblSalesForecastDetails INNER JOIN tblSalesForecast ON tblSalesForecastDetails.SalesForecastID = tblSalesForecast.ID
		WHERE tblSalesForecast.Year=@prmYear AND tblSalesForecast.Month=@prmMonth AND tblSalesForecast.WeekID=@prmweekID AND State=0 AND 
		RevisionID=(SELECT max(tblSalesForecastDetails.RevisionID)
		FROM tblSalesForecastDetails INNER JOIN tblSalesForecast ON tblSalesForecastDetails.SalesForecastID = tblSalesForecast.ID
		WHERE tblSalesForecast.Year=@prmYear AND tblSalesForecast.Month=@prmMonth AND tblSalesForecast.WeekID=@prmweekID)
*/
		Insert into @tep_table2
		SELECT tblSalesForecastDetails.ProductCode, tblSalesForecastDetails.Qty
		FROM tblSalesForecastDetails INNER JOIN tblSalesForecast ON tblSalesForecastDetails.SalesForecastID = tblSalesForecast.ID
		WHERE tblSalesForecast.Year=@prmYear AND tblSalesForecast.Month=@prmMonth AND State=1 AND RevisionID=
		(SELECT max(tblSalesForecastDetails.RevisionID)
		FROM tblSalesForecastDetails INNER JOIN tblSalesForecast ON tblSalesForecastDetails.SalesForecastID = tblSalesForecast.ID
		WHERE tblSalesForecast.Year=@prmYear AND tblSalesForecast.Month=@prmMonth AND State=1)


	DECLARE FinishProduct_Cursor CURSOR FOR
	Select ProductCode,Qty From @tep_table2

	OPEN FinishProduct_Cursor
	FETCH NEXT FROM FinishProduct_Cursor
	INTO @FinishProductCode, @neededQty
		WHILE @@FETCH_STATUS = 0
		BEGIN
	
			SELECT @OriFinishProdutFormulaID=FinishProdutFormulaID,@OriPrimaryFinishProductCode=PrimaryFinishProductCode, @OriPrimaryFinishProductQty=PrimaryFinishProductQty, @OriFinishProductType=FinishProductType
			FROM   tblFinishProduct
			WHERE FinishProductCode=@FinishProductCode

				IF @OriFinishProductType='Secondary'--Secondary Primary
					BEGIN
						SELECT @FormulaQty=tblFormula.FormulaQty,@FormulaUnit= tblUnit.UnitName
						FROM   tblFormula FULL JOIN tblUnit ON tblFormula.FormulaUnitID = tblUnit.UnitID
						WHERE  FormulaID=@OriFinishProdutFormulaID

						Insert into @tep_table3
						SELECT tblFormulaMaterial.FormulaMaterialCode, (tblFormulaMaterial.FormulaQty * @neededQty) / @FormulaQty , tblMaterial.MaterialDescription
						FROM   tblFormulaMaterial INNER JOIN
                        tblMaterial ON tblFormulaMaterial.FormulaMaterialCode = tblMaterial.MaterialCode full JOIN
                        tblUnit ON tblMaterial.UnitID = tblUnit.UnitID
						Where FormulaID=@OriFinishProdutFormulaID
			
						SELECT @OriFinishProdutFormulaID=FinishProdutFormulaID
						FROM   tblFinishProduct
						Where  FinishProductCode=@OriPrimaryFinishProductCode

						Insert into @tep_table3
						SELECT tblFormulaMaterial.FormulaMaterialCode, (tblFormulaMaterial.FormulaQty * @neededQty) / @FormulaQty , tblMaterial.MaterialDescription
						FROM   tblFormulaMaterial INNER JOIN
                        tblMaterial ON tblFormulaMaterial.FormulaMaterialCode = tblMaterial.MaterialCode full JOIN
                        tblUnit ON tblMaterial.UnitID = tblUnit.UnitID
						Where FormulaID=@OriFinishProdutFormulaID
						
					END
				ELSE IF @OriFinishProductType='Primary'--Secondary Primary
					BEGIN

						SELECT @FormulaQty=tblFormula.FormulaQty,@FormulaUnit= tblUnit.UnitName
						FROM   tblFormula FULL JOIN tblUnit ON tblFormula.FormulaUnitID = tblUnit.UnitID
						WHERE  FormulaID=@OriFinishProdutFormulaID
						--print @FormulaQty
						Insert into @tep_table3
						--SELECT  tblFormulaMaterial.FormulaMaterialCode, (tblFormulaMaterial.FormulaQty * @neededQty) / @FormulaQty, tblMaterial.MaterialDescription
						--FROM    tblFormulaMaterial INNER JOIN
                        --tblMaterial ON tblFormulaMaterial.FormulaMaterialCode = tblMaterial.MaterialCode
						
						SELECT  FormulaMaterialCode, (FormulaQty*@neededQty)/@FormulaQty,tblMaterial.MaterialDescription
						FROM tblFormulaMaterial INNER JOIN
                        tblMaterial ON tblFormulaMaterial.FormulaMaterialCode = tblMaterial.MaterialCode
						Where tblFormulaMaterial.FormulaID=@OriFinishProdutFormulaID
					END
				ELSE
					BEGIN
						Insert into @tep_table3 values(null,null,null)
					END

			FETCH NEXT FROM FinishProduct_Cursor
			INTO @FinishProductCode, @neededQty
	END

	CLOSE FinishProduct_Cursor
	DEALLOCATE FinishProduct_Cursor

END

SELECT FormulaMaterialCode,sum(FormulaQty) as Qty,max(MaterialDescription) as MaterialDescription
FROM @tep_table3
GROUP BY FormulaMaterialCode

--SELECT FormulaMaterialCode,FormulaQty --,FormulaUnit 
--FROM @tep_table3
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_PackingMaterialsForecastByY_M_W]
(
	@prmYear int,
	@prmMonth varchar(50),
	@prmWeek int
	--@prmweekID int
)
AS
	SET NOCOUNT ON;
BEGIN

DECLARE @FinishProductCode varchar(50) ,@OriFinishProdutBasicQty numeric(18, 4),@OriFinishProductType varchar(30),
		@OriPrimaryFinishProductCode varchar(50),@OriPrimaryFinishProductQty numeric(18, 4),
		@OriFinishProdutFormulaID varchar(50),@neededQty numeric(18, 4),@FormulaUnit varchar(50)='',@FormulaQty numeric(18, 2)

DECLARE @tep_table2 table
(
  ProductCode varchar(50),
  Qty int
)

DECLARE @tep_table3 table
(
  FormulaMaterialCode varchar(50),
  FormulaQty numeric(18, 4),
  MaterialDescription varchar(500),
  year int,
  month varchar(50),
  week int
)
/*
		Insert into @tep_table2
		SELECT tblSalesForecastDetails.ProductCode, tblSalesForecastDetails.Qty
		FROM tblSalesForecastDetails INNER JOIN tblSalesForecast ON tblSalesForecastDetails.SalesForecastID = tblSalesForecast.ID
		WHERE tblSalesForecast.Year=@prmYear AND tblSalesForecast.Month=@prmMonth AND tblSalesForecast.WeekID=@prmweekID AND State=0 AND 
		RevisionID=(SELECT max(tblSalesForecastDetails.RevisionID)
		FROM tblSalesForecastDetails INNER JOIN tblSalesForecast ON tblSalesForecastDetails.SalesForecastID = tblSalesForecast.ID
		WHERE tblSalesForecast.Year=@prmYear AND tblSalesForecast.Month=@prmMonth AND tblSalesForecast.WeekID=@prmweekID)
*/
		Insert into @tep_table2
		SELECT tblSalesForecastDetails.ProductCode, tblSalesForecastDetails.Qty
		FROM tblSalesForecastDetails INNER JOIN tblSalesForecast ON tblSalesForecastDetails.SalesForecastID = tblSalesForecast.ID
		WHERE tblSalesForecast.Year=@prmYear AND tblSalesForecast.Month=@prmMonth AND State=1 AND WeekID=@prmWeek AND 
		RevisionID=(SELECT max(tblSalesForecastDetails.RevisionID)
		FROM tblSalesForecastDetails INNER JOIN tblSalesForecast ON tblSalesForecastDetails.SalesForecastID = tblSalesForecast.ID
		WHERE tblSalesForecast.Year=@prmYear AND tblSalesForecast.Month=@prmMonth AND State=1 AND WeekID=@prmWeek)


	DECLARE FinishProduct_Cursor CURSOR FOR
	Select ProductCode,Qty From @tep_table2

	OPEN FinishProduct_Cursor
	FETCH NEXT FROM FinishProduct_Cursor
	INTO @FinishProductCode, @neededQty
		WHILE @@FETCH_STATUS = 0
		BEGIN
	
			SELECT @OriFinishProdutFormulaID=FinishProdutFormulaID,@OriPrimaryFinishProductCode=PrimaryFinishProductCode, @OriPrimaryFinishProductQty=PrimaryFinishProductQty, @OriFinishProductType=FinishProductType
			FROM   tblFinishProduct
			WHERE FinishProductCode=@FinishProductCode

				IF @OriFinishProductType='Secondary'--Secondary Primary
					BEGIN
						SELECT @FormulaQty=tblFormula.FormulaQty,@FormulaUnit= tblUnit.UnitName
						FROM   tblFormula FULL JOIN tblUnit ON tblFormula.FormulaUnitID = tblUnit.UnitID
						WHERE  FormulaID=@OriFinishProdutFormulaID

						Insert into @tep_table3
						SELECT tblFormulaMaterial.FormulaMaterialCode, (tblFormulaMaterial.FormulaQty * @neededQty) / @FormulaQty , tblMaterial.MaterialDescription,@prmYear,@prmMonth,@prmWeek
						FROM   tblFormulaMaterial INNER JOIN
                        tblMaterial ON tblFormulaMaterial.FormulaMaterialCode = tblMaterial.MaterialCode full JOIN
                        tblUnit ON tblMaterial.UnitID = tblUnit.UnitID
						Where FormulaID=@OriFinishProdutFormulaID
			
						SELECT @OriFinishProdutFormulaID=FinishProdutFormulaID
						FROM   tblFinishProduct
						Where  FinishProductCode=@OriPrimaryFinishProductCode

						Insert into @tep_table3
						SELECT tblFormulaMaterial.FormulaMaterialCode, (tblFormulaMaterial.FormulaQty * @neededQty) / @FormulaQty , tblMaterial.MaterialDescription,@prmYear,@prmMonth,@prmWeek
						FROM   tblFormulaMaterial INNER JOIN
                        tblMaterial ON tblFormulaMaterial.FormulaMaterialCode = tblMaterial.MaterialCode full JOIN
                        tblUnit ON tblMaterial.UnitID = tblUnit.UnitID
						Where FormulaID=@OriFinishProdutFormulaID
						
					END
				ELSE IF @OriFinishProductType='Primary'--Secondary Primary
					BEGIN

						SELECT @FormulaQty=tblFormula.FormulaQty,@FormulaUnit= tblUnit.UnitName
						FROM   tblFormula FULL JOIN tblUnit ON tblFormula.FormulaUnitID = tblUnit.UnitID
						WHERE  FormulaID=@OriFinishProdutFormulaID
						--print @FormulaQty
						Insert into @tep_table3
						--SELECT  tblFormulaMaterial.FormulaMaterialCode, (tblFormulaMaterial.FormulaQty * @neededQty) / @FormulaQty, tblMaterial.MaterialDescription
						--FROM    tblFormulaMaterial INNER JOIN
                        --tblMaterial ON tblFormulaMaterial.FormulaMaterialCode = tblMaterial.MaterialCode
						
						SELECT  FormulaMaterialCode, (FormulaQty*@neededQty)/@FormulaQty,tblMaterial.MaterialDescription,@prmYear,@prmMonth,@prmWeek
						FROM tblFormulaMaterial INNER JOIN
                        tblMaterial ON tblFormulaMaterial.FormulaMaterialCode = tblMaterial.MaterialCode
						Where tblFormulaMaterial.FormulaID=@OriFinishProdutFormulaID
					END
				ELSE
					BEGIN
						Insert into @tep_table3 values(null,null,null,null,null,null)
					END

			FETCH NEXT FROM FinishProduct_Cursor
			INTO @FinishProductCode, @neededQty
	END

	CLOSE FinishProduct_Cursor
	DEALLOCATE FinishProduct_Cursor

END

SELECT FormulaMaterialCode,sum(FormulaQty) as Qty,max(MaterialDescription) as MaterialDescription,max(year) as Year,max(month) as Month,max(week) as week
FROM @tep_table3
GROUP BY FormulaMaterialCode

--SELECT FormulaMaterialCode,FormulaQty --,FormulaUnit 
--FROM @tep_table3
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_PackingMaterialsForecast_FULL]
(
	@prmYear1 int,
	@prmMonth1 varchar(50),
	@prmYear2 int,
	@prmMonth2 varchar(50),
	@prmYear3 int,
	@prmMonth3 varchar(50)
)
AS
	SET NOCOUNT ON;
BEGIN

DECLARE @tep_table table
(
	
	FormulaMaterialCode varchar(50),	
	FormulaQty numeric(18, 4),
	MaterialDescription varchar(500),
	Year int,
	Month varchar(50),
	week int
  
)

Insert into @tep_table
Exec [dbo].[SPGET_PackingMaterialsForecastByY_M_W] @prmYear=@prmYear1,@prmMonth=@prmMonth1,@prmWeek=1

Insert into @tep_table
Exec [dbo].[SPGET_PackingMaterialsForecastByY_M_W] @prmYear=@prmYear1,@prmMonth=@prmMonth1,@prmWeek=2

Insert into @tep_table
Exec [dbo].[SPGET_PackingMaterialsForecastByY_M_W] @prmYear=@prmYear1,@prmMonth=@prmMonth1,@prmWeek=3

Insert into @tep_table
Exec [dbo].[SPGET_PackingMaterialsForecastByY_M_W] @prmYear=@prmYear1,@prmMonth=@prmMonth1,@prmWeek=4

Insert into @tep_table
Exec [dbo].[SPGET_PackingMaterialsForecastByY_M_W] @prmYear=@prmYear2,@prmMonth=@prmMonth2,@prmWeek=1

Insert into @tep_table
Exec [dbo].[SPGET_PackingMaterialsForecastByY_M_W] @prmYear=@prmYear2,@prmMonth=@prmMonth2,@prmWeek=2

Insert into @tep_table
Exec [dbo].[SPGET_PackingMaterialsForecastByY_M_W] @prmYear=@prmYear2,@prmMonth=@prmMonth2,@prmWeek=3

Insert into @tep_table
Exec [dbo].[SPGET_PackingMaterialsForecastByY_M_W] @prmYear=@prmYear2,@prmMonth=@prmMonth2,@prmWeek=4

Insert into @tep_table
Exec [dbo].[SPGET_PackingMaterialsForecastByY_M_W] @prmYear=@prmYear3,@prmMonth=@prmMonth3,@prmWeek=1

Insert into @tep_table
Exec [dbo].[SPGET_PackingMaterialsForecastByY_M_W] @prmYear=@prmYear3,@prmMonth=@prmMonth3,@prmWeek=2

Insert into @tep_table
Exec [dbo].[SPGET_PackingMaterialsForecastByY_M_W] @prmYear=@prmYear3,@prmMonth=@prmMonth3,@prmWeek=3

Insert into @tep_table
Exec [dbo].[SPGET_PackingMaterialsForecastByY_M_W] @prmYear=@prmYear3,@prmMonth=@prmMonth3,@prmWeek=4

SELECT MaterialCode,MaterialDescription,
		Week1,Stock-Week1 AS Week1_Minus,Week2,Stock-Week1-Week2 AS Week2_Minus,Week3,Stock-Week1-Week2-Week3 AS Week3_Minus,Week4,Stock-Week1-Week2-Week3-Week4 AS Week4_Minus,
		Week1+Week2+Week3+Week4 AS Month1,
		Stock-Week1-Week2-Week3-Week4 AS Month1_Minus,
		Week5+Week6+Week7+Week8 AS Month2,
		Stock-Week1-Week2-Week3-Week4-Week5-Week6-Week7-Week8 AS Month2_Minus,
		Week9+Week10+Week11+Week12 AS Month3,
		Stock-Week1-Week2-Week3-Week4-Week5-Week6-Week7-Week8-Week9-Week10-Week11-Week12 AS Month3_Minus,
		Stock,
		Week1+Week2+Week3+Week4+Week5+Week6+Week7+Week8+Week9+Week10+Week11+Week12 AS Total
FROM(
	SELECT tempFormulaMaterialCode as MaterialCode,
	(select ISNULL(max(CONVERT(numeric(18,2),FormulaQty)),0) from @tep_table where Year=@prmYear1 AND Month=@prmMonth1 AND week=1 AND FormulaMaterialCode=tempFormulaMaterialCode )as week1,
	(select ISNULL(max(CONVERT(numeric(18,2),FormulaQty)),0) from @tep_table where Year=@prmYear1 AND Month=@prmMonth1 AND week=2 AND FormulaMaterialCode=tempFormulaMaterialCode )as week2,
	(select ISNULL(max(CONVERT(numeric(18,2),FormulaQty)),0) from @tep_table where Year=@prmYear1 AND Month=@prmMonth1 AND week=3 AND FormulaMaterialCode=tempFormulaMaterialCode )as week3,
	(select ISNULL(max(CONVERT(numeric(18,2),FormulaQty)),0) from @tep_table where Year=@prmYear1 AND Month=@prmMonth1 AND week=4 AND FormulaMaterialCode=tempFormulaMaterialCode )as week4,
	(select ISNULL(max(CONVERT(numeric(18,2),FormulaQty)),0) from @tep_table where Year=@prmYear2 AND Month=@prmMonth2 AND week=1 AND FormulaMaterialCode=tempFormulaMaterialCode )as week5,
	(select ISNULL(max(CONVERT(numeric(18,2),FormulaQty)),0) from @tep_table where Year=@prmYear2 AND Month=@prmMonth2 AND week=2 AND FormulaMaterialCode=tempFormulaMaterialCode )as week6,
	(select ISNULL(max(CONVERT(numeric(18,2),FormulaQty)),0) from @tep_table where Year=@prmYear2 AND Month=@prmMonth2 AND week=3 AND FormulaMaterialCode=tempFormulaMaterialCode )as week7,
	(select ISNULL(max(CONVERT(numeric(18,2),FormulaQty)),0) from @tep_table where Year=@prmYear2 AND Month=@prmMonth2 AND week=4 AND FormulaMaterialCode=tempFormulaMaterialCode )as week8,
	(select ISNULL(max(CONVERT(numeric(18,2),FormulaQty)),0) from @tep_table where Year=@prmYear3 AND Month=@prmMonth3 AND week=1 AND FormulaMaterialCode=tempFormulaMaterialCode )as week9,
	(select ISNULL(max(CONVERT(numeric(18,2),FormulaQty)),0) from @tep_table where Year=@prmYear3 AND Month=@prmMonth3 AND week=2 AND FormulaMaterialCode=tempFormulaMaterialCode )as week10,
	(select ISNULL(max(CONVERT(numeric(18,2),FormulaQty)),0) from @tep_table where Year=@prmYear3 AND Month=@prmMonth3 AND week=3 AND FormulaMaterialCode=tempFormulaMaterialCode )as week11,
	(select ISNULL(max(CONVERT(numeric(18,2),FormulaQty)),0) from @tep_table where Year=@prmYear3 AND Month=@prmMonth3 AND week=4 AND FormulaMaterialCode=tempFormulaMaterialCode )as week12,
	(select ISNULL(max(CONVERT(numeric(18,2),StockQty)),0)   from tblStock where StockMaterialID=tempFormulaMaterialCode AND StoreID='Packing') as stock,
	(SELECT MaterialDescription from tblMaterial where MaterialCode=tempFormulaMaterialCode)as MaterialDescription

	FROM (
		select DISTINCT(FormulaMaterialCode) as tempFormulaMaterialCode from @tep_table  
		--UNION
		--select DISTINCT(MaterialCode) from tblPlanMaterials  
		--UNION
		--select DISTINCT(MaterialCode) from tblPlanMaterials  
		) AS MaterialList
	) AS MaterialPlan
--select FormulaQty from @tep_table

--select FormulaQty as week1 from @tep_table where year=@prmYear1 AND Month=@prmMonth1 AND week=1
--full join
--select FormulaQty as week2 from @tep_table where year=@prmYear1 AND Month=@prmMonth1 AND week=2

--select FormulaQty as week1 from @tep_table where year=@prmYear1 AND Month=@prmMonth1 AND week=2

END

--select * from @tep_table
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_PackingMaterialsForecastCheck]
(
	@prmYear int,
	@prmMonth varchar(50),
	@prmWeek int
)
AS
	SET NOCOUNT ON;
BEGIN

SELECT  ID, RevisionNo, Year, Month, WeekID, EnteredDate
FROM    tblSalesForecast
where	Year=@prmYear AND Month=@prmMonth AND WeekID=@prmWeek

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_PackingTypeByType]
(
@type varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT     PackingID, PackingTitle + ' - ' + CAST(PackingQty AS VARCHAR(50)) AS Packing
FROM         tblPckingType
WHERE Type=@Type
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_PlanBatch]
AS


	SET NOCOUNT ON;
SELECT        Year, Month, RevisionID, ProductCode, WeekID, BatchSize,Nos
FROM            tblPlanBatch
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_PlanBatch_ByWeek]
(
@Year int,
@Month varchar(50),
@RevisionID int,
@WeekID int
)
AS


	SET NOCOUNT ON;
SELECT        Year, Month, RevisionID, ProductCode, WeekID, BatchSize,Nos
FROM            tblPlanBatch
WHERE Year=@Year and Month=@Month and RevisionID=@RevisionID and WeekID=@WeekID
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
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
union
SELECT        tblPlanMaterials.Year, tblPlanMaterials.Month, tblPlanMaterials.RevisionID, tblPlanMaterials.WeekID, tblPlanMaterials.MaterialCode, tblPlanMaterials.Qty, tblPlanMaterials.Type, tblPlanMaterials.Status, 
                         tblUnit.UnitCode
FROM            tblPlanMaterials INNER JOIN
                         tblBasicProduct ON tblPlanMaterials.MaterialCode = tblBasicProduct.BasicProductCode INNER JOIN
                         tblUnit ON tblBasicProduct.BasicProductUnitID = tblUnit.UnitID
WHERE        ([Year] = @Year) AND ([Month] = @Month) AND Type=@Type

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_PlanMaterial_Availability]
(
	@Year1 int,
	@Month1 varchar(50),
	@Year2 int,
	@Month2 varchar(50),
	@Year3 int,
	@Month3 varchar(50),
	@Type varchar(50),
	@outParam int OUT
	
)
AS
BEGIN
	SET NOCOUNT OFF;

DECLARE @RevisionID1 int
DECLARE @RevisionID2 int
DECLARE @RevisionID3 int
DECLARE @count1 int
DECLARE @count2 int
DECLARE @count3 int

select @RevisionID1=MAX(RevisionID) from tblPlanMaterials where [Year]=@Year1 AND [Month]=@Month1
select @RevisionID2=MAX(RevisionID) from tblPlanMaterials where [Year]=@Year2 AND [Month]=@Month2
select @RevisionID3=MAX(RevisionID) from tblPlanMaterials where [Year]=@Year3 AND [Month]=@Month3

select @count1=count(*) from tblPlanMaterials where Year=@Year1 AND Month=@Month1 AND RevisionID=@RevisionID1 and Type=@Type AND Status=1
select  @count2=count(*) from tblPlanMaterials where Year=@Year2 AND Month=@Month2 AND RevisionID=@RevisionID2 and Type=@Type AND Status=1
select  @count3=count(*) from tblPlanMaterials where Year=@Year3 AND Month=@Month3 AND RevisionID=@RevisionID3 and Type=@Type AND Status=1

IF @count2>0
BEGIN
SET @count2=1
END

IF @count3>0
BEGIN
SET @count3=1
END

SET @outParam=ISNULL(@count2,0)+ISNULL(@count3,0)

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_PlanMaterial_Full]
(
	@Year1 int,
	@Month1 varchar(50),
	@Year2 int,
	@Month2 varchar(50),
	@Year3 int,
	@Month3 varchar(50),
	@Type varchar(50)
	
)
AS
BEGIN
	SET NOCOUNT OFF;

DECLARE @RevisionID1 int
DECLARE @RevisionID2 int
DECLARE @RevisionID3 int

select @RevisionID1=MAX(RevisionID) from tblPlanMaterials where [Year]=@Year1 AND [Month]=@Month1
select @RevisionID2=MAX(RevisionID) from tblPlanMaterials where [Year]=@Year2 AND [Month]=@Month2
select @RevisionID3=MAX(RevisionID) from tblPlanMaterials where [Year]=@Year3 AND [Month]=@Month3

SELECT MaterialCode,Material,Unit,
		Week1,Stock-Week1 AS Week1_Minus,Week2,Stock-Week1-Week2 AS Week2_Minus,Week3,Stock-Week1-Week2-Week3 AS Week3_Minus,Week4,Stock-Week1-Week2-Week3-Week4 AS Week4_Minus,
		Week1+Week2+Week3+Week4 AS Month1,
		Stock-Week1-Week2-Week3-Week4 AS Month1_Minus,
		Week5+Week6+Week7+Week8 AS Month2,
		Stock-Week1-Week2-Week3-Week4-Week5-Week6-Week7-Week8 AS Month2_Minus,
		Week9+Week10+Week11+Week12 AS Month3,
		Stock-Week1-Week2-Week3-Week4-Week5-Week6-Week7-Week8-Week9-Week10-Week11-Week12 AS Month3_Minus,
		Stock,
		Week1+Week2+Week3+Week4+Week5+Week6+Week7+Week8+Week9+Week10+Week11+Week12 AS Total
		 FROM(

SELECT MaterialCode,dbo.Get_ItemName(MaterialCode) AS Material,dbo.Get_Unit_Of_Item(MaterialCode) AS Unit,
dbo.Get_PlanMaterialWeek(@Year1, @Month1,@RevisionID1,MaterialCode,1) AS Week1,
dbo.Get_PlanMaterialWeek(@Year1, @Month1,@RevisionID1,MaterialCode,2) AS Week2,
dbo.Get_PlanMaterialWeek(@Year1, @Month1,@RevisionID1,MaterialCode,3) AS Week3,
dbo.Get_PlanMaterialWeek(@Year1, @Month1,@RevisionID1,MaterialCode,4) AS Week4,
dbo.Get_PlanMaterialWeek(@Year2, @Month2,@RevisionID2,MaterialCode,1)AS Week5,
dbo.Get_PlanMaterialWeek(@Year2, @Month2,@RevisionID2,MaterialCode,2) AS Week6,
dbo.Get_PlanMaterialWeek(@Year2, @Month2,@RevisionID2,MaterialCode,3)AS Week7,
dbo.Get_PlanMaterialWeek(@Year2, @Month2,@RevisionID2,MaterialCode,4) AS Week8,
dbo.Get_PlanMaterialWeek(@Year3, @Month3,@RevisionID3,MaterialCode,1)AS Week9,
dbo.Get_PlanMaterialWeek(@Year3, @Month3,@RevisionID3,MaterialCode,2)AS Week10,
dbo.Get_PlanMaterialWeek(@Year3, @Month3,@RevisionID3,MaterialCode,3) AS Week11,
dbo.Get_PlanMaterialWeek(@Year3, @Month3,@RevisionID3,MaterialCode,4) AS Week12,

dbo.Get_GRN_Stock(MaterialCode,'RM_Main','RM_Processed',1)+dbo.Get_GRN_Stock(MaterialCode,'RPD_Main','RPD_Main',1)+dbo.Get_TGRN_Stock(MaterialCode,0)+
dbo.Get_GRN_Stock(MaterialCode,'Lab_01','Lab',1)+dbo.Get_WIP_PRPD_Stock(MaterialCode,2,1,3,5,4,0,2,3)+dbo.Get_ToGRN_Stock(MaterialCode,'RM_Main','RM_Processed',0,2,2)+
dbo.Get_ToGRN_Stock(MaterialCode,'RPD_Main','Lab_01',0,2,2) AS Stock

 FROM (
select DISTINCT(MaterialCode) from tblPlanMaterials  where Year=@Year1 and Month=@Month1 and RevisionID=@RevisionID1 and Status=1 AND Type=@Type
UNION
select DISTINCT(MaterialCode) from tblPlanMaterials  where Year=@Year2 and Month=@Month2 and RevisionID=@RevisionID2 and Status=1 AND Type=@Type
UNION
select DISTINCT(MaterialCode) from tblPlanMaterials  where Year=@Year3 and Month=@Month3 and RevisionID=@RevisionID3 and Status=1 AND Type=@Type
) AS MaterialList
) AS MaterialPlan

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.SPGET_PlanWeeks
(
	@Year int,
	@Month varchar(50),
	@WeekID int
)
AS
	SET NOCOUNT OFF

BEGIN

DECLARE @RevisionID int

SELECT @RevisionID=max(RevisionID) from tblPlanWeeks where  ([Year]=@Year AND [Month]=@Month AND [WeekID]=@WeekID)

SELECT [Year],[Month] ,WeekID,RevisionID, FromDate, ToDate, [State] FROM tblPlanweeks WHERE ([Year]=@Year AND [Month]=@Month AND [WeekID]=@WeekID AND RevisionID=@RevisionID)

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_PlanWeeks_ByMonth]
(
	@Year int,
	@Month varchar(50)

)
AS
	SET NOCOUNT OFF

BEGIN

DECLARE @RevisionID int

SELECT @RevisionID=max(RevisionID) from tblPlanWeeks where  ([Year]=@Year AND [Month]=@Month)

SELECT [Year],[Month] ,WeekID,RevisionID, FromDate, ToDate, [State] FROM tblPlanweeks WHERE ([Year]=@Year AND [Month]=@Month AND  RevisionID=@RevisionID)

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_PlanWeeks_ByMonth_Fixed]
(
	@Year int,
	@Month varchar(50)

)
AS
	SET NOCOUNT OFF

BEGIN

DECLARE @RevisionID int

SELECT @RevisionID=max(RevisionID) from tblPlanWeeks where  ([Year]=@Year AND [Month]=@Month)

SELECT [Year],[Month] ,WeekID,RevisionID, FromDate, ToDate, [State] FROM tblPlanweeks WHERE ([Year]=@Year AND [Month]=@Month AND  RevisionID=@RevisionID AND State=1)

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_PrimaryBasicProductByBasicProductID]
(
	@BasicProductCode varchar(50)
)
AS
	SET NOCOUNT ON;


SELECT	FormulaMaterialCode, Qty, BasicProductCode
FROM	Plan_BasicProduct_MaterialTotal
WHERE	BasicProductCode=@BasicProductCode
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_ProjectMaterial_Availability]
(
	--@DispatchID  varchar(50),
	@MaterialID varchar(50),
	@MaterialType varchar(50),
	@Qty numeric(18, 2)
	--@StoreID varchar(50)
)
AS
	SET NOCOUNT OFF;

BEGIN

--BEGIN TRAN

--DECLARE @GRNNO numeric,@ItemCode varchar(50),@NetQty numeric(20, 6),@StockID numeric(18,0),@Remains bit,
--			@RemainQty numeric(20, 6),@Difference numeric(20, 6),@StockQty numeric(20, 6),@Ori_MRIssuedQty numeric(20, 6),
--			@StockDuration numeric(18,2),@StoreID varchar(50)

DECLARE @StockQty numeric(18, 2) , @StockID numeric(18,0)
--DECLARE @IssuedStockList TABLE(GRNID varchar(50),StockID varchar(50),StoreID varchar(50),Qty numeric )

--SELECT @Remains = 0
--SELECT @Ori_MRIssuedQty = @IssuedQty


if @MaterialType='Finish Product'
Begin
SELECT    @StockID = StockID, @StockQty = StockQty
FROM         tblStock
WHERE     (StockFinishProduct = @MaterialID)
end
else if @MaterialType='Basic Product'
Begin
SELECT    @StockID = StockID, @StockQty = StockQty
FROM         tblStock
WHERE     (StockBasicProduct = @MaterialID)
end
else
Begin
SELECT    @StockID = StockID, @StockQty = StockQty
FROM         tblStock
WHERE     (StockMaterialID = @MaterialID)
end



IF @StockQty >= @Qty
BEGIN

--SELECT @UnitPrice1 = dbo.StockUnitPrice_FinishProduct(@StockID)

SELECT        tblStock.*
FROM            tblStock
where StockID=@StockID

UPDATE       tblStock
SET StockQty = @StockQty-@Qty
Where StockID =@StockID

END -- @stock > @IssuedQty
ELSE
BEGIN
	RETURN -1
END

END
--------------------
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_ProjectMaterials]
(
	@ProjetID varchar(20)
)
AS
	SET NOCOUNT ON;

BEGIN

SELECT MaterialCode, BasicProductCode, FinishProductCode, UsedQty, DamagedQty, UnitPrice
FROM tblProjectMaterials
WHERE ProjectID=@ProjetID;

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_Projects]

AS
	SET NOCOUNT ON;

BEGIN

SELECT        tblProjects.ProjectName, tblDepartment.DepDescription as Department, tblProjects.ProjectID, tblProjects.Status, tblProjects.ProjectType, tblStore.StoreID, tblProjects.ProjectName+' - '+tblDepartment.DepDescription as ProjectName2
FROM            tblDepartment INNER JOIN
                         tblProjects ON tblDepartment.DepID = tblProjects.DepID INNER JOIN
                         tblStore ON tblDepartment.DepID = tblStore.StoreDepID
						 WHERE tblDepartment.DepID != 25

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_Projets]

AS
	SET NOCOUNT ON;

BEGIN

SELECT        tblProjects.ProjectName, tblProjects.DepID, tblProjects.ProjectID, tblProjects.Status, tblProjects.ProjectType, tblStore.StoreID
FROM            tblDepartment INNER JOIN
                         tblProjects ON tblDepartment.DepID = tblProjects.DepID INNER JOIN
                         tblStore ON tblDepartment.DepID = tblStore.StoreDepID
						 WHERE tblDepartment.DepID != 25

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_QCReport_ByType]
(
@QCReportType varchar(50),
@status int
)
AS
	SET NOCOUNT ON;

SELECT TOP 50 QCReportID, ReportType, RPDBatchID, TestBy, SendBy, SampleSize
FROM    tblQCReport
where ReportType=@QCReportType AND Status=@status
order by QCReportID desc
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_SalesMethod]
AS
	SET NOCOUNT ON;

SELECT        SalesMethodID, SMDesctiption
FROM            tblSalesMethod
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_Section_ByDepType]
(
@DepType1 varchar(50),
@DepType2 varchar(50),
@DepType3 varchar(50),
@DepType4 varchar(50)

)
AS
	SET NOCOUNT ON;

	BEGIN
SELECT     SectionID, SectionName, DepID, SuperviserID, MorningFrom, MorningTo, LunchFrom, LunchTo, EveFrom, EveTo, NightBreakFrom1, NightBreakTo1, NightBreakFrom2,
                      NightBreakTo2, NightBreakFrom3, NightBreakTo3
FROM         tblSection
 WHERE DepID in (select DepID from tblDepartment where Type=@DepType1 OR Type=@DepType2 OR Type=@DepType3 OR Type=@DepType4)


END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGET_User_PsswordExpired]
(
@UserID int,
@outParam int OUT
)
AS
	SET NOCOUNT ON;

DECLARE @ExpDate datetime

SELECT    @ExpDate=ExpiryDate
FROM         tblUser
WHERE UserID=@UserID

IF @ExpDate<Getdate()
BEGIN
SET @outParam=1
END
ELSE

BEGIN
SET @outParam=0
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
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

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPUPDATE_FinishProduct_Availability]
(
	@DispatchID  varchar(50),
	@FinishProductID varchar(50),
	@IssuedQty numeric(20, 6)
	--@StoreID varchar(50)
)
AS
	SET NOCOUNT OFF;

BEGIN

BEGIN TRAN

DECLARE @GRNNO numeric,@ItemCode varchar(50),@NetQty numeric(20, 6),@StockID numeric(18,0),@Remains bit,
			@RemainQty numeric(20, 6),@Difference numeric(20, 6),@StockQty numeric(20, 6),@Ori_MRIssuedQty numeric(20, 6),
			@StockDuration numeric(18,2),@StoreID varchar(50)

DECLARE @IssuedStockList TABLE(GRNID varchar(50),StockID varchar(50),StoreID varchar(50),Qty numeric )

SELECT @Remains = 0
SELECT @Ori_MRIssuedQty = @IssuedQty


SELECT    @StockID = StockID, @StockQty = StockQty , @StoreID = StoreID
FROM         tblStock
WHERE     (StockFinishProduct = @FinishProductID)

IF @StockQty >= @IssuedQty
BEGIN

--SELECT @UnitPrice1 = dbo.StockUnitPrice_FinishProduct(@StockID)

DECLARE GRNFinishProduct_Cursor CURSOR FOR
SELECT     tblGRNFinishProduct.GRNNO, tblGRNFinishProduct.FinishProductCode, tblGRNFinishProduct.NetQty
FROM         tblGRNFinishProduct INNER JOIN
                      tblGRN ON tblGRNFinishProduct.GRNNO = tblGRN.GRNNO
WHERE     (tblGRNFinishProduct.FinishProductCode = @FinishProductID) AND (tblGRNFinishProduct.GRNNO IN
                          (SELECT     GRNNO
                            FROM          tblGRN AS tblGRN_1
                            WHERE      (GRNStoreID = @StoreID))) AND (tblGRN.GRNStatus = 1)
ORDER BY tblGRNFinishProduct.GRNNO

	OPEN GRNFinishProduct_Cursor
	FETCH NEXT FROM GRNFinishProduct_Cursor
	INTO @GRNNO,@ItemCode,@NetQty
	WHILE @@FETCH_STATUS = 0
	BEGIN
		DECLARE @TotalIssuedQty numeric(20, 6)

		SELECT @TotalIssuedQty = ISNULL(SUM(StockIssuedQty),0)
		FROM tblStockGRN
		WHERE StockGRNNO = @GRNNO AND StockID = @StockID

		IF @Remains = 1
		BEGIN
			SELECT @IssuedQty = @RemainQty
			SELECT @Remains = 0
		END

			SELECT @Difference = @NetQty - @TotalIssuedQty


		IF @Difference > 0
			BEGIN

				DECLARE @COUNT int
				IF @IssuedQty > @Difference
					BEGIN

					SELECT @COUNT = COUNT(*)
							FROM tblStockGRN
							WHERE StockID = @StockID AND StockGRNNO = @GRNNO

						IF @COUNT > 0
							BEGIN
								UPDATE tblStockGRN SET StockIssuedQty = StockIssuedQty + @Difference
								WHERE StockID = @StockID AND StockGRNNO = @GRNNO				
								INSERT INTO [dbo].[tblDispatchIssueList] ([DispatchID],[GRNID],[Status],[IssuDate],[IssuedQty]) VALUES (@DispatchID,@GRNNO,0,GETDATE(),@Difference)
--								INSERT INTO @IssuedStockList (GRNID,StockID,StoreID,Qty )
--								values (@GRNNO,@StockID,@StoreID,@Difference)

							END
						ELSE
							BEGIN
								INSERT INTO tblStockGRN VALUES(@StockID,@GRNNO,GETDATE(),@Difference)				
								INSERT INTO [dbo].[tblDispatchIssueList] ([DispatchID],[GRNID],[Status],[IssuDate],[IssuedQty]) VALUES (@DispatchID,@GRNNO,0,GETDATE(),@Difference)
--								INSERT INTO @IssuedStockList (GRNID,StockID,StoreID,Qty )
--								values (@GRNNO,@StockID,@StoreID,@Difference)

							END

						SELECT @Remains = 1
						SELECT @RemainQty = @IssuedQty - @Difference
--						SELECT @Cost = @Cost + ((@UnitPrice+dbo.StockHoldingCost(@GRNNO,@UnitPrice))* @Difference)
					END
				ELSE
				BEGIN
						SELECT @COUNT = COUNT(*)
						FROM tblStockGRN
						WHERE StockID = @StockID AND StockGRNNO = @GRNNO
					IF @COUNT > 0
						BEGIN
							UPDATE tblStockGRN SET StockIssuedQty = StockIssuedQty + @IssuedQty
							WHERE StockID = @StockID AND StockGRNNO = @GRNNO			
							INSERT INTO [dbo].[tblDispatchIssueList] ([DispatchID],[GRNID],[Status],[IssuDate],[IssuedQty]) VALUES (@DispatchID,@GRNNO,0,GETDATE(),@IssuedQty)
--							INSERT INTO @IssuedStockList (GRNID,StockID,StoreID,Qty )
--								values (@GRNNO,@StockID,@StoreID,@IssuedQty)

						END
					ELSE
						BEGIN
							INSERT INTO tblStockGRN VALUES(@StockID,@GRNNO,GETDATE(),@IssuedQty)			
							INSERT INTO [dbo].[tblDispatchIssueList] ([DispatchID],[GRNID],[Status],[IssuDate],[IssuedQty]) VALUES (@DispatchID,@GRNNO,0,GETDATE(),@IssuedQty)
--							INSERT INTO @IssuedStockList (GRNID,StockID,StoreID,Qty )
--							values (@GRNNO,@StockID,@StoreID,@IssuedQty)
						END
					BREAK
				END



			END

--------Fetch the next Record
		FETCH NEXT FROM GRNFinishProduct_Cursor
		INTO @GRNNO,@ItemCode,@NetQty
	END
	CLOSE GRNFinishProduct_Cursor
	DEALLOCATE GRNFinishProduct_Cursor

--	UPDATE tblStock
--	SET StockQty = StockQty - @Ori_MRIssuedQty
--	WHERE StockID = @StockID
SELECT GRNID,StockID,StoreID,Qty FROM @IssuedStockList

IF @@ERROR <> 0
BEGIN
 ROLLBACK TRAN
END
ELSE
BEGIN
	COMMIT TRAN
END

	RETURN 1

END -- @stock > @IssuedQty
ELSE
BEGIN
	RETURN -1
END

END
--------------------
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPUPDATE_PlanBatch]
(
	@Year numeric(18, 0),
	@Month varchar(50),
	@RevisionID numeric(18, 0),
	@ProductCode varchar(50),
	@WeekID numeric(18, 0),
	@BatchSize numeric(18, 2),
	@Nos numeric(18, 0),
	@Original_RevisionID numeric(18, 0)
)
AS
	SET NOCOUNT OFF;
UPDATE [tblPlanBatch] SET [Year] = @Year, [Month] = @Month, [ProductCode] = @ProductCode, [WeekID] = @WeekID, [BatchSize] = @BatchSize, [Nos] = @Nos
 WHERE (([RevisionID] = @Original_RevisionID));
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[SPUPDATE_PlanBatchStatus_Finalize]
	(
	@Year numeric(18, 0),
	@Month varchar(50),
	@WeekID numeric(18, 0),
	@Status numeric(18, 0),
	@BatchLevel numeric(18, 0)
    )

AS

SET NOCOUNT OFF;
BEGIN

UPDATE  tblPlanBatch
SET     Status =1
where	Year =@Year AND Month =@Month AND WeekID =@WeekID AND BatchLevel=@BatchLevel

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[SPUPDATE_PlanBatchStatus_Reprocess]
	(
	@Year numeric(18, 0),
	@Month varchar(50),
	@WeekID numeric(18, 0),
	@Status numeric(18, 0),
	@BatchLevel numeric(18, 0)
    )

AS

SET NOCOUNT OFF;
BEGIN

UPDATE  tblPlanBatch
SET     Status =0
where	Year =@Year AND Month =@Month AND WeekID =@WeekID AND BatchLevel=@BatchLevel


DELETE FROM tblPlanMaterials
where	Year =@Year AND Month =@Month AND WeekID =@WeekID 

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPUPDATE_PlanMaterial_Fix]
(
	@Year int,
	@Month varchar(50),
	@WeekID int,
	@Type varchar(50),
	@Status int
	
)
AS
BEGIN
	SET NOCOUNT OFF;

DECLARE @RevisionID int

SELECT @RevisionID=max(RevisionID) from tblPlanMaterials where @Year=@Year and [Month]=@Month and WeekID=@WeekID  

update tblPlanMaterials set [Status]=@Status where @Year=@Year and Month=@Month and WeekID=@WeekID and RevisionID=@RevisionID

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPUPDATE_PlanWeeks_Fix]
(
	@Year int,
	@Month varchar(50),
	@WeekID int,
	@RevisionID int,
	@State int
)
AS
	SET NOCOUNT OFF;
	

BEGIN

UPDATE tblPlanWeeks set State=@State where Year=@Year AND Month=@Month AND WeekID=@WeekID AND RevisionID=@RevisionID

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPUPDATE_SalesForecast_Status]
(
	@SFStatus int,
	@FSID int
)
AS
	SET NOCOUNT OFF;

UPDATE       tblSalesForecast SET State =@SFStatus
where ID=@FSID
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPUPDATE_SalesMethod]
(
	@SalesMethodID varchar(50),
	@SMDesctiption varchar(200)
)
AS
	SET NOCOUNT OFF;

UPDATE       tblSalesMethod
SET          SMDesctiption =@SMDesctiption
WHERE SalesMethodID=@SalesMethodID
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPUPDATE_User_OnlineState]
(
	@Online bit,
	@Original_UserID numeric
)
AS
	SET NOCOUNT OFF;
BEGIN


UPDATE    tblUser
SET              [Online] = @Online
WHERE     (UserID = @Original_UserID)

				END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[zzz]
(
	@Year1 int,
	@Month1 varchar(50),
	@Year2 int,
	@Month2 varchar(50),
	@Year3 int,
	@Month3 varchar(50),
	@Type varchar(50)
	
)
AS
BEGIN
	SET NOCOUNT OFF;

DECLARE @RevisionID1 int
DECLARE @RevisionID2 int
DECLARE @RevisionID3 int

select @RevisionID1=MAX(RevisionID) from tblSalesForecast INNER JOIN tblSalesForecastDetails ON tblSalesForecast.ID = tblSalesForecastDetails.SalesForecastID where [tblSalesForecast].[Year]=@Year1 AND [tblSalesForecast].[Month]=@Month1
select @RevisionID1=MAX(RevisionID) from tblSalesForecast INNER JOIN tblSalesForecastDetails ON tblSalesForecast.ID = tblSalesForecastDetails.SalesForecastID where [tblSalesForecast].[Year]=@Year2 AND [tblSalesForecast].[Month]=@Month2
select @RevisionID1=MAX(RevisionID) from tblSalesForecast INNER JOIN tblSalesForecastDetails ON tblSalesForecast.ID = tblSalesForecastDetails.SalesForecastID where [tblSalesForecast].[Year]=@Year3 AND [tblSalesForecast].[Month]=@Month3

------------------OK

SELECT MaterialCode,Material,Unit,
		Week1,Stock-Week1 AS Week1_Minus,Week2,Stock-Week1-Week2 AS Week2_Minus,Week3,Stock-Week1-Week2-Week3 AS Week3_Minus,Week4,Stock-Week1-Week2-Week3-Week4 AS Week4_Minus,
		Week1+Week2+Week3+Week4 AS Month1,
		Stock-Week1-Week2-Week3-Week4 AS Month1_Minus,
		Week5+Week6+Week7+Week8 AS Month2,
		Stock-Week1-Week2-Week3-Week4-Week5-Week6-Week7-Week8 AS Month2_Minus,
		Week9+Week10+Week11+Week12 AS Month3,
		Stock-Week1-Week2-Week3-Week4-Week5-Week6-Week7-Week8-Week9-Week10-Week11-Week12 AS Month3_Minus,
		Stock,
		Week1+Week2+Week3+Week4+Week5+Week6+Week7+Week8+Week9+Week10+Week11+Week12 AS Total
		 FROM(

SELECT MaterialCode,dbo.Get_ItemName(MaterialCode) AS Material,dbo.Get_Unit_Of_Item(MaterialCode) AS Unit,
dbo.Get_PlanMaterialWeek(@Year1, @Month1,@RevisionID1,MaterialCode,1) AS Week1,
dbo.Get_PlanMaterialWeek(@Year1, @Month1,@RevisionID1,MaterialCode,2) AS Week2,
dbo.Get_PlanMaterialWeek(@Year1, @Month1,@RevisionID1,MaterialCode,3) AS Week3,
dbo.Get_PlanMaterialWeek(@Year1, @Month1,@RevisionID1,MaterialCode,4) AS Week4,
dbo.Get_PlanMaterialWeek(@Year2, @Month2,@RevisionID2,MaterialCode,1)AS Week5,
dbo.Get_PlanMaterialWeek(@Year2, @Month2,@RevisionID2,MaterialCode,2) AS Week6,
dbo.Get_PlanMaterialWeek(@Year2, @Month2,@RevisionID2,MaterialCode,3)AS Week7,
dbo.Get_PlanMaterialWeek(@Year2, @Month2,@RevisionID2,MaterialCode,4) AS Week8,
dbo.Get_PlanMaterialWeek(@Year3, @Month3,@RevisionID3,MaterialCode,1)AS Week9,
dbo.Get_PlanMaterialWeek(@Year3, @Month3,@RevisionID3,MaterialCode,2)AS Week10,
dbo.Get_PlanMaterialWeek(@Year3, @Month3,@RevisionID3,MaterialCode,3) AS Week11,
dbo.Get_PlanMaterialWeek(@Year3, @Month3,@RevisionID3,MaterialCode,4) AS Week12,

dbo.Get_GRN_Stock(MaterialCode,'RM_Main','RM_Processed',1)+dbo.Get_GRN_Stock(MaterialCode,'RPD_Main','RPD_Main',1)+dbo.Get_TGRN_Stock(MaterialCode,0)+
dbo.Get_GRN_Stock(MaterialCode,'Lab_01','Lab',1)+dbo.Get_WIP_PRPD_Stock(MaterialCode,2,1,3,5,4,0,2,3)+dbo.Get_ToGRN_Stock(MaterialCode,'RM_Main','RM_Processed',0,2,2)+
dbo.Get_ToGRN_Stock(MaterialCode,'RPD_Main','Lab_01',0,2,2) AS Stock

 FROM (
select DISTINCT(MaterialCode) from tblPlanMaterials  where Year=@Year1 and Month=@Month1 and RevisionID=@RevisionID1 and Status=1 AND Type=@Type
UNION
select DISTINCT(MaterialCode) from tblPlanMaterials  where Year=@Year2 and Month=@Month2 and RevisionID=@RevisionID2 and Status=1 AND Type=@Type
UNION
select DISTINCT(MaterialCode) from tblPlanMaterials  where Year=@Year3 and Month=@Month3 and RevisionID=@RevisionID3 and Status=1 AND Type=@Type
) AS MaterialList
) AS MaterialPlan

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPADD_BasicProduct]
(
	@BasicProductCode varchar(50),
	@BasicProductName varchar(500),
	@BasicProductDescription varchar(2000),
	@BasicProductSubCatID varchar(50),
	@BasicProductCatID varchar(50),
	@BasicProductUnitID numeric(18, 0),
	@BasicProductFormID numeric(18, 0),
	@BasicProductAvgCost numeric(10, 2),
	@BasicProductStatus bit,
	@BasicProductType varchar(50),
	@STDBatchSize numeric(10, 2),
	@DepID int,
	@SectionID int
)
AS
	SET NOCOUNT OFF;
BEGIN
DECLARE @COUNT1		int
DECLARE	@COUNT2		int
DECLARE	@COUNT3		int
DECLARE @FormulaID int
DECLARE	@DepID_Sec		int

	SELECT @DepID_Sec=DepID from tblSection where SectionID=@SectionID

	SELECT @COUNT1 = COUNT(*) FROM [tblBasicProduct] WHERE [BasicProductCode] = @BasicProductCode
	SELECT @COUNT2 = COUNT(*) FROM tblProductManufacturing WHERE ProductCode = @BasicProductCode AND Type='Manf'
	SELECT @COUNT3 = COUNT(*) FROM tblProductManufacturing WHERE ProductCode = @BasicProductCode AND Type='Pack'
	SELECT @FormulaID=ISNULL(Max(FormulaID),0) from tblFormula 

	IF @COUNT1 > 0
	BEGIN
		UPDATE [tblBasicProduct] SET [BasicProductName] = @BasicProductName,[BasicProductDescription] = @BasicProductDescription,[BasicProductSubCatID] = @BasicProductSubCatID,
			[BasicProductCatID] = @BasicProductCatID,[BasicProductUnitID] = @BasicProductUnitID,[BasicProductFormID] = @BasicProductFormID,
			[BasicProductAvgCost] = @BasicProductAvgCost,[BasicProductStatus] = @BasicProductStatus,[BasicProductType] = @BasicProductType,STDBatchSize=@STDBatchSize
		WHERE (([BasicProductCode] = @BasicProductCode))
	
	END
	ELSE
	BEGIN
		INSERT INTO [tblBasicProduct] ([BasicProductCode], [BasicProductName], [BasicProductDescription], [BasicProductSubCatID], [BasicProductCatID], [BasicProductUnitID],[BasicProductFormulaID], [BasicProductFormID], [BasicProductAvgCost], [BasicProductStatus], [BasicProductType],[STDBatchSize]) 
		VALUES (@BasicProductCode, @BasicProductName, @BasicProductDescription, @BasicProductSubCatID, @BasicProductCatID, @BasicProductUnitID,@FormulaID, @BasicProductFormID, @BasicProductAvgCost, @BasicProductStatus, @BasicProductType,@STDBatchSize)
		
	END


-----------------------Update tblManufacturing-----------------------------------------------------


	IF @COUNT2 > 0
	BEGIN
		UPDATE tblProductManufacturing set DepID=@DepID
		WHERE ProductCode = @BasicProductCode AND Type='Manf'
	
	END
	ELSE
	BEGIN
		Insert into tblProductManufacturing (ProductCode,DepID,Type) VALUES (@BasicProductCode,@DepID,'Manf')
	END


IF @COUNT3 > 0
	BEGIN
		UPDATE tblProductManufacturing set SectionID=@SectionID,DepID=@DepID_Sec
		WHERE ProductCode = @BasicProductCode AND Type='Pack'
	
	END
	ELSE
	BEGIN
		Insert into tblProductManufacturing (ProductCode,DepID,SectionID,Type) VALUES (@BasicProductCode,@DepID_Sec,@SectionID,'Pack')
	END


END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPADD_BatchMR_SendMR]
(
	@Part varchar(50),
	@BatchID varchar(50),
	@MRStore varchar(50),
	@MREnterdBy varchar(50),
	@MRRemarks varchar(5000),
	@MRStatus int,
	@MRType int,
	@OriginType int,
	@outParam numeric(8,0) OUT
)
AS
	SET NOCOUNT ON;
BEGIN
BEGIN TRAN


DECLARE @BasicProductCode varchar(50)
DECLARE @BatchSTDBatchID varchar(50)
DECLARE @FormID int
DECLARE @MRFromDepID numeric(18, 0)

SELECT @BatchSTDBatchID=BatchSTDBatchID FROM tblBatch where BatchID=@BatchID

SELECT @BasicProductCode=STDBasicProductCode FROM tblSTDBatch where STDBatchID=@BatchSTDBatchID


--SELECT @FormID=BasicProductFormID from tblBasicProduct

--IF @FormID=2
--BEGIN
--select @MRFromDepID=DepID from tblDepartment where DepName='Manufacturing-01' 
--END
--ELSE
--BEGIN
--select @MRFromDepID=DepID from tblDepartment where DepName='Manufacturing-02' 
--END

SELECT @MRFromDepID=DepID FROM  tblProductManufacturing WHERE ProductCode=@BasicProductCode AND [Type]='Manf'



INSERT INTO tblMR
                      (MRStore, MRDate, MREnterdBy, MRFromDepID, MRRemarks, MRStatus, MRType, MRPrint, MRBulkPrint,OriginType)
VALUES     (@MRStore, GETDATE(),@MREnterdBy,@MRFromDepID,@MRRemarks,@MRStatus,@MRType, 0, 0,@OriginType)
SET @outParam = SCOPE_IDENTITY()

INSERT INTO tblBatchMR
						  (BatchID, MRNO, Status, Date, Part)
	VALUES     (@BatchID,@outParam, 1, GETDATE(),@Part)
	
	
INSERT INTO [tblMRMaterial]
           ([MRNO]
           ,[MRMaterialCode]
           ,[MRDescription]
           ,[MRReqdQty]
           ,[MRIssuedQty]
           ,[MRBINNo]
           ,[MRUnitRate])

SELECT @outParam
      ,MaterialCode
      ,'Batch Material Requisition'
      ,Qty
      ,0
      ,'N/A'
      ,0 from tblBatchFormulaMaterial where BatchID=@BatchID AND Part=@Part
           

IF @@ERROR <> 0
BEGIN
	ROLLBACK TRAN
END
ELSE
BEGIN
	COMMIT TRAN
END
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPADD_BatchMR_SendMR_Optional]
(
	@Part varchar(50),
	@BatchID varchar(50),
	@MRStore varchar(50),
	@MREnterdBy varchar(50),
	@MRRemarks varchar(5000),
	@MRStatus int,
	@MRType int,
	@OriginType int,
	@outParam numeric(8,0) OUT
)
AS
	SET NOCOUNT ON;
BEGIN
BEGIN TRAN


DECLARE @BasicProductCode varchar(50)
DECLARE @BatchSTDBatchID varchar(50)
DECLARE @FormID int
DECLARE @MRFromDepID numeric(18, 0)

SELECT @BatchSTDBatchID=BatchSTDBatchID FROM tblBatch where BatchID=@BatchID

SELECT @BasicProductCode=STDBasicProductCode FROM tblSTDBatch where STDBatchID=@BatchSTDBatchID

--SELECT @FormID=BasicProductFormID from tblBasicProduct


--IF @FormID=2
--BEGIN
--select @MRFromDepID=DepID from tblDepartment where DepName='Manufacturing-01' 
--END
--ELSE
--BEGIN
--select @MRFromDepID=DepID from tblDepartment where DepName='Manufacturing-02' 
--END
SELECT @MRFromDepID=DepID FROM  tblProductManufacturing WHERE ProductCode=@BasicProductCode AND [Type]='Manf'


INSERT INTO tblMR
                      (MRStore, MRDate, MREnterdBy, MRFromDepID, MRRemarks, MRStatus, MRType, MRPrint, MRBulkPrint,OriginType)
VALUES     (@MRStore, GETDATE(),@MREnterdBy,@MRFromDepID,@MRRemarks,@MRStatus,@MRType, 0, 0,@OriginType)
SET @outParam = SCOPE_IDENTITY()

INSERT INTO tblBatchMR
						  (BatchID, MRNO, Status, Date, Part)
	VALUES     (@BatchID,@outParam, 1, GETDATE(),@Part)
	
	


IF @@ERROR <> 0
BEGIN
	ROLLBACK TRAN
END
ELSE
BEGIN
	COMMIT TRAN
END
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPADD_BatchMR_SendMR_SemiFinished]
(
	@Part varchar(50),
	@BatchID varchar(50),
	@MRStore varchar(50),
	@MREnterdBy varchar(50),
	@MRRemarks varchar(5000),
	@MRStatus int,
	@MRType int,
	@OriginType int,
	@outParam numeric(8,0) OUT
)
AS
	SET NOCOUNT ON;
BEGIN
BEGIN TRAN


DECLARE @BasicProductCode varchar(50)
DECLARE @BatchSTDBatchID varchar(50)
DECLARE @FormID int
DECLARE @MRFromDepID numeric(18, 0)

SELECT @BatchSTDBatchID=BatchSTDBatchID FROM tblBatch where BatchID=@BatchID

SELECT @BasicProductCode=STDBasicProductCode FROM tblSTDBatch where STDBatchID=@BatchSTDBatchID

--SELECT @FormID=BasicProductFormID from tblBasicProduct


--IF @FormID=2
--BEGIN
--select @MRFromDepID=DepID from tblDepartment where DepName='Manufacturing-01' 
--END
--ELSE
--BEGIN
--select @MRFromDepID=DepID from tblDepartment where DepName='Manufacturing-02' 
--END
SELECT @MRFromDepID=DepID FROM  tblProductManufacturing WHERE ProductCode=@BasicProductCode AND [Type]='Manf'


INSERT INTO tblMR
                      (MRStore, MRDate, MREnterdBy, MRFromDepID, MRRemarks, MRStatus, MRType, MRPrint, MRBulkPrint,OriginType)
VALUES     (@MRStore, GETDATE(),@MREnterdBy,@MRFromDepID,@MRRemarks,@MRStatus,@MRType, 0, 0,@OriginType)
SET @outParam = SCOPE_IDENTITY()

INSERT INTO tblBatchMR
						  (BatchID, MRNO, Status, Date, Part)
	VALUES     (@BatchID,@outParam, 1, GETDATE(),@Part)
	
	
INSERT INTO tblMRBasicProduct
           ([MRNO]
           ,[MRBasicProductID]
           ,[MRDescription]
           ,[MRReqdQty]
           ,[MRIssuedQty]
           ,[MRBINNo]
           ,[MRUnitRate])

SELECT @outParam
      ,BasicProductCode
      ,'Batch Material Requisition'
      ,Qty
      ,0
      ,'N/A'
      ,0 from tblBatchFormulaBasicProducts where BatchID=@BatchID AND Part=@Part
           

IF @@ERROR <> 0
BEGIN
	ROLLBACK TRAN
END
ELSE
BEGIN
	COMMIT TRAN
END
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPADD_FinishProduct]
(
	@FinishProductCode varchar(50),
	@BasicProductCode varchar(50),
	@FinishProdutPackingTypeID numeric(18, 0),
	@FinishProdutDescription varchar(2000),
	@FinishProdutBasicQty numeric(18, 4),
	@FinishProdutAvgCost numeric(10, 2),
	@FinishProdutStatus bit,
	@PrimaryFinishProductCode	varchar(50)	,
	@PrimaryFinishProductQty	numeric(18, 0)	,
	@FinishProductType	varchar(50)

)
AS
BEGIN
	SET NOCOUNT OFF;
		DECLARE @COUNT int

SELECT @COUNT = COUNT(*) FROM tblFinishProduct WHERE [FinishProductCode] = @FinishProductCode

IF @COUNT > 0
BEGIN

UPDATE    tblFinishProduct
SET              BasicProductCode = @BasicProductCode, FinishProdutPackingTypeID = @FinishProdutPackingTypeID, 
                      FinishProdutDescription = @FinishProdutDescription, FinishProdutBasicQty = @FinishProdutBasicQty, FinishProdutAvgCost = @FinishProdutAvgCost, 
                      FinishProdutStatus = @FinishProdutStatus, PrimaryFinishProductCode = @PrimaryFinishProductCode, PrimaryFinishProductQty = @PrimaryFinishProductQty, 
                      FinishProductType = @FinishProductType
WHERE     (FinishProductCode = @FinishProductCode)
 
END
			ELSE
			BEGIN
				INSERT INTO tblFinishProduct
                      (FinishProductCode, BasicProductCode, FinishProdutPackingTypeID, FinishProdutDescription, FinishProdutBasicQty, FinishProdutAvgCost, 
                      FinishProdutStatus, PrimaryFinishProductCode, PrimaryFinishProductQty, FinishProductType)
VALUES     (@FinishProductCode,@BasicProductCode,@FinishProdutPackingTypeID,@FinishProdutDescription,@FinishProdutBasicQty,@FinishProdutAvgCost,@FinishProdutStatus,@PrimaryFinishProductCode,@PrimaryFinishProductQty,@FinishProductType)


END


END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPADD_SalesForecast]
(

	@RevisionNo int,
	@Year int,
	@Month varchar(50),
	@WeekID int,
	@Accuracy varchar(50),
	@State int,
	@EenteredBy varchar(50),
	@outParam int out

)
AS
	SET NOCOUNT OFF;

BEGIN

INSERT INTO tblSalesForecast
(RevisionNo, Year, Month, WeekID, Accuracy, State, EnteredBy, EnteredDate)
VALUES (@RevisionNo,@Year,@Month,@WeekID,@Accuracy,@State,@EenteredBy,getdate())

SELECT @outParam=CONVERT(int,ISNULL(SCOPE_IDENTITY(),0)) 

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPADD_SalesForecastDetails]
(
	@prmYear int,
	@prmMonth varchar(50),
	@prmweekID int,
	@SalesForecastID int,
	--@RevisionID int,
	@ProductCode varchar(50),
	@Qty int,
	@outParam int out

)
AS
	SET NOCOUNT OFF;

BEGIN


	--DECLARE @prmYear int=2014,@prmMonth varchar(50)='April',@prmweekID int=1,@FinishProduct varchar(50)='AR/AB/4.5/CA'
	DECLARE @preRevisionID int =0

	SELECT @preRevisionID=max(tblSalesForecastDetails.RevisionID)
	FROM tblSalesForecastDetails INNER JOIN tblSalesForecast ON tblSalesForecastDetails.SalesForecastID = tblSalesForecast.ID
	WHERE tblSalesForecast.Year=@prmYear AND tblSalesForecast.Month=@prmMonth AND tblSalesForecast.WeekID=@prmweekID AND tblSalesForecastDetails.ProductCode=@ProductCode	AND State=0	

	if @preRevisionID=0
	BEGIN
		INSERT INTO tblSalesForecastDetails (SalesForecastID, RevisionID, ProductCode, Qty)
		VALUES        (@SalesForecastID,@preRevisionID+1,@ProductCode,@Qty)
	END
	else if @preRevisionID=1
	BEGIN
		INSERT INTO tblSalesForecastDetails (SalesForecastID, RevisionID, ProductCode, Qty)
		VALUES        (@SalesForecastID,@preRevisionID+1,@ProductCode,@Qty)
	END
	else if @preRevisionID=2
	BEGIN
		INSERT INTO tblSalesForecastDetails (SalesForecastID, RevisionID, ProductCode, Qty)
		VALUES        (@SalesForecastID,@preRevisionID+1,@ProductCode,@Qty)
	END
	else if @preRevisionID=3
	BEGIN
		INSERT INTO tblSalesForecastDetails (SalesForecastID, RevisionID, ProductCode, Qty)
		VALUES        (@SalesForecastID,3,@ProductCode,@Qty)
	END
	else
	BEGIN
		INSERT INTO tblSalesForecastDetails (SalesForecastID,RevisionID, ProductCode, Qty)
		VALUES        (@SalesForecastID,0,@ProductCode,@Qty)
	END
	--print @preRevisionID
	--INSERT INTO tblSalesForecastDetails (SalesForecastID, RevisionID, ProductCode, Qty)
	--VALUES        (@SalesForecastID,@preRevisionID,@ProductCode,@Qty)

SET @outParam = SCOPE_IDENTITY()

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPDELETE_Activity]
(
	@ActID numeric(18,0)
)
AS
	SET NOCOUNT OFF;

BEGIN

BEGIN TRAN

DECLARE @SeqNo int, @ActSTDBatchID numeric(18,0), @Count int,@ActID1 numeric(18,0)

SELECT @SeqNo = SequenceNo,@ActSTDBatchID = ActSTDBatchID
FROM tblActivity
WHERE (([ActID] = @ActID))


SELECT @Count = COUNT(*)
FROM tblActivity
WHERE ActSTDBatchID = @ActSTDBatchID

DELETE FROM [tblActivity] WHERE (([ActID] = @ActID))

DECLARE activity_cursor CURSOR FOR 
SELECT ActID
FROM tblActivity
WHERE SequenceNo > @SeqNo and ActSTDBatchID = @ActSTDBatchID
ORDER BY SequenceNo


OPEN activity_cursor;

FETCH NEXT FROM activity_cursor 
INTO @ActID1;

WHILE @@FETCH_STATUS = 0
BEGIN

UPDATE tblActivity SET SequenceNo = SequenceNo - 1 WHERE ActID = @ActID1

FETCH NEXT FROM activity_cursor 
    INTO @ActID1;
END
CLOSE activity_cursor;
DEALLOCATE activity_cursor;

IF @@ERROR <> 0
BEGIN
ROLLBACK TRAN
END
ELSE
BEGIN
COMMIT TRAN
END

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPDELETE_ActivityDetails]
(
	@ActivityID int,
	@outParam int out
)
AS
	SET NOCOUNT OFF;
	DELETE FROM tblActivity WHERE (([ActID] = @ActivityID))
	SET @outParam = SCOPE_IDENTITY()
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPDELETE_User]
(
	@Original_UserID numeric
)
AS
	SET NOCOUNT OFF;

DECLARE @count int

SELECT @count=count(*) from tblEmployee where EmpID in (select EmpID from tblUser where UserID=@Original_UserID)

IF @count=0
BEGIN
DELETE FROM [tblUser] WHERE (([UserID] = @Original_UserID))
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_Activity_By_STDBatchID]
(
	@ActSTDBatchID varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT     ActID, ActMainActID, ActSTDBatchID, ActDuration, ActManHours, ActCost, SequenceNo, Part, InstructedBy, LastEdited, BlockNextActivity
FROM         tblActivity
WHERE     (ActSTDBatchID = @ActSTDBatchID)
ORDER BY SequenceNo
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_BasicProduct_DataView_Category]
(
	@Category varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        tblBasicProduct.BasicProductCode + ' - ' + tblBasicProduct.BasicProductDescription AS BasicProduct, tblBasicProduct.BasicProductName, 
                         tblBasicProduct.BasicProductDescription, tblBasicProduct.BasicProductCatID, tblProductCategory.ProductCategory, tblBasicProduct.BasicProductSubCatID, 
                         tblProductSubCategory.ProductSubCategory, tblBasicProduct.BasicProductUnitID, tblUnit.UnitCode, tblBasicProduct.BasicProductFormID, tblForm.Form, 
                         tblBasicProduct.BasicProductFormulaID, tblBasicProduct.BasicProductAvgCost, tblBasicProduct.BasicProductStatus, tblBasicProduct.BasicProductType, 
                         tblBasicProduct.STDBatchSize, tblBasicProduct.BasicProductCode,dbo.Get_ProductManforPack(BasicProductCode,'Pack') AS SectionID,dbo.Get_ProductManforPack(BasicProductCode,'Manf') as DepID
FROM            tblBasicProduct INNER JOIN
                         tblForm ON tblBasicProduct.BasicProductFormID = tblForm.FormID INNER JOIN
                         tblProductCategory ON tblBasicProduct.BasicProductCatID = tblProductCategory.ProductCatID INNER JOIN
                         tblProductSubCategory ON tblBasicProduct.BasicProductSubCatID = tblProductSubCategory.ProductSubCatID INNER JOIN
                         tblUnit ON tblBasicProduct.BasicProductUnitID = tblUnit.UnitID
WHERE        (tblBasicProduct.BasicProductCatID = @Category)
ORDER BY tblBasicProduct.BasicProductCode, tblBasicProduct.BasicProductDescription
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_FinishProduct_ByBasicProduct]
(
@BasicProductCode varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT     FinishProductCode, BasicProductCode, ISNULL(FinishProdutFormulaID, 0) AS FinishProdutFormulaID, ISNULL(FinishProdutPackingTypeID, 0) 
                      AS FinishProdutPackingTypeID, FinishProductCode+' - '+FinishProdutDescription AS FinishProduct, FinishProdutBasicQty, FinishProdutAvgCost, FinishProdutStatus, PrimaryFinishProductCode, 
                      PrimaryFinishProductQty, FinishProductType
FROM         tblFinishProduct
WHERE BasicProductCode=@BasicProductCode AND FinishProdutStatus=1
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_Batch_LabourCost]
(
	@BatchID varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        tblBatchLaourDetails.EmployeeID, CONVERT(numeric(18,2),SUM(dbo.GetTime(tblBatchLaourDetails.WorkStart, tblBatchLaourDetails.WorkStop)/60)) AS LaborHours, CONVERT(numeric(18,2),AVG(tblBatchLaourDetails.HourlyRate)) AS HourlyRate, 
                         AVG(tblBatchLaourDetails.OTRate) AS OTRate, tblEmployee.EmpName AS Employee,SUM(dbo.EmployeeCost(tblBatchLaourDetails.WorkStart, tblBatchLaourDetails.WorkStop,tblBatchLaourDetails.OTHours,tblBatchLaourDetails.OTRate,tblBatchLaourDetails.HourlyRate)) AS LaborCost
FROM            tblBatch INNER JOIN
                         tblBatchActivity ON tblBatch.BatchID = tblBatchActivity.BatchID INNER JOIN
                         tblBatchLaourDetails ON tblBatchActivity.BatchActID = tblBatchLaourDetails.BatchActID INNER JOIN
                         tblEmployee ON tblBatchLaourDetails.EmployeeID = tblEmployee.EmpID
WHERE        (tblBatch.BatchID = @BatchID) AND (tblBatchActivity.ActType='Manufacturing')
GROUP BY tblBatchLaourDetails.EmployeeID, tblEmployee.EmpName
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_Batch_PreviousCost]
(
	@BatchID varchar(50)
)
AS
	SET NOCOUNT ON;

 DECLARE @ProductCode varchar(50)
  DECLARE @BatchType varchar(50)

 SELECT @BatchType=BatchType from tblBatch where BatchID=@BatchID

 IF @BatchType='Basic'
 BEGIN
 select @ProductCode=STDBasicProductCode from tblSTDBatch where STDBatchID in( Select BatchSTDBatchID from tblBatch where  BatchID=@BatchID)
 END
 ELSE
 BEGIN
  Select @ProductCode=SUBSTRING(BatchID,1,5) from tblBatch where  BatchID=@BatchID
 END

 
SELECT       tblBatchCost.BatchID AS ManufacturingBatchID, tblBatchCost.TotalCost, tblBatchCost.UnitCost, tblBatch.BatchFinalQty AS OutPut, CONVERT(numeric(18,2),(tblBatch.BatchFinalQty/dbo.GetInput(@BatchID))*100) AS Yield
FROM            tblBatchCost INNER JOIN
                         tblBatch ON tblBatchCost.BatchID = tblBatch.BatchID
WHERE        (tblBatchCost.BatchID IN
                             (SELECT        TOP (3) BatchID
                               FROM            tblBatch AS tblBatch_1
                               WHERE        (BatchSTDBatchID IN
                                                             (SELECT        STDBatchID
                                                               FROM            tblSTDBatch
                                                               WHERE        (STDBasicProductCode = @ProductCode))) AND (BatchID <> @BatchID)
                               ORDER BY BatchEndDate DESC))
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_BatchMRPacking_By_Batch]
(
	@BatchID varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        tblBatchPackingMR.MaterialCode AS Item, SUM(ISNULL(tblBatchPackingMR.BatchUsed, 0)) AS MRIssuedQty, View_Material.UnitCode AS Unit, 
                         tblBatchPackingMR.MRNO ,SUM(ISNULL(tblBatchPackingMR.BatchDamaged,0)) AS RejectedQty
FROM            tblBatchPackingMR INNER JOIN
                         View_Material ON tblBatchPackingMR.MaterialCode = View_Material.MaterialCode
WHERE        (tblBatchPackingMR.BatchNO = @BatchID) AND (tblBatchPackingMR.State = 1)
GROUP BY tblBatchPackingMR.BatchNO, tblBatchPackingMR.MaterialCode, View_Material.UnitCode, tblBatchPackingMR.MRNO,tblBatchPackingMR.BatchDamaged
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_BatchPacking_MachineCost]
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

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_BatchPackingMR]
(
@BasicProductCode varchar(50),
@MaterialCode varchar(50)
)

AS
	SET NOCOUNT OFF;




BEGIN


SELECT        tblBatchPackingMR.ID,ISNULL(tblBatchPackingMR.BatchNO, 'No') AS BatchNO, tblBatchPackingMR.MRNO, tblBatchPackingMR.BatchUsed, 
                         tblBatchPackingMR.BatchDamaged, tblBatchPackingMR.BatchReturned,tblBatchPackingMR.MRNO AS MRNO, tblBatchPackingMR.State, 
                         tblMRMaterial.MRIssuedQty
FROM            dbo.tblBatchPackingMR INNER JOIN
                         dbo.tblMR ON dbo.tblBatchPackingMR.MRNO = dbo.tblMR.MRNO INNER JOIN
                         dbo.tblMRMaterial ON dbo.tblBatchPackingMR.MRNO = dbo.tblMRMaterial.MRNO AND 
                         dbo.tblBatchPackingMR.MaterialCode = dbo.tblMRMaterial.MRMaterialCode INNER JOIN
                         dbo.tblSection ON dbo.tblMR.MRSectionID = dbo.tblSection.SectionID
WHERE        (dbo.tblBatchPackingMR.State = 0)AND tblBatchPackingMR.MRNO in (select MRNO from tblBatchPackingMR where BatchNO in (select BatchID from View_Batch where STDBasicProductCode=@BasicProductCode))
AND MaterialCode=@MaterialCode AND tblBatchPackingMR.StartQty>0


END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_CustomersBySalesMethod]
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

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_FinishProduct]
AS
	SET NOCOUNT ON;
SELECT     FinishProductCode, BasicProductCode, ISNULL(FinishProdutFormulaID, 0) AS FinishProdutFormulaID, ISNULL(FinishProdutPackingTypeID, 0) 
                      AS FinishProdutPackingTypeID, FinishProdutDescription, FinishProdutBasicQty, FinishProdutAvgCost, FinishProdutStatus, PrimaryFinishProductCode, 
                      PrimaryFinishProductQty, FinishProductType
FROM         tblFinishProduct
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_FinishProduct_By_BasicProduct_and_Type]
(
	@Status int,
	@BasicProductCode varchar(50),
	@ProductType varchar(50)

)
AS
BEGIN
	SET NOCOUNT ON;

SELECT        tblFinishProduct.FinishProductCode, tblFinishProduct.FinishProductCode + ' - ' + tblFinishProduct.FinishProdutDescription AS FinishProduct, 
                         tblFinishProduct.BasicProductCode, tblFinishProduct.FinishProdutFormulaID, tblFinishProduct.FinishProdutPackingTypeID, tblPckingType.PackingTitle, 
                         tblPckingType.PackingQty, tblPckingType.PackingTitle + ' - ' + CAST(tblPckingType.PackingQty AS VARCHAR(50)) AS Packing, 
                         tblFinishProduct.FinishProdutDescription, tblFinishProduct.FinishProdutBasicQty, tblFinishProduct.FinishProdutAvgCost, tblFinishProduct.FinishProdutStatus, 
                         tblBasicProduct.BasicProductDescription, tblFinishProduct.PrimaryFinishProductCode, tblFinishProduct.PrimaryFinishProductQty, 
                         tblFinishProduct.FinishProductType
FROM            tblFinishProduct INNER JOIN
                         tblBasicProduct ON tblFinishProduct.BasicProductCode = tblBasicProduct.BasicProductCode INNER JOIN
                         tblPckingType ON tblFinishProduct.FinishProdutPackingTypeID = tblPckingType.PackingID
WHERE        (tblFinishProduct.FinishProdutStatus = @Status) AND (tblBasicProduct.BasicProductCode = @BasicProductCode) AND 
                         (tblFinishProduct.FinishProductType = @ProductType)
ORDER BY tblFinishProduct.FinishProductCode
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_FinishProduct_ByCategory]
(
	@Status bit,
	@ProductCategory varchar(50)

)
AS
BEGIN
	SET NOCOUNT ON;


SELECT        tblFinishProduct.FinishProductCode + ' - ' + tblFinishProduct.FinishProdutDescription AS FinishProduct, tblFinishProduct.FinishProductCode, 
                         tblFinishProduct.BasicProductCode, tblFinishProduct.FinishProdutFormulaID, tblFinishProduct.FinishProdutPackingTypeID, tblPckingType.PackingTitle, 
                         tblPckingType.PackingQty, tblPckingType.PackingTitle + ' - ' + CAST(tblPckingType.PackingQty AS VARCHAR(50)) AS Packing, 
                         tblFinishProduct.FinishProdutDescription, tblFinishProduct.FinishProdutBasicQty, tblFinishProduct.FinishProdutAvgCost, tblFinishProduct.FinishProdutStatus, 
                         tblBasicProduct.BasicProductDescription, tblFinishProduct.PrimaryFinishProductCode, tblFinishProduct.PrimaryFinishProductQty, 
                         tblFinishProduct.FinishProductType
FROM            tblFinishProduct INNER JOIN
                         tblBasicProduct ON tblFinishProduct.BasicProductCode = tblBasicProduct.BasicProductCode INNER JOIN
                         tblPckingType ON tblFinishProduct.FinishProdutPackingTypeID = tblPckingType.PackingID
WHERE        (tblBasicProduct.BasicProductCatID = @ProductCategory) AND (tblFinishProduct.FinishProdutStatus = @Status)
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_FinishProduct_DataView]
(
	@Type varchar(50),
	@BasicProdcut varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON;


BEGIN
SELECT        tblFinishProduct.FinishProductCode + ' - ' + tblFinishProduct.FinishProdutDescription AS FinishProduct, tblFinishProduct.FinishProductCode, 
                         tblFinishProduct.BasicProductCode, tblFinishProduct.FinishProdutFormulaID, tblFinishProduct.FinishProdutPackingTypeID, 
                         tblFinishProduct.FinishProdutDescription, tblFinishProduct.FinishProdutBasicQty, tblFinishProduct.FinishProdutAvgCost, tblFinishProduct.FinishProdutStatus, 
                         tblBasicProduct.BasicProductDescription, tblFinishProduct.PrimaryFinishProductCode, tblFinishProduct.PrimaryFinishProductQty, 
                         tblFinishProduct.FinishProductType, tblPckingType.PackingTitle AS Packing
FROM            tblFinishProduct INNER JOIN
                         tblBasicProduct ON tblFinishProduct.BasicProductCode = tblBasicProduct.BasicProductCode INNER JOIN
                         tblPckingType ON tblFinishProduct.FinishProdutPackingTypeID = tblPckingType.PackingID
WHERE        (tblFinishProduct.FinishProductType = @Type) AND (tblFinishProduct.BasicProductCode = @BasicProdcut)


END
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_FinishProduct_DataView_By_CAPNO]
(
	@CAPNO varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON;

SELECT        tblFinishProduct.FinishProductCode, tblFinishProduct.FinishProductCode + ' - ' + tblFinishProduct.FinishProdutDescription AS FinishProduct, 
                         tblFinishProduct.BasicProductCode, tblFinishProduct.FinishProdutFormulaID, tblFinishProduct.FinishProdutPackingTypeID, tblPckingType.PackingTitle, 
                         tblPckingType.PackingQty, tblPckingType.PackingTitle + ' - ' + CAST(tblPckingType.PackingQty AS VARCHAR(50)) AS Packing, 
                         tblFinishProduct.FinishProdutDescription, tblFinishProduct.FinishProdutBasicQty, tblFinishProduct.FinishProdutAvgCost, tblFinishProduct.FinishProdutStatus, 
                         tblBasicProduct.BasicProductDescription, tblFinishProduct.PrimaryFinishProductCode, tblFinishProduct.PrimaryFinishProductQty, 
                         tblFinishProduct.FinishProductType
FROM            tblFinishProduct INNER JOIN
                         tblBasicProduct ON tblFinishProduct.BasicProductCode = tblBasicProduct.BasicProductCode INNER JOIN
                         tblPckingType ON tblFinishProduct.FinishProdutPackingTypeID = tblPckingType.PackingID
ORDER BY tblFinishProduct.FinishProductCode
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_FinishProduct_DataView_By_ReworkBatch_ProductList]
(
	@ReworkBatchID varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON;

SELECT        tblFinishProduct.FinishProductCode, tblFinishProduct.FinishProductCode + ' - ' + tblFinishProduct.FinishProdutDescription AS FinishProduct, 
                         tblFinishProduct.BasicProductCode, tblFinishProduct.FinishProdutFormulaID, tblFinishProduct.FinishProdutPackingTypeID, tblPckingType.PackingTitle, 
                         tblPckingType.PackingQty, tblPckingType.PackingTitle + ' - ' + CAST(tblPckingType.PackingQty AS VARCHAR(50)) AS Packing, 
                         tblFinishProduct.FinishProdutDescription, tblFinishProduct.FinishProdutBasicQty, tblFinishProduct.FinishProdutAvgCost, tblFinishProduct.FinishProdutStatus, 
                         tblBasicProduct.BasicProductDescription, tblFinishProduct.PrimaryFinishProductCode, tblFinishProduct.PrimaryFinishProductQty, 
                         tblFinishProduct.FinishProductType
FROM            tblFinishProduct INNER JOIN
                         tblBasicProduct ON tblFinishProduct.BasicProductCode = tblBasicProduct.BasicProductCode INNER JOIN
                         tblPckingType ON tblFinishProduct.FinishProdutPackingTypeID = tblPckingType.PackingID
ORDER BY tblFinishProduct.FinishProductCode

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_FinishProduct_DataView_By_Type]
(
	@Status int,
	@FinishProductType varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON;

SELECT        tblFinishProduct.FinishProductCode, tblFinishProduct.FinishProductCode + ' - ' + tblFinishProduct.FinishProdutDescription AS FinishProduct, 
                         tblFinishProduct.BasicProductCode, tblFinishProduct.FinishProdutFormulaID, tblFinishProduct.FinishProdutPackingTypeID, tblPckingType.PackingTitle, 
                         tblPckingType.PackingQty, tblPckingType.PackingTitle + ' - ' + CAST(tblPckingType.PackingQty AS VARCHAR(50)) AS Packing, 
                         tblFinishProduct.FinishProdutDescription, tblFinishProduct.FinishProdutBasicQty, tblFinishProduct.FinishProdutAvgCost, tblFinishProduct.FinishProdutStatus, 
                         tblBasicProduct.BasicProductDescription, tblFinishProduct.PrimaryFinishProductCode, tblFinishProduct.PrimaryFinishProductQty, 
                         tblFinishProduct.FinishProductType
FROM            tblFinishProduct INNER JOIN
                         tblBasicProduct ON tblFinishProduct.BasicProductCode = tblBasicProduct.BasicProductCode INNER JOIN
                         tblPckingType ON tblFinishProduct.FinishProdutPackingTypeID = tblPckingType.PackingID
WHERE        (tblFinishProduct.FinishProdutStatus = @Status) AND (tblFinishProduct.FinishProductType = @FinishProductType)
ORDER BY tblFinishProduct.FinishProductCode
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_FinishProduct_DataView_Search]
(

	@Status bit
)
AS
BEGIN
	SET NOCOUNT ON;


BEGIN
SELECT        tblFinishProduct.FinishProductCode, tblFinishProduct.FinishProductCode + ' - ' + tblFinishProduct.FinishProdutDescription AS FinishProduct, 
                         tblFinishProduct.BasicProductCode, tblFinishProduct.FinishProdutFormulaID, tblFinishProduct.FinishProdutPackingTypeID, tblPckingType.PackingTitle, 
                         tblPckingType.PackingQty, tblPckingType.PackingTitle + ' - ' + CAST(tblPckingType.PackingQty AS VARCHAR(50)) AS Packing, 
                         tblFinishProduct.FinishProdutDescription, tblFinishProduct.FinishProdutBasicQty, tblFinishProduct.FinishProdutAvgCost, tblFinishProduct.FinishProdutStatus, 
                         tblBasicProduct.BasicProductDescription, tblFinishProduct.PrimaryFinishProductCode, tblFinishProduct.PrimaryFinishProductQty, 
                         tblFinishProduct.FinishProductType
FROM            tblFinishProduct INNER JOIN
                         tblBasicProduct ON tblFinishProduct.BasicProductCode = tblBasicProduct.BasicProductCode INNER JOIN
                         tblPckingType ON tblFinishProduct.FinishProdutPackingTypeID = tblPckingType.PackingID
WHERE        (tblFinishProduct.FinishProdutStatus = @Status)
ORDER BY tblFinishProduct.FinishProductCode
END

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_FinishProduct_DataView_Status]
(
	@Status int
)
AS
BEGIN
	SET NOCOUNT ON;
SELECT        tblFinishProduct.FinishProductCode, tblFinishProduct.FinishProductCode + ' - ' + tblFinishProduct.FinishProdutDescription AS FinishProduct, 
                         tblFinishProduct.BasicProductCode, tblFinishProduct.FinishProdutFormulaID, tblFinishProduct.FinishProdutPackingTypeID, tblPckingType.PackingTitle, 
                         tblPckingType.PackingQty, tblPckingType.PackingTitle + ' - ' + CAST(tblPckingType.PackingQty AS VARCHAR(50)) AS Packing, 
                         tblFinishProduct.FinishProdutDescription, tblFinishProduct.FinishProdutBasicQty, tblFinishProduct.FinishProdutAvgCost, tblFinishProduct.FinishProdutStatus, 
                         tblBasicProduct.BasicProductDescription, tblFinishProduct.PrimaryFinishProductCode, tblFinishProduct.PrimaryFinishProductQty, 
                         tblFinishProduct.FinishProductType
FROM            tblFinishProduct INNER JOIN
                         tblBasicProduct ON tblFinishProduct.BasicProductCode = tblBasicProduct.BasicProductCode INNER JOIN
                         tblPckingType ON tblFinishProduct.FinishProdutPackingTypeID = tblPckingType.PackingID
WHERE        (tblFinishProduct.FinishProdutStatus = @Status)
ORDER BY tblFinishProduct.FinishProductCode
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_FinishProduct_DataView_Stock_RPT]
(

	@DepID numeric(18,0),
	@SubCategoryID varchar(50)
)

AS
BEGIN
	SET NOCOUNT ON;

SELECT        tblFinishProduct.FinishProductCode, tblFinishProduct.FinishProductCode + ' - ' + tblFinishProduct.FinishProdutDescription AS FinishProduct, 
                         tblFinishProduct.BasicProductCode, tblFinishProduct.FinishProdutFormulaID, tblFinishProduct.FinishProdutPackingTypeID, tblPckingType.PackingTitle, 
                         tblPckingType.PackingQty, tblPckingType.PackingTitle + ' - ' + CAST(tblPckingType.PackingQty AS VARCHAR(50)) AS Packing, 
                         tblFinishProduct.FinishProdutDescription, tblFinishProduct.FinishProdutBasicQty, tblFinishProduct.FinishProdutAvgCost, tblFinishProduct.FinishProdutStatus, 
                         tblUnit.UnitID, tblUnit.UnitName, tblUnit.UnitCode, View_BasicProduct.BasicProductName, View_BasicProduct.BasicProductDescription, 
                         View_BasicProduct.BasicProductType, View_BasicProduct.ProductCategory, View_BasicProduct.ProductSubCategory, View_BasicProduct.Form, 
                         ISNULL(tblStock.StockQty, 0) AS StockQty, ISNULL(tblStock.StockMinimumQty, 0) AS StockMinimumQty, tblStore.StoreID, tblStore.StoreDepID, 
                         tblStore.StoreName, View_BasicProduct.BasicProductSubCatID, tblDepartment.DepName
FROM            tblFinishProduct INNER JOIN
                         tblPckingType ON tblFinishProduct.FinishProdutPackingTypeID = tblPckingType.PackingID INNER JOIN
                         View_BasicProduct ON tblFinishProduct.BasicProductCode = View_BasicProduct.BasicProductCode INNER JOIN
                         tblUnit ON tblPckingType.PackingUnitID = tblUnit.UnitID INNER JOIN
                         tblStock ON tblFinishProduct.FinishProductCode = tblStock.StockFinishProduct LEFT OUTER JOIN
                         tblStore LEFT OUTER JOIN
                         tblDepartment ON tblStore.StoreDepID = tblDepartment.DepID ON tblStock.StoreID = tblStore.StoreID
WHERE        (@DepID = 0) AND (@SubCategoryID = 'ALL') OR
                         (@DepID = 0) AND (View_BasicProduct.BasicProductSubCatID = @SubCategoryID) OR
                         (@SubCategoryID = 'ALL') AND (tblStore.StoreDepID = @DepID) OR
                         (View_BasicProduct.BasicProductSubCatID = @SubCategoryID) AND (tblStore.StoreDepID = @DepID)
ORDER BY tblFinishProduct.FinishProductCode

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_FinishProduct_SecondaryProductList]
(

	@FinishProduct varchar(50)

)
AS
BEGIN

SET NOCOUNT ON;


SELECT        tblFinishProduct.PrimaryFinishProductCode, tblFinishProduct.FinishProductCode, tblFinishProduct.FinishProdutFormulaID, 
                         tblFinishProduct.FinishProdutPackingTypeID, 
                         tblFinishProduct.FinishProdutDescription + ' - ' + tblFinishProduct.FinishProductCode AS FinishProdutDescription, tblFinishProduct.FinishProdutBasicQty, 
                         tblFinishProduct.FinishProdutAvgCost, tblFinishProduct.FinishProdutStatus, tblFinishProduct.PrimaryFinishProductQty, tblFinishProduct.FinishProductType, 
                          tblFinishProduct.BasicProductCode, tblPckingType.PackingTitle AS Packing
FROM            tblFinishProduct INNER JOIN
                         tblPckingType ON tblFinishProduct.FinishProdutPackingTypeID = tblPckingType.PackingID
WHERE        (tblFinishProduct.PrimaryFinishProductCode = @FinishProduct) AND (tblFinishProduct.FinishProdutStatus = 'True') AND 
                         (tblFinishProduct.FinishProductType = 'Secondary')

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_FinishProductByID]
(
	@FinishProductCode varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT     FinishProductCode, BasicProductCode, ISNULL(FinishProdutFormulaID, 0) AS FinishProdutFormulaID, ISNULL(FinishProdutPackingTypeID, 0) 
                      AS FinishProdutPackingTypeID, FinishProdutDescription, FinishProdutBasicQty, FinishProdutAvgCost, FinishProdutStatus, PrimaryFinishProductCode, 
                      PrimaryFinishProductQty, FinishProductType
FROM         tblFinishProduct
WHERE     (FinishProductCode = @FinishProductCode)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_GRN_Manage]
(
	@Status int,
	@DateFrom datetime,
	@DateTo datetime,
	@DepID numeric(18,0)
)
AS
	SET NOCOUNT ON;
SELECT        tblGRN.GRNNO, ISNULL(CAST(tblGRN.GRNMTNNO AS VARCHAR(50)), '') + ISNULL(CAST(tblGRN.GRNMRNO AS VARCHAR(50)), '') + ISNULL(CAST(tblGRN.GRNRPDBatchID AS VARCHAR(50)), '') AS Doc, 
                         tblGRN.GRNDate, tblGRN.GRNApproveDate, tblGRN.GRNEnterdBy, tblGRN.GRNStoreID, tblGRN.GRNType, tblGRN.GRNStatus, tblEmployee.EmpName AS EnterdByName, tblGRN.GRNCategory, tblGRN.GRNPrint, 
                         tblGRN.GRNBulkPrint, View_Employee.Employee as GRNApproveByName
FROM            tblGRN INNER JOIN
                         tblEmployee ON tblGRN.GRNEnterdBy = tblEmployee.EmpID INNER JOIN
                         tblStore ON tblGRN.GRNStoreID = tblStore.StoreID INNER JOIN
                         View_Employee ON tblGRN.GRNApprovedBy = View_Employee.EmpID
WHERE     (tblGRN.GRNStatus = @Status) AND (tblStore.StoreDepID = @DepID) AND (tblGRN.GRNDate >= @DateFrom) AND (tblGRN.GRNDate <= @DateTo)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_MR_ByStoreNoStatus]
(
	@StoreID varchar(50),
	@Status int
)
AS
	SET NOCOUNT ON;
SELECT        tblMR.MRNO, tblMR.MRStore, tblStore.StoreName, tblMR.MRDate, tblEmployee.EmpName AS ApproveBy, tblMR.MRApproveDate, tblEmployee_1.EmpName AS EnterdBy, tblDepartment.DepName, 
                         tblMR.MRRemarks, tblMR.MRStatus, tblMR.MRSectionID, tblMR.MRPrint, tblMR.MRBulkPrint, tblMR.OriginType,tblBatchMR.BatchID
FROM            tblMR INNER JOIN
                         tblDepartment ON tblMR.MRFromDepID = tblDepartment.DepID INNER JOIN
                         tblStore ON tblMR.MRStore = tblStore.StoreID INNER JOIN
                         tblEmployee ON tblMR.MRApprovedBy = tblEmployee.EmpID INNER JOIN
                         tblEmployee AS tblEmployee_1 ON tblMR.MREnterdBy = tblEmployee_1.EmpID LEFT JOIN
                         tblBatchMR ON tblMR.MRNO = tblBatchMR.MRNO
WHERE     (tblMR.MRStore = @StoreID) AND (tblMR.MRStatus = @Status)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_MR_DataView_Manage]
(
	@ToDate Datetime,
	@FromDate Datetime,
	@MRStatus int,
	@DepID numeric(18,0)
)
AS
	SET NOCOUNT ON;
SELECT     MRNO, MRStore, MRDate, MRApprovedBy, MRApproveDate, MREnterdBy, MRFromDepID, MRIssuedBy, MRIssuedDate, MRReceivedBy, MRReceivedDate, 
                      MRRemarks, MRStatus, MRType, EnterdBy, ApprovedBy, IssuedBy, ReceivedBy, StoreName, DepName, MRSectionID, MRPrint, MRBulkPrint,OriginType,MRDescription
FROM         View_MR
GROUP BY MRNO, MRStore, MRDate, MRApprovedBy, MRApproveDate, MREnterdBy, MRFromDepID, MRIssuedBy, MRIssuedDate, MRReceivedBy, MRReceivedDate, 
                      MRRemarks, MRStatus, MRType, EnterdBy, ApprovedBy, IssuedBy, ReceivedBy, StoreName, DepName, MRSectionID, MRPrint, MRBulkPrint,OriginType,MRDescription
HAVING      (MRDate <= @ToDate) AND (MRDate >= @FromDate) AND (MRStatus = @MRStatus) AND (MRFromDepID = @DepID)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_MRMaterial_BulkPrint_Dataview]
(
	@StoreID varchar(50),
	@MRStatus_Issued int,
	@MRStatus_Received int,
	@MRStatus_ReceviedGRN int,
	@MRStatus_ReceviedSubStock int

)
AS
	SET NOCOUNT ON;

SELECT    MRNO,BatchID, Item,IssuedQty,Unit,IssuedBy,IssuedDate,StoreName, DepName ,MRDescription from (

SELECT     View_MRMaterial.MRNO,dbo.GetBatchNo_of_MR(View_MRMaterial.MRNO) as BatchID,View_MRMaterial.MaterialDescription+'-'+View_MRMaterial.MaterialCode AS Item, 
                      dbo.RemoveZero(View_MRMaterial.MRIssuedQty) AS IssuedQty,View_MRMaterial.UnitCode AS Unit,View_MR.MRIssuedBy AS IssuedBy, 
                      convert(varchar,View_MR.MRIssuedDate,111) AS IssuedDate,View_MR.StoreName, View_MR.DepName, View_MR.MRDescription
FROM         View_MRMaterial INNER JOIN
                      View_MR ON View_MRMaterial.MRNO = View_MR.MRNO
WHERE     (View_MR.MRStore = @StoreID) AND (View_MR.MRBulkPrint = 0) AND ((View_MR.MRStatus=@MRStatus_Issued) OR (View_MR.MRStatus=@MRStatus_Received) OR (View_MR.MRStatus=@MRStatus_ReceviedGRN)OR (View_MR.MRStatus=@MRStatus_ReceviedSubStock))

UNION

SELECT     View_MRBasicProducts.MRNO,dbo.GetBatchNo_of_MR(View_MRBasicProducts.MRNO) as BatchID, View_MRBasicProducts.BasicProductDescription+'-'+View_MRBasicProducts.MRBasicProductID AS Item, 
                      dbo.RemoveZero(View_MRBasicProducts.MRIssuedQty) AS IssuedQty,View_MRBasicProducts.UnitCode AS Unit,View_MR.MRIssuedBy AS IssuedBy, 
                      convert(varchar,View_MR.MRIssuedDate,111) AS IssuedDate, View_MR.StoreName, View_MR.DepName ,View_MR.MRDescription
FROM         View_MRBasicProducts INNER JOIN
                      View_MR ON View_MRBasicProducts.MRNO = View_MR.MRNO
WHERE     (View_MR.MRStore = @StoreID) AND (View_MR.MRBulkPrint = 0) AND ((View_MR.MRStatus=@MRStatus_Issued) OR (View_MR.MRStatus=@MRStatus_Received) OR (View_MR.MRStatus=@MRStatus_ReceviedGRN)OR (View_MR.MRStatus=@MRStatus_ReceviedSubStock))
) as results
ORDER BY IssuedDate
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_MTN_ByFromDep_Status]
(
	@UserID numeric(18, 0),
	@Status int
)
AS
	SET NOCOUNT ON;
SELECT        View_MTN.MTNNO, View_MTN.MTNBatchID, View_MTN.MTNDate, View_MTN.MTNApprovedBy, View_MTN.MTNApprovedByName, View_MTN.MTNApproveDate, 
                         View_MTN.MTNEnterdBy, View_MTN.MTNEnterdByName, View_MTN.MTNFromDepID, View_MTN.FromDepName, View_MTN.MTNToDepID, View_MTN.DepNameTo, 
                         View_MTN.MTNReceivedBy, View_MTN.MTNReceivedByName, View_MTN.MTNReceivedDate, View_MTN.MTNStatus, View_MTN.MTNType, 
                         View_MTN.MTNItemType, View_MTN.MTNStore, View_MTN.StoreName, View_MTN.MTNPRPDBatchID, View_MTN.MTNPackingBatch, [dbo].[Get_MTN_BatchNo](View_MTN.MTNNO) AS BatchID 
FROM            View_MTN LEFT OUTER JOIN
                         tblBatchActivity ON View_MTN.MTNPackingBatch = tblBatchActivity.BatchActID
WHERE        (View_MTN.MTNStatus = @Status) 

/*
AND (View_MTN.MTNFromDepID IN
                             (SELECT        Department
                               FROM            tblUserDepartments
                               WHERE        (UserID = @UserID)))
*/
ORDER BY View_MTN.MTNNO
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_MTN_Dataview_Manage]
(
	@FromDate datetime,
	@ToDate datetime,
	@DepID numeric(18, 0),
	@MTNStatus int
)
AS
	SET NOCOUNT ON;
SELECT        MTNNO, MTNBatchID, MTNDate, MTNApprovedBy, MTNApprovedByName, MTNApproveDate, MTNEnterdBy, MTNEnterdByName, MTNFromDepID, FromDepName, MTNToDepID, DepNameTo, MTNReceivedBy, 
                         MTNReceivedByName, MTNReceivedDate, MTNStatus, MTNType, MTNItemType, MTNStore, StoreName, GRNNO, GRNDate, GRNEnterdBy, GRNEnterdByName, GRNApproveDate, GRNApprovedBy, 
                         GRNApprovedByName
FROM            View_MTN
WHERE     (MTNFromDepID = @DepID) AND (MTNStatus = @MTNStatus) AND (MTNDate >= @FromDate) AND (MTNDate <= @ToDate)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_PackingTypeByID]
(
	@PackingType numeric
)
AS
	SET NOCOUNT ON;
SELECT     PackingID, PackingTitle, Type, PackingUnitID, PackingQty
FROM         tblPckingType
WHERE     (PackingID = @PackingType)
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_PackingTypeDataView]
AS
	SET NOCOUNT ON;
SELECT        tblPckingType.PackingID, tblPckingType.PackingTitle, tblPckingType.PackingUnitID, tblUnit.UnitName,
                         tblUnit.UnitCode, tblPckingType.PackingQty, tblPckingType.Type
FROM            tblPckingType INNER JOIN
                         tblUnit ON tblPckingType.PackingUnitID = tblUnit.UnitID
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_QCReport_Status_Type]
(
	@Status int,
	@ReportType varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT     TOP 50   QCReportID, ReportType, RPDBatchID, PRPDBatchID, ProductionBatchID,PackingBatchID, FinishDate, AnalyzedBy, AnalyzedByName, RDQAOfficer, RDQAOfficerName,
                         TestBy, TestByName, SendBy, SendByName, SendDate, SampleSize, Remarks, Status, SpecificGravity

FROM            View_QCReport
WHERE        (Status = @Status) AND (ReportType = @ReportType)
ORDER BY QCReportID
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_SalesForecast_By_Status]
(
	@State int
)
AS
	SET NOCOUNT ON;
SELECT        tblSalesForecast.ID, tblSalesForecast.Year, tblSalesForecast.Month, tblSalesForecast.WeekID, tblSalesForecast.State, tblSalesForecast.Accuracy, tblSalesForecast.RevisionNo, tblSalesForecast.EnteredDate, tblEmployee.EmpName as EnteredBy
FROM            tblSalesForecast INNER JOIN
                         tblEmployee ON tblSalesForecast.EnteredBy = tblEmployee.EmpID
where State=@State
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_SalesForecastContent]
(
	@SalesForecastID varchar(50)

)
AS

SELECT   tblSalesForecastDetails.ProductCode, tblFinishProduct.FinishProdutDescription, tblSalesForecastDetails.Qty
FROM     tblSalesForecastDetails INNER JOIN tblFinishProduct ON tblSalesForecastDetails.ProductCode = tblFinishProduct.FinishProductCode
WHERE	 SalesForecastID=@SalesForecastID
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_Stock_ByStore]
(
	@StoreID varchar(50)
)
AS
	SET NOCOUNT ON;

SELECT     S.StockID, S.StoreID, ISNULL(S.StockMaterialID, 'N/A') AS ItemCode, M.MaterialDescription AS Item, dbo.Round_Stock(StockQty) as StockQty, 
                      dbo.Round_Stock(S.StockReorderLevel) AS StockReorderLevel, dbo.Round_Stock(S.StockMinimumQty) AS StockMinimumQty, dbo.Round_Stock(S.StockMaximumQty) 
                      AS StockMaximumQty, dbo.Round_Stock(S.StockEconomicalQty) AS StockEconomicalQty, dbo.Round_Stock(S.StockReservedQty) AS StockReservedQty, S.StockStatus, 
                      S.StockType, S.StockUnitPrice, 'Material' AS StockTypeName, tblUnit.UnitCode ,ISNULL(S.StockMaterialID, 'N/A')+' - ' + M.MaterialDescription  as MaterialIDName
FROM         tblStock AS S INNER JOIN
                      tblMaterial AS M ON S.StockMaterialID = M.MaterialCode INNER JOIN
                      tblUnit ON M.UnitID = tblUnit.UnitID
WHERE     (S.StoreID = @StoreID)
UNION
SELECT     S.StockID, S.StoreID, ISNULL(S.StockBasicProduct, 'N/A') AS ItemCode, B.BasicProductDescription AS Item, dbo.Round_Stock(S.StockQty) AS StockQty, 
                      dbo.Round_Stock(S.StockReorderLevel) AS StockReorderLevel, dbo.Round_Stock(S.StockMinimumQty) AS StockMinimumQty, dbo.Round_Stock(S.StockMaximumQty) 
                      AS StockMaximumQty, dbo.Round_Stock(S.StockEconomicalQty) AS StockEconomicalQty, dbo.Round_Stock(S.StockReservedQty) AS StockReservedQty, S.StockStatus, 
                      S.StockType, S.StockUnitPrice, 'Basic Product' AS StockTypeName, tblUnit.UnitCode ,ISNULL(S.StockBasicProduct, 'N/A')+' - ' + B.BasicProductDescription as MaterialIDName
FROM         tblStock AS S INNER JOIN
                      tblBasicProduct AS B ON S.StockBasicProduct = B.BasicProductCode INNER JOIN
                      tblUnit ON B.BasicProductUnitID = tblUnit.UnitID
WHERE     (S.StoreID = @StoreID) 
UNION
SELECT     S.StockID, S.StoreID, ISNULL(S.StockFinishProduct, 'N/A') AS ItemCode, B.BasicProductDescription AS Item, dbo.Round_Stock(S.StockQty) AS StockQty, 
                      dbo.Round_Stock(S.StockReorderLevel) AS StockReorderLevel, dbo.Round_Stock(S.StockMinimumQty) AS StockMinimumQty, dbo.Round_Stock(S.StockMaximumQty) 
                      AS StockMaximumQty, dbo.Round_Stock(S.StockEconomicalQty) AS StockEconomicalQty, dbo.Round_Stock(S.StockReservedQty) AS StockReservedQty, S.StockStatus, 
                      S.StockType, S.StockUnitPrice, 'Finish Product' AS StockTypeName, tblPckingType.PackingTitle as UnitCode ,ISNULL(S.StockFinishProduct, 'N/A')+' - ' + B.BasicProductDescription as MaterialIDName
FROM         tblStock AS S INNER JOIN
                      tblFinishProduct AS F INNER JOIN
                      tblBasicProduct AS B ON F.BasicProductCode = B.BasicProductCode AND F.BasicProductCode = B.BasicProductCode ON 
                      S.StockFinishProduct = F.FinishProductCode INNER JOIN
                      tblPckingType ON F.FinishProdutPackingTypeID = tblPckingType.PackingID
WHERE     (S.StoreID = @StoreID) 
ORDER BY ItemCode
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_User_Login]
(
	@UserName varchar(200),
	@Password varchar(200)
)
AS
	SET NOCOUNT ON;

DECLARE @COUNT int

SELECT @COUNT = COUNT(*)
FROM tblUser
WHERE UserName = @UserName AND Password = @Password

IF @COUNT > 0
BEGIN
SELECT        UserID, EmpID, UserName, Password, Question, Answer, Status, UserRoleID, ExpiryDate, Online, LastLoggedIn
FROM            tblUser
WHERE        (UserName = @UserName) AND (Password = @Password) AND (Status = 1)
RETURN 1
END
ELSE
BEGIN
RETURN -1
END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPGET_WIP_PackingFiles_BySectionID]
(
@SectionID int,
@BatchStatus_Packing int
)
AS
	SET NOCOUNT ON;


select BatchID,BatchActID,EndProductCode,StopQty,StartProductCode,StartQty,BatchStatus,ActType from
(
select BatchID,BatchActID,EndProductCode,StopQty,StartProductCode,StartQty,dbo.Get_PackingBatchStatus(BatchActStatus) AS BatchStatus,ActType from tblBatchActivity where ActType='Packing' and (BatchActStatus=0 or BatchActStatus=1 or BatchActStatus=2) and StartProductCode  in (
select ProductCode from tblProductManufacturing where SectionID=@SectionID and Type='Pack')
UNION
select BatchID,BatchActID,EndProductCode,StopQty,StartProductCode,StartQty,dbo.Get_PackingBatchStatus(BatchActStatus) AS BatchStatus,ActType from tblBatchActivity where ActType='Packing_Secondary' and (BatchActStatus=5 or BatchActStatus=6) and StartProductCode  in (
(select FinishProductCode from tblFinishProduct where BasicProductCode in (select ProductCode from tblProductManufacturing where SectionID=@SectionID and Type='Pack')))

)AS Table1 where ActType<>'Manufacturing' AND BatchStatus=@BatchStatus_Packing
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPUPDATE_MR_Received_toSection]
(
	@ReceivedBy varchar(50),
	@Status int,
	@MRNO numeric
)
AS
	SET NOCOUNT OFF;

	DECLARE @SectionID int
	DECLARE @BatchID varchar(50)
BEGIN

BEGIN TRAN

UPDATE    tblMR
SET              MRStatus = @Status, MRReceivedBy = @ReceivedBy, MRReceivedDate = GETDATE()
WHERE     (MRNO = @MRNO)



select @SectionID=ISNULL(MRSectionID,0) from tblMR where MRNO=@MRNO

IF @SectionID<>0
BEGIN

select @BatchID=RPDBatchID from tblRPDBatch where RPDBatchID in(select TOP 1(RPDBatchID) from tblRPDBatch order by RPDBatchInstructedDate desc)

INSERT INTO tblBatchPackingMR (BatchNo,MRNO,MaterialCode,StartQty,BatchUsed,BatchDamaged,BatchReturned,[State],SectionID) 
SELECT @BatchID,MRNO,MRMaterialCode,MRIssuedQty,0,0,0,0,@SectionID from tblMRMaterial where MRNO=@MRNO

END



IF @@ERROR <> 0
BEGIN
	ROLLBACK TRAN
END
ELSE
BEGIN
	COMMIT TRAN
END

END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SPUPDATE_User]
(
	@EmpID varchar(50),
	@UserName varchar(200),
	@Password varchar(200),
	@Question varchar(500),
	@Answer varchar(500),
	@Status bit,
	@UserRoleID numeric(18,0),
	@Original_UserID numeric
)
AS
	SET NOCOUNT OFF;
BEGIN
DECLARE @COUNT int,@UName varchar(50),@COUNT1 int
SELECT @COUNT = COUNT(*)
FROM tblUser
WHERE UserName = @UserName

IF @COUNT > 0
	BEGIN

		SELECT @UName = UserName
		FROM tblUser
		WHERE (([UserID] = @Original_UserID))

			IF @UName = @UserName
				BEGIN
UPDATE    tblUser
SET              EmpID = @EmpID, UserName = @UserName, Password = @Password, Question = @Question, Answer = @Answer, Status = @Status,
                      UserRoleID = @UserRoleID,ExpiryDate=DATEADD(month,6,GETDATE()),LastLoggedIn=GetDate(),Online=1
WHERE     (UserID = @Original_UserID)

				END
			ELSE
					BEGIN
							RETURN -1

					END
	END
ELSE
BEGIN

UPDATE    tblUser
SET              EmpID = @EmpID, UserName = @UserName, Password = @Password, Question = @Question, Answer = @Answer, Status = @Status,
                      UserRoleID = @UserRoleID,ExpiryDate=DATEADD(month,6,GETDATE()),LastLoggedIn=GetDate(),Online=1
WHERE     (UserID = @Original_UserID)
END




END
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblBatchActivityMachineDetails]
 ADD CONSTRAINT [FK_tblBatchActivityMachineDetails_tblMachine] FOREIGN KEY ([MachineID]) 
		REFERENCES [dbo].[tblMachine] ([MachineCode]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblBatchActivityMachineDetails]
 ADD CONSTRAINT [FK_tblBatchActivityMachineDetails_tblBatchActivity] FOREIGN KEY ([BatchID]) 
		REFERENCES [dbo].[tblBatchActivity] ([BatchActID]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblCustomer]
 ADD CONSTRAINT [FK_tblCustomer_tblSalesMethod] FOREIGN KEY ([SalesMethod]) 
		REFERENCES [dbo].[tblSalesMethod] ([SalesMethodID]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblCustomerTerritoryList]
 ADD CONSTRAINT [FK_tblCustomerTerritoryList_tblCustomer] FOREIGN KEY ([CustomerID]) 
		REFERENCES [dbo].[tblCustomer] ([CustomerID]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblDispatchIssueList]
 ADD CONSTRAINT [FK_tblDispatchIssueList_tblDispatchNote] FOREIGN KEY ([DispatchID]) 
		REFERENCES [dbo].[tblDispatchNote] ([DispatchID]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblDispatchIssueList]
 ADD CONSTRAINT [FK_tblDispatchIssueList_tblGRN] FOREIGN KEY ([GRNID]) 
		REFERENCES [dbo].[tblGRN] ([GRNNO]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblProjectMaterials]
 ADD CONSTRAINT [FK_tblProjectMaterials_tblProjects] FOREIGN KEY ([ProjectID]) 
		REFERENCES [dbo].[tblProjects] ([ProjectID]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblProjectMaterials]
 ADD CONSTRAINT [FK_tblProjectMaterials_tblMaterial] FOREIGN KEY ([MaterialCode]) 
		REFERENCES [dbo].[tblMaterial] ([MaterialCode]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblProjectMaterials]
 ADD CONSTRAINT [FK_tblProjectMaterials_tblBasicProduct] FOREIGN KEY ([BasicProductCode]) 
		REFERENCES [dbo].[tblBasicProduct] ([BasicProductCode]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblProjectMaterials]
 ADD CONSTRAINT [FK_tblProjectMaterials_tblFinishProduct] FOREIGN KEY ([FinishProductCode]) 
		REFERENCES [dbo].[tblFinishProduct] ([FinishProductCode]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblProjectMaterials]
 ADD CONSTRAINT [FK_tblProjectMaterials_tblGRN] FOREIGN KEY ([GRNNO]) 
		REFERENCES [dbo].[tblGRN] ([GRNNO]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblProjects]
 ADD CONSTRAINT [FK_tblProjects_tblDepartment] FOREIGN KEY ([DepID]) 
		REFERENCES [dbo].[tblDepartment] ([DepID]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblSalesForecast]
 ADD CONSTRAINT [FK_tblSalesForecast_tblEmployee] FOREIGN KEY ([EnteredBy]) 
		REFERENCES [dbo].[tblEmployee] ([EmpID]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblSalesForecastDetails]
 ADD CONSTRAINT [FK_tblSalesForecastDetails_tblSalesForecast] FOREIGN KEY ([SalesForecastID]) 
		REFERENCES [dbo].[tblSalesForecast] ([ID]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

ALTER TABLE [dbo].[tblUser]
 ADD CONSTRAINT [FK_tblUser_tblEmployee] FOREIGN KEY ([EmpID]) 
		REFERENCES [dbo].[tblEmployee] ([EmpID]) 
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblBasicProduct"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 256
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblFormulaMaterial"
            Begin Extent = 
               Top = 6
               Left = 294
               Bottom = 136
               Right = 498
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_1UnitOf_BasicProduct_To_MaterialOnly'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_1UnitOf_BasicProduct_To_MaterialOnly'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblBasicProduct"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 256
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblFormulaBasicProduct"
            Begin Extent = 
               Top = 6
               Left = 294
               Bottom = 136
               Right = 524
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblBasicProduct_1"
            Begin Extent = 
               Top = 6
               Left = 562
               Bottom = 136
               Right = 780
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_1UnitOf_BasicProduct_To_SemiFinishedOnly'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_1UnitOf_BasicProduct_To_SemiFinishedOnly'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_BasicProduct_MaterialTotal'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_BasicProduct_MaterialTotal'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[31] 4[16] 2[35] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblPlanBatch"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Plan_BasicProduct_MaterialTotal"
            Begin Extent = 
               Top = 6
               Left = 262
               Bottom = 119
               Right = 482
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementFirstWeek'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementFirstWeek'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Plan_MaterialRequirementFirstWeek"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementFirstWeek_PRPD'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementFirstWeek_PRPD'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Plan_MaterialRequirementFirstWeek_PRPD"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementFirstWeek_Store'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementFirstWeek_Store'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblPlanBatch"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Plan_BasicProduct_MaterialTotal"
            Begin Extent = 
               Top = 6
               Left = 262
               Bottom = 119
               Right = 482
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementFourthWeek'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementFourthWeek'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[28] 4[22] 2[25] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Plan_MaterialRequirementFourthWeek"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementFourthWeek_PRPD'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementFourthWeek_PRPD'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Plan_MaterialRequirementFourthWeek_PRPD"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementFourthWeek_Store'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementFourthWeek_Store'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Plan_MaterialRequirementFirstWeek"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Plan_MaterialRequirementSecondWeek"
            Begin Extent = 
               Top = 6
               Left = 296
               Bottom = 136
               Right = 516
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblMaterial"
            Begin Extent = 
               Top = 6
               Left = 554
               Bottom = 136
               Right = 762
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Plan_MaterialsListMonth"
            Begin Extent = 
               Top = 6
               Left = 800
               Bottom = 119
               Right = 1020
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Plan_MaterialRequirementFourthWeek"
            Begin Extent = 
               Top = 6
               Left = 1058
               Bottom = 136
               Right = 1278
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Plan_MaterialRequirementThirdWeek"
            Begin Extent = 
               Top = 120
               Left = 800
               Bottom = 250
               Right = 1020
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefa',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementMonth'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane2',
	@value = N'ults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementMonth'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 2,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementMonth'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Plan_MaterialRequirementMonth"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 200
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementMonth_BasicOnly'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementMonth_BasicOnly'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Plan_MaterialRequirementMonth_IntermediateOnly"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblMaterial"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 438
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblMaterials_1"
            Begin Extent = 
               Top = 6
               Left = 476
               Bottom = 136
               Right = 668
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementMonth_Intermediate_ToBasic'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementMonth_Intermediate_ToBasic'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Plan_MaterialRequirementMonth"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementMonth_IntermediateOnly'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementMonth_IntermediateOnly'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Plan_MaterialsListMonth_PRPD"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblMaterial"
            Begin Extent = 
               Top = 6
               Left = 262
               Bottom = 136
               Right = 470
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Plan_MaterialRequirementMonth_BasicOnly"
            Begin Extent = 
               Top = 6
               Left = 508
               Bottom = 136
               Right = 694
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Plan_MaterialRequirementMonth_Intermediate_ToBasic"
            Begin Extent = 
               Top = 6
               Left = 732
               Bottom = 136
               Right = 918
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementMonth_PRPD'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementMonth_PRPD'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblPlanBatch"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Plan_BasicProduct_MaterialTotal"
            Begin Extent = 
               Top = 6
               Left = 262
               Bottom = 119
               Right = 482
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementSecondWeek'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementSecondWeek'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Plan_MaterialRequirementSecondWeek"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementSecondWeek_PRPD'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementSecondWeek_PRPD'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Plan_MaterialRequirementSecondWeek_PRPD"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementSecondWeek_Store'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementSecondWeek_Store'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblPlanBatch"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Plan_BasicProduct_MaterialTotal"
            Begin Extent = 
               Top = 6
               Left = 262
               Bottom = 119
               Right = 482
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementThirdWeek'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementThirdWeek'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Plan_MaterialRequirementThirdWeek"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementThirdWeek_PRPD'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementThirdWeek_PRPD'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Plan_MaterialRequirementThirdWeek_PRPD"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementThirdWeek_Store'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialRequirementThirdWeek_Store'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialsListMonth'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialsListMonth'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPane1',
	@value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
',
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialsListMonth_PRPD'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

EXECUTE [sp_addextendedproperty]
	@name = N'MS_DiagramPaneCount',
	@value = 1,
	@level0type = 'SCHEMA',
	@level0name = N'dbo',
	@level1type = 'VIEW',
	@level1name = N'Plan_MaterialsListMonth_PRPD'
GO

IF @@ERROR <> 0 BEGIN IF @@TRANCOUNT > 0 ROLLBACK SET NOEXEC ON END
GO

IF @@TRANCOUNT>0 COMMIT TRANSACTION
GO

SET NOEXEC OFF