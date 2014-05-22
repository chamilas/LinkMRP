USE [MRP]
GO

/****** Object:  View [dbo].[View_MTN]    Script Date: 5/22/2014 10:10:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO








CREATE VIEW [dbo].[View_MTN]
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

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
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
	         Column = 2100
	         Alias = 1695
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
	' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_MTN'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_MTN'
GO

