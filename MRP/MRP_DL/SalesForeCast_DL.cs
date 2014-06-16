using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MRP_DL;
using SESD.MRP.REF;
using System.Data;

namespace DL
{
    public class SalesForeCast_DL
    {
        SqlConnection Connection = new SqlConnection();
        private SqlConnection sqlConnection;

        public SalesForeCast_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(SalesForecast obj)
        {
            try
            {

                SqlParameter SFNO = new SqlParameter();
                SFNO.Direction = ParameterDirection.Output;

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RevisionNo", obj.RevisionNo),
                new SqlParameter("@Year", obj.Year),
                new SqlParameter("@Month", obj.Month),
                new SqlParameter("@WeekID", obj.WeekID),
                new SqlParameter("@Accuracy", obj.Accuracy),
                new SqlParameter("@State", obj.State),
                new SqlParameter("@EenteredBy", obj.EenteredBy),
                new SqlParameter("@ProductCategory", obj.ProductCategory),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };
                return Execute.RunSP_Output(Connection, "SPADD_SalesForecast", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long GetBasicProductForecastByBPandDate(int year,String month,String BasicproductID)
        {
            try
            {

                //SqlParameter Qty = new SqlParameter();
                //Qty.Direction = ParameterDirection.Output;

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@prmYear", year),
                new SqlParameter("@prmMonth", month),
                new SqlParameter("@prmBasicProductCode", BasicproductID),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}

        };
                return Execute.RunSP_Output(Connection, "SPGET_BasicProductForecast", paramList);
                //return 0;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetForeCastByStatus(int State, String ProductType)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@State", State),
                new SqlParameter("@ProductType", ProductType)};

                return Execute.RunSP_DataTable(Connection, "SPGET_SalesForecast_By_Status", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetForeCastContentByFSID(int ForecastID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SalesForecastID", ForecastID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_SalesForecastContent", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_Status(int FSID,int Status,String ApprovedBy)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SFStatus", Status),
                new SqlParameter("@ApprovedBy", ApprovedBy),
                new SqlParameter("@FSID", FSID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_SalesForecast_Status", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

    }
}
