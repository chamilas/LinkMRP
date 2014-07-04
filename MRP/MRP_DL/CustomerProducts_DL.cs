using DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using SESD.MRP.REF;

namespace MRP_DL
{
    public class CustomerProducts_DL
    {
        SqlConnection Connection = new SqlConnection();
        private SqlConnection sqlConnection;

        public CustomerProducts_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(CustomerProducts obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", obj.Customer_Code),
                new SqlParameter("@BasicProductCode", obj.Basic_Product_ID),
                new SqlParameter("@DiscountType", obj.Discount_Type),
                new SqlParameter("@PrincePerQuantity", obj.Price_Per_Quantity),
                new SqlParameter("@DiscountPerQuantity", obj.Discount_Per_Quantity),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_CustomerProducts", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetPricePerItem()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerProductPerPrice");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetDiscountPerItem()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerProductPerDiscount");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public List<string> GetCustomersProductCategory(int customerID)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@ID", customerID) };
                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerProductCatList", paramList);
                List<string> list = new List<string>();

                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(dr[0].ToString());
                }



                return list;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public List<string> GetCustomersProductList(string text)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@ProductCatID", text) };
                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerProductList", paramList);
                List<string> list = new List<string>();

                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(dr[0].ToString() + "-" + dr[1].ToString());
                }



                return list;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public List<string> GetCustomersProduct(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@Customer_Code", id) };
                dt = Execute.RunSP_DataTable(Connection, "SPGET_ProductsByCustomers", paramList);
                List<string> list = new List<string>();

                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(dr[0].ToString() + "-" + dr[1].ToString());
                }



                return list;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int IsAddedProduct(int CustomerID, string productCode)
        {
            try
            {
                DataTable dt = new DataTable();
                int rows = 0;
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@C_ID", CustomerID), new SqlParameter("@B_code", productCode) };

                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerProduct_ADDED", paramList);

                foreach (DataRow dr in dt.Rows)
                {
                    rows++;
                }
                return rows;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long CustomerProductRemove(int CustomerID, string productCode)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@C_ID", CustomerID),
                new SqlParameter("@B_code", productCode),
        };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_CustomerProduct_REMOVE", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
