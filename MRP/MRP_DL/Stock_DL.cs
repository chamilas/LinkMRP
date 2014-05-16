using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class Stock_DL
    {
        SqlConnection Connection = new SqlConnection();

        public Stock_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(Stock obj)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID", obj.StockStore.StoreID),
                new SqlParameter("@StockType", obj.StockType),
                 new SqlParameter("@StockMaterialID", obj.StockMaterial.MaterialCode),
                 new SqlParameter("@StockBasicProduct", obj.StockBasicProduct.BasicProductCode),
                new SqlParameter("@StockFinishProduct", obj.StockFinishProduct.FinishProductCode),
                new SqlParameter("@StockQty", obj.StockQty),
                 new SqlParameter("@StockReorderLevel", obj.StockReorderLevel),
                 new SqlParameter("@StockMinimumQty", obj.StockMinimumQty),
                new SqlParameter("@StockMaximumQty", obj.StockMaximumQty),
                new SqlParameter("@StockEconomicalQty", obj.StockEconomicalQty),
                new SqlParameter("@StockReservedQty", obj.StockReservedQty),
                 new SqlParameter("@StockStatus", obj.StockStatus),
                 new SqlParameter("@StockUnitPrice", obj.StockUnitPrice)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Stock", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Add_All(Stock obj)
        {

            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID", obj.StockStore.StoreID),
                new SqlParameter("@StockType", obj.StockType),
                 new SqlParameter("@StockItemCode", obj.StockMaterial.MaterialCode),
                new SqlParameter("@StockQty", obj.StockQty),
                 new SqlParameter("@StockReorderLevel", obj.StockReorderLevel),
                 new SqlParameter("@StockMinimumQty", obj.StockMinimumQty),
                new SqlParameter("@StockMaximumQty", obj.StockMaximumQty),
                new SqlParameter("@StockEconomicalQty", obj.StockEconomicalQty),
                new SqlParameter("@StockReservedQty", obj.StockReservedQty),
                 new SqlParameter("@StockStatus", obj.StockStatus),
                 new SqlParameter("@StockUnitPrice", obj.StockUnitPrice)};

            return Execute.RunSP_RowsEffected(Connection, "SPADD_Stock_All", paramList);
        }

        public int Update(Stock obj,String Original_ItemCode)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID", obj.StockStore.StoreID),
                new SqlParameter("@StockType", obj.StockType),
                 new SqlParameter("@StockMaterialID", obj.StockMaterial.MaterialCode),
                 new SqlParameter("@StockBasicProduct", obj.StockBasicProduct.BasicProductCode),
                new SqlParameter("@StockFinishProduct", obj.StockFinishProduct.FinishProductCode),
                new SqlParameter("@StockQty", obj.StockQty),
                 new SqlParameter("@StockReorderLevel", obj.StockReorderLevel),
                 new SqlParameter("@StockMinimumQty", obj.StockMinimumQty),
                new SqlParameter("@StockMaximumQty", obj.StockMaximumQty),
                new SqlParameter("@StockEconomicalQty", obj.StockEconomicalQty),
                new SqlParameter("@StockReservedQty", obj.StockReservedQty),
                 new SqlParameter("@StockStatus", obj.StockStatus),
                 new SqlParameter("@StockUnitPrice", obj.StockUnitPrice),
                new SqlParameter("@Original_StockItemCode", obj.StockUnitPrice) };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Stock_All", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long StockID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StockID", StockID) };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Stock", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public StockCollec Get()
        {
            return null;
        }

        public Stock Get(long StockID)
        {

            Store_DL objStore_DL = new Store_DL(Connection);
            Material_DL objMaterial_DL = new Material_DL(Connection);
            BasicProduct_DL objBasicProduct_DL = new BasicProduct_DL(Connection);
            FinishProduct_DL objFinishProduct_DL = new FinishProduct_DL(Connection);

            Stock objStock = new Stock();

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StockID", StockID) };

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_StockByID", paramList);

                objStock.StockBasicProduct = objBasicProduct_DL.Get(Convert.ToString(dt.Rows[0]["StockBasicProduct"]));
                objStock.StockEconomicalQty = Convert.ToDecimal(dt.Rows[0]["StockEconomicalQty"]);
                objStock.StockFinishProduct = objFinishProduct_DL.Get(Convert.ToString(dt.Rows[0]["StockFinishProduct"]));
                objStock.StockID = Convert.ToInt64(dt.Rows[0]["StockID"]);
                objStock.StockMaterial = objMaterial_DL.Get(Convert.ToString(dt.Rows[0]["StockMaterialID"]));
                objStock.StockMaximumQty = Convert.ToDecimal(dt.Rows[0]["StockMaximumQty"]);
                objStock.StockMinimumQty = Convert.ToDecimal(dt.Rows[0]["StockMinimumQty"]);
                objStock.StockQty = Convert.ToDecimal(dt.Rows[0]["StockQty"]);
                objStock.StockReorderLevel = Convert.ToDecimal(dt.Rows[0]["StockReorderLevel"]);
                objStock.StockReservedQty = Convert.ToDecimal(dt.Rows[0]["StockReservedQty"]);
                objStock.StockStatus = (Stock.Status)(dt.Rows[0]["StockStatus"]);
                objStock.StockStore = objStore_DL.Get(Convert.ToString(dt.Rows[0]["StoreID"]));
                objStock.StockType = (Stock.Type)(dt.Rows[0]["StockType"]);


                return objStock;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


            
                  
              
        }

        public System.Data.DataTable GetDataView(String StoreID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID", StoreID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Stock_ByStore", paramList);


                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        //public Decimal GetAVGUnitPrice_Material(String StoreID,String MaterialCode)
        //{
        //    tblStockTableAdapter da = new tblStockTableAdapter();
        //    da.Connection = Connection;
        //    try
        //    {
        //        return Convert.ToDecimal(da.SPGET_Stock_AVGUnitPrice_Material(MaterialCode, StoreID));

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //    }
        //}


        //public Decimal GetAVGUnitPrice_FinishProduct(String StoreID, String FinishProductCode)
        //{
        //    tblStockTableAdapter da = new tblStockTableAdapter();
        //    da.Connection = Connection;
        //    try
        //    {
        //        return Convert.ToDecimal(da.SPGET_Stock_AVGUnitPrice_FinishProduct(FinishProductCode,StoreID));

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //    }
        //}


        // public Decimal GetAVGUnitPrice_BasicProduct(String StoreID, String BasicProductCode)
        //{
        //    tblStockTableAdapter da = new tblStockTableAdapter();
        //    da.Connection = Connection;
        //    try
        //    {
        //        return Convert.ToDecimal(da.SPGET_Stock_AVGUnitPrice_BasicProduct(BasicProductCode,StoreID));

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //    }
        //}


        public Decimal GetAvailableQty(String StoreID, String Code, Stock.Type Type)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ItemCode", Code),
                new SqlParameter("@StoreID", StoreID),
                new SqlParameter("@Type", Type)};

                return Execute.RunSP_Decimal(Connection, "SPGET_Stock_AvailableQty", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public Decimal GetAvailableQty(String Code)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ItemCode", Code)};

                return Execute.RunSP_Decimal(Connection, "SPGET_Stock_AvailableQty_By_ItemCode", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Get_ReorderLevel_Below_Count(String EmpID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpID", EmpID)};

                return Execute.RunSP_Int(Connection, "SPGET_STOCK_BELOW_REORDER_COUNT_By_Storekeeper", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable GetBinCard_BP(String StoreID, DateTime FromDate, string BasicProductCode)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FromDate", FromDate),
                 new SqlParameter("@BasicProductCode", BasicProductCode),
                 new SqlParameter("@StoreID", StoreID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Stock_BINCard_BP", paramList);


                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public System.Data.DataTable GetBinCard(String StoreID,DateTime FromDate,string MaterialCode)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FromDate", FromDate),
                 new SqlParameter("@MaterialCode", MaterialCode),
                 new SqlParameter("@StoreID", StoreID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Stock_BINCard", paramList);


                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public System.Data.DataTable GetStock(String StoreID,string MaterialCode)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                 new SqlParameter("@ItemCode", MaterialCode),
                 new SqlParameter("@StoreID", StoreID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Stock_ByStore_Material", paramList);


                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public System.Data.DataTable GetFinishProduct_Availability(String ProductCode, int quantity)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                 new SqlParameter("@FinishProductID", ProductCode),
                 new SqlParameter("@IssuedQty",quantity)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_FinishProduct_Availability", paramList);


                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public void UpdateFinishProductAvailability(String DispatchID,String productid, int qty)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DispatchID", DispatchID),
                new SqlParameter("@FinishProductID", productid),
                new SqlParameter("@IssuedQty", qty)
                };

                Execute.RunSP_DataTable(Connection, "SPUPDATE_FinishProduct_Availability", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        
    }
}
