using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class POMaterials_DL
    {
        SqlConnection Connection = new SqlConnection();

        public POMaterials_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public long Add(POMaterials obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PONO", obj.PONO),
                new SqlParameter("@MaterialCode", obj.MaterialCode),
                new SqlParameter("@POQty", obj.POQty),
                new SqlParameter("@UnitPrice", obj.UnitPrice)

                
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_POMaterials", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(MR obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRStore", obj.MRStore.StoreID),
                new SqlParameter("@MRDate", obj.MRDate),
                new SqlParameter("@MRApprovedBy", obj.MRApprovedBy),
                new SqlParameter("@MRApproveDate", obj.MRApprovedDate),
                new SqlParameter("@MREnterdBy", obj.MREnterdBy),
                new SqlParameter("@MRFromDepId", obj.MRDepartmentFrom.DepID),
                new SqlParameter("@MRIssuedBy",  obj.MRIssuedBy),
                new SqlParameter("@MRIssuedDate", obj.MRIssuedDate),
                new SqlParameter("@MRReceivedBy", obj.MRReceivedBy),
                new SqlParameter("@MRReceivedDate", obj.MRReceivedDate),
                new SqlParameter("@MRRemarks", obj.MRRemarks),
                new SqlParameter("@MRStatus", obj.MRStatus),
                new SqlParameter("@MRType", obj.MRType),
                new SqlParameter("@Original_MRNO", obj.MRNO)
                
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MR", paramList);

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


        public DataTable Get_ByPOID_Detail(String PONO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PONO", PONO)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_POMaterials_By_PO_Detail", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable Get_ByPOID(String PONO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PONO", PONO)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_POMaterials_By_PO", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable Get_ByPOID_Search(String PONO,string Search)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PONO", PONO),
                new SqlParameter("@Search", Search)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_POMaterials_By_PO_Search", paramList);

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
                    

                    objPO.POApporvedBy = Convert.ToString(dt.Rows[0]["POApporvedBy"]);
                    objPO.POApprovedDate = Convert.ToDateTime(dt.Rows[0]["POApprovedDate"]);
                    objPO.POChangedApprove = Convert.ToString(dt.Rows[0]["POChangedApprove"]);
                    objPO.POChangedApprovedDate = Convert.ToDateTime(dt.Rows[0]["POChangedApprovedDate"]);
                    objPO.POChangedBy = Convert.ToString(dt.Rows[0]["POChangedBy"]);
                    objPO.POChangedDate = Convert.ToDateTime(dt.Rows[0]["POChangedDate"]);
                    objPO.POChangedRemarks = Convert.ToString(dt.Rows[0]["POChangedRemarks"]);
                    objPO.PODate = Convert.ToDateTime(dt.Rows[0]["PODate"]);
                    objPO.POEnterdBy = Convert.ToString(dt.Rows[0]["POEnterdBy"]);
                    objPO.POEnterdDate = Convert.ToDateTime(dt.Rows[0]["POEnterdDate"]);
                    objPO.PONO = Convert.ToString(dt.Rows[0]["PONO"]);
                    objPO.POPaymentType = Convert.ToString(dt.Rows[0]["POPaymentType"]);
                    objPO.POReference = Convert.ToString(dt.Rows[0]["POReference"]);
                    objPO.PORequiredDate = Convert.ToDateTime(dt.Rows[0]["PORequiredDate"]);
                    objPO.POStatus = Convert.ToInt32(dt.Rows[0]["POStatus"]);
                    objPO.POSupplierID = Convert.ToInt32(dt.Rows[0]["POSupplierID"]);
                    objPO.POValidityPeriod = Convert.ToInt32(dt.Rows[0]["POSupplierID"]);
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
