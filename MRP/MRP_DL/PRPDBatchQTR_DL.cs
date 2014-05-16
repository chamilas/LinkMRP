using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data.SqlClient;
using System.Data;




namespace DL
{
    public class PRPDBatchQTR_DL
    {
        SqlConnection Connection = new SqlConnection();


        public PRPDBatchQTR_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public long Add(PRPDBatchQTR obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID" , obj.PRPDBatchID),
                new SqlParameter("@SandContent" , obj.SandContent),
                new SqlParameter("@ForiegnMatter" , obj.ForiegnMatter),
                new SqlParameter("@MoistureContent" , obj.MoistureContent),
                new SqlParameter("@AnalyzedBy" , obj.AnalyzedBy),
                new SqlParameter("@RDQAOfficer" , obj.RDQAOfficer),
                new SqlParameter("@Date" , obj.Date),
                new SqlParameter("@SampleSize" , obj.SampleSize),
                new SqlParameter("@Acceptance" , obj.Acceptance),
                new SqlParameter("@SandContentState" , obj.SandContentState),
                new SqlParameter("@ForiegnMatterState" , obj.ForiegnMatterState),
                new SqlParameter("@MoistureContentState" , obj.MoistureContentState),
                new SqlParameter("@Remarks" , obj.Remarks),
                new SqlParameter("@Status" , obj.Status)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_PRPDBatchQTR", paramList);

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
                
                new SqlParameter("@Original_TestID",ID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_PRPDBatchQTR", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }



        /*public PRPDBatchQTR Get(long ID)
        {

            MRPDataSetPRPDTableAdapters.tblPRPDBatchQTRTableAdapter da = new DL.MRPDataSetPRPDTableAdapters.tblPRPDBatchQTRTableAdapter();
            MRPDataSetPRPD.tblPRPDBatchQTRDataTable dt = new MRPDataSetPRPD.tblPRPDBatchQTRDataTable();
            PRPDBatchQTR obj = new PRPDBatchQTR();
            try
            {
                da.Connection = Connection;
                da.FillByID(dt, ID);
                if (dt.Rows.Count > 0)
                {
                    foreach (MRPDataSetPRPD.tblPRPDBatchQTRRow dr in dt.Rows)
                    {
                        obj.Acceptance = dr.Acceptance;
                        obj.AnalyzedBy = dr.AnalyzedBy;
                        obj.Date = dr.Date;
                        obj.ForiegnMatter = dr.ForiegnMatter;
                        obj.ForiegnMatterState = dr.ForiegnMatterState;
                        obj.MoistureContent = dr.MoistureContent;
                        obj.MoistureContentState = dr.MoistureContentState;
                        obj.PRPDBatchID = dr.PRPDBatchID;
                        obj.RDQAOfficer = dr.RDQAOfficer;
                        obj.Remarks = dr.Remarks;
                        obj.SampleSize = dr.SampleSize;
                        obj.SandContent = dr.SandContent;
                        obj.SandContentState = dr.SandContentState;
                        obj.Status = dr.Status;
                        obj.TestID = Convert.ToInt64(dr.TestID);
                        
                    }
                    return obj;
                }

                return null;



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
        */

        public DataTable Get_View()
        {
            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchQTR");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public DataTable Get_View(String PRPDBatchID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDBatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchQTR_By_PRPDBatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }



        public DataTable Get_View_By_Status(String Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status",Status)};

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchQTR_Status", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public DataTable Get_View(String PRPDBatchID,String Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status",Status),
                new SqlParameter("@PRPDBatchID",PRPDBatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchQTR_By_PRPDBatch_Status", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }
    }
}
