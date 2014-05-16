using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class GRNBasicProducts_DL
    {
        SqlConnection Connection = new SqlConnection();

        BasicProduct_DL objBasicProduct_DL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        GRN_DL objGRN_DL = new GRN_DL(ConnectionStringClass.GetConnection());


        public GRNBasicProducts_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        

        public int Add(GRNBasicProducts obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", obj.GRN.GRNNo),
                new SqlParameter("@BasicProductCode", obj.BasicProduct.BasicProductCode),
                new SqlParameter("@GrossQty", obj.GrossQty),
                new SqlParameter("@NetQty", obj.NetQty),
                new SqlParameter("@UnitPrice", obj.UnitPrice),
                new SqlParameter("@Remarks", obj.Remarks)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_GRNBasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Delete(long GRNNO, String BasicProductCode)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_GRNNO", GRNNO),
                new SqlParameter("@Original_BasicProductCode", BasicProductCode)};

                return Execute.RunSP_RowsEffected(Connection, "SDDELETE_GRNBasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(GRNBasicProducts obj, long GRNNO, String BasicProductCode)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", obj.GRN.GRNNo),
                new SqlParameter("@BasicProductCode", obj.BasicProduct.BasicProductCode),
                new SqlParameter("@GrossQty", obj.GrossQty),
                new SqlParameter("@NetQty", obj.NetQty),
                new SqlParameter("@UnitPrice", obj.UnitPrice),
                new SqlParameter("@Remarks", obj.Remarks),
                 new SqlParameter("@Original_GRNNO", GRNNO),
                new SqlParameter("@Original_BasicProductCode", BasicProductCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_GRNBasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public GRNBasicProductsCollec Get()
        {
            try
            {


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_GRNBasicProduct");


                GRNBasicProductsCollec objGRNBasicProductsCollec = new GRNBasicProductsCollec();



                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    GRNBasicProducts objGRNBasicProduct = new GRNBasicProducts();

                    objGRNBasicProduct.BasicProduct= objBasicProduct_DL.Get(Convert.ToString(dt.Rows[i]["BasicProductCode"]));
                    objGRNBasicProduct.GRN = objGRN_DL.Get(Convert.ToInt64(dt.Rows[i]["GRNNO"]));
                    objGRNBasicProduct.GrossQty = Convert.ToDecimal(dt.Rows[i]["GrossQty"]);
                    objGRNBasicProduct.NetQty = Convert.ToDecimal(dt.Rows[i]["NetQty"]);
                    objGRNBasicProduct.Remarks = Convert.ToString(dt.Rows[i]["Remarks"]);
                    objGRNBasicProduct.UnitPrice = Convert.ToDecimal(dt.Rows[i]["UnitPrice"]);

                    objGRNBasicProductsCollec.Add(objGRNBasicProduct);
                }


                return objGRNBasicProductsCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public GRNBasicProducts Get(long GRNNO, String BasicProductCode)
        {
            try
            {


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_GRNBasicProduct_ByID");


                GRNBasicProducts objGRNBasicProduct = new GRNBasicProducts();


                    objGRNBasicProduct.BasicProduct = objBasicProduct_DL.Get(Convert.ToString(dt.Rows[0]["BasicProductCode"]));
                    objGRNBasicProduct.GRN = objGRN_DL.Get(Convert.ToInt64(dt.Rows[0]["GRNNO"]));
                    objGRNBasicProduct.GrossQty = Convert.ToDecimal(dt.Rows[0]["GrossQty"]);
                    objGRNBasicProduct.NetQty = Convert.ToDecimal(dt.Rows[0]["NetQty"]);
                    objGRNBasicProduct.Remarks = Convert.ToString(dt.Rows[0]["Remarks"]);
                    objGRNBasicProduct.UnitPrice = Convert.ToDecimal(dt.Rows[0]["UnitPrice"]);


                    return objGRNBasicProduct;


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
                new SqlParameter("@BasicProductCode", Code)};

                return Execute.RunSP_Decimal(Connection, "SPGET_GRN_ISSUE_BasicProduct_Available",paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }
    }
}
