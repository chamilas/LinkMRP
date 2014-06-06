USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPGET_Packing_PrimaryBatchRemainningQty]    Script Date: 5/20/2014 3:47:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SPGET_Packing_PrimaryBatchRemainningQty]
(
	@BatchActStatus_Finished int,
	@BatchActStatus_Secondary int,
	@PrimaryBatchID numeric(18,0)
)
AS
	SET NOCOUNT ON;
SELECT  dbo.GetRemaining_ToPackSecondary_ByBatchAct(@PrimaryBatchID,@BatchActStatus_Finished,@BatchActStatus_Secondary) AS RemainningQty

GO

