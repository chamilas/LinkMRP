USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPGET_PackingMaterialsForecastByY_M_W]    Script Date: 5/17/2014 10:45:57 PM ******/
SET ANSI_NULLS ON
GO

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
		WHERE tblSalesForecast.Year=@prmYear AND tblSalesForecast.Month=@prmMonth AND State=0 AND WeekID=@prmWeek AND 
		RevisionID=(SELECT max(tblSalesForecastDetails.RevisionID)
		FROM tblSalesForecastDetails INNER JOIN tblSalesForecast ON tblSalesForecastDetails.SalesForecastID = tblSalesForecast.ID
		WHERE tblSalesForecast.Year=@prmYear AND tblSalesForecast.Month=@prmMonth AND WeekID=@prmWeek)


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

