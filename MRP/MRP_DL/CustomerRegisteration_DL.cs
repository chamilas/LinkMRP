using DL;
using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MRP_DL
{
    public class CustomerRegisteration_DL
    {
        SqlConnection Connection = new SqlConnection();
        private SqlConnection sqlConnection;

        public CustomerRegisteration_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(NewCustomer obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Name", obj.Name),
                new SqlParameter("@OtherNames", obj.OtherNames),
                new SqlParameter("@Address", obj.Address),
                new SqlParameter("@CustomerType", obj.Customer_Type),
                new SqlParameter("@Category", obj.Category),
                new SqlParameter("@Area", obj.Area),
                new SqlParameter("@Discount_Type", obj.Discount_Type),
                new SqlParameter("@Discount_Apply", obj.Discount_Apply),
                new SqlParameter("@Credits_Limits", obj.Credits_Limits),
                new SqlParameter("@Status", 0),
                new SqlParameter("@UserID", obj.UserID),
                new SqlParameter("@Active", 0),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_NewCustomer", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public long AddCompanyRegDetails(CompanyRegDetails obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", obj.Customer_Code),
                new SqlParameter("@CompanyRegNum", obj.CompanyRegNum),
                new SqlParameter("@BusinessRegNum", obj.BusinessRegNum),
                new SqlParameter("@VatRegNum", obj.VatRegNum),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@UserID", obj.UserID)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_NewCustomerCompanyRegDetails", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long AddCompanyDetails(CompanyDetails obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", obj.Customer_Code),
                new SqlParameter("@Owner_name", obj.Owner_name),
                new SqlParameter("@Telephone", obj.Telephone),
                new SqlParameter("@Fax", obj.Fax),
                new SqlParameter("@Email", obj.Email),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@UserID", obj.UserID)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_NewCustomerCompanyDetails", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long AddCompanyFinanceDetails(FinanceDetails obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", obj.Customer_Code),
                new SqlParameter("@Bank_Guaranty_Amount", obj.Bank_Guaranty_Amount),
                new SqlParameter("@Guaranty_Bank", obj.Guaranty_Bank),
                new SqlParameter("@Branch", obj.Branch),
                new SqlParameter("@Bank_Guaranty_Exceed_Pre", obj.Bank_Guaranty_Exceed_Pre),
                new SqlParameter("@Renew_Date", obj.Renew_Date),
                new SqlParameter("@Remaing_Dates", obj.Remaing_Dates),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@UserID", obj.UserID)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_NewCustomerFinanceDetails", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long AddCompanyTransactionDetails(TransactionDetails obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", obj.Customer_Code),
                new SqlParameter("@Opening_Balanace", obj.Opening_Balanace),
                new SqlParameter("@Recived_Cheques", obj.Recived_Cheques),
                new SqlParameter("@Return_Cheques", obj.Return_Cheques),
                new SqlParameter("@Due_Amount", obj.Due_Amount),
                new SqlParameter("@Customer_Status", obj.Customer_Status),
                new SqlParameter("@Status", obj.Status),
                new SqlParameter("@UserID", obj.UserID)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_NewCustomerTransactionDetails", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long AddFinanceNotes(AuthorizedNotes obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", obj.Customer_Code),
                new SqlParameter("@Note_From_Finance", obj.Note_From_Finance),
                new SqlParameter("@UserID_Finace", obj.UserID_Finace)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_NewCustomerAuthorizedNotes_Finance", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long AddSalesNotes(AuthorizedNotes obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", obj.Customer_Code),
                new SqlParameter("@Note_From_Finance", obj.Note_From_Sales),
                new SqlParameter("@UserID_Sales", obj.UserID_Sales)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_NewCustomerAuthorizedNotes_Sales", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public long AddTerritory(int CustomerID, int TerritoryID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@CustomerID", CustomerID),
                new SqlParameter("@TerritoryID", TerritoryID),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_CustomerTerritory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long ApproveCompanyDetails(int Customer_Code, int Status, int UserID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", Customer_Code),
                new SqlParameter("@Status", Status),
                new SqlParameter("@UserID", UserID)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_ApproveNewCustomerCompanyDetails", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public long ApproveCompanyRegDetails(int Customer_Code, int Status, int UserID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", Customer_Code),
                new SqlParameter("@Status", Status),
                new SqlParameter("@UserID", UserID)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_ApproveNewCustomerCompanyReg", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public long ApproveCompanyFinanceDetails(int Customer_Code, int Status, int UserID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", Customer_Code),
                new SqlParameter("@Status", Status),
                new SqlParameter("@UserID", UserID)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_ApproveNewCustomerFinanceDetails", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public long ApproveCustomer(int Customer_Code, int Status, int UserID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", Customer_Code),
                new SqlParameter("@Status", Status),
                new SqlParameter("@UserID", UserID)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_ApproveNewCustomerMaster", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public long ApproveCustomerTransaction(int Customer_Code, int Status, int UserID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", Customer_Code),
                new SqlParameter("@Status", Status),
                new SqlParameter("@UserID", UserID)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_ApproveNewCustomerTransactionDetails", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public long UpadeCustomerName(int Customer_Code, string Name, int UserID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", Customer_Code),
                new SqlParameter("@Name", Name),
                new SqlParameter("@UserID", UserID)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_CustomerName", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public long UpadeCustomerAddress(int Customer_Code, string Address, int UserID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", Customer_Code),
                new SqlParameter("@Address", Address),
                new SqlParameter("@UserID", UserID)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_CustomerAddress", paramList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable AppCustomerMaster()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerMasterApp");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable AppCustomerCompanyDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerCompanyDetailsApp");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable AppCustomerCompanyRegDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerCompanyRegApp");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable AppCustomerFinanceDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerFinanceDetailsApp");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable AppCustomerTransactionDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerTransactionDetailsApp");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetCustomerCompanyRegDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerCompanyReg_Code");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetCustomerCompanyDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerCompanyDetails_Code");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetCustomerFinanceDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerFinanceDetails_Code");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetCustomerTransactionDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerTransactionDetails_Code");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetCustomerDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerMaster");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
