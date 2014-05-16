using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data;
using System.Data.SqlClient;

 
namespace DL
{
   public class PRPDBatchActivityInstructions_DL
    {
             SqlConnection Connection = new SqlConnection();

       public PRPDBatchActivityInstructions_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


       MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
       PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
       Machine_DL objMachine_DL = new Machine_DL(ConnectionStringClass.GetConnection());


       public int Add(PRPDBatchActivityInstructions obj)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID" , obj.PRPDBatch.PRPDBatchID),
                new SqlParameter("@ActivityID" , obj.Activity.MainActID),
                new SqlParameter("@MachineID" , obj.MachineCode),
                new SqlParameter("@ParticleSize" , obj.ParticleSize),
                new SqlParameter("@InstructionDesc" , obj.InstructionDesc)};

               return Execute.RunSP_RowsEffected(Connection, "SPADD_PRPDBatchActivityInstructions", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }


       public int Update_withoutMachine(PRPDBatchActivityInstructions obj)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {

                new SqlParameter("@PRPDBatchID" , obj.PRPDBatch.PRPDBatchID),
                new SqlParameter("@ActivityID" , obj.Activity.MainActID),
                new SqlParameter("@ParticleSize" , obj.ParticleSize),
                new SqlParameter("@InstructionDesc" , obj.InstructionDesc),
                new SqlParameter("@Original_PRPDBatchActivityInstructionsID" , obj.PRPDBatchActivityInstructionsID)};

               return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatchActivityInstructions_withoutMachine", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

        public int Update(PRPDBatchActivityInstructions obj)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {

                new SqlParameter("@PRPDBatchID" , obj.PRPDBatch.PRPDBatchID),
                new SqlParameter("@ActivityID" , obj.Activity.MainActID),
                new SqlParameter("@MachineID" , obj.Machine.MachineCode),
                new SqlParameter("@ParticleSize" , obj.ParticleSize),
                new SqlParameter("@InstructionDesc" , obj.InstructionDesc),
                new SqlParameter("@Original_PRPDBatchActivityInstructionsID" , obj.PRPDBatchActivityInstructionsID)};

               return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatchActivityInstructions", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public int Delete(PRPDBatchActivityInstructions obj)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_PRPDBatchActivityInstructionsID" ,obj.PRPDBatchActivityInstructionsID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_PRPDBatchActivityInstructions", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


