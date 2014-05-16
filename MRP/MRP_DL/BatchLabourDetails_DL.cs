using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class BatchLabourDetails_DL
    {

        SqlConnection Connection = new SqlConnection();

        public BatchLabourDetails_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public long Add(BatchLabourDetails objBatchLabourDetails)
        {

            
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID",objBatchLabourDetails.BatchAct.BatchActID),
                new SqlParameter("@EmployeeID", objBatchLabourDetails.Emp.EmployeeID),
                new SqlParameter("@WorkStart",objBatchLabourDetails.WorkStart),
                new SqlParameter("@WorkStop",objBatchLabourDetails.WorkStop),
                new SqlParameter("@OTHours", objBatchLabourDetails.OTHours)};

                return Execute.RunSP_Int(Connection, "SPADD_BatchLabourDetails", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

                   
        }

         public long Add_Secondary(BatchLabourDetails objBatchLabourDetails)
        {

            
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID",objBatchLabourDetails.BatchAct.BatchActID),
                new SqlParameter("@EmployeeID", objBatchLabourDetails.Emp.EmployeeID),
                new SqlParameter("@WorkStart",objBatchLabourDetails.WorkStart),
                new SqlParameter("@WorkStop",objBatchLabourDetails.WorkStop),
                new SqlParameter("@OTHours", objBatchLabourDetails.OTHours)};

                return Execute.RunSP_Int(Connection, "SPADD_BatchLabourDetails_Secondary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

                   
        }

        


        public long Delete(int LabourRecID)
        {


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@LabourRecID",LabourRecID)};

                return Execute.RunSP_Int(Connection, "SPDELETE_BatchLaourDetails", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }



        public DataTable Get(long BatchActID, int SectionID)
        {


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID", BatchActID),
                new SqlParameter("@SectionID", SectionID)

                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Employee_Recordon_Batch_by_Section", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }


        public BatchLabourDetails Get(long LabourActID)
        {


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@LabourRecID", LabourActID)

                };

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_BatchLaourDetails", paramList);

                BatchLabourDetails obj = new BatchLabourDetails();
                BatchActivity_DL objBatchActivity_DL = new BatchActivity_DL(ConnectionStringClass.GetConnection());
                Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());

                if (dt.Rows.Count != 0)
                {

                    obj.BatchAct = objBatchActivity_DL.GetByID(Convert.ToInt32(dt.Rows[0]["BatchActID"]));
                    obj.Emp =objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["EmployeeID"]));
                    obj.HourlyRate = Convert.ToDecimal(dt.Rows[0]["HourlyRate"]);
                    obj.LabourRecID = Convert.ToInt32(dt.Rows[0]["LabourRecID"]);
                    obj.OTHours = Convert.ToDecimal(dt.Rows[0]["OTHours"]);
                    obj.OTRate = Convert.ToDecimal(dt.Rows[0]["OTRate"]);
                    obj.WorkStart_Date = Convert.ToDateTime(dt.Rows[0]["WorkStart"]);
                    obj.WorkStop_Date = Convert.ToDateTime(dt.Rows[0]["WorkStop"]);
                }



                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }



        public DataTable Get_ByBatchActID(int BatchActID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID", BatchActID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchLabourDetails_By_BatchActID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
