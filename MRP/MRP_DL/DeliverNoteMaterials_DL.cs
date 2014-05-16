using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class DeliverNoteMaterials_DL
    {
        SqlConnection Connection = new SqlConnection();
        DeliverNote_DL objDeliverNote_DL = new DeliverNote_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());

        public DeliverNoteMaterials_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(DeliverNoteMaterials obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MaterialCode", obj.MaterialCode),
                new SqlParameter("@DeleverNoteID", obj.DeliverNote),
                new SqlParameter("@Quantity", obj.DeleverdMaterialQty)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_DeliverNoteMaterials", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
        public int Update_EditOnly(DeliverNoteMaterials obj)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MaterialCode", obj.MaterialCode),
                new SqlParameter("@Quantity", obj.DeleverdMaterialQty),
                 new SqlParameter("@ID", obj.ID)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_DeliverNoteMaterials_EditOnly", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(DeliverNoteMaterials obj)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MaterialCode", obj.MaterialCode),
                new SqlParameter("@DeliverNoteID", obj.DeliverNote),
                new SqlParameter("@Quantity", obj.DeleverdMaterialQty),
                new SqlParameter("@AcceptQty", obj.AcceptQty),
                new SqlParameter("@ReworkQty", obj.ReworkQty),
                 new SqlParameter("@RejectQty", obj.RejectQty),
                new SqlParameter("@ReworkRemarks", obj.ReworkRemarks),
                 new SqlParameter("@RejectRemarks", obj.RejectRemarks),
                new SqlParameter("@ReworkUnitPrice", obj.ReworkUnitPrice) ,
                 new SqlParameter("@ID", obj.ID)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_DeliverNoteMaterials", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long ID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@ID",ID )};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_DeliverNoteMaterials", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DeliverNoteMaterials Get(long ID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@ID",ID )};

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_DeliverNoteMaterialsByID", paramList);

                DeliverNoteMaterials objDN = new DeliverNoteMaterials();

                DeliverNoteMaterials obj = new DeliverNoteMaterials();

                obj.AcceptQty = Convert.ToDecimal(dt.Rows[0]["AcceptQty"]);
                obj.ActualReceivedQty = Convert.ToDecimal(dt.Rows[0]["ActualReceived"]);
                obj.DeliverNote = Convert.ToString(dt.Rows[0]["DeliverNoteID"]);
                obj.ID = Convert.ToInt64(dt.Rows[0]["ID"]);
                obj.MaterialCode = Convert.ToString(dt.Rows[0]["MaterialCode"]);
                obj.RejectQty = Convert.ToDecimal(dt.Rows[0]["RejectQty"]);
                obj.RejectRemarks = Convert.ToString(dt.Rows[0]["RejectRemarks"]);
                obj.ReworkQty = Convert.ToDecimal(dt.Rows[0]["ReworkQty"]);
                obj.ReworkRemarks = Convert.ToString(dt.Rows[0]["ReworkRemarks"]);
                obj.ReworkUnitPrice = Convert.ToDecimal(dt.Rows[0]["ReworkUnitPrice"]);
                obj.Unit = Convert.ToString(dt.Rows[0]["UnitCode"]);
                obj.DeleverdMaterialQty = Convert.ToDecimal(dt.Rows[0]["Quantity"]);


                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


       
    }
}
