using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class FormulaFinishProduct_DL
    {
        SqlConnection Connection = new SqlConnection();
        Formula_DL objFormula_DL = new Formula_DL(ConnectionStringClass.GetConnection());
        FinishProduct_DL objFinishProduct_DL = new FinishProduct_DL(ConnectionStringClass.GetConnection());

        public FormulaFinishProduct_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(FormulaFinishProduct obj,Employee objEmployee)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormulaID", obj.Formula.FormulaID),
                new SqlParameter("@FormulaFinishProductCode", obj.FinishProduct.FinishProductCode),
                new SqlParameter("@FormulaPart", obj.FormulaPart),
                new SqlParameter("@FormulaProductQty", obj.FormulaProductQty),
                new SqlParameter("@FormulaInstructedBy", objEmployee.EmployeeID)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_FormulaBasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(FormulaFinishProduct obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormulaPart", obj.FormulaPart),
                new SqlParameter("@FormulaQty", obj.FormulaProductQty),
                new SqlParameter("@Original_FormulaID", obj.Formula.FormulaID),
                new SqlParameter("@Original_FormulaFinishProductCode", obj.FinishProduct.FinishProductCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_FormulaFinishProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long FormulaID, String FinishProductCode, String FormulaPart)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_FormulaID", FormulaID),
                new SqlParameter("@Original_FormulaFinishProductCode", FinishProductCode),
                new SqlParameter("@FormulaPart", FormulaPart)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_FormulaFinishProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public FormulaFinishProductCollec Get()
        {
            return null;
        }

        public FormulaFinishProduct Get(long FormulaID, String FinishProductCode , String FormulaPart)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormulaID", FormulaID),
                new SqlParameter("@FinishProductID", FinishProductCode),
                new SqlParameter("@FormulaPart", FormulaPart)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_FormulaFinishProductByID", paramList);

                FormulaFinishProduct objFormulaFinishProduct = new FormulaFinishProduct();

                
                    objFormulaFinishProduct.FinishProduct = objFinishProduct_DL.Get(Convert.ToString(dt.Rows[0]["FinishProductID"]));
                    objFormulaFinishProduct.Formula = objFormula_DL.Get(Convert.ToInt32(dt.Rows[0]["FormulaID"]));
                    objFormulaFinishProduct.FormulaPart = Convert.ToString(dt.Rows[0]["FormulaPart"]);
                    objFormulaFinishProduct.FormulaProductQty = Convert.ToDecimal(dt.Rows[0]["FormulaProductQty"]);

                
                return objFormulaFinishProduct;



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
                
                new SqlParameter("@FormulaID", FormulaID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_FormulaFinishProduct_By_FormulaID", paramList);

                return dt;



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }


    }
}
