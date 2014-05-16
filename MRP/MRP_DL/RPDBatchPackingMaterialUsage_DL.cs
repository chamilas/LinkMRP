using SESD.MRP.REF;
using System.Data;
using System.Data.Sql;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DL
{
    public class RPDBatchPackingMaterialUsage_DL
    {
        SqlConnection Connection = new SqlConnection();


        public RPDBatchPackingMaterialUsage_DL(SqlConnection Conn)
               {
                   Connection = Conn;
               }

        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        MR_DL objMR_DL = new MR_DL(ConnectionStringClass.GetConnection());
        RPDBatch_DL objRPDBatch_DL = new RPDBatch_DL(ConnectionStringClass.GetConnection());

        public int Add(RPDBatchPackingMaterialUsage obj,long OriginalMRNO,String OriginalMaterial) 
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", obj.RPDBatch.RPDBatchID),
                new SqlParameter("@MRNO",obj.MR.MRNO),
                new SqlParameter("@Original_MRNO", obj.MR.MRNO),
                new SqlParameter("@MaterialCode", obj.Material.MaterialCode),
                new SqlParameter("@Original_MaterialCode", obj.Material.MaterialCode),
                new SqlParameter("@Qty", obj.Quantity)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_RPDBatchPackingMaterialUsage_Update", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Update(RPDBatchPackingMaterialUsage obj,string Original_RPDBatchID,long Original_MRNO,string Original_MaterialCode )
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", obj.RPDBatch),
                new SqlParameter("@MRNO", obj.MR),
                new SqlParameter("@MaterialCode", obj.Material),
                new SqlParameter("@Qty", obj.Quantity),
                new SqlParameter("@Original_RPDBatchID" , obj.RPDBatch),
                new SqlParameter("@Original_MRNO" , obj.MR),
                new SqlParameter("@Original_MaterialCode" , obj.Material)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_RPDBatchPackingMaterialUsage", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(String RPDBatchID,long MRNO,String MaterialCode)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_RPDBatchID" , RPDBatchID),
                new SqlParameter("@Original_MRNO" , MRNO),
                new SqlParameter("@Original_MaterialCode" , MaterialCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_RPDBatchPackingMaterialUsage", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public RPDBatchPackingMaterialUsage Get(String RPDBatchID, string MaterialCode, long MRNO)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID",RPDBatchID),
                new SqlParameter("@MRNO",MRNO),
                new SqlParameter("@MaterialCode",MaterialCode)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchPackingMaterialUsageByID", paramList);

                RPDBatchPackingMaterialUsage obj = new RPDBatchPackingMaterialUsage();

                if (dt.Rows.Count > 0)
                {

                    obj.RPDBatch = objRPDBatch_DL.Get(Convert.ToString(dt.Rows[0]["RPDBatchID"]));
                    obj.MR = objMR_DL.Get(Convert.ToInt64(dt.Rows[0]["MRNO"]));
                    obj.Material = objMaterial_DL.Get(Convert.ToString(dt.Rows[0]["MaterialCode"]));
                    obj.Quantity = Convert.ToDecimal(dt.Rows[0]["Qty"]);

                }

                return obj;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataByBatchID(string RPDBatchID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                 new SqlParameter("@RPDBatchID",RPDBatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchPackingMaterialUsageByBatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

    }
}
