using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using SESD.MRP.REF;
using System.Data;

namespace DL
{
    public class TestParameter_DL
    {
        private SqlConnection Connection = new SqlConnection();

        
        public TestParameter_DL(SqlConnection conn)
        {
            Connection = conn;

        }

        public long Add(TestParameter obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Parameter", obj.Parameter),
                new SqlParameter("@Description", obj.Description),
                new SqlParameter("@Type", obj.Type)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_TestParameters", paramList);

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
                
                new SqlParameter("@Original_ParameterID", ID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_TestParameters", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetView()
        {
            try
            {


                
                return Execute.RunSP_DataTable(Connection, "SPGET_TestParameters");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetView(String Type)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Type", Type)};


                return Execute.RunSP_DataTable(Connection, "SPGET_TestParameters_By_Type",paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public TestParameter Get(long ID)
        {
            TestParameter obj = new TestParameter();
            

                    

                    try
                    {


                        SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ParameterID",ID)};

                        DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_TestParameters_ID", paramList);


                        obj.Description = Convert.ToString(dt.Rows[0]["Description"]);
                        obj.Parameter = Convert.ToString(dt.Rows[0]["Parameter"]);
                        obj.ParameterID = Convert.ToInt64(dt.Rows[0]["ParameterID"]);
                        obj.Type = Convert.ToString(dt.Rows[0]["Type"]);
                        return obj;



                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message, ex);
                    }



        }
    }
}
