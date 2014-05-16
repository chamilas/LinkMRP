using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class PO_DL
    {
        SqlConnection Connection = new SqlConnection();

        public PO_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public long Add(PO obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PONO", obj.PONO),
                new SqlParameter("@POSupplierID", obj.POSupplierID),
                new SqlParameter("@POEnterdBy", obj.POEnterdBy),
                new SqlParameter("@POPaymentType", obj.POPaymentType),
                new SqlParameter("@PORequiredDate", obj.PORequiredDate),
                new SqlParameter("@POReference", obj.POReference),
                new SqlParameter("@POStatus", obj.POStatus),
                new SqlParameter("@POValidityPeriod", obj.POValidityPeriod),
                new SqlParameter("@POType", obj.POType),
                 new SqlParameter("@POCategory", obj.POCategory)
                
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_PO", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_Finalize(PO obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PONO", obj.PONO),
                new SqlParameter("@POChangedBy", obj.POChangedBy),
                new SqlParameter("@POStatus", obj.POStatus)
                
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PO_Finalize", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        
        public int Update_Issue(MR obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@IssuedBy", obj.MRIssuedBy),
                new SqlParameter("@Status", obj.MRStatus),
                new SqlParameter("@MRNO", obj.MRNO)
                
                                                                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MR_Issue", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Delete(long MRNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_MRNO", MRNO)
                
                                                                };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MR", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public DataTable GetView_Search(string POCategory,String Search)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Search", Search),
                new SqlParameter("@POType", POCategory),
                
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_PO_Search", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public PO Get(String PONO)
        {
            try
            {
                DataTable dt = new DataTable();
                PO objPO = new PO();

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PONO", PONO)
                                                                };

                dt= Execute.RunSP_DataTable(Connection, "SPGET_PO_ByID", paramList);


                if (dt.Rows.Count>0)
                {

                    if (dt.Rows[0]["POApporvedBy"] != DBNull.Value)
                    {
                        objPO.POApporvedBy = Convert.ToString(dt.Rows[0]["POApporvedBy"]);
                    }
                    if (dt.Rows[0]["POApprovedDate"] != DBNull.Value)
                    {
                        objPO.POApprovedDate = Convert.ToDateTime(dt.Rows[0]["POApprovedDate"]);
                    }
                    if (dt.Rows[0]["POChangedApprove"] != DBNull.Value)
                    {
                        objPO.POChangedApprove = Convert.ToString(dt.Rows[0]["POChangedApprove"]);
                    }
                    if (dt.Rows[0]["POChangedApprovedDate"] != DBNull.Value)
                    {
                        objPO.POChangedApprovedDate = Convert.ToDateTime(dt.Rows[0]["POChangedApprovedDate"]);
                    }
                    if (dt.Rows[0]["POChangedBy"] != DBNull.Value)
                    {
                        objPO.POChangedBy = Convert.ToString(dt.Rows[0]["POChangedBy"]);
                    }
                    if (dt.Rows[0]["POChangedDate"] != DBNull.Value)
                    {
                        objPO.POChangedDate = Convert.ToDateTime(dt.Rows[0]["POChangedDate"]);
                    }
                    if (dt.Rows[0]["POChangedRemarks"] != DBNull.Value)
                    {
                        objPO.POChangedRemarks = Convert.ToString(dt.Rows[0]["POChangedRemarks"]);
                    }
                    if (dt.Rows[0]["PODate"] != DBNull.Value)
                    {
                        objPO.PODate = Convert.ToDateTime(dt.Rows[0]["PODate"]);
                    }
                    objPO.POEnterdBy = Convert.ToString(dt.Rows[0]["POEnterdBy"]);
                    objPO.POEnterdDate = Convert.ToDateTime(dt.Rows[0]["POEnterdDate"]);
                    objPO.PONO = Convert.ToString(dt.Rows[0]["PONO"]);
                    objPO.POPaymentType = Convert.ToString(dt.Rows[0]["POPaymentType"]);
                    if (dt.Rows[0]["POReference"] != DBNull.Value)
                    {
                        objPO.POReference = Convert.ToString(dt.Rows[0]["POReference"]);
                    }
                    objPO.PORequiredDate = Convert.ToDateTime(dt.Rows[0]["PORequiredDate"]);
                    objPO.POStatus = Convert.ToInt32(dt.Rows[0]["POStatus"]);
                    objPO.POSupplierID = Convert.ToInt32(dt.Rows[0]["POSupplierID"]);
                    if (dt.Rows[0]["POSupplierID"] != DBNull.Value)
                    {
                        objPO.POValidityPeriod = Convert.ToInt32(dt.Rows[0]["POValidityPeriod"]);
                    }
                }

                return objPO;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }






        
    }
}
