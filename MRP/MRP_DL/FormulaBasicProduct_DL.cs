using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class FormulaBasicProduct_DL
    {
        SqlConnection Connection = new SqlConnection();

        BasicProduct_DL objBasicProduct_DL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        Formula_DL objFormula_DL = new Formula_DL(ConnectionStringClass.GetConnection());

        public FormulaBasicProduct_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public int Add(FormulaBasicProduct obj,Employee objEmployee)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormulaID", obj.Formula.FormulaID),
                new SqlParameter("@FormulaBasicProductCode", obj.BasicProduct.BasicProductCode),
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

        public int Update(FormulaBasicProduct obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormulaPart", obj.Formula.FormulaID),
                new SqlParameter("@FormulaProductQty", obj.BasicProduct.BasicProductCode),
                new SqlParameter("@Original_FormulaID", obj.FormulaPart),
                new SqlParameter("@Original_FormulaBasicProductCode", obj.FormulaProductQty)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_FormulaBasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long FormulaID,String BasicProductCode,String FormulaPart)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormulaID", FormulaID),
                new SqlParameter("@FormulaProductQty", BasicProductCode),
                new SqlParameter("@Original_FormulaID", FormulaPart)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_FormulaBasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public FormulaBasicProductCollec Get()
        {
            return null;
        }

        public FormulaBasicProduct Get(long FormulaID, String BasicProductCode,String FormulaPart)
        {


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FormulaID", FormulaID),
                new SqlParameter("@FormulaBasicProductCode", BasicProductCode),
                new SqlParameter("@FormulaPart", FormulaPart)};

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_FormulaBasicProductByID", paramList);

                FormulaBasicProduct objFormulaBasicProduct = new FormulaBasicProduct();

                for (int i = 0; i < dt.Rows.Count;i++)
                {
                    objFormulaBasicProduct.BasicProduct = objBasicProduct_DL.Get(Convert.ToString(dt.Rows[0]["FormulaBasicProductCode"]));
                    objFormulaBasicProduct.Formula = objFormula_DL.Get(Convert.ToInt32(dt.Rows[0]["FormulaID"]));
                    objFormulaBasicProduct.FormulaPart = Convert.ToString(dt.Rows[0]["FormulaPart"]);
                    objFormulaBasicProduct.FormulaProductQty = Convert.ToDecimal(dt.Rows[0]["FormulaProductQty"]);
                }
                return objFormulaBasicProduct;
           


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

                return Execute.RunSP_DataTable(Connection, "SPGET_FormulaFinishProduct_By_FormulaID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
