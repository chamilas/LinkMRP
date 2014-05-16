using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MTNMaterial_DL
    {
        SqlConnection Connection = new SqlConnection();


        public MTNMaterial_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(MTNMaterial obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", obj.MTN.MTNNo),
                new SqlParameter("@MTNMaterialCode", obj.Material.MaterialCode),
                new SqlParameter("@MTNTransferQty", obj.TransferQty),
                new SqlParameter("@MTNUnitRate", obj.UnitRate),
                new SqlParameter("@MTNRceivedQty",  obj.ReceivedQty)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MTNMaterial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Add(MTNMaterial obj, String StoreID, long GRNNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", obj.MTN.MTNNo),
                new SqlParameter("@MTNMaterialCode", obj.Material.MaterialCode),
                new SqlParameter("@MTNDescription", obj.Description),
                new SqlParameter("@MTNTransferQty", obj.TransferQty),
                new SqlParameter("@MTNUnitRate", obj.UnitRate),
                new SqlParameter("@GRNNO",  GRNNO),
                new SqlParameter("@StoreID", StoreID)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MTNMaterial_BY_GRN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(MTNMaterial obj,long OriginalMTNNO,String OriginalMaterialCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", obj.MTN.MTNNo),
                new SqlParameter("@MTNMaterialCode", obj.Material.MaterialCode),
                new SqlParameter("@MTNBatchNo", obj.MTN.MTNBatch),
                new SqlParameter("@MTNDescription", obj.Description),
                new SqlParameter("@MTNTransferQty", obj.TransferQty),
                new SqlParameter("@MTNUnitRate", obj.UnitRate),
                new SqlParameter("@MTNRceivedQty",  obj.ReceivedQty),
                new SqlParameter("@Original_MTNNO",  OriginalMTNNO),
                new SqlParameter("@Original_MTNMaterialCode",  OriginalMaterialCode)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MTNMaterial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int Update(Decimal RecevedQty, long MTNNO, String MaterialCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNRceivedQty",  RecevedQty),
                new SqlParameter("@MTNNO",  MTNNO),
                new SqlParameter("@MaterialCode",  MaterialCode)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MTNMaterial_GRN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        //public int Issue_GRN(MTN objMTN)
        //{
        //    tblMTNMaterialTableAdapter da = new tblMTNMaterialTableAdapter();
        //    da.Connection = Connection;
        //    try
        //    {
        //        return Convert.ToInt32(da.SPUPDATE_GRN_MTN_ISSUE_MATERIAL_FOR_GRN(objMTN.MTNNo, objMTN.MTNStore.StoreID, objMTN.MTNGRN.GRNNo, Convert.ToInt32(MTN.Status.Approved), objMTN.MTNApprovedBy.EmployeeID));

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


        public int Delete(long MTNNO, String MaterialCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Original_MTNNO",  MTNNO),
                new SqlParameter("@Original_MTNMaterialCode",  MaterialCode)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MTNMaterial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public MTNMaterialCollc Get()
        {
            return null;
        }

        public MTNMaterial Get(long MTNNO, String MaterialCode)
        {
            Material_DL objMaterial_DL = new Material_DL(Connection);
            MTN_DL objMTN_DL = new MTN_DL(Connection);

            MTNMaterial objMTNMaterial = new MTNMaterial();

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Original_MTNNO",  MTNNO),
                new SqlParameter("@Original_MTNMaterialCode",  MaterialCode)
        };

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPDELETE_MTNMaterial", paramList);


                    objMTNMaterial.Material = objMaterial_DL.Get(Convert.ToString(dt.Rows[0]["MTNMaterialCode"]));
                    objMTNMaterial.Batch = "No";
                    objMTNMaterial.Description = Convert.ToString(dt.Rows[0]["MTNDescription"]);
                    objMTNMaterial.MTN = objMTN_DL.Get(Convert.ToInt64(dt.Rows[0]["MTNNO"]));
                    objMTNMaterial.TransferQty = Convert.ToDecimal(dt.Rows[0]["MTNTransferQty"]);
                    objMTNMaterial.UnitRate = Convert.ToDecimal(dt.Rows[0]["MTNUnitRate"]);
                    objMTNMaterial.ReceivedQty = Convert.ToDecimal(dt.Rows[0]["ReceivedQty"]);

                return objMTNMaterial;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


           
            

            
        }

        public MTNMaterialCollc GetByNo(long MTNNO)
        {

            MTNMaterialCollc objMTNMaterialCollc = new MTNMaterialCollc();
            Material_DL objMaterial_DL = new Material_DL(Connection);
            MTN_DL objMTN_DL = new MTN_DL(Connection);

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Original_MTNNO",  MTNNO)
        };

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPDELETE_MTNMaterial", paramList);


                for (int i = 0; i < dt.Rows.Count;i++)
                {
                    MTNMaterial objMTNMaterial = new MTNMaterial();

                    objMTNMaterial.Material = objMaterial_DL.Get(Convert.ToString(dt.Rows[0]["MTNMaterialCode"]));
                    objMTNMaterial.Batch = "No";
                    objMTNMaterial.Description = Convert.ToString(dt.Rows[0]["MTNDescription"]);
                    objMTNMaterial.MTN = objMTN_DL.Get(Convert.ToInt64(dt.Rows[0]["MTNNO"]));
                    objMTNMaterial.TransferQty = Convert.ToDecimal(dt.Rows[0]["MTNTransferQty"]);
                    objMTNMaterial.UnitRate = Convert.ToDecimal(dt.Rows[0]["MTNUnitRate"]);
                    objMTNMaterial.ReceivedQty = Convert.ToDecimal(dt.Rows[0]["ReceivedQty"]);

                    objMTNMaterialCollc.Add(objMTNMaterial);
                }
                return objMTNMaterialCollc;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


           

        }

        //-- New - -
        public System.Data.DataTable GetDataViewByMTNNO(long MTNNO)
        {

            MTNMaterialCollc objMTNMaterialCollc = new MTNMaterialCollc();
            Material_DL objMaterial_DL = new Material_DL(Connection);
            MTN_DL objMTN_DL = new MTN_DL(Connection);

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Original_MTNNO",  MTNNO)
        };

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPDELETE_MTNMaterial", paramList);
                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


    }
}
