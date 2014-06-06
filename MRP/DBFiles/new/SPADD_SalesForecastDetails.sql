USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPADD_SalesForecastDetails]    Script Date: 5/17/2014 10:39:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADD_SalesForecastDetails]
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

