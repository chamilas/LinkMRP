using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class BatchMachineDetails_DL
    {

        SqlConnection Connection = new SqlConnection();

        public BatchMachineDetails_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public long Add(BatchMachineDetails objBatchMachineDetails)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID", objBatchMachineDetails.BatchAct.BatchActID),
                new SqlParameter("@MachineID", objBatchMachineDetails.TheMachine.MachineCode),
                new SqlParameter("@MachineStart", objBatchMachineDetails.StartTime),
                 new SqlParameter("@MachineStop", objBatchMachineDetails.StopTime)
                };

                return Execute.RunSP_Int(Connection, "SPADD_BatchMachineDetails", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }


        public long Delete(int MachineRecID)
        {


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MachineRecID",MachineRecID)};

                return Execute.RunSP_Int(Connection, "SPDELETE_BatchMachineDetails", paramList);

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

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchMachineDetails_By_BatchActID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
