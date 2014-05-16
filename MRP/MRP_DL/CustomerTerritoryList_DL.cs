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
    public class CustomerTerritoryList_DL
    {
        SqlConnection Connection = new SqlConnection();
        private SqlConnection sqlConnection;

        public CustomerTerritoryList_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(CustomerTerritoryList obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@CustomerID", obj.CustomerID),
                new SqlParameter("@TerritoryName", obj.TerritoryName),
                new SqlParameter("@TerritoryID", obj.TerritoryID),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_CustomerTerritoryList", paramList);

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

                return Execute.RunSP_Int(Connection, "SPDELETE_CustomerTerritoryList", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetCustomerTerritoryListByID(string CustomerID)
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

    }
}
