USE [MRP]
GO

/****** Object:  StoredProcedure [dbo].[SPGET_PackingMaterialsForecast_FULL]    Script Date: 5/19/2014 1:07:30 PM ******/
SET ANSI_NULLS ON
GO

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

