using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SESD.MRP.REF;

namespace DL
{
   public class GRN_Payment_DL
    {
       SqlConnection Connection = new SqlConnection();

        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        MR_DL objMR_DL = new MR_DL(ConnectionStringClass.GetConnection());
        MTN_DL objMTN_DL = new MTN_DL(ConnectionStringClass.GetConnection());
        Store_DL objStore_DL = new Store_DL(ConnectionStringClass.GetConnection());

        public GRN_Payment_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public long Add(GRN_Payment obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", obj.GRNNo),
                new SqlParameter("@PONo", obj.PONo),
                new SqlParameter("@InvoiceNo", obj.InvoiceNo),
                new SqlParameter("@InvoiceType", obj.InvoiceType),
                 new SqlParameter("@Supplier", obj.Supplier)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_GRN_Payment", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public DataTable Get_DataByGRNNO(long GRNNO)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", GRNNO)};

                return Execute.RunSP_DataTable(Connection, "SPGET_GRN_Payment_ByGRNNO", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public GRN_Payment GetByGRNNO(long GRNNO)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", GRNNO)};

                GRN_Payment obj = new GRN_Payment();

               DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_GRN_Payment_ByGRNNO", paramList);

               if (dt.Rows.Count != 0)
               {
                   obj.GRNNo = Convert.ToInt64(dt.Rows[0]["GRNNO"]);
                   obj.InvoiceNo = Convert.ToString(dt.Rows[0]["InvoiceNo"]);
                   obj.InvoiceType = Convert.ToString(dt.Rows[0]["InvoiceType"]);
                   obj.PONo = Convert.ToString(dt.Rows[0]["PONo"]);
                   obj.Supplier = Convert.ToString(dt.Rows[0]["Supplier"]);

                   return obj;
               }
               else
               {
                   return new GRN_Payment();
               }

                



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }




    }
}
