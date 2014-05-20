USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPDELETE_ActivityDetails]    Script Date: 5/18/2014 11:39:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPDELETE_ActivityDetails]
(
	@ActivityID int

)
AS
	SET NOCOUNT OFF;
	DELETE FROM tblActivity WHERE (([ActID] = @ActivityID))
GO

