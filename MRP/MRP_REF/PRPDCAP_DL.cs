using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using SESD.MRP.DL.MRPDataSetPRPDTableAdapters;
using SESD.MRP.REF;

namespace SESD.MRP.DL
{
   public class PRPDCAP_DL
    {
       tblPRPDCAPTableAdapter da;
       SqlConnection Connection = new SqlConnection();

       public PRPDCAP_DL(SqlConnection Conn)
        {
            Connection = Conn;
            da = new tblPRPDCAPTableAdapter();
            da.Connection = Connection;

        }

       public long Add(PRPDCAP obj)
        {
            try
            {
                da.Connection = Connection;
                Decimal? ID = null;
               int res = da.SPADD_PRPDCAP_Update(obj.PRPDCAPID,
                    obj.MaterialCode,
                    obj.GRNNO,
                    obj.CAPQty,
                    obj.Instructions,
                    obj.ReworkQty,
                    obj.DisposeQty,
                    obj.AcceptQty,
                    obj.Remarks,
                    obj.EnteredBy.EmployeeID,
                    obj.EnteredDate,
                    obj.ApprovedBy.EmployeeID,
                    obj.ApprovedDate,
                    obj.TestedBy.EmployeeID,
                    obj.TestedDate,
                    (int)obj.Status,
                    obj.ReworkMTN,
                    obj.DisposeMTN,
                    ref ID);

                if (ID.HasValue)
                {
                    return Convert.ToInt64(ID.Value);
                }
                return 0;

    
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            finally
            {
                da.Dispose();


            }


        }

       public int Update(PRPDCAP obj, long Original_PRPDCAPID)
        {
            try
            {
                da.Connection = Connection;
                return da.Update(obj.MaterialCode,
                    obj.GRNNO,
                    obj.CAPQty,
                    obj.Instructions,
                    obj.ReworkQty,
                    obj.DisposeQty,
                    obj.AcceptQty,
                    obj.Remarks,
                    obj.EnteredBy.EmployeeID,
                    obj.EnteredDate,
                    obj.ApprovedBy.EmployeeID,
                    obj.ApprovedDate,
                    obj.TestedBy.EmployeeID,
                    obj.TestedDate,
                    (int)obj.Status,obj.ReworkMTN,obj.DisposeMTN,
                    Original_PRPDCAPID);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            finally
            {
                da.Dispose();

            }

        }

       public int Delete(long PRPDCAPID)
        {
            try
            {
                da.Connection = Connection;

                return da.Delete(PRPDCAPID);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            finally
            {
                da.Dispose();

            }
        }

       public String GetMaxID()
        {
            return "";
        }

       public System.Data.DataTable GetDataByID(long PRPDCAPID)
       {
           tblPRPDCAPTableAdapter da = new tblPRPDCAPTableAdapter();
           da.Connection = Connection;
           try
           {
               return da.GetDataByID(PRPDCAPID);
           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
           finally
           {
               da.Dispose();
           }
       }
       public System.Data.DataTable GetData(PRPDCAP.CAPStatus Status)
       {
           tblPRPDCAPTableAdapter da = new tblPRPDCAPTableAdapter();
           da.Connection = Connection;
           try
           {
               return da.GetDataByStatus(Convert.ToInt32(Status));
           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
           finally
           {
               da.Dispose();
           }
       }


       public System.Data.DataTable GetData(PRPDCAP.CAPStatus Status1, PRPDCAP.CAPStatus Status2)
       {
           tblPRPDCAPTableAdapter da = new tblPRPDCAPTableAdapter();
           da.Connection = Connection;
           try
           {
               return da.GetDataByApprove(Convert.ToInt32(Status1), Convert.ToInt32(Status2));
           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
           finally
           {
               da.Dispose();
           }
       }

       public PRPDCAP Get(long PRPDCAPID)
       {

           MRPDataSetPRPD dsMRP = new MRPDataSetPRPD();

           PRPDCAP obj = new PRPDCAP();
           Employee_DL objEmployee_DL = new Employee_DL(Connection);
           Material_DL objMaterial_DL = new Material_DL(Connection);
           try
           {

               da.Connection = Connection;

               da.FillByID(dsMRP.tblPRPDCAP, PRPDCAPID);

               if (dsMRP.tblPRPDCAP.Rows.Count > 0)
               {
                   MRPDataSetPRPD.tblPRPDCAPRow dr = (MRPDataSetPRPD.tblPRPDCAPRow)dsMRP.tblPRPDCAP.Rows[0];
                   if (!dr.IsAcceptQtyNull())
                   {
                       obj.AcceptQty = dr.AcceptQty;
                   }
                   
                   if (!dr.IsApprovedByNull())
                   {
                       obj.ApprovedBy = objEmployee_DL.Get(dr.ApprovedBy);
                   }
                   if (!dr.IsApprovedDateNull())
                   {
                       obj.ApprovedDate = dr.ApprovedDate;
                   }
                   
                   obj.MaterialCode = (dr.CAPMaterial);
                   obj.CAPQty = dr.CAPQty;
                   if (!dr.IsDisposeQtyNull())
                   {
                       obj.DisposeQty = dr.DisposeQty;
                   }
                   if (!dr.IsEnterdByNull())
                   {
                       obj.EnteredBy = objEmployee_DL.Get(dr.EnterdBy);
                   }
                   
                   obj.EnteredDate = dr.EnterdDate;
                   obj.GRNNO =Convert.ToInt64(dr.GRNNO);
                   obj.Instructions = dr.Instructions;
                   obj.PRPDCAPID = Convert.ToInt64(dr.PRPDCAPID);
                   obj.Remarks = dr.Remarks;
                   if (!dr.IsReworkQtyNull())
                   {
                       obj.ReworkQty = dr.ReworkQty;
                   }
                   
                   obj.Status = (PRPDCAP.CAPStatus)dr.CAPStatus;
                   if (!dr.IsTestedByNull())
                   {
                       obj.TestedBy = objEmployee_DL.Get(dr.TestedBy);
                   }
                   if (!dr.IsTestDateNull())
                   {
                       obj.TestedDate = dr.TestDate;
                   }

                   if (!dr.IsReworkMTNNull())
                   {
                       obj.ReworkMTN = Convert.ToInt64(dr.ReworkMTN);

                   }

                   if (!dr.IsDisposeMTNNull())
                   {
                       obj.DisposeMTN = Convert.ToInt64(dr.DisposeMTN);
                   }
                   
                   return obj;
               }

              return null;

           }

           catch (Exception ex)
           {
               throw new Exception(ex.Message, ex);
           }

           finally
           {
               da.Dispose();

               dsMRP.Dispose();


               objEmployee_DL = null;
               objMaterial_DL = null;

           }


       }

    }
}
