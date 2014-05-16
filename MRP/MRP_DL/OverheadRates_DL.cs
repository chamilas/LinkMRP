using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SESD.MRP.REF;

namespace DL
{
    public class OverheadRates_DL
    {
        SqlConnection Connection = new SqlConnection();
        public OverheadRates_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public int Add(OverheadRates obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepID", obj.SectionID),
                new SqlParameter("@Rate", obj.Rate),
                  new SqlParameter("@EnterdBy", obj.EnterdBy),
                new SqlParameter("@Date", obj.EnterdDate)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_OverheadRates", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            
        }


        public OverheadRates Get(long DepID)
        {
            OverheadRates obj = new OverheadRates();

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepID", DepID)
        };

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_OverheadRates_By_DepID", paramList);

                obj.EnterdBy = Convert.ToString(dt.Rows[0]["EnterdBy"]);
                obj.EnterdDate = Convert.ToDateTime(dt.Rows[0]["Date"]);
                obj.SectionID = Convert.ToInt64(dt.Rows[0]["DepID"]);
                obj.Rate = Convert.ToDecimal(dt.Rows[0]["Rate"]);

                return obj;

            }


            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);


            }
            



        }
    }
}
