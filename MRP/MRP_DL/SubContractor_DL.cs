using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    public class SubContractor_DL
    {
        private User _CurrentUser;

        SubContractor objSubContractor;
        SqlConnection Connection = new SqlConnection();

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
       


        public SubContractor_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(SubContractor obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SubCode", obj.SubCode),
                new SqlParameter("@SubName", obj.SubName),
                 new SqlParameter("@SubAddress", obj.SubAddress),
                 new SqlParameter("@SubPhone", obj.SubPhone),
                new SqlParameter("@SubMobile", obj.SubMobile),
                new SqlParameter("@SubEmail", obj.SubEmail),
                new SqlParameter("@SubFax", obj.SubFax),
                new SqlParameter("@SubContactPerson", obj.SubContactPerson),
                new SqlParameter("@SubStatus", obj.SubStatus)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_SubContractor", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        //public int Delete(long ID)
        //{
        //    //try
        //    //{
        //    //    return da.Delete(ID);
        //    //}
        //    //catch (Exception ex)
        //    //{
                
        //    //    throw ex;
        //    //}
        //}


        public DataTable GetView()
        {
            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_SubContractor");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public SubContractor Get(long ID)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SubContractorID", ID)};

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_SubContractor_By_ID", paramList);


                SubContractor obj = new SubContractor();

                obj.SubAddress = Convert.ToString(dt.Rows[0]["SubAddress"]);
                obj.SubCode = Convert.ToString(dt.Rows[0]["SubCode"]);
                obj.SubContactPerson = Convert.ToString(dt.Rows[0]["SubContactPerson"]);
                obj.SubContractorID = Convert.ToInt64(dt.Rows[0]["SubContractorID"]);
                obj.SubEmail = Convert.ToString(dt.Rows[0]["SubEmail"]);
                obj.SubFax = Convert.ToString(dt.Rows[0]["SubFax"]);
                obj.SubMobile = Convert.ToString(dt.Rows[0]["SubMobile"]);
                obj.SubName = Convert.ToString(dt.Rows[0]["SubName"]);
                obj.SubPhone = Convert.ToString(dt.Rows[0]["SubPhone"]);
                obj.SubStatus = Convert.ToBoolean(dt.Rows[0]["SubStatus"]);

                return obj;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


          
        }
    }
}
