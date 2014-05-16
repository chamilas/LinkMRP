using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class GRN_DL
    {
        SqlConnection Connection = new SqlConnection();

        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        MR_DL objMR_DL = new MR_DL(ConnectionStringClass.GetConnection());
        MTN_DL objMTN_DL = new MTN_DL(ConnectionStringClass.GetConnection());
        Store_DL objStore_DL = new Store_DL(ConnectionStringClass.GetConnection());

        public GRN_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public long Add(GRN obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNMTNNO", obj.GRNMTNNo),
                new SqlParameter("@GRNMRNO", obj.GRNMR),
                new SqlParameter("@GRNRPDBatchID", obj.GRNRPDBatch),
                new SqlParameter("@GRNDate", obj.GRNDate),
                new SqlParameter("@GRNApprovedBy", obj.GRNApprovedBy),
                new SqlParameter("@GRNApproveDate", obj.GRNApprovedDate),
                new SqlParameter("@GRNEnterdBy",  obj.GRNEnterdBy),
                new SqlParameter("@GRNStoreID", obj.GRNStore.StoreID),
                new SqlParameter("@GRNType", obj.GRNType),
                new SqlParameter("@GRNStatus", obj.GRNStatus)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_GRN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Add_Direct(GRN obj)
        {

             try
            {
                 SqlParameter GRNNO = new SqlParameter();
                 GRNNO.Direction= ParameterDirection.Output;

                 SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNEnterdBy", obj.GRNEnterdBy),
                new SqlParameter("@GRNStoreID", obj.GRNStore.StoreID),
                new SqlParameter("@GRNType", obj.GRNType),
                new SqlParameter("@GRNStatus", obj.GRNStatus),
                new SqlParameter("@GRNCategory", obj.GRNCategory),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}

               };


               return Execute.RunSP_Output(Connection, "SPADD_GRN_Direct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Add_Direct_TGRN(GRN obj, string DeliverNote, string DeliverPONO)
        {

            try
            {
                SqlParameter GRNNO = new SqlParameter();
                GRNNO.Direction = ParameterDirection.Output;

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNEnterdBy", obj.GRNEnterdBy),
                new SqlParameter("@GRNStoreID", obj.GRNStore.StoreID),
                new SqlParameter("@GRNType", obj.GRNType),
                new SqlParameter("@GRNStatus", obj.GRNStatus),
                new SqlParameter("@GRNCategory", obj.GRNCategory),
                new SqlParameter("@DeliverNoteID", DeliverNote),
                new SqlParameter("@DeliverPONO", DeliverPONO),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}

               };


                return Execute.RunSP_Output(Connection, "SPADD_GRN_Direct_TGRN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public long Add_MR(GRN obj)
        {
             try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNMRNO", obj.GRNMR),
                new SqlParameter("@GRNDate", obj.GRNDate),
                new SqlParameter("@GRNEnterdBy", obj.GRNEnterdBy),
                new SqlParameter("@GRNStoreID", obj.GRNStore.StoreID),
                new SqlParameter("@GRNType", obj.GRNType),
                new SqlParameter("@GRNStatus", obj.GRNStatus)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_GRN_MR", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            
        }


        public long Add_RPD(GRN obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", obj.GRNRPDBatch),
                new SqlParameter("@GRNDate", obj.GRNDate),
                new SqlParameter("@GRNEnterdBy", obj.GRNEnterdBy),
                new SqlParameter("@GRNStoreID", obj.GRNStore.StoreID),
                new SqlParameter("@GRNType", obj.GRNType),
                new SqlParameter("@GRNStatus", obj.GRNStatus),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output(Connection, "SPADD_GRN_RPD", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public long Add_MTN(GRN obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNMTNNO", obj.GRNMTNNo),
                new SqlParameter("@GRNDate", obj.GRNDate),
                new SqlParameter("@GRNApprovedBy", obj.GRNApprovedBy),
                new SqlParameter("@GRNApproveDate", obj.GRNApprovedDate),
                new SqlParameter("@GRNStoreID", obj.GRNStore.StoreID),
                new SqlParameter("@GRNType", obj.GRNType),
                new SqlParameter("@GRNStatus", obj.GRNStatus)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_GRN_MTN",paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(GRN obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNMTNNO", obj.GRNMTNNo),
                new SqlParameter("@GRNDate", obj.GRNDate),
                new SqlParameter("@GRNApprovedBy", obj.GRNApprovedBy),
                new SqlParameter("@GRNApproveDate", obj.GRNApprovedDate),
                new SqlParameter("@GRNStoreID", obj.GRNStore.StoreID),
                new SqlParameter("@GRNType", obj.GRNType),
                new SqlParameter("@GRNStatus", obj.GRNStatus)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_GRN_MTN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(long GRNNO,GRN.Status Status)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@GRNNO",GRNNO ),
                new SqlParameter("@GRNStatus",Status)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_GRN_STATUS", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Approve(GRN objGRN)
        {



            
            try
            {
                
                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@GRNNO",objGRN.GRNNo),
                new SqlParameter("@GRNApprovedBy",objGRN.GRNApprovedBy)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_GRN_APPROVE", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }

        public int Delete(long GRNNO)
        {


            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Original_GRNNO",GRNNO)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_GRN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public GRNCollec Get()
        {
            return null;
        }

        public GRN Get(long GRNNO)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@GRNNO",GRNNO)
                };

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_GRNByID", paramList);


                GRN objGRN = new GRN();

                objGRN.GRNApprovedBy = Convert.ToString(dt.Rows[0]["GRNApprovedBy"]);
                objGRN.GRNApprovedDate = Convert.ToDateTime(dt.Rows[0]["GRNApproveDate"]);
                objGRN.GRNDate = Convert.ToDateTime(dt.Rows[0]["GRNDate"]);
                objGRN.GRNEnterdBy = Convert.ToString(dt.Rows[0]["GRNEnterdBy"]);
                objGRN.GRNMR = Convert.ToInt64(dt.Rows[0]["GRNMRNO"]);
                objGRN.GRNMTNNo = Convert.ToInt64(dt.Rows[0]["GRNMTNNO"]);
                objGRN.GRNNo = Convert.ToInt64(dt.Rows[0]["GRNNO"]);
                objGRN.GRNRPDBatch = null;
                objGRN.GRNStore =objStore_DL.Get(Convert.ToString(dt.Rows[0]["GRNStoreID"]));
                objGRN.DeliverNoteID = Convert.ToString(dt.Rows[0]["DeliverNoteID"]);

                return objGRN;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            
              
              
        }

        public System.Data.DataTable GetDataView(String StoreID,GRN.Status Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@StoreID",StoreID),
                new SqlParameter("@Status",Status)
                };

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_GRN_DataviewByStatus", paramList);


                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable GetDataView(long DepID,DateTime From,DateTime To, GRN.Status Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Status",Status),
                new SqlParameter("@DateFrom",From),
                new SqlParameter("@DateTo",To),
                new SqlParameter("@DepID",DepID)
                };

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_GRN_Manage", paramList);


                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public void AddMTNItem(long MTNNO,String Code,long GRNNO,String Remarks,Decimal RecQty)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@ReceivedQty",MTNNO),
                new SqlParameter("@MTNNO",MTNNO),
                new SqlParameter("@Code",Code),
                new SqlParameter("@GRNNO",GRNNO),
                new SqlParameter("@Remarks",Remarks)
                };

                Execute.RunSP_DataTable(Connection, "SPADD_GRN_Item_MTN", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView_Items(long GRNNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@GRNNO",GRNNO)
                };

               return  Execute.RunSP_DataTable(Connection, "SPGET_GRN_ItemsByGRNNO", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView_Items_Print(long GRNNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@GRNNO",GRNNO)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_GRN_ItemsByGRNNO_Print", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_GEN_BY_Material(String MaterialCode,String StoreID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@MaterialCode",MaterialCode),
                new SqlParameter("@GRNStoreID",StoreID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_GRN_BY_MaterialCode", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public DataTable Get_By_Material_Store(String MaterialCode, String StoreID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@MaterialCode",MaterialCode),
                new SqlParameter("@GRNStoreID",StoreID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_GRN_By_Material_Store", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
        

  public DataTable Get_GRN_Batch(long GRNNO)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@GRNNO",GRNNO)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_GRN_Batch", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable Get_GEN_BY_BasicProduct(String BasicProductCode, String StoreID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@BasicProductCode",BasicProductCode),
                new SqlParameter("@StoreID",StoreID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_GRN_BY_BasicProduct", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_GEN_BY_FinishProduct(String FinishProductCode, String StoreID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@FinishProductCode",FinishProductCode),
                new SqlParameter("@StoreID",StoreID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_GRN_BY_FinishProduct", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable GetGRNBulkPrint(string GRNStoreID,int GRNType)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@GRNStoreID",GRNStoreID),
                 new SqlParameter("@GRNType",GRNType)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_GRN_BulkPrint_Dataview", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_BulkPrinted(long GRNNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@GRNNO",GRNNO)};


                int x=Execute.RunSP_Int(Connection, "SPUPDATE_GRN_GRNBulkPrint", paramList);

                return x;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


       

    }
}
