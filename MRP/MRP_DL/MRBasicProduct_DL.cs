using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MRBasicProduct_DL
    {
        
        SqlConnection Connection = new SqlConnection();

        BasicProduct_DL objBasicProduct_DL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        MR_DL objMR_DL = new MR_DL(ConnectionStringClass.GetConnection());


        public MRBasicProduct_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(MRBasicProduct obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", obj.MR.MRNO),
                new SqlParameter("@MRBasicProductID", obj.BasicProduct.BasicProductCode),
                new SqlParameter("@MRDescription", obj.Description),
                new SqlParameter("@MRReqdQty", obj.ReqdQty),
                new SqlParameter("@MRIssuedQty", obj.IssuedQty),
                new SqlParameter("@MRBINNo", obj.MRBINNo)
                
             };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MRBasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(MRBasicProduct obj,long OriginalMRNO,String OriginalBasicProductCode)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", obj.MR.MRNO),
                new SqlParameter("@MRBasicProductID", obj.BasicProduct.BasicProductCode),
                new SqlParameter("@MRDescription", obj.Description),
                new SqlParameter("@MRReqdQty", obj.ReqdQty),
                new SqlParameter("@MRIssuedQty", obj.IssuedQty),
                new SqlParameter("@MRBINNo", obj.MRBINNo),
                new SqlParameter("@MRUnitRate",  obj.UniRate),
                 new SqlParameter("@Original_MRNO", OriginalMRNO),
                new SqlParameter("@Original_MRBasicProductID",OriginalBasicProductCode),
                
             };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MRBasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long MRNO,String BasicProductCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@Original_MRNO", MRNO),
                new SqlParameter("@Original_MRBasicProductID",BasicProductCode),
                
             };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MRBasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public MRBasicProductCollec Get()
        {

            try
            {

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_MRBasicProduct");

                MRBasicProductCollec objMRBasicCollec = new MRBasicProductCollec();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    MRBasicProduct objMRBasicProduct = new MRBasicProduct();
                    objMRBasicProduct.BasicProduct = objBasicProduct_DL.Get(Convert.ToString(dt.Rows[i]["MRBasicProductID"]));
                    objMRBasicProduct.Description = Convert.ToString(dt.Rows[i]["MRDescription"]);
                    objMRBasicProduct.MR = objMR_DL.Get(Convert.ToInt64(dt.Rows[i]["MRNO"]));
                    objMRBasicProduct.MRBINNo = Convert.ToString(dt.Rows[i]["MRBINNo"]);
                    objMRBasicProduct.ReqdQty = Convert.ToDecimal(dt.Rows[i]["MRReqdQty"]);
                    objMRBasicProduct.IssuedQty = Convert.ToDecimal(dt.Rows[i]["MRIssuedQty"]);


                    if (dt.Rows[i]["MRUnitRate"] != null)
                    {
                        objMRBasicProduct.UniRate = Convert.ToDecimal(dt.Rows[i]["MRUnitRate"]);
                    }
                    else
                    {
                        objMRBasicProduct.UniRate = 0;
                    }

                    objMRBasicCollec.Add(objMRBasicProduct);


                }
                return objMRBasicCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


           

           

        }


        public MRBasicProductCollec Get(long MRNO)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@MRNO", MRNO)
                
                
             };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MRBasicProduct_By_MR",paramList);

                MRBasicProductCollec objMRBasicCollec = new MRBasicProductCollec();
                if(dt.Rows.Count>0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        MRBasicProduct objMRBasicProduct = new MRBasicProduct();
                        objMRBasicProduct.BasicProduct = objBasicProduct_DL.Get(Convert.ToString(dt.Rows[i]["MRMaterialCode"]));
                        objMRBasicProduct.Description = Convert.ToString(dt.Rows[i]["MRDescription"]);
                        objMRBasicProduct.MR = objMR_DL.Get(Convert.ToInt64(dt.Rows[i]["MRNO"]));
                        objMRBasicProduct.MRBINNo = Convert.ToString(dt.Rows[i]["MRBINNo"]);
                        objMRBasicProduct.ReqdQty = Convert.ToDecimal(dt.Rows[i]["MRReqdQty"]);
                        objMRBasicProduct.IssuedQty = Convert.ToDecimal(dt.Rows[i]["MRIssuedQty"]);
                        objMRBasicProduct.UnitCode = objMRBasicProduct.BasicProduct.BasicProductUnit.UnitCode;
                        objMRBasicProduct.Item = objMRBasicProduct.BasicProduct.BasicProductCode + " - " + objMRBasicProduct.BasicProduct.BasicProductDescription;
                        objMRBasicProduct.ItemCode = objMRBasicProduct.BasicProduct.BasicProductCode;

                        if (dt.Rows[i]["MRUnitRate"] != null)
                        {
                            objMRBasicProduct.UniRate = Convert.ToDecimal(dt.Rows[i]["MRUnitRate"]);
                        }
                        else
                        {
                            objMRBasicProduct.UniRate = 0;
                        }

                        objMRBasicCollec.Add(objMRBasicProduct);

                    }
                }
                return objMRBasicCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public MRBasicProduct Get(long MRNO, String BasicProductCode)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@MRNO", MRNO),
                 new SqlParameter("@BasicProductCode", BasicProductCode)
                
                
             };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MRBasicProductByID", paramList);

                MRBasicProduct objMRBasicProduct = new MRBasicProduct();

                    objMRBasicProduct.BasicProduct = objBasicProduct_DL.Get(Convert.ToString(dt.Rows[0]["MRBasicProductID"]));
                    objMRBasicProduct.Description = Convert.ToString(dt.Rows[0]["MRDate"]);
                    objMRBasicProduct.MR = objMR_DL.Get(Convert.ToInt64(dt.Rows[0]["MRNO"]));
                    objMRBasicProduct.MRBINNo = Convert.ToString(dt.Rows[0]["MRBINNo"]);
                    objMRBasicProduct.ReqdQty = Convert.ToDecimal(dt.Rows[0]["MRReqdQty"]);
                    objMRBasicProduct.IssuedQty = Convert.ToDecimal(dt.Rows[0]["MRIssuedQty"]);


                    if (dt.Rows[0]["MRDate"] != null)
                    {
                        objMRBasicProduct.UniRate = Convert.ToDecimal(dt.Rows[0]["MRUnitRate"]);
                    }
                    else
                    {
                        objMRBasicProduct.UniRate = 0;
                    }

                    return objMRBasicProduct;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

           public System.Data.DataTable GetBasicProductList(long MRNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", MRNO)
                
             };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MRBasicProducts_ByMRNO_Dataview", paramList);

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


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MRBasicProduct_By_MR", paramList);

                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Issue(MRBasicProduct obj, String StoreID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@MRNO", obj.MR.MRNO),
                 new SqlParameter("@MRItemCode", obj.ItemCode),
                 new SqlParameter("@MRIssuedQty", obj.IssuedQty),
                 new SqlParameter("@StoreID", StoreID)


             };


                return Execute.RunSP_Int(Connection, "SPUPDATE_MRBasicProduct_Issue", paramList);




            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Get_StockByStore(String StoreID, String BasicProductCode, Decimal IssuedQty)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@MRItemCode", BasicProductCode),
                 new SqlParameter("@MRIssuedQty", IssuedQty),
                 new SqlParameter("@StoreID", StoreID)
                
                
             };


                return Execute.RunSP_Int(Connection, "SPGET_MRBasicProduct_StockByStoreID", paramList);




            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public System.Data.DataTable Get_RequestedSemiFinished(string BatchNo, string PartNo)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchNo),
                 new SqlParameter("@PartID", PartNo)
                
             };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_SemiFinishedRequested_By_BatchID_Part", paramList);

                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


    }
}
