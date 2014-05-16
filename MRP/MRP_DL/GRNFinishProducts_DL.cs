using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class GRNFinishProducts_DL
    {
        SqlConnection Connection = new SqlConnection();

        FinishProduct_DL objFinishProduct_DL = new FinishProduct_DL(ConnectionStringClass.GetConnection());
        GRN_DL objGRN_DL = new GRN_DL(ConnectionStringClass.GetConnection());

        public GRNFinishProducts_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(GRNFinishProducts obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", obj.GRN.GRNNo),
                new SqlParameter("@FinishProductCode", obj.FinishProducts.FinishProductCode),
                new SqlParameter("@GrossQty", obj.GrossQty),
                new SqlParameter("@NetQty", obj.NetQty),
                new SqlParameter("@UnitPrice", obj.UnitPrice),
                new SqlParameter("@Remarks", obj.Remarks)};

                return Execute.RunSP_RowsEffected(Connection, "SDADD_GRNFinishProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Delete(long GRNNO, String FinshProductCode)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_GRNNO", GRNNO),
                new SqlParameter("@Original_FinishProductCode", FinshProductCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_GRNFinishProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(GRNFinishProducts obj, long GRNNO, String FinishProductCode)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", obj.GRN.GRNNo),
                new SqlParameter("@FinishProductCode", obj.FinishProducts.FinishProductCode),
                new SqlParameter("@GrossQty", obj.GrossQty),
                new SqlParameter("@NetQty", obj.NetQty),
                new SqlParameter("@UnitPrice", obj.UnitPrice),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@Original_GRNNO",GRNNO),
                new SqlParameter("@Original_FinishProductCode",FinishProductCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_GRNFinishProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public GRNFinishProductsCollec Get()
        {
            
            try
            {


                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_GRNFinishProduct");


                GRNFinishProductsCollec objGRNFinishProductsCollec = new GRNFinishProductsCollec();

                  

                for (int i=0;i<dt.Rows.Count;i++)
                {
                    GRNFinishProducts objGRNFinishProduct = new GRNFinishProducts();

                    objGRNFinishProduct.FinishProducts = objFinishProduct_DL.Get(Convert.ToString(dt.Rows[i]["FinishProductCode"]));
                    objGRNFinishProduct.GRN = objGRN_DL.Get(Convert.ToInt64(dt.Rows[i]["GRNNO"]));
                    objGRNFinishProduct.GrossQty = Convert.ToDecimal(dt.Rows[i]["GrossQty"]);
                    objGRNFinishProduct.NetQty = Convert.ToDecimal(dt.Rows[i]["NetQty"]);
                    objGRNFinishProduct.Remarks = Convert.ToString(dt.Rows[i]["Remarks"]);
                    objGRNFinishProduct.UnitPrice = Convert.ToDecimal(dt.Rows[i]["UnitPrice"]);

                    objGRNFinishProductsCollec.Add(objGRNFinishProduct);
                }


                return objGRNFinishProductsCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


            }


        public GRNFinishProducts Get(long GRNNO, String FinishProductCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", GRNNO),
                new SqlParameter("@FinishProductCode",FinishProductCode)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_GRNFinishProduct_ByID");


                GRNFinishProducts objGRNFinishProduct = new GRNFinishProducts();


                    objGRNFinishProduct.FinishProducts = objFinishProduct_DL.Get(Convert.ToString(dt.Rows[0]["FinishProductCode"]));
                    objGRNFinishProduct.GRN = objGRN_DL.Get(Convert.ToInt64(dt.Rows[0]["GRNNO"]));
                    objGRNFinishProduct.GrossQty = Convert.ToDecimal(dt.Rows[0]["GrossQty"]);
                    objGRNFinishProduct.NetQty = Convert.ToDecimal(dt.Rows[0]["NetQty"]);
                    objGRNFinishProduct.Remarks = Convert.ToString(dt.Rows[0]["Remarks"]);
                    objGRNFinishProduct.UnitPrice = Convert.ToDecimal(dt.Rows[0]["UnitPrice"]);



                    return objGRNFinishProduct;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public Decimal Get_AvailableQty(long GRNNO, String Code)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", GRNNO),
                new SqlParameter("@FinishProductCode",Code)};

                return Execute.RunSP_Decimal(Connection, "SPGET_GRN_ISSUE_FinishProduct_Available", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        
    }
}
