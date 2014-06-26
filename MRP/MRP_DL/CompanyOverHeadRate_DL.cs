using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class CompanyOverHeadRate_DL
    {
        SqlConnection Connection = new SqlConnection();

        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());

        public CompanyOverHeadRate_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(CompanyOverHeadRate obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ID", obj.ID),
                new SqlParameter("@Rate", obj.Rate),
                new SqlParameter("@EnteredBy", obj.EnterdBy.EmployeeID),
                new SqlParameter("@EnteredDate", obj.EnterdDate)};


                return Execute.RunSP_RowsEffected(Connection, "SPADD_CompanyOverHeadRate_Update", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public CompanyOverHeadRate Get()
        {
            try
            {

                CompanyOverHeadRate obj = new CompanyOverHeadRate();


                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_OverheadRates");


                obj.EnterdBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["EnterdBy"]));
                obj.EnterdDate = Convert.ToDateTime(dt.Rows[0]["Date"]);
                obj.ID = Convert.ToInt64(dt.Rows[0]["DepID"]);
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
