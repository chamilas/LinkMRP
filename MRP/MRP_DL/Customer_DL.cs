using DL;
using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DL
{
    public class Customer_DL
    {
        SqlConnection Connection = new SqlConnection();
        private SqlConnection sqlConnection;

        public Customer_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }



        public long Add(Customer obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@CustomerID", obj.CustomerID),
                new SqlParameter("@Name", obj.Name),
                new SqlParameter("@Address", obj.Address),
                new SqlParameter("@Telephone", obj.Telephone),
                new SqlParameter("@ProductType", obj.ProductType),
                new SqlParameter("@SalesMethod", obj.SalesMethod),
                new SqlParameter("@Territory", obj.Territory),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Customer", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long Delete(String CustomerID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@CustomerID",CustomerID)};

                return Execute.RunSP_Int(Connection, "SPDELETE_Customer", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }




        public DataTable GetDistributorTerritory(string Category)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Category", Category)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_DistributorTerritoryList", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetTerritoryByCustomerID(string CustomerID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@CustomerID", CustomerID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_CustomerTerritory_ByID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GegCustomerBySalesMethod(string SalesMethod)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SalesMethod", SalesMethod)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_CustomersBySalesMethod", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetFinishProduct()
        {
            try
            {
                return Execute.RunSP_DataTable(Connection, "SPGET_FinishProduct_DataView_All_RPT");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        private void CheckProductAvailability()
        {

        }

        public long AddCustomerTerritory(String CustomerID, String TerritoryID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {              
                new SqlParameter("@CustomerID", CustomerID),
                new SqlParameter("@TerritoryName", TerritoryID),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_CustomerTerritoryList", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);

            }
        }

        public DataTable GetCustomers()
        {
            try
            {
                return Execute.RunSP_DataTable(Connection, "SPGET_Customers");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

//------------------------------------------------------------------------------------------------------------
        //public long test(String year, String month, String week, String fcastid, String pid,String qty)
        public long test(SalesForecast obj1,SalesForecastDetails obj2)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                

                new SqlParameter("@prmYear", obj1.Year),
                new SqlParameter("@prmMonth", obj1.Month),
                new SqlParameter("@prmWeekID", obj1.WeekID),
                new SqlParameter("@SalesForecastID", obj2.SalesForecastID),
                new SqlParameter("@ProductCode", obj2.ProductCode),
                new SqlParameter("@Qty", obj2.Qty),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_RowsEffected(Connection, "zzz5", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
