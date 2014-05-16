using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace DL
{
   public class RPDBatchActivityInstructions_DL
    {
       SqlConnection Connection = new SqlConnection();

       public RPDBatchActivityInstructions_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


       MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
       RPDBatch_DL objRPDBatch_DL = new RPDBatch_DL(ConnectionStringClass.GetConnection());
       Machine_DL objMachine_DL = new Machine_DL(ConnectionStringClass.GetConnection());
            

       public long Add(RPDBatchActivityInstructions obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchActivityInstructionsID", obj.ID),
                new SqlParameter("@BatchNo",obj.RPDBatch.RPDBatchID),
                new SqlParameter("@ActivityID", obj.Activity.MainActID),
                new SqlParameter("@MachineID", obj.Machine.MachineCode),
                new SqlParameter("@ParticleSize", obj.ParticleSize),
                new SqlParameter("@InstructionDesc", obj.Description),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output(Connection, "SPADD_RPDBatchActivityInstructions_Update", paramList);

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
                
                new SqlParameter("@Original_RPDBatchActivityInstructionsID" , ID )};

               return Execute.RunSP_RowsEffected(Connection, "SPDELETE_RPDBatchActivityInstructions", paramList);
           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

       public RPDBatchActivityInstructions Get(long ID)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchActivityInstructionsID",ID)};


               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActivityInstructions_By_ID", paramList);

               RPDBatchActivityInstructions obj = new RPDBatchActivityInstructions();

               if (dt.Rows.Count > 0)
               {

                   obj.ID = Convert.ToInt64(dt.Rows[0]["RPDBatchActivityInstructionsID"]);
                   obj.RPDBatch = objRPDBatch_DL.Get(Convert.ToString(dt.Rows[0]["BatchNo"]));
                   obj.Activity = objMainActivity_DL.Get(Convert.ToInt64(dt.Rows[0]["ActivityID"]));
                   obj.Machine = objMachine_DL.Get(Convert.ToString(dt.Rows[0]["MachineID"]));
                   obj.ParticleSize = Convert.ToString(dt.Rows[0]["ParticleSize"]);
                   obj.Description = Convert.ToString(dt.Rows[0]["InstructionDesc"]);
               }

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


               return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActivityInstructions_View");

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public System.Data.DataTable GetDataView(String RPDBatchID)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                 new SqlParameter("@BatchNo",RPDBatchID)
                };

               return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActivityInstructions_By_RPDBatchID", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }


    }
}
