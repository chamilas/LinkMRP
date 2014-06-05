using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using SESD.MRP.REF;
using DL;
using System.Data;

namespace DL
{
    public class BatchActivityMachineDetails_DL
    {

        SqlConnection Connection = new SqlConnection();

        public BatchActivityMachineDetails_DL(SqlConnection conn)
        {
            Connection = conn;
        }

        public long Add(BatchActivityMachineDetails obj)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {

                new SqlParameter("@BatchID", obj.BatchID),
                new SqlParameter("@MachineID", obj.MachineID),
                new SqlParameter("@InputQty", obj.InputQty),
                new SqlParameter("@OutputQty", obj.OutputQty),
                new SqlParameter("@RejectedQty", obj.RejectedQty),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output(Connection, "SPADD_BatchActivityMachineDetails", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public DataTable GetBatchActivityMachineDetails(String BatchActID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID", BatchActID)
     };

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchActivityMachineDetails", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

    }
}
