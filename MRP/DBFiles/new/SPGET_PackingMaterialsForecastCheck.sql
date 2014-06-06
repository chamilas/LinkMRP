USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPGET_PackingMaterialsForecastCheck]    Script Date: 5/19/2014 1:16:22 PM ******/
SET ANSI_NULLS ON
GO

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

