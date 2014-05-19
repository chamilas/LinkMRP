using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class FormulaMaterial_DL
    {
        SqlConnection Connection = new SqlConnection();
        Formula_DL objFormula_DL = new Formula_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());

        public FormulaMaterial_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(FormulaMaterial obj,Employee objEmployee)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormulaID", obj.Formula.FormulaID),
                new SqlParameter("@FormulaMaterialCode", obj.Material.MaterialCode),
                new SqlParameter("@FormulaPart", obj.FormulaPart),
                new SqlParameter("@FormulaQty", obj.FormulaProductQty),
                new SqlParameter("@FormulaInstructedBy", objEmployee.EmployeeID)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_FormulaMaterial", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(FormulaMaterial obj)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormulaPart", obj.FormulaPart),
                new SqlParameter("@FormulaQty", obj.FormulaProductQty),
                new SqlParameter("@Original_FormulaID",obj.Formula.FormulaID ),
                new SqlParameter("@Original_FormulaMaterialCode",obj.Material.MaterialCode )};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_FormulaMaterial", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long FormulaID, String MaterialCode, String FormulaPart)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Original_FormulaID",FormulaID ),
                new SqlParameter("@Original_FormulaMaterialCode",MaterialCode ),
                new SqlParameter("@FormulaPart", FormulaPart)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_FormulaMaterial", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public FormulaMaterialCollec Get()
        {
            return null;
        }

        public FormulaMaterial Get(long FormulaID, String MaterialCode, String FormulaPart)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@FormulaID",FormulaID ),
                new SqlParameter("@FormulaMaterialCode",MaterialCode ),
                new SqlParameter("@FormulaPart", FormulaPart)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_FormulaMaterial_ByID", paramList);


                FormulaMaterial obj = new FormulaMaterial();

                if (dt.Rows.Count > 0)
                {

                    obj.Material = objMaterial_DL.Get(Convert.ToString(dt.Rows[0]["FormulaMaterialCode"]));
                    obj.Formula = objFormula_DL.Get(Convert.ToInt32(dt.Rows[0]["FormulaID"]));
                    obj.FormulaPart = Convert.ToString(dt.Rows[0]["FormulaPart"]);
                    obj.FormulaProductQty = Convert.ToDecimal(dt.Rows[0]["FormulaQty"]);

                }
                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

                
        }

        public DataTable GetDataView_FormulaID(long FormulaID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@FormulaID",FormulaID )};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_FormualMaterial_By_FormulaID", paramList);

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }
    }
}