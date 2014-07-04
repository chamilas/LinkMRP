using DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MRP_DL
{
    public class NewOrder_DL
    {
        SqlConnection Connection = new SqlConnection();
        private SqlConnection sqlConnection;

        public NewOrder_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long AddTemp(string productID, int quantity)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProductID", productID),
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_TempProducts", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetTempProducts()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = Execute.RunSP_DataTable(Connection, "SPGET_TempProducts");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long Remove_TempProducts(string ProductId)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Product_Code", ProductId),
        };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_TempProducts", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int IsAddedProduct(string productID)
        {
            try
            {
                DataTable dt = new DataTable();
                int rows = 0;
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@ProductID", productID) };

                dt = Execute.RunSP_DataTable(Connection, "SPGET_TempProducts_ADDED", paramList);

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

        public void Clear_TempProducts()
        {

            try
            {

                Execute.RunSP_DataTable(Connection, "SPDELETE_TempProducts_CLEAR");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public string GetNewOrderID()
        {
            try
            {
                DataTable dt = new DataTable();
                string ID = "";

                dt = Execute.RunSP_DataTable(Connection, "SPGET_NewOrderID");

                foreach (DataRow dr in dt.Rows)
                {
                    ID = dr[0].ToString();
                }
                return ID;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long AddOrder(string orderID, int customer_Code, int State)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@OrderID ", orderID),
                new SqlParameter("@Customer_Code ", customer_Code),
                new SqlParameter("@State", State)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Order_NEW", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public long AddOrderDetails(string orderID, string productID, int Quantity, int Assign_Quantity)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@OrderID ", orderID),
                new SqlParameter("@ProductID ", productID),
                new SqlParameter("@Quantity", Quantity),
                new SqlParameter("@Assign_Quantity", Assign_Quantity)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_OrderDetails", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public bool FillDetails(int CustomerID)
        {

            try
            {
                string OrderID=GetNewOrderID();
                DataTable dt = GetTempProducts();
                long rows = AddOrder(OrderID, CustomerID,0);

                if (rows > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        AddOrderDetails(OrderID, dr[0].ToString().Split('-')[0], int.Parse(dr[1].ToString()), 0);
                    }

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
