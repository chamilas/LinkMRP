using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    public class Supplier_DL
    {
        private User _CurrentUser;

        Supplier objSupplier;
        SqlConnection Connection = new SqlConnection();
     

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }



        public Supplier_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(Supplier obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SupplierType", obj.SupplierType),
                new SqlParameter("@SupName", obj.SupplieName),
                 new SqlParameter("@SupAddress", obj.SupplierAddress),
                 new SqlParameter("@SupPhone", obj.SupplierPhone),
                new SqlParameter("@SupMobile", obj.SupplierMobile),
                new SqlParameter("@SupEmail", obj.SupplierEmail),
                new SqlParameter("@SupFax", obj.SupplierFax),
                new SqlParameter("@SupVat", obj.SupplierVat),
                new SqlParameter("@SupVatNumber", obj.SupplierVATNo),
                new SqlParameter("@SupContactPerson", obj.SupplierContactPerson),
                new SqlParameter("@SupplierStatus", obj.SupplierStatus),
                new SqlParameter("@SupplierCode", obj.SupplierNameCode),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Supplier", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(Supplier obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SupplierType", obj.SupplierType),
                new SqlParameter("@SupName", obj.SupplieName),
                 new SqlParameter("@SupAddress", obj.SupplierAddress),
                 new SqlParameter("@SupPhone", obj.SupplierPhone),
                new SqlParameter("@SupMobile", obj.SupplierMobile),
                new SqlParameter("@SubEmail", obj.SupplierEmail),
                new SqlParameter("@SupFax", obj.SupplierFax),
                new SqlParameter("@SupVat", obj.SupplierVat),
                new SqlParameter("@SupVatNumber", obj.SupplierVATNo),
                new SqlParameter("@SupContactPerson", obj.SupplierContactPerson),
                new SqlParameter("@SupplierStatus", obj.SupplierStatus),
                new SqlParameter("@SupplierCode", obj.SupplierNameCode),
                new SqlParameter("@Original_SupplierID", obj.SupplierNameCode)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Supplier", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Delete(long SupplierID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_SupplierID", SupplierID)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Supplier", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable GetView_Search(string SupType, string Key)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SupType", SupType),
                 new SqlParameter("@Key", Key)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_SupplierByType",paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable GetDataView(string SupplierType)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SupplierType", SupplierType)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Supplier_DataView", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public Supplier Get(long SupID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SupplierID", SupID)
                };

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_SupplierByID", paramList);


                Supplier obj = new Supplier();

                if (dt.Rows.Count > 0)
                {
                    obj.SupplieName = Convert.ToString(dt.Rows[0]["SupName"]);
                    obj.SupplierAddress = Convert.ToString(dt.Rows[0]["SupAddress"]);
                    obj.SupplierCode = Convert.ToString(dt.Rows[0]["SupplierID"]);
                    obj.SupplierContactPerson = Convert.ToString(dt.Rows[0]["SupContactPerson"]);
                    obj.SupplierEmail = Convert.ToString(dt.Rows[0]["SupEmail"]);
                    obj.SupplierFax = Convert.ToString(dt.Rows[0]["SupFax"]);
                    obj.SupplierID = Convert.ToInt64(dt.Rows[0]["SupplierID"]);
                    obj.SupplierMobile = Convert.ToString(dt.Rows[0]["SupMobile"]);
                    obj.SupplierPhone = Convert.ToString(dt.Rows[0]["SupPhone"]);

                    obj.SupplierStatus = Convert.ToBoolean(dt.Rows[0]["SupplierStatus"]);
                    obj.SupplierType = Convert.ToString(dt.Rows[0]["SupMobile"]);
                    obj.SupplierPhone = Convert.ToString(dt.Rows[0]["SupPhone"]);
                    obj.SupplierVat = Convert.ToBoolean(dt.Rows[0]["SupVat"]);
                    obj.SupplierVATNo = Convert.ToString(dt.Rows[0]["SupVatNumber"]);
                }

                return obj;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


      
    }
}
