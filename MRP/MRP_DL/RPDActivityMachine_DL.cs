using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data.SqlClient;
using System.Data;
using DL;



namespace DL
{
   public class RPDActivityMachine_DL
    {
       SqlConnection Connection = new SqlConnection();

       public RPDActivityMachine_DL(SqlConnection Conn)
        {
            Connection = Conn;
           
        }

       MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
       Machine_DL objMachine_DL = new Machine_DL(ConnectionStringClass.GetConnection());
            

        public int Add(RPDActivityMachine objRPDActivityMachine)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActID", objRPDActivityMachine.ActivityID),
                new SqlParameter("@MachineID", objRPDActivityMachine.MachineCode),
                new SqlParameter("@CostPerMachineHour", objRPDActivityMachine.CostPerMachineHour),
                new SqlParameter("@CostPerManHour", objRPDActivityMachine.CostPerManHour)};

               return Execute.RunSP_RowsEffected(Connection, "SPADD_RPDActivityMachine", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

        public int Update(RPDActivityMachine objRPDActivityMachine,long Original_ActID,string Original_MachineCode)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActID", objRPDActivityMachine.ActivityID),
                new SqlParameter("@MachineID",objRPDActivityMachine.MachineCode),
                new SqlParameter("@CostPerMachineHour",objRPDActivityMachine.CostPerMachineHour),
                new SqlParameter("@CostPerManHour",objRPDActivityMachine.CostPerManHour),
                new SqlParameter("@Original_ActID",objRPDActivityMachine.ActivityID),
                new SqlParameter("@Original_MachineID",objRPDActivityMachine.MachineCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_RPDActivityMachine", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }


        public int Delete(long ActID, string MachineCode)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_ActID", ActID),
                new SqlParameter("@Original_MachineID", MachineCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_RPDActivityMachine", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public RPDActivityMachineCollec Get()
        {

            try
            {

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityMachine");

                RPDActivityMachineCollec objCollec = new RPDActivityMachineCollec();
                RPDActivityMachine obj = new RPDActivityMachine();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {


                        obj.ActivityID = Convert.ToString(dt.Rows[i]["ActID"]);
                        obj.MachineCode = Convert.ToString(dt.Rows[i]["MachineID"]);
                        obj.CostPerMachineHour = Convert.ToDecimal(dt.Rows[i]["CostPerMachineHour"]);
                        obj.CostPerManHour = Convert.ToDecimal(dt.Rows[i]["CostPerManHour"]);


                        objCollec.Add(obj);
                    }
                }

                return objCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public RPDActivityMachineCollec GetbyMachineID(string MachineID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MachineID",MachineID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityMachineByMachineID", paramList);

                RPDActivityMachineCollec objCollec = new RPDActivityMachineCollec();
                RPDActivityMachine obj = new RPDActivityMachine();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        obj.ActivityID = Convert.ToString(dt.Rows[i]["ActID"]);
                        obj.MachineCode = Convert.ToString(dt.Rows[i]["MachineID"]);
                        obj.CostPerMachineHour = Convert.ToDecimal(dt.Rows[i]["CostPerMachineHour"]);
                        obj.CostPerManHour = Convert.ToDecimal(dt.Rows[i]["CostPerManHour"]);

                        objCollec.Add(obj);
                    }
                }

                return objCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public RPDActivityMachineCollec Get(long ActID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActID",ActID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityMachineByActID", paramList);

                RPDActivityMachineCollec objCollec = new RPDActivityMachineCollec();
                RPDActivityMachine obj = new RPDActivityMachine();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        obj.ActivityID = Convert.ToString(dt.Rows[i]["ActID"]);
                        obj.MachineCode = Convert.ToString(dt.Rows[i]["MachineID"]);
                        obj.CostPerMachineHour = Convert.ToDecimal(dt.Rows[i]["CostPerMachineHour"]);
                        obj.CostPerManHour = Convert.ToDecimal(dt.Rows[i]["CostPerManHour"]);

                        objCollec.Add(obj);
                    }
                }

                return objCollec;


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


                return Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityMachine");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        

    }
}


   
