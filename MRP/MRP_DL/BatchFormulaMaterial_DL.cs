using System;
using System.Collections.Generic;
using System.Text;
using DL;
using SESD.MRP.REF;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    public class BatchFormulaMaterial_DL
    {
        SqlConnection Connection = new SqlConnection();


        public BatchFormulaMaterial_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public int Add(BatchFormulaMaterial obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MaterialCode", obj.MaterialCode),
                new SqlParameter("@BatchID", obj.BatchID),
                new SqlParameter("@Qty",obj.Qty),
                new SqlParameter("@Part", obj.Part),
                new SqlParameter("@Type", obj.Type),
                new SqlParameter("@AddedBy", obj.AddedBy),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@Status", obj.Status),
     };

                return Execute.RunSP_Int(Connection, "SPADD_BatchFormulaMaterial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Delete(String Original_MaterialCode, String @Original_BatchID, String Part)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MaterialCode", Original_MaterialCode),
                new SqlParameter("@BatchID", @Original_BatchID),
                new SqlParameter("@Part", Part)
     };

                return Execute.RunSP_Int(Connection, "SPDELETE_BatchFormulaMaterial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(BatchFormulaMaterial obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MaterialCode", obj.MaterialCode),
                 new SqlParameter("@Qty", obj.Qty),
                new SqlParameter("@BatchID", obj.BatchID),
                new SqlParameter("@Part", obj.Part),
                 new SqlParameter("@AddedBy", obj.AddedBy),
                 new SqlParameter("@Remarks", obj.Remarks)
     };

                return Execute.RunSP_Int(Connection, "SPUPDATE_BatchFormulaMaterial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_Weigh(string BatchID, string Part, string WeighBy)
        {

            

        
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
               
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@Part", Part),
                 new SqlParameter("@WeighBy", WeighBy),
     };

                return Execute.RunSP_Int(Connection, "SPUPDATE_BatchFormulaMaterial_WeighAll", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

    public int Update_WeighCheck(string BatchID, string Part, string WeighCheckBy)
        {

        try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
               
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@Part", Part),
                 new SqlParameter("@WeighCheckBy", WeighCheckBy),
                                    };

                return Execute.RunSP_Int(Connection, "SPUPDATE_BatchFormulaMaterial_WeighCheckAll", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


    public DataTable GetMaterial_NotReceived(String BatchID)
    {
        try
        {


            SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID)
     };

            return Execute.RunSP_DataTable(Connection, "SPGET_BatchFormulaMaterial_NotReceived", paramList);

        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message, ex);
        }
    }

        public DataTable GetView(String BatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID)
     };

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchFormulaItems_By_BatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable GetMaterial(String BatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID)
     };

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchFormulaMaterial_By_BatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public DataTable GetView(String BatchID, String Part)
        {
            

             try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@Part", Part)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchFormulaMaterial_View_By_BatchID_Part", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable GetView_Full(String BatchID, String Part)
        {
            

             try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@Part", Part)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchFormula_Item_Qty_By_BatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Get_WeighedCount(String BatchID, String Part)
        {


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@Part", Part),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                };

                return Execute.RunSP_Output(Connection, "SPGET_BatchFormulaMaterial_WeighedCount", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

           public int Get_WeighCheckedCount(String BatchID, String Part)
        {


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@Part", Part),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                };

                return Execute.RunSP_Output(Connection, "SPGET_BatchFormulaMaterial_WeighCheckedCount", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        

        //public DataTable GetView_Qty(String BatchID, String Part)
        //{
        //    try
        //    {
        //        return daQtyView.GetDataByBatchID(Part,BatchID);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

    }
}
