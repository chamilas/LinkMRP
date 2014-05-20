USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPGET_MR_DataView_Manage]    Script Date: 5/12/2014 1:33:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SPGET_MR_DataView_Manage]
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

