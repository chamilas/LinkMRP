using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MachineActivity_DL
    {
         SqlConnection Conncetion = new SqlConnection();

        public MachineActivity_DL(SqlConnection conn)
        {
            Conncetion = conn;
        }

        public int Add(MachineActivity obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MachineID", obj.MachineID),
                new SqlParameter("@MainActID", obj.MainActivityID)};

                return Execute.RunSP_RowsEffected(Conncetion, "SPADD_MachineActivity", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Update(MachineActivity obj, MachineActivity OriginalObj)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MachineID", obj.MachineID),
                new SqlParameter("@MainActID", obj.MainActivityID),
                new SqlParameter("@Original_MachineID", OriginalObj.MachineID),
                new SqlParameter("@Original_MainActID", OriginalObj.MainActivityID)};

                return Execute.RunSP_RowsEffected(Conncetion, "SPUPDATE_MachineActivity", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(MachineActivity Obj)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Original_MachineID", Obj.MachineID),
                new SqlParameter("@Original_MainActID", Obj.MainActivityID)};

                return Execute.RunSP_RowsEffected(Conncetion, "SPDELEE_MachineActivity", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public System.Data.DataTable GetDataByAct(long ActID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
        
                new SqlParameter("@MainActID",ActID)};

                return Execute.RunSP_DataTable(Conncetion, "SPGET_MachineActivityByAct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

       
    }
}