       public PRPDBatchActivityInstructions.PRPDBatchActivityInstructionsCollec Get()
       {

           try
           {

               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityInstructions");

               PRPDBatchActivityInstructions.PRPDBatchActivityInstructionsCollec objCollec = new PRPDBatchActivityInstructions.PRPDBatchActivityInstructionsCollec();
               PRPDBatchActivityInstructions obj = new PRPDBatchActivityInstructions();

               if (dt.Rows.Count > 0)
               {
                   for (int i = 0; i < dt.Rows.Count; i++)
                   {


                       obj.PRPDBatchActivityInstructionsID = Convert.ToInt64(dt.Rows[i]["PRPDBatchActivityInstructionsID"]);
                       obj.PRPDBatch = objPRPDBatch_DL.Get(Convert.ToString(dt.Rows[i]["PRPDBatchID"]));
                       obj.Machine = objMachine_DL.Get(Convert.ToString(dt.Rows[i]["MachineID"]));
                       obj.Activity = objMainActivity_DL.Get(Convert.ToInt64(dt.Rows[i]["ActivityID"]));
                       obj.ActivityID = Convert.ToInt64(dt.Rows[i]["ActivityID"]);
                       obj.MachineCode = Convert.ToString(dt.Rows[i]["MachineID"]);
                       obj.ParticleSize = Convert.ToString(dt.Rows[i]["ParticleSize"]);
                       obj.InstructionDesc = Convert.ToString(dt.Rows[i]["InstructionDesc"]);

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


       public PRPDBatchActivityInstructions.PRPDBatchActivityInstructionsCollec Get(String PRPDBatchNo)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID",PRPDBatchNo)};

               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityInstructionsByBatchID", paramList);

               PRPDBatchActivityInstructions.PRPDBatchActivityInstructionsCollec objCollec = new PRPDBatchActivityInstructions.PRPDBatchActivityInstructionsCollec();

               PRPDBatchActivityInstructions obj = new PRPDBatchActivityInstructions();

               if (dt.Rows.Count > 0)
               {
                   for (int i = 0; i < dt.Rows.Count; i++)
                   {


                       obj.PRPDBatchActivityInstructionsID = Convert.ToInt64(dt.Rows[i]["PRPDBatchActivityInstructionsID"]);
                       obj.PRPDBatch = objPRPDBatch_DL.Get(Convert.ToString(dt.Rows[i]["PRPDBatchID"]));
                       obj.ActivityID = Convert.ToInt64(dt.Rows[i]["ActivityID"]);
                       obj.MachineCode = Convert.ToString(dt.Rows[i]["MachineID"]);
                       obj.Machine = objMachine_DL.Get(Convert.ToString(dt.Rows[i]["MachineID"]));
                       obj.Activity = objMainActivity_DL.Get(Convert.ToInt64(dt.Rows[i]["ActivityID"]));
                       obj.ParticleSize = Convert.ToString(dt.Rows[i]["ParticleSize"]);
                       obj.InstructionDesc = Convert.ToString(dt.Rows[i]["InstructionDesc"]);
                       obj.Activity = objMainActivity_DL.Get(Convert.ToInt64(dt.Rows[i]["MainActivity"]));

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


       //public PRPDBatchActivityInstructions.PRPDBatchActivityInstructionsCollec Get(String PRPDBatchID, long ActID)
       //{
       //    MRPDataSetPRPD dsMRP = new MRPDataSetPRPD();

       //    PRPDBatchActivityInstructions.PRPDBatchActivityInstructionsCollec objPRPDBatchActivityInstructionsCollec = new PRPDBatchActivityInstructions.PRPDBatchActivityInstructionsCollec();

       //    MainActivity_DL objMainActivity_DL = new MainActivity_DL(Connection);
       //    PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(Connection);
       //    Machine_DL objMachine_DL = new Machine_DL(Connection);

       //    try
       //    {


       //        da.FillByActID(dsMRP.tblPRPDBatchActivityInstructions,ActID);

       //        foreach (MRPDataSetPRPD.tblPRPDBatchActivityInstructionsRow dr in dsMRP.tblPRPDBatchActivityInstructions)
       //        {
       //            PRPDBatchActivityInstructions objPRPDBatchActivityInstructions = new PRPDBatchActivityInstructions();

       //            objPRPDBatchActivityInstructions.PRPDBatch = objPRPDBatch_DL.Get(dr.PRPDBatchID);
       //            objPRPDBatchActivityInstructions.Activity = objMainActivity_DL.Get(Convert.ToInt64(dr.ActivityID));
       //            if (!dr.IsMachineIDNull())
       //            {
       //                objPRPDBatchActivityInstructions.Machine = objMachine_DL.Get(dr.MachineID);

       //            } 
       //            objPRPDBatchActivityInstructions.InstructionDesc = dr.InstructionDesc;
       //            objPRPDBatchActivityInstructions.ParticleSize = dr.ParticleSize;
       //            objPRPDBatchActivityInstructions.PRPDBatchActivityInstructionsID = Convert.ToInt64(dr.PRPDBatchActivityInstructionsID);

       //            objPRPDBatchActivityInstructionsCollec.Add(objPRPDBatchActivityInstructions);
       //        }
       //        return objPRPDBatchActivityInstructionsCollec;
       //    }
       //    catch (Exception ex)
       //    {

       //        throw new Exception(ex.Message, ex);
       //    }
       //    finally
       //    {
       //        dsMRP.Dispose();


       //        objMainActivity_DL = null;
       //        objPRPDBatch_DL = null;

       //    }

       //}


       public PRPDBatchActivityInstructions Get(long PRPDBatchActivityInstructionsID)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchActivityInstructionsID",PRPDBatchActivityInstructionsID)};


               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityInstructionsByID", paramList);

               PRPDBatchActivityInstructions obj = new PRPDBatchActivityInstructions();

               if (dt.Rows.Count > 0)
               {

                   obj.PRPDBatchActivityInstructionsID = Convert.ToInt64(dt.Rows[0]["PRPDBatchActivityInstructionsID"]);
                   obj.PRPDBatch = objPRPDBatch_DL.Get(Convert.ToString(dt.Rows[0]["PRPDBatchID"]));
                   obj.ActivityID = Convert.ToInt64(dt.Rows[0]["ActivityID"]);
                   obj.MachineCode = Convert.ToString(dt.Rows[0]["MachineID"]);
                   obj.Machine = objMachine_DL.Get(Convert.ToString(dt.Rows[0]["MachineID"]));
                   obj.Activity = objMainActivity_DL.Get(Convert.ToInt64(dt.Rows[0]["ActivityID"]));
                   obj.ParticleSize = Convert.ToString(dt.Rows[0]["ParticleSize"]);
                   obj.InstructionDesc = Convert.ToString(dt.Rows[0]["InstructionDesc"]);
               }

               return obj;


           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }


       public System.Data.DataTable GetDataByBatchID(String PRPDBatchNo)
       {
           try
           {

               SqlParameter[] paramList = new SqlParameter[] {
                
               new SqlParameter("@PRPDBatchID" , PRPDBatchNo)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityInstructionsByBatchID", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }


       public System.Data.DataTable GetDataByID(long @PRPDBatchActivityInstructionsID)
       {
           try
           {

               SqlParameter[] paramList = new SqlParameter[] {
                
               new SqlParameter("@PRPDBatchActivityInstructionsID" , PRPDBatchActivityInstructionsID)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityInstructionsByID ", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }
    }
}

