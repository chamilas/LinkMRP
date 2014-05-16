using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class Form_DL
    {
        SqlConnection Connection = new SqlConnection();


        public Form_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public int Add(Form objForm)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Form", objForm.FormName)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Form", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Update(Form objForm)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Form", objForm.FormName),
                new SqlParameter("@Original_FormID", objForm.FormID)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Form", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long FormID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_FormID", FormID)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Form", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public FormCollec Get()
        {
            return null;
        }

        public Form Get(long FormID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormID", FormID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_FormByID", paramList);


                Form obj = new Form();


                obj.FormID = Convert.ToInt64(dt.Rows[0]["FormID"]);
                obj.FormName = Convert.ToString(dt.Rows[0]["Form"]);


                return obj;
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

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Form");

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }
    }
}
