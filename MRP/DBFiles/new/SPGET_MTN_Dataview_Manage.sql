USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPGET_MTN_Dataview_Manage]    Script Date: 5/22/2014 10:12:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SPGET_MTN_Dataview_Manage]
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

