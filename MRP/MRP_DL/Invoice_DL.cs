using DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MRP_DL
{
    public class Invoice_DL
    {
        SqlConnection Connection = new SqlConnection();
        private SqlConnection sqlConnection;

        public Invoice_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public string GetNewInvoiceID()
        {
            try
            {
                DataTable dt = new DataTable();
                string ID = "";

                dt = Execute.RunSP_DataTable(Connection, "SPGET_NewInvoiceID");

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

        public long AddInvoiceDetails(string invoiceID,string productID, string productName, int quantity, double price)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@InvoiceID", invoiceID),
                new SqlParameter("@ProductID", productID),
                new SqlParameter("@ProductName", productName),
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@Price", price)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_InvoiceDetails", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public long AddInvoice(string invoiceID, string orderID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@InvoiceID", invoiceID),
                new SqlParameter("@OrderID", orderID)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Invoices", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetInvoiceByOrder(string orderID)
        {
            try
            {
                DataTable dt = new DataTable();

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ID", orderID)
        };

                dt = Execute.RunSP_DataTable(Connection, "SPGET_InvoiceByOrder_NEW",paramList);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public bool FillDetails(string OrderID)
        {

            try
            {
                string InvoiceID = GetNewInvoiceID();
                DataTable dt = GetInvoiceByOrder(OrderID);
                long rows = AddInvoice(InvoiceID,OrderID);

                if (rows > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        AddInvoiceDetails(InvoiceID, dr[0].ToString(), dr[1].ToString(), int.Parse(dr[2].ToString()), double.Parse(dr[3].ToString()));
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

        public DataTable GetInvoiceForApproval()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = Execute.RunSP_DataTable(Connection, "SPGET_InvoiceForApproval");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long UpdateInvoiceStatus(string invoiceID,  int approve, int cancel )
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@InvoiceID", invoiceID),
                new SqlParameter("@Approve", approve),
                new SqlParameter("@Cancel", cancel)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_InvoiceStatus", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetInvoiceForHigherApproval(int approve, int cancel)
        {
            try
            {
                DataTable dt = new DataTable();

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Approve", approve),
                new SqlParameter("@Cancel", cancel)
        };

                dt = Execute.RunSP_DataTable(Connection, "SPGET_InvoiceForhigherApproval", paramList);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetInvoice(string ID)
        {
            try
            {
                DataTable dt = new DataTable();

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ID", ID)
        };

                dt = Execute.RunSP_DataTable(Connection, "SPGET_InvoiceForPrint", paramList);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetDispatch(string ID)
        {
            try
            {
                DataTable dt = new DataTable();

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ID", ID)
        };

                dt = Execute.RunSP_DataTable(Connection, "SPGET_DispatchForPrint", paramList);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long UpdateDispatchStatus(string invoiceID, int approve)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@InvoiceID", invoiceID),
                new SqlParameter("@Dispatch", approve)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_InvoiceStatusDispatch", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public long UpdatePrintStatus(string invoiceID, int approve)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@InvoiceID", invoiceID),
                new SqlParameter("@Print", approve)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_InvoiceStatusPrint", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetDispatchPrint()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = Execute.RunSP_DataTable(Connection, "SPGET_InvoiceDispatch");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetInvoicePrint()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = Execute.RunSP_DataTable(Connection, "SPGET_InvoicePrint");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public double GetSumDetails(DataTable dt,int index)
        {
            try
            {
                double value = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    value = value + double.Parse(dr[index].ToString());
                }

                return value;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public string GetCustomerName(string id)
        {
            try
            {
                DataTable dt = new DataTable();
                string ch="";
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@ID", id) };

                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerNameByInvoiceID", paramList);

                foreach (DataRow dr in dt.Rows)
                {
                    ch = dr[0].ToString();
                }
                return ch;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
