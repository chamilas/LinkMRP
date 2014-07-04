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
    public class Region_DL
    {
        SqlConnection Connection = new SqlConnection();
        private SqlConnection sqlConnection;

        public Region_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(Region obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Name", obj.Name),
                new SqlParameter("@ASM", obj.ASM),
                new SqlParameter("@Province", obj.Province),
                new SqlParameter("@ProductCatID", obj.ProductCatID),
                new SqlParameter("@SalesMethodID", obj.SalesMethodID),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Region", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long IsAdd(Region obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Name", obj.Name),
                new SqlParameter("@ASM", obj.ASM),
                new SqlParameter("@Province", obj.Province),
                new SqlParameter("@ProductCatID", obj.ProductCatID),
                new SqlParameter("@SalesMethodID", obj.SalesMethodID)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Region_ADD", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public List<string> GetSalesMethods()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_SalesMethod_SMDesctiption");
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

        public string GetSalesMethodsID( string text)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_SalesMethod");

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[1].ToString() == text)
                    {
                        return dr[0].ToString();
                    }
                }

                return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public List<string> GetProductCategory()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_ProductCategory");
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

        public string GetProductCatID(string text)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_ProductCategory");
                string ProductCatID;

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[1].ToString() == text)
                    {
                        ProductCatID = dr[0].ToString();
                        return ProductCatID;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public List<string> GetRegion()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_Region");
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

        public string GetRegionIDByName(string text)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_Region");
                string ProductCatID;

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[1].ToString() == text)
                    {
                        ProductCatID = dr[0].ToString();
                        return ProductCatID;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public List<string> GetASM()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_ASM");
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

        public long GetASMByID(string text)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Execute.RunSP_DataTable(Connection, "SPGET_ASM");
                long ID;

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[1].ToString() == text)
                    {
                        ID = Int32.Parse(dr[0].ToString());
                        return ID;
                    }
                }

                return 0;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
        
    }
}
