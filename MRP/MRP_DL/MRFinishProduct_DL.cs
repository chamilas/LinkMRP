using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MRFinishProduct_DL
    {
        SqlConnection Connection = new SqlConnection();

        FinishProduct_DL objFinishProduct_DL = new FinishProduct_DL(ConnectionStringClass.GetConnection());
        Formula_DL objFormula_DL = new Formula_DL(ConnectionStringClass.GetConnection());
        MR_DL objMR_DL = new MR_DL(ConnectionStringClass.GetConnection());


        public MRFinishProduct_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public int Add(MRFinishProduct obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", obj.MR.MRNO),
                new SqlParameter("@MRFinishProductID", obj.FinishProduct.FinishProductCode),
                new SqlParameter("@MRDescription", obj.Description),
                new SqlParameter("@MRReqdQty", obj.ReqdQty),
                new SqlParameter("@MRIssuedQty", obj.IssuedQty),
                new SqlParameter("@MRBINNo", obj.MRBINNo)
                
             };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MRFinishProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(MRFinishProduct obj,long OriginalMRNO,String OriginalFinishProductCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", obj.MR.MRNO),
                new SqlParameter("@MRFinishProductID", obj.FinishProduct.FinishProductCode),
                new SqlParameter("@MRDescription", obj.Description),
                new SqlParameter("@MRReqdQty", obj.ReqdQty),
                new SqlParameter("@MRIssuedQty", obj.IssuedQty),
                new SqlParameter("@MRBINNo", obj.MRBINNo),
                new SqlParameter("@Original_MRNO",OriginalMRNO),
                new SqlParameter("@Original_MRFinishProductID", OriginalFinishProductCode)

                
             };

                return Execute.RunSP_RowsEffected(Connection, "SPGET_MRBasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long MRNO, String FinishProductCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Original_MRNO",MRNO),
                new SqlParameter("@Original_MRFinishProductID", FinishProductCode)

                
             };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MRFinishProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public MRFinishProductCollec Get()
        {
           try
            {


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MRFinishProduct");

                MRFinishProductCollec objMRFinishProductCollec = new MRFinishProductCollec();

                for (int i = 0; i < dt.Rows.Count;i++ )
                {
                    MRFinishProduct objMRFinishProduct = new MRFinishProduct();
                    objMRFinishProduct.FinishProduct = objFinishProduct_DL.Get(Convert.ToString(dt.Rows[i]["MRFinishProductID"]));
                    objMRFinishProduct.Description = Convert.ToString(dt.Rows[i]["MRDescription"]);
                    objMRFinishProduct.MR = objMR_DL.Get(Convert.ToInt64(dt.Rows[i]["MRIssuedQty"]));
                    objMRFinishProduct.MRBINNo = Convert.ToString(dt.Rows[i]["MRIssuedQty"]);
                    objMRFinishProduct.ReqdQty = Convert.ToDecimal(dt.Rows[i]["MRIssuedQty"]);
                    objMRFinishProduct.IssuedQty = Convert.ToDecimal(dt.Rows[i]["MRIssuedQty"]);
                    //objMRFinishProduct.UniRate = Convert.ToDecimal(dr.MRUnitRate);

                    if (dt.Rows[i]["MRIssuedQty"]!=null)
                    {
                        objMRFinishProduct.UniRate = Convert.ToDecimal(dt.Rows[i]["MRIssuedQty"]);
                    }
                    else
                    {
                        objMRFinishProduct.UniRate = 0;
                    }

                    objMRFinishProductCollec.Add(objMRFinishProduct);

                   

                }
                return objMRFinishProductCollec;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


                
                

        }

        public MRFinishProductCollec Get(long MRNO)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", MRNO)
                
             };



             DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MRFinishProducts_ByMRNO",paramList);

                MRFinishProductCollec objMRFinishProductCollec = new MRFinishProductCollec();

                for (int i = 0; i < dt.Rows.Count;i++ )
                {
                    MRFinishProduct objMRFinishProduct = new MRFinishProduct();
                    objMRFinishProduct.FinishProduct = objFinishProduct_DL.Get(Convert.ToString(dt.Rows[i]["MRFinishProductID"]));
                    objMRFinishProduct.Description = Convert.ToString(dt.Rows[i]["MRDescription"]);
                    objMRFinishProduct.MR = objMR_DL.Get(Convert.ToInt64(dt.Rows[i]["MRNO"]));
                    objMRFinishProduct.MRBINNo = Convert.ToString(dt.Rows[i]["MRBINNo"]);
                    objMRFinishProduct.ReqdQty = Convert.ToDecimal(dt.Rows[i]["ReqdQty"]);
                    objMRFinishProduct.IssuedQty = Convert.ToDecimal(dt.Rows[i]["IssuedQty"]);
                    objMRFinishProduct.UnitCode = "Nos";


                    if (dt.Rows[i]["MRUnitRate"] != DBNull.Value)
                    {
                        objMRFinishProduct.UniRate = Convert.ToDecimal(dt.Rows[i]["MRUnitRate"]);
                    }
                    else
                    {
                        objMRFinishProduct.UniRate = 0;
                    }

                    objMRFinishProductCollec.Add(objMRFinishProduct);

                   

                }
                return objMRFinishProductCollec;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public MRFinishProduct Get(long MRNO, String FinishProductCode)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", MRNO),
                new SqlParameter("@FinishProductCode", FinishProductCode)
                
             };



                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MRFinishProductCode", paramList);

                MRFinishProduct objMRFinishProduct = new MRFinishProduct();

                objMRFinishProduct.FinishProduct = objFinishProduct_DL.Get(Convert.ToString(dt.Rows[0]["MRFinishProductID"]));
                objMRFinishProduct.Description = Convert.ToString(dt.Rows[0]["MRDescription"]);
                objMRFinishProduct.MR = objMR_DL.Get(Convert.ToInt64(dt.Rows[0]["MRNO"]));
                objMRFinishProduct.MRBINNo = Convert.ToString(dt.Rows[0]["MRBINNo"]);
                objMRFinishProduct.ReqdQty = Convert.ToDecimal(dt.Rows[0]["MRReqdQty"]);
                objMRFinishProduct.IssuedQty = Convert.ToDecimal(dt.Rows[0]["MRIssuedQty"]);
                    //objMRFinishProduct.UniRate = Convert.ToDecimal(dr.MRUnitRate);

                    if (dt.Rows[0]["MRIssuedQty"] != null)
                    {
                        objMRFinishProduct.UniRate = Convert.ToDecimal(dt.Rows[0]["MRIssuedQty"]);
                    }
                    else
                    {
                        objMRFinishProduct.UniRate = 0;
                    }

                    return objMRFinishProduct;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }
        

              public System.Data.DataTable GetData_View(long MRNO)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", MRNO)
                
             };
                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MRFinishProducts_By_MRNO", paramList);


                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public System.Data.DataTable GetDataView(long MRNO)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", MRNO)
                
             };
                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MRFinishProducts_ByMRNO", paramList);


                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public int Issue(MRFinishProduct obj, String StoreID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@MRNO", obj.MR.MRNO),
                new SqlParameter("@MRItemCode", obj.FinishProduct.FinishProductCode),
                 new SqlParameter("@StoreID", StoreID),
                new SqlParameter("@MRIssuedQty", obj.IssuedQty)
                
             };
                return Execute.RunSP_Int(Connection, "SPUPDATE_MRFinishProduct_Issue", paramList);
            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Get_StockByStore(String StoreID, String FinishProductCode, Decimal IssuedQty)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID", StoreID),
                new SqlParameter("@MRItemCode", FinishProductCode),
                new SqlParameter("@IssuedQty", IssuedQty)
                
             };
                return Execute.RunSP_Int(Connection, "SPGET_MRFinishProduct_StockByStoreID", paramList);
            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
