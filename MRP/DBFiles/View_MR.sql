USE [MRP]
GO

/****** Object:  View [dbo].[View_MR]    Script Date: 5/12/2014 1:15:03 PM ******/
SET ANSI_NULLS ON
GO

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

