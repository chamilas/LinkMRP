using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using DL;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class QCReport_DL
    {


        SqlConnection Connection = new SqlConnection();

        public QCReport_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public long Add_RPD(QCReport obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("RPDBatchID", obj.RPDBatchID),
                new SqlParameter("@SendBy", obj.SendBy),
                new SqlParameter("@SampleSize", obj.SampleSize),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@SpecificGravity", obj.SpecificGravity),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}

                };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_QCReport_RPD", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public long Add_PRPD(QCReport obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", obj.PRPDBatchID),
                new SqlParameter("@SendBy", obj.SendBy),
                new SqlParameter("@SampleSize", obj.SampleSize),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@SpecificGravity", obj.SpecificGravity),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}

                };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_QCReport_PRPD", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }



        public long Add_Production(QCReport obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProductionBatchID", obj.ProductionBatchID),
                new SqlParameter("@SendBy", obj.SendBy),
                new SqlParameter("@SampleSize", obj.SampleSize),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@SpecificGravity", obj.SpecificGravity),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}

                };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_QCReport_Production", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public long Add_Packing(QCReport obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PackingBatchID", obj.PackingBatchID),
                new SqlParameter("@SendBy", obj.SendBy),
                new SqlParameter("@SampleSize", obj.SampleSize),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@SpecificGravity", obj.SpecificGravity),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}

                };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_QCReport_Packing", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public long Add_Packing_Rework(QCReport obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PackingBatchID", obj.PackingBatchID),
                new SqlParameter("@SendBy", obj.SendBy),
                new SqlParameter("@SampleSize", obj.SampleSize),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@SpecificGravity", obj.SpecificGravity),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}

                };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_QCReport_Packing_Rework", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public long Add_Packing_Secondary(QCReport obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PackingBatchID", obj.PackingBatchID),
                new SqlParameter("@SendBy", obj.SendBy),
                new SqlParameter("@SampleSize", obj.SampleSize),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@SpecificGravity", obj.SpecificGravity),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}

                };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_QCReport_Packing_Secondary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public long Update_Production(QCReport obj, int BatchStatus, string BatchID, string ChangedBy)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                    new SqlParameter("@BatchStatus",BatchStatus),
                    new SqlParameter("@BatchID", BatchID),
                    new SqlParameter("@ChangedBy",ChangedBy),
                new SqlParameter("@AnalyzedBy", obj.AnalyzedBy),
                new SqlParameter("@RDQAOfficer", obj.RDQAOfficer),
                new SqlParameter("@TestBy", obj.TestBy),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@Original_QCReportID",obj.QCReportID)

                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_QCReport_Production", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }

        public long Update_Packing(QCReport obj, string BatchID, string ChangedBy)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                    new SqlParameter("@BatchID", BatchID),
                    new SqlParameter("@ChangedBy",ChangedBy),
                new SqlParameter("@AnalyzedBy", obj.AnalyzedBy),
                new SqlParameter("@RDQAOfficer", obj.RDQAOfficer),
                new SqlParameter("@TestBy", obj.TestBy),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@Original_QCReportID",obj.QCReportID)

                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_QCReport_Packing", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }

        public long Update_RPD(QCReport obj, string RPDBatchID,int RPDBatchStatus)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                    new SqlParameter("@RPDBatchID", RPDBatchID),
                    new SqlParameter("@RPDBatchStatus", RPDBatchStatus),
                new SqlParameter("@AnalyzedBy", obj.AnalyzedBy),
                new SqlParameter("@RDQAOfficer", obj.RDQAOfficer),
                new SqlParameter("@TestBy", obj.TestBy),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@Original_QCReportID",obj.QCReportID)

                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_QCReport_RPD", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }


        public long Update_PRPD(QCReport obj, string PRPDBatchID, int PRPDBatchStatus)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                    new SqlParameter("@PRPDBatchID", PRPDBatchID),
                    new SqlParameter("@PRPDBatchStatus", PRPDBatchStatus),
                new SqlParameter("@AnalyzedBy", obj.AnalyzedBy),
                new SqlParameter("@RDQAOfficer", obj.RDQAOfficer),
                new SqlParameter("@TestBy", obj.TestBy),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@Original_QCReportID",obj.QCReportID)

                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_QCReport_PRPD", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }


        public long Add(QCReport obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@QCReportID", obj.QCReportID),
                new SqlParameter("@ReportType", obj.ReportType),
                new SqlParameter("@RPDBatchID", obj.RPDBatchID),
                new SqlParameter("@PRPDBatchID", obj.PRPDBatchID),
                new SqlParameter("@ProductionBatchID", obj.ProductionBatchID),
                new SqlParameter("@PackingBatchID", obj.PackingBatchID),
                new SqlParameter("@AnalyzedBy", obj.AnalyzedBy),
                new SqlParameter("@RDQAOfficer", obj.RDQAOfficer),
                new SqlParameter("@TestBy", obj.TestBy),
                new SqlParameter("@SendBy", obj.SendBy),
                new SqlParameter("@SendDate", obj.SendDate),
                new SqlParameter("@SampleSize", obj.SampleSize),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@SpecificGravity", obj.SpecificGravity),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}

                };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_QCReport_Update", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Delete(long QCReportID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_QCReportID", QCReportID)

                };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_QCReport", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetView()
        {
            try
            {


                return Execute.RunSP_DataTable(Connection, "SPGET_QCReport");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetView_RPD(String RPDID)
        {

            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDID)


                };

            try
            {


                return Execute.RunSP_DataTable(Connection, "SPGET_QCReport_View_RPDBatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetView_PRPD(String PRPDID)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDID)

                };

            try
            {


                return Execute.RunSP_DataTable(Connection, "SPGET_QCReport_PRPDBatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetView_Production(String BatchID, int Status)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProductionBatchID", BatchID),
                new SqlParameter("@Status", Status)

                };

            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_QCReport_Count_By_Production", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetView(String ReportType, int Status)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ReportType", ReportType),
                new SqlParameter("@Status", Status)

                };

            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_QCReport_Status_Type", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public DataTable Get_IsPackingQCPass(String PackingBatchID, int ReportStatus, string ReportType)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PackingBatchID", PackingBatchID),
                new SqlParameter("@ReportStatus", ReportStatus),
                new SqlParameter("@ReportType", ReportType)
                };

            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_QCReport_Check_IsPackingQCPass", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_IsReworkQCPass(String PackingBatchID, int ReportStatus, string ReportType)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PackingBatchID", PackingBatchID),
                new SqlParameter("@ReportStatus", ReportStatus),
                new SqlParameter("@ReportType", ReportType)
                };

            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_QCReport_Check_IsPackingQCPass", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public DataTable Get_IsManufacturingQCPass(String BatchID, int ReportStatus)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@ReportStatus", ReportStatus),

                };

            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_QCReport_Check_IsManufacturingQCPass", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }




        public DataTable GetView_PackingQC(String PackingBatchID)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PackingBatchID", PackingBatchID)

                };

            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_QCReport_View_PackingBatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable GetView_PackingReworkQC(String PackingBatchID)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PackingBatchID", PackingBatchID)

                };

            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_QCReport_View_PackingBatchID_Rework", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public DataTable GetView_PackingQC_Sec(String PackingBatchID)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PackingBatchID", PackingBatchID)

                };

            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_QCReport_View_PackingBatchID_Sec", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public QCReport Get_ProductionQCReport(String BatchID, int Status)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@Status", Status)

                };

            try
            {

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_QCReport_By_ProductionID_Status", paramList);

                QCReport obj = new QCReport();

                if (dt.Rows.Count > 0)
                {

                    if (dt.Rows[0]["AnalyzedBy"] != null)
                    {
                        obj.AnalyzedBy = Convert.ToString(dt.Rows[0]["AnalyzedBy"]);
                    }

                    if (dt.Rows[0]["FinishDate"] != DBNull.Value)
                    {
                        obj.FinishDate = Convert.ToDateTime(dt.Rows[0]["FinishDate"]);
                    }

                    if (dt.Rows[0]["RDQAOfficer"] != null)
                    {
                        obj.RDQAOfficer = Convert.ToString(dt.Rows[0]["RDQAOfficer"]);
                    }

                    obj.ProductionBatchID = Convert.ToString(dt.Rows[0]["ProductionBatchID"]);

                    obj.QCReportID = Convert.ToInt64(dt.Rows[0]["QCReportID"]);
                    if (dt.Rows[0]["Remarks"] != null)
                    {
                        obj.Remarks = Convert.ToString(dt.Rows[0]["Remarks"]);
                    }
                    obj.ReportType = Convert.ToString(dt.Rows[0]["ReportType"]);
                    obj.SampleSize = "0";
                    obj.SendBy = Convert.ToString(dt.Rows[0]["SendBy"]);
                    obj.SendDate = Convert.ToDateTime(dt.Rows[0]["SendDate"]);
                    obj.SpecificGravity = Convert.ToDecimal(dt.Rows[0]["SpecificGravity"]);
                    obj.Status = Convert.ToInt32(dt.Rows[0]["Status"]);

                    if (dt.Rows[0]["Remarks"] != null)
                    {
                        obj.TestBy = Convert.ToString(dt.Rows[0]["TestBy"]);
                    }


                }

                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public QCReport Get(long QCReportID)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@QCReportID", QCReportID)

                };

            try
            {

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_QCReport_ByID", paramList);

                QCReport obj = new QCReport();

                if (dt.Rows.Count > 0)
                {

                    if (dt.Rows[0]["AnalyzedBy"] != null)
                    {
                        obj.AnalyzedBy = Convert.ToString(dt.Rows[0]["AnalyzedBy"]);
                    }

                    if (dt.Rows[0]["FinishDate"] != DBNull.Value)
                    {
                        obj.FinishDate = Convert.ToDateTime(dt.Rows[0]["FinishDate"]);
                    }

                    if (dt.Rows[0]["RDQAOfficer"] != null)
                    {
                        obj.RDQAOfficer = Convert.ToString(dt.Rows[0]["RDQAOfficer"]);
                    }

                    if (dt.Rows[0]["RPDBatchID"] != null)
                    {
                        obj.RPDBatchID = Convert.ToString(dt.Rows[0]["RPDBatchID"]);
                    }

                    if (dt.Rows[0]["PRPDBatchID"] != null)
                    {
                        obj.PRPDBatchID = Convert.ToString(dt.Rows[0]["PRPDBatchID"]);
                    }

                    obj.ProductionBatchID = Convert.ToString(dt.Rows[0]["ProductionBatchID"]);

                    obj.QCReportID = Convert.ToInt64(dt.Rows[0]["QCReportID"]);
                    if (dt.Rows[0]["Remarks"] != null)
                    {
                        obj.Remarks = Convert.ToString(dt.Rows[0]["Remarks"]);
                    }
                    obj.ReportType = Convert.ToString(dt.Rows[0]["ReportType"]);
                    obj.SampleSize = Convert.ToString(dt.Rows[0]["SampleSize"]);
                    obj.SendBy = Convert.ToString(dt.Rows[0]["SendBy"]);
                    obj.SendDate = Convert.ToDateTime(dt.Rows[0]["SendDate"]);
                    obj.SpecificGravity = Convert.ToDecimal(dt.Rows[0]["SpecificGravity"]);
                    obj.Status = Convert.ToInt32(dt.Rows[0]["Status"]);

                    if (dt.Rows[0]["Remarks"] != null)
                    {
                        obj.TestBy = Convert.ToString(dt.Rows[0]["TestBy"]);
                    }


                }

                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }


        public QCReport Get_PckingQCReport(String BatchID, int Status)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@Status", Status)

                };

            try
            {

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_QCReport_By_PackingID_Status", paramList);

                QCReport obj = new QCReport();

                if (dt.Rows.Count > 0)
                {

                    if (dt.Rows[0]["AnalyzedBy"] != null)
                    {
                        obj.AnalyzedBy = Convert.ToString(dt.Rows[0]["AnalyzedBy"]);
                    }

                    if (dt.Rows[0]["FinishDate"] != DBNull.Value)
                    {
                        obj.FinishDate = Convert.ToDateTime(dt.Rows[0]["FinishDate"]);
                    }

                    if (dt.Rows[0]["RDQAOfficer"] != null)
                    {
                        obj.RDQAOfficer = Convert.ToString(dt.Rows[0]["RDQAOfficer"]);
                    }

                    obj.PackingBatchID = Convert.ToString(dt.Rows[0]["PackingBatchID"]);

                    obj.QCReportID = Convert.ToInt64(dt.Rows[0]["QCReportID"]);
                    if (dt.Rows[0]["Remarks"] != null)
                    {
                        obj.Remarks = Convert.ToString(dt.Rows[0]["Remarks"]);
                    }
                    obj.ReportType = Convert.ToString(dt.Rows[0]["ReportType"]);
                    obj.SampleSize = "0";
                    obj.SendBy = Convert.ToString(dt.Rows[0]["SendBy"]);
                    obj.SendDate = Convert.ToDateTime(dt.Rows[0]["SendDate"]);
                    obj.SpecificGravity = Convert.ToDecimal(dt.Rows[0]["SpecificGravity"]);
                    obj.Status = Convert.ToInt32(dt.Rows[0]["Status"]);

                    if (dt.Rows[0]["Remarks"] != null)
                    {
                        obj.TestBy = Convert.ToString(dt.Rows[0]["TestBy"]);
                    }


                }

                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }


        public QCReport Get_ReworkQCReport(String BatchID, int Status)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@Status", Status)

                };

            try
            {

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_QCReport_By_PackingID_Status", paramList);

                QCReport obj = new QCReport();

                if (dt.Rows.Count > 0)
                {

                    if (dt.Rows[0]["AnalyzedBy"] != null)
                    {
                        obj.AnalyzedBy = Convert.ToString(dt.Rows[0]["AnalyzedBy"]);
                    }

                    if (dt.Rows[0]["FinishDate"] != DBNull.Value)
                    {
                        obj.FinishDate = Convert.ToDateTime(dt.Rows[0]["FinishDate"]);
                    }

                    if (dt.Rows[0]["RDQAOfficer"] != null)
                    {
                        obj.RDQAOfficer = Convert.ToString(dt.Rows[0]["RDQAOfficer"]);
                    }

                    obj.PackingBatchID = Convert.ToString(dt.Rows[0]["PackingBatchID"]);

                    obj.QCReportID = Convert.ToInt64(dt.Rows[0]["QCReportID"]);
                    if (dt.Rows[0]["Remarks"] != null)
                    {
                        obj.Remarks = Convert.ToString(dt.Rows[0]["Remarks"]);
                    }
                    obj.ReportType = Convert.ToString(dt.Rows[0]["ReportType"]);
                    obj.SampleSize = "0";
                    obj.SendBy = Convert.ToString(dt.Rows[0]["SendBy"]);
                    obj.SendDate = Convert.ToDateTime(dt.Rows[0]["SendDate"]);
                    obj.SpecificGravity = Convert.ToDecimal(dt.Rows[0]["SpecificGravity"]);
                    obj.Status = Convert.ToInt32(dt.Rows[0]["Status"]);

                    if (dt.Rows[0]["Remarks"] != null)
                    {
                        obj.TestBy = Convert.ToString(dt.Rows[0]["TestBy"]);
                    }


                }

                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        //public DataTable GetView(String PRPD)
        //{
        //    try
        //    {
        //        return da.GetDataByPRPDBatchID(PRPD);
        //    }
        //    catch (SqlException sqlex)
        //    {
        //        throw sqlex;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public DataTable GetView(String PRPD,bool Status)
        //{
        //    try
        //    {
        //        return da.GetDataByPRPDBatchStatus(PRPD,Status);
        //    }
        //    catch (SqlException sqlex)
        //    {
        //        throw sqlex;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}


        public QCReport Get_PRPD_Quality_Passed(String PRPDBatchID)
        {
            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDBatchID),
                new SqlParameter("@Status", true)

                };

            QCReport obj = new QCReport();

            try
            {
                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_QCReport_PRPDBatch_Status", paramList);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count;i++ )
                    {

                        if (dt.Rows[0]["AnalyzedBy"] != null)
                        {
                            obj.AnalyzedBy = Convert.ToString(dt.Rows[0]["AnalyzedBy"]);
                        }

                        if (dt.Rows[0]["FinishDate"] != DBNull.Value)
                        {
                            obj.FinishDate = Convert.ToDateTime(dt.Rows[0]["FinishDate"]);
                        }

                        if (dt.Rows[0]["RDQAOfficer"] != null)
                        {
                            obj.RDQAOfficer = Convert.ToString(dt.Rows[0]["RDQAOfficer"]);
                        }

                        obj.PackingBatchID = Convert.ToString(dt.Rows[0]["PackingBatchID"]);

                        obj.QCReportID = Convert.ToInt64(dt.Rows[0]["QCReportID"]);
                        if (dt.Rows[0]["Remarks"] != null)
                        {
                            obj.Remarks = Convert.ToString(dt.Rows[0]["Remarks"]);
                        }
                        obj.ReportType = Convert.ToString(dt.Rows[0]["ReportType"]);
                        obj.SampleSize = "0";
                        obj.SendBy = Convert.ToString(dt.Rows[0]["SendBy"]);
                        obj.SendDate = Convert.ToDateTime(dt.Rows[0]["SendDate"]);
                        obj.SpecificGravity = Convert.ToDecimal(dt.Rows[0]["SpecificGravity"]);
                        obj.Status = Convert.ToInt32(dt.Rows[0]["Status"]);

                        if (dt.Rows[0]["Remarks"] != null)
                        {
                            obj.TestBy = Convert.ToString(dt.Rows[0]["TestBy"]);
                        }

                    }
                    return obj;
                }
                return null;
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool IsRPDBatchAccept(String RPDBatchID, int Status)
        {

            SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@RPDBatchID", RPDBatchID),
                new SqlParameter("@Status", Status),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

            try
            {

                int x = Execute.RunSP_Output(Connection, "SPGET_QCReport_Count_By_RPD", paramList);
                if (x > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);

                return false;
            }
        }


        public bool IsPRPDBatchAccept(String PRPDBatchID,int Status)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {new SqlParameter("@PRPDBatchID", PRPDBatchID),
                    new SqlParameter("@Status", Status),
                       new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                int x = Execute.RunSP_Output(Connection, "SPGET_QCReport_Count_By_PRPD", paramList);

                if (x > 0)
                {
                    return true;
                }
                return false;
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public bool IsProductionBatchAccept(String BatchID)
        //{
        //    try
        //    {
        //        int count = Convert.ToInt32(da.SPGET_QCReport_Count_By_Production(Convert.ToInt32(QCReport.ReportStatus.Accept), BatchID));
        //        if (count > 0)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //    catch (SqlException sqlex)
        //    {
        //        throw sqlex;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

    }
}

