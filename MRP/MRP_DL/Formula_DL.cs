using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    public class Formula_DL
    {
        SqlConnection Connection = new SqlConnection();

        Unit_DL objUnit_DL = new Unit_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());

        public Formula_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(Formula objFormula)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormulaQty", objFormula.FormulaQty),
                new SqlParameter("@FormulaUnitID", objFormula.FormulaUnit.UnitID),
                new SqlParameter("@FormulaInstructedBy", objFormula.FormulaInstructedBy.EmployeeID),
                new SqlParameter("@FormulaInstructedDate", objFormula.FormulaInstructedDate),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output(Connection, "SPADD_Formula", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            
        }

        public int Add_FG(Formula objFormula)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormulaQty", objFormula.FormulaQty),
                new SqlParameter("@FormulaInstructedBy", objFormula.FormulaInstructedBy.EmployeeID),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                };

                return Execute.RunSP_Output(Connection, "SPADD_Formula_FG", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }



        public int Update(Formula objFormula)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormulaQty", objFormula.FormulaQty),
                new SqlParameter("@FormulaUnitID", objFormula.FormulaUnit.UnitID),
                new SqlParameter("@FormulaInstructedBy", objFormula.FormulaInstructedBy.EmployeeID),
                new SqlParameter("@FormulaInstructedDate", objFormula.FormulaInstructedDate),
                new SqlParameter("@Original_FormulaID", objFormula.FormulaID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Formula", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Delete(long FormulaID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_FormulaID", FormulaID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Formula", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public Formula Get(long FormulaID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormulaID", FormulaID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Formula", paramList);

                Formula obj = new Formula();

                if (dt.Rows.Count >0)
                {
                    obj.FormulaID = Convert.ToInt64(dt.Rows[0]["FormulaID"]);
                    obj.FormulaInstructedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["FormulaInstructedBy"]));
                    obj.FormulaInstructedDate = Convert.ToDateTime(dt.Rows[0]["FormulaInstructedDate"]);
                    obj.FormulaQty = Convert.ToInt64(dt.Rows[0]["FormulaQty"]);
                    obj.FormulaUnit = objUnit_DL.Get(Convert.ToInt64(dt.Rows[0]["FormulaUnitID"]));
                }

                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }




        public DataTable GetDataView_Items(long FormulaID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormulaID", FormulaID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_FormulaByID", paramList);


                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

    }
}
