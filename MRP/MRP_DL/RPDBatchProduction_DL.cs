using SESD.MRP.REF;
using System.Data.Sql;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data; 

namespace DL
{
    public class RPDBatchProduction_DL
    {
        SqlConnection Connection = new SqlConnection();

        public RPDBatchProduction_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        RPDBatch_DL objRPDBatch_DL = new RPDBatch_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());

        public int Add(RPDBatchProduction obj,String OriginalMaterialCode)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", obj.RPDBatch.RPDBatchID),
                new SqlParameter("@MaterialCode", obj.Material.MaterialCode),
                new SqlParameter("@OriginalMaterialCode", obj.Material.MaterialCode),
                new SqlParameter("@Qty", obj.MaterialQuantity)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_RPDBatchProduction_Update", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Update(RPDBatchProduction obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {

                new SqlParameter("@RPDBatchID" , obj.RPDBatch),
                new SqlParameter("@MaterialCode" , obj.Material),
                new SqlParameter("@Qty" , obj.MaterialQuantity)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_RPDBatchProduction", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(String RPDBatchID, String MaterialCode)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_RPDBatchID" , RPDBatchID),
                new SqlParameter("@Original_MaterialCode" , MaterialCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_RPDBatchProduction", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public RPDBatchProduction Get(String RPDBatchID, String MaterialCode)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID",RPDBatchID),
                new SqlParameter("@MaterialCode",MaterialCode)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchProduction_By_ID", paramList);

                RPDBatchProduction obj = new RPDBatchProduction();

                if (dt.Rows.Count > 0)
                {
                    obj.RPDBatch = objRPDBatch_DL.Get(Convert.ToString(dt.Rows[0]["RPDBatchID"]));
                    obj.MaterialQuantity = Convert.ToDecimal(dt.Rows[0]["Qty"]);
                    obj.Material = objMaterial_DL.Get(Convert.ToString(dt.Rows[0]["MaterialCode"]));
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
                
                 new SqlParameter("@RPDBatchID",RPDBatchID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchProductionByBatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


    }
}
