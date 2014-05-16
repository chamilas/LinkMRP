using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace DL
{
    public class TGRN_DL
    {
        SqlConnection Connection = new SqlConnection();
        public TGRN_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        DeliverNote_DL objDeliverNote_DL = new DeliverNote_DL(ConnectionStringClass.GetConnection());
        //public int Add(TGRN obj)
        //{
        //    tblTGRNTableAdapter da = new tblTGRNTableAdapter();
        //    da.Connection = Connection;
        //    try
        //    {
        //        return da.Insert(obj.TGRNDeleveryNote.DeleveryNoteID,
        //            obj.TGRNDate,
        //            obj.TGRNEnterdBy.EmployeeID,
        //            Convert.ToInt32(obj.TGRNStatus));

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //    }
        //}

        //public int Update(TGRN obj)
        //{
        //    tblTGRNTableAdapter da = new tblTGRNTableAdapter();
        //    da.Connection = Connection;
        //    try
        //    {
        //        return da.Update(obj.TGRNDeleveryNote.DeleveryNoteID,
        //            obj.TGRNDate,
        //            obj.TGRNEnterdBy.EmployeeID,
        //            Convert.ToInt32(obj.TGRNStatus),
        //            obj.TGRNNO);

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //    }
        //}

        //public int Delete(long TGRNNO)
        //{
        //    tblTGRNTableAdapter da = new tblTGRNTableAdapter();
        //    da.Connection = Connection;
        //    try
        //    {
        //        return da.Delete(TGRNNO);

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //    }
        //}

        //public TGRNCollec Get()
        //{
        //    tblTGRNTableAdapter da = new tblTGRNTableAdapter();
        //    da.Connection = Connection;
        //    Employee_DL objEmpDL = new Employee_DL(Connection);
        //    DeleverNote_DL objDelNoteDL = new DeleverNote_DL(Connection);

        //    TGRNCollec objTGRNCollec = new TGRNCollec();

        //    MRPDataSet1 dsMRP = new MRPDataSet1();

        //    try
        //    {
        //        da.Fill(dsMRP.tblTGRN);
        //        foreach (MRPDataSet1.tblTGRNRow dr in dsMRP.tblTGRN)
        //        {
        //            TGRN objTGRN = new TGRN();
        //            objTGRN.TGRNDate = dr.TGRNDate;
        //            objTGRN.TGRNDeleveryNote = objDelNoteDL.Get(dr.TGRNDeleverNoteNo);
        //            objTGRN.TGRNEnterdBy = objEmpDL.Get(dr.TGRNEnterdBy);
        //            objTGRN.TGRNEnterdDate = dr.TGRNEnterdDate;
        //            objTGRN.TGRNNO = Convert.ToInt64(dr.TGRNNO);
        //            objTGRN.TGRNStatus = (TGRN.Status)Convert.ToInt32(dr.TGRNStatus);
        //            objTGRNCollec.Add(objTGRN);
        //        }
        //        return objTGRNCollec;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //    }
        //}

        public TGRN Get(long TGRNNO)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@TGRNNo", TGRNNO)};

            DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_TGRNByID", paramList);


            TGRN obj = new TGRN();

            try
            {
                if (dt.Rows.Count > 0)
                {
                    obj.TGRNDate = Convert.ToDateTime(dt.Rows[0]["TGRNDate"]);
                    obj.TGRNDeleveryNote = objDeliverNote_DL.Get(Convert.ToString(dt.Rows[0]["TGRNDeleverNoteNo"]));
                    obj.TGRNEnterdBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["TGRNEnterdBy"]));
                    obj.TGRNEnterdDate = Convert.ToDateTime(dt.Rows[0]["TGRNEnterdDate"]);
                    obj.TGRNNO = Convert.ToInt64(dt.Rows[0]["TGRNNO"]);
                    obj.TGRNStatus = (TGRN.Status)Convert.ToInt32(dt.Rows[0]["TGRNStatus"]);

                }

                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            finally
            {
            }
        }

        //public TGRNCollec Get(TGRN.Status Status)
        //{
        //    tblTGRNTableAdapter da = new tblTGRNTableAdapter();
        //    da.Connection = Connection;
        //    Employee_DL objEmpDL = new Employee_DL(Connection);
        //    DeleverNote_DL objDelNoteDL = new DeleverNote_DL(Connection);

        //    TGRNCollec objTGRNCollec = new TGRNCollec();

        //    MRPDataSet1 dsMRP = new MRPDataSet1();

        //    try
        //    {
        //        da.FillByStatus(dsMRP.tblTGRN, Convert.ToInt32(Status));
        //        foreach (MRPDataSet1.tblTGRNRow dr in dsMRP.tblTGRN)
        //        {
        //            TGRN objTGRN = new TGRN();
        //            objTGRN.TGRNDate = dr.TGRNDate;
        //            objTGRN.TGRNDeleveryNote = objDelNoteDL.Get(dr.TGRNDeleverNoteNo);
        //            objTGRN.TGRNEnterdBy = objEmpDL.Get(dr.TGRNEnterdBy);
        //            objTGRN.TGRNEnterdDate = dr.TGRNEnterdDate;
        //            objTGRN.TGRNNO = Convert.ToInt64(dr.TGRNNO);
        //            objTGRN.TGRNStatus = (TGRN.Status)Convert.ToInt32(dr.TGRNStatus);
        //            objTGRNCollec.Add(objTGRN);
        //        }
        //        return objTGRNCollec;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //    }
        //}

        //public int Update(long TGRNNO, Employee EnterdBy, TGRN.Status TGRNStatus)
        //{
        //    tblTGRNTableAdapter da = new tblTGRNTableAdapter();
        //    da.Connection = Connection;
        //    Employee_DL objEmpDL = new Employee_DL(Connection);
        //    DeleverNote_DL objDelNoteDL = new DeleverNote_DL(Connection);

        //    long MTNO = 0;

        //    MRPDataSet1 dsMRP = new MRPDataSet1();

        //    try
        //    {
        //       return da.Update_TGRN_ByLAB_NEW(TGRNNO, Convert.ToInt32(TGRNStatus), EnterdBy.EmployeeID);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //    }
        
        //}

        //public int Update_Rework(long TGRNNO, Employee EnterdBy, TGRN.Status TGRNStatus)
        //{
        //    tblTGRNTableAdapter da = new tblTGRNTableAdapter();
        //    da.Connection = Connection;
        //    Employee_DL objEmpDL = new Employee_DL(Connection);
        //    DeleverNote_DL objDelNoteDL = new DeleverNote_DL(Connection);

        //    long MTNO = 0;

        //    MRPDataSet1 dsMRP = new MRPDataSet1();

        //    try
        //    {
        //        return da.SPUPDATE_TGRN_ByLAB_MTN_REWORK(TGRNNO, Convert.ToInt32(TGRNStatus), EnterdBy.EmployeeID);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //    }

        //}
    }
}
