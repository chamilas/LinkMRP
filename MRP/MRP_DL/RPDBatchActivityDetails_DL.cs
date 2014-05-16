using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using SESD.MRP.DL.MRPDataSetRPDTableAdapters;
using System.Data.SqlClient;
using System.Data;


namespace SESD.MRP.DL
{
    public class RPDBatchActivityDetails_DL
    {
        SqlConnection Connection = new SqlConnection();
        public RPDBatchActivityDetails_DL(SqlConnection Conn)
        {
            Connection = Conn;
            da.Connection = Connection;
        }
        tblRPDBatchActivityDetailsTableAdapter da = new tblRPDBatchActivityDetailsTableAdapter();

        public long Add(RPDBatchActivityDetails obj)
        {
            try
            {

                Decimal? RETID = null;
                int res = da.SPADD_RPDBatchActivityDetails_Update(
                    obj.BatchActDetailsID,
                    obj.RPDBatchActID,
                    obj.StartQty,
                    obj.StopQty,
                    obj.StartTime,
                    obj.StopTime,
                    obj.Frequency,
                    obj.InitialVolume,
                    obj.FinalQty,
                    obj.LossQty,
                    obj.SieveSize,
                    obj.Comments,
                    obj.NoOfTrays,
                    obj.SupervisedBy,
                    ref RETID);
                if (res > 0)
                {
                    return Convert.ToInt64(RETID.Value);
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



        public int Delete(long BatchActivityDetailsID)
        {
            try
            {

                return da.Delete(BatchActivityDetailsID);
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


        public int GetNotFinishedCount(long BatchActivityID)
        {
            try
            {

                return Convert.ToInt32(da.SPGET_RPDBatchActivityDetails_Count_NotFinished(BatchActivityID));
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

        public RPDBatchActivityDetails Get(long RPDBatchActivityDetailsID)
        {
            MRPDataSetRPD dsMRP = new MRPDataSetRPD();
            RPDBatch_DL objRPDBatch_DL = new RPDBatch_DL(Connection);
            Employee_DL objEmployee_DL = new Employee_DL(Connection);
            MainActivity_DL objMainActivity_DL = new MainActivity_DL(Connection);
            Machine_DL objMachine_DL = new Machine_DL(Connection);
            Material_DL objMaterial_DL = new Material_DL(Connection);
            RPDBatchActivityDetails obj = new RPDBatchActivityDetails();
            try
            {

                da.FillByID(dsMRP.tblRPDBatchActivityDetails, RPDBatchActivityDetailsID);
                if (dsMRP.tblRPDBatchActivityDetails.Rows.Count > 0)
                {
                    foreach (MRPDataSetRPD.tblRPDBatchActivityDetailsRow dr in dsMRP.tblRPDBatchActivityDetails)
                    {
                        obj.BatchActDetailsID = Convert.ToInt64(dr.BatchActDetailsID);
                        obj.Comments = dr.Comments;
                        obj.FinalQty = dr.FinalQty;
                        obj.Frequency = dr.Frequency;
                        obj.InitialVolume = dr.InitialVolume;
                        obj.LossQty = dr.LossQty;
                        obj.NoOfTrays = dr.NoOfTrays;
                        obj.RPDBatchActID = Convert.ToInt64(dr.RPDBatchActID);
                        obj.SieveSize = dr.SieveSize;
                        obj.StartQty = dr.StartQty;
                        obj.StartTime = dr.StartTime;
                        obj.StopQty = dr.StopQty;
                        obj.StopTime = dr.StopTime;
                        obj.SupervisedBy = dr.SupervisedBy;
                        
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
             dsMRP.Dispose();

                objRPDBatch_DL=null;
                objEmployee_DL=null;
                objMainActivity_DL=null;
                objMachine_DL=null;


            }
        }

        public System.Data.DataTable GetData(long RPDBatchAct)
        {
            tblRPDBatchActivityDetailsTableAdapter da = new tblRPDBatchActivityDetailsTableAdapter();
            da.Connection = Connection;
            try
            {

                return da.GetDataByBatchAct(RPDBatchAct);

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


    }
}
