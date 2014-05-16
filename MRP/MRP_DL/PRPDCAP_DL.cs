using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using SESD.MRP.REF;
using System.Data;

namespace DL
{
   public class PRPDCAP_DL
    {
       SqlConnection Connection = new SqlConnection();

       Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
       Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());


       public PRPDCAP_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

       public long Add(PRPDCAP obj)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDCAPID" , obj.PRPDCAPID),
                new SqlParameter("@CAPMaterial" , obj.MaterialCode),
                new SqlParameter("@GRNNO" , obj.GRNNO),
                new SqlParameter("@CAPQty" , obj.CAPQty),
                new SqlParameter("@Instructions" , obj.Instructions),
                new SqlParameter("@ReworkQty" , obj.ReworkQty),
                new SqlParameter("@DisposeQty" , obj.DisposeQty),
                new SqlParameter("@AcceptQty" , obj.AcceptQty),
                new SqlParameter("@Remarks" , obj.Remarks),
                new SqlParameter("@EnterdBy" , obj.EnteredBy.EmployeeID),
                new SqlParameter("@EnterdDate" , obj.EnteredDate),
                new SqlParameter("@ApprovedBy" , obj.ApprovedBy.EmployeeID),
                new SqlParameter("@ApprovedDate" , obj.ApprovedDate),
                new SqlParameter("@TestedBy" , obj.TestedBy.EmployeeID),
                new SqlParameter("@TestDate" , obj.TestedDate),
                new SqlParameter("@CAPStatus" , obj.Status),
                new SqlParameter("@ReworkMTN" , obj.ReworkMTN),
                new SqlParameter("@DisposeMTN" , obj.DisposeMTN)};

               return Execute.RunSP_RowsEffected(Connection, "SPADD_PRPDCAP", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       } 

       public int Update(PRPDCAP obj, long Original_PRPDCAPID)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_PRPDCAPID",Original_PRPDCAPID)};

               return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDCAP", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public int Delete(long PRPDCAPID)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_PRPDCAPID",PRPDCAPID)};

               return Execute.RunSP_RowsEffected(Connection, "SPDELETE_PRPDCAP", paramList);
           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

       public String GetMaxID()
        {
            return "";
        }

       public System.Data.DataTable GetDataByID(long PRPDCAPID)
       {
           try
           {

               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDCAPID",PRPDCAPID)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDCAPByID", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

       public System.Data.DataTable GetData(PRPDCAP.CAPStatus Status)
       {
           try
           {

               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status",Status)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDCAP_By_Status", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

       public System.Data.DataTable GetData(PRPDCAP.CAPStatus Status1, PRPDCAP.CAPStatus Status2)
       {
           try
           {

               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status1",Status1),
                new SqlParameter("@Status2",Status2)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDCAP_By_Approve", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

       public PRPDCAP Get(long PRPDCAPID)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDCAPID",PRPDCAPID)};


               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PRPDCAPByID", paramList);

               PRPDCAP obj = new PRPDCAP();

               if (dt.Rows.Count > 0)
               {

                   obj.PRPDCAPID = Convert.ToInt64(dt.Rows[0]["PRPDCAPID"]);
                   obj.MaterialCode = Convert.ToString(dt.Rows[0]["CAPMaterial"]);
                   obj.GRNNO = Convert.ToInt64(dt.Rows[0]["GRNNO"]);
                   obj.CAPQty = Convert.ToDecimal(dt.Rows[0]["CAPQty"]);
                   obj.Instructions = Convert.ToString(dt.Rows[0]["Instructions"]);
                   obj.ReworkQty = Convert.ToDecimal(dt.Rows[0]["ReworkQty"]);
                   obj.DisposeQty = Convert.ToDecimal(dt.Rows[0]["DisposeQty"]);
                   obj.AcceptQty = Convert.ToDecimal(dt.Rows[0]["AcceptQty"]);
                   obj.Remarks = Convert.ToString(dt.Rows[0]["Remarks"]);
                   obj.EnteredBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["EnterdBy"]));
                   obj.EnteredDate = Convert.ToDateTime(dt.Rows[0]["EnterdDate"]);
                   obj.ApprovedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["ApprovedBy"]));
                   obj.ApprovedDate = Convert.ToDateTime(dt.Rows[0]["ApprovedDate"]);
                   obj.TestedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["TestedBy"]));
                   obj.TestedDate = Convert.ToDateTime(dt.Rows[0]["TestDate"]);
                   obj.Status = (PRPDCAP.CAPStatus)Enum.Parse(typeof(PRPDCAP.CAPStatus),Convert.ToString(dt.Rows[0]["CAPStatus"]));
                   obj.ReworkMTN = Convert.ToInt64(dt.Rows[0]["ReworkMTN"]);
                   obj.DisposeMTN = Convert.ToInt64(dt.Rows[0]["DisposeMTN"]);
                   
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
