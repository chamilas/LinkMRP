using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class SKU_DL
    {
        SqlConnection Connection = new SqlConnection();


        public SKU_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(SKU obj)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SKUPackingID", obj.SKUPackingType.PackingID),
                new SqlParameter("@SKUDescription", obj.SKUDescription),
                 new SqlParameter("@SKUQuantity", obj.SKUQty),
                 new SqlParameter("@SKUCost", obj.SKUCost)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_SKU", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Update(SKU obj)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SKUPackingID", obj.SKUPackingType.PackingID),
                new SqlParameter("@SKUDescription", obj.SKUDescription),
                 new SqlParameter("@SKUQuantity", obj.SKUQty),
                 new SqlParameter("@SKUCost", obj.SKUCost),
                new SqlParameter("@Original_SKUID", obj.SKUCost)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_SKU", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }

        public int Delete(long SKUID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_SKUID", SKUID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_SKU", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public SKUCollec Get()
        {
            return null;
        }

        public SKU Get(long SKUID)
        {

            PackingType_DL objPackingType_DL = new PackingType_DL(Connection);

            SKU objSKU = new SKU();

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_SKUID", SKUID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_SKUByID", paramList);

                objSKU.SKUCost = Convert.ToDecimal(dt.Rows[0]["SKUCost"]);
                objSKU.SKUDescription = Convert.ToString(dt.Rows[0]["SKUDescription"]);
                objSKU.SKUID =Convert.ToInt64(dt.Rows[0]["SKUID"]);
                objSKU.SKUPackingType = objPackingType_DL.Get(Convert.ToInt64(dt.Rows[0]["SKUPackingType"]));
                objSKU.SKUQty = Convert.ToDecimal(dt.Rows[0]["SKUQty"]);

                return objSKU;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public System.Data.DataTable GetDataView()
        {

            try
            {


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_SKU");

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }

        public System.Data.DataTable GetDataView(String FinishProductCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FinishProductCode", FinishProductCode)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_SKUDataView_By_FinishProductCode");

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }
    }
}
