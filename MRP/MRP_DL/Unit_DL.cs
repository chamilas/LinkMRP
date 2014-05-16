using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class Unit_DL
    {
        SqlConnection Connection = new SqlConnection();


        public Unit_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(Unit obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UnitName", obj.UnitName),
                new SqlParameter("@UnitCode", obj.UnitCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Unit", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            
        }

        public int Update(Unit obj)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UnitName", obj.UnitName),
                new SqlParameter("@UnitCode", obj.UnitCode),
                 new SqlParameter("@Original_UnitID", obj.UnitID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Unit", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            
        }

        public int Delete(long UnitID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_UnitID", UnitID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Unit", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        

        public Unit Get(long UnitID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UnitID", UnitID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_UnitByID", paramList);


                Unit obj = new Unit();

                if (dt.Rows.Count > 0)
                {
                    obj.UnitCode = Convert.ToString(dt.Rows[0]["UnitCode"]);
                    obj.UnitID = Convert.ToInt64(dt.Rows[0]["UnitID"]);
                    obj.UnitName = Convert.ToString(dt.Rows[0]["UnitName"]);
                }

                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
          
        }

        public DataTable GetDataView()
        {
            try
            {
                return Execute.RunSP_DataTable(Connection, "SPGET_Unit");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
