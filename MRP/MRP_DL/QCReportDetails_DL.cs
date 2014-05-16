using System;
using System.Collections.Generic;
using System.Text;
using DL;
using SESD.MRP.REF;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    public class QCReportDetails_DL
    {
        private SqlConnection Connection = new SqlConnection();

        public QCReportDetails_DL(SqlConnection conn)
        {
            Connection = conn;
        }


        public long Add(QCReportDetails obj)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@QCReportID", obj.QCReportID),
                new SqlParameter("@TestParameterID", obj.TestParameterID),
                new SqlParameter("@Result", obj.Result),
                  new SqlParameter("@MaterialCode", obj.MaterialCode),
                new SqlParameter("@Comment", obj.Comment),
                new SqlParameter("@Acceptence", obj.Acceptence),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}


                };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_QCReportDetails_Update", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }




        }

        public int Delete(long TestDetailsID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_TestDetailsID", TestDetailsID)

                };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_QCReportDetails", paramList);

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


                return Execute.RunSP_DataTable(Connection, "SPGET_QCReportDetails");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetView(long ReportID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@QCReportID", ReportID)

                };

                return Execute.RunSP_DataTable(Connection, "SPGET_QCReportDetails_ReportID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public QCReportDetails Get(long ID)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@TestDetailsID", ID)

                };

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_QCReportDetails_ID", paramList);


                QCReportDetails obj = new QCReportDetails();


                if (dt.Rows.Count > 0)
                {

                    obj.Acceptence = Convert.ToBoolean(dt.Rows[0]["Acceptence"]);
                    obj.Comment = Convert.ToString(dt.Rows[0]["Comment"]);
                    obj.MaterialCode = Convert.ToString(dt.Rows[0]["MaterialCode"]);
                    obj.QCReportID = Convert.ToInt64(dt.Rows[0]["QCReportID"]);
                    obj.Result = Convert.ToString(dt.Rows[0]["Result"]);
                    obj.TestDetailsID = Convert.ToInt64(dt.Rows[0]["TestDetailsID"]);
                    obj.TestParameterID = Convert.ToInt64(dt.Rows[0]["TestParameterID"]);

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
