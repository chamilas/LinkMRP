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
    public class Territory_DL
    {
        SqlConnection Connection = new SqlConnection();
        private SqlConnection sqlConnection;

        public Territory_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(Territory obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Name", obj.Name),
                new SqlParameter("@SalesRep", obj.SalesRep),
                new SqlParameter("@District", obj.District),
                new SqlParameter("@RegionID", obj.RegionID),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Territory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public long IsAdd(Territory obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Name", obj.Name),
                new SqlParameter("@SalesRep", obj.SalesRep),
                new SqlParameter("@District", obj.District),
                new SqlParameter("@RegionID", obj.RegionID)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPGET_Territory_ADD", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long Assign_Territory(int CustomerID, int TerritoryID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@CustomerID", CustomerID),
                new SqlParameter("@TerritoryID", TerritoryID),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Assign_Territory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public List<string> GetTerritory()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_Territory");
                List<string> list = new List<string>();

                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(dr[1].ToString());
                }



                return list;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int GetTerritoryIDByName(string text)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_Territory");

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[1].ToString() == text)
                    {
                        return int.Parse(dr[0].ToString());
                    }
                }

                return 0;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public List<string> GetSalesRep()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_SalesRep");
                List<string> list = new List<string>();

                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(dr[1].ToString());
                }



                return list;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long GetSalesRepIDByName(string text)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_SalesRep");

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[1].ToString() == text)
                    {
                        return Int32.Parse(dr[0].ToString());
                    }
                }

                return 0;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public List<string> GetCustomers(string SalesMethodID)
        {
            try
            {
                DataTable dt = new DataTable();

                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@ID", SalesMethodID) };

                dt = Execute.RunSP_DataTable(Connection, "SPGET_Active_Customers",paramList);
                List<string> list = new List<string>();

                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(dr[1].ToString());
                }



                return list;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int GetCustomersIDByName(string text, string SalesMethodID)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@ID", SalesMethodID) };

                dt = Execute.RunSP_DataTable(Connection, "SPGET_Active_Customers", paramList);

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[1].ToString() == text)
                    {
                        return Int32.Parse(dr[0].ToString());
                    }
                }

                return 0;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetTerritoryNamesByCustomer(int ID)
        {
            try
            {
                DataTable dt = new DataTable();

                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@ID", ID) };

                dt = Execute.RunSP_DataTable(Connection, "SPGET_TerritoryListByCustomer",paramList);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int IsAddedTerritory(int CustomerID, int TerritoryID)
        {
            try
            {
                DataTable dt = new DataTable();
                int rows = 0;
                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@C_ID", CustomerID), new SqlParameter("@T_ID", TerritoryID) };

                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomerTerritory_ADDED", paramList);

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

        public long Remove_Assign_Territory(int CustomerID, int TerritoryID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@CustomerID", CustomerID),
                new SqlParameter("@TerritoryID", TerritoryID),
        };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Assign_Territory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetCustomer(int ActiveState)
        {
            try
            {
                DataTable dt = new DataTable();

                SqlParameter[] paramList = new SqlParameter[] { new SqlParameter("@State", ActiveState) };

                dt = Execute.RunSP_DataTable(Connection, "SPGET_CustomersByState", paramList);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long Customer_State(int CustomerID, int State)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Customer_Code", CustomerID),
                new SqlParameter("@Status", State),
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Customer_State", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public List<string> GetActiveCustomers()
        {
            try
            {
                DataTable dt = new DataTable();


                dt = Execute.RunSP_DataTable(Connection, "SPGET_All_Active_Customers");
                List<string> list = new List<string>();

                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(dr[1].ToString());
                }



                return list;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int GetActiveCustomersIDByName(string text)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = Execute.RunSP_DataTable(Connection, "SPGET_All_Active_Customers");

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[1].ToString() == text)
                    {
                        return Int32.Parse(dr[0].ToString());
                    }
                }

                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Territory()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_TerritoryList");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public List<string> Territorydata(int index)
        {
            DataTable dt = new DataTable();
            dt = Territory();
            List<string> datalist = new List<string>();

            foreach (DataRow dr in dt.Rows)
            {
                string ch = dr[index].ToString();
                datalist.Add(ch);
            }
            return datalist;
        }

        public List<Territory> Territorydata()
        {
            DataTable dt = new DataTable();
            dt = Territory();
            List<Territory> datalist = new List<Territory>();

            foreach (DataRow dr in dt.Rows)
            {
                Territory tr = new Territory();
                tr.Name = dr[0].ToString();
                tr.ID = int.Parse(dr[1].ToString());
                datalist.Add(tr);

            }
            return datalist;
        }

        public int TerritoryID(string name)
        {
            int id = -1;
            List<Territory> data = Territorydata();
            for (int y = 0; y < data.Count; y++)
            {
                if (data[y].Name == name)
                {
                    id = data[y].ID;
                    return id;
                }
            }

            return id;
        }

    }
}
