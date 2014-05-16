using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using SESD.MRP.REF;
using DL;

namespace DL
{
    public class ActivityMachine_DL
    {

        SqlConnection Connection = new SqlConnection();
        public ActivityMachine_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public int Add(ActivityMachine obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActID", obj.Activity.ActivityID),
                new SqlParameter("@MachineID", obj.Machine.MachineCode),
                new SqlParameter("@EstimatedHours", obj.EstimatedHour)   
        };

                return Execute.RunSP_Output(Connection, "SPADD_ActivityMachine", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int Delete(long ActID, String MachineCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_ActID", ActID),
                new SqlParameter("@Original_MachineID", MachineCode)
        };

                return Execute.RunSP_Output(Connection, "SPDELETE_ActivityMachine", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

       

        public ActivityMachineCollec Get(Activity objActivity)
        {
            ActivityMachineCollec objActivityMachineCollec = new ActivityMachineCollec();
            Activity_DL objActivityDL = new Activity_DL(Connection);
            Machine_DL objMachineDL = new Machine_DL(Connection);

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActID", objActivity.ActivityID)
        };

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_ActivityMachine_By_ActID", paramList);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ActivityMachine obj = new ActivityMachine();

                    if (dt.Rows[i]["ActID"] != null)
                    {
                        obj.Activity = objActivityDL.Get(Convert.ToInt64(dt.Rows[i]["ActID"]));
                    }

                    if (dt.Rows[i]["MachineID"] != null)
                    {
                        obj.Machine = objMachineDL.Get(Convert.ToString(dt.Rows[i]["MachineID"]));
                    }

                    obj.EstimatedHour = Convert.ToDecimal(dt.Rows[i]["EstimatedHours"]);

                    objActivityMachineCollec.Add(obj);

                }

                return objActivityMachineCollec;



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

       
    }
}
