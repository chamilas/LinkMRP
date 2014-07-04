using DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MRP_DL
{
    public class OrderSorting_DL
    {
        SqlConnection Connection = new SqlConnection();
        private SqlConnection sqlConnection;

        public OrderSorting_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public DataTable GetUnsortedOrders()
        {
            try
            {
                return Execute.RunSP_DataTable(Connection, "SPGET_UnsortedOrders");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetOrderDetails(string ID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@ID", ID) };
                return Execute.RunSP_DataTable(Connection, "SPGET_OrderDetails", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetOrderDetailsByManager(string ID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@ID", ID) };
                return Execute.RunSP_DataTable(Connection, "SPGET_OrderDetailsByManager", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long UpdateOrderDetails(string OrderID,string ProductId,int Quantity, string Batch)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@OrderID", OrderID),
                new SqlParameter("@ProductID", ProductId),
                new SqlParameter("@Assign_Quantity", Quantity),
                new SqlParameter("@Batch", Batch)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_OrderDetails", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long UpdateQuantityReserved(string ProductId, int Quantity)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ID", ProductId),
                new SqlParameter("@Quantity", Quantity)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_StockReserve", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int IsComplete(string ID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@OrderID", ID) };
                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_OrderComplete", paramList);
                int rows = 0;
                foreach(DataRow dr in dt.Rows)
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

        public long UpdateOrderState(string OrderID, int State)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@OrderID", OrderID),
                new SqlParameter("@State", State),

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_OrderState", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetOrdersBySate(int state)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@State", state) };
                return Execute.RunSP_DataTable(Connection, "SPGET_UnsortedOrdersByState", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public void Reserved(string OrderID)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@OrderID", OrderID) };
                dt=Execute.RunSP_DataTable(Connection, "SPGET_ProductsForUpdate", paramList);

                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] paramList1 = new SqlParameter[] {
                
                        new SqlParameter("@ProductID", dr[0].ToString()),
                        new SqlParameter("@Quantity", Int32.Parse(dr[1].ToString())),

                        };

                     Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Stock_ReserveQuantity", paramList1);
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public void Confirm_Reserved(string OrderID)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@OrderID", OrderID) };
                dt = Execute.RunSP_DataTable(Connection, "SPGET_ProductsForUpdate", paramList);

                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] paramList1 = new SqlParameter[] {
                
                        new SqlParameter("@ProductID", dr[0].ToString()),
                        new SqlParameter("@Quantity", Int32.Parse(dr[1].ToString())),

                        };

                    Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Stock_ReserveQuantity_Confirm", paramList1);
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public string GetOrderIDByInvoiceID(string ID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@InvoiceID", ID) };
                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_OrderIDByInvoiceID", paramList);
                string id = "";
                foreach (DataRow dr in dt.Rows)
                {
                    id = dr[0].ToString();
                }
                return id;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetIncompleteInvoices()
        {
            try
            {
                return Execute.RunSP_DataTable(Connection, "SPGET_IncomleteInvoices");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int GetQuantity(string ID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@ID", ID) };
                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_StockQuantityByProductID", paramList);
                int rows = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    rows= int.Parse(dr[0].ToString());
                }
                return rows;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
