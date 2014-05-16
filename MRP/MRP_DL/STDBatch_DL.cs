using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class STDBatch_DL
    {
        SqlConnection Connection = new SqlConnection();
        public STDBatch_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public string Add_Basic(STDBatch obj)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@STDBatchDescription", obj.STDBatchDescription),
                 new SqlParameter("@STDBasicProductCode", obj.STDBatchBasicProduct.BasicProductCode),
                 new SqlParameter("@STDBatchSize", obj.STDBatchSize),
                 new SqlParameter("@STDInstructedBy", obj.STDBatchInstructedBy.EmployeeID),
                 new SqlParameter("@STDBatchType", obj.STDBatchType),
                 new SqlParameter("@STDDuration", obj.STDDuration),
                 new SqlParameter("@EditableBatch", obj.EditableBatch),
                 new SqlParameter("@LabourHours", obj.LabourHours),
                 new SqlParameter("@MachineHours", obj.MachineHours),
                 new SqlParameter("@OutputQty", obj.OutputQty),
                 new SqlParameter("@InputQty", obj.InputQty),
                 new SqlParameter("@SpecificGravity", obj.SpecificGravity),
                 new SqlParameter("@Water", obj.Water),
                 new SqlParameter("@outParam",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}
                };

                return Execute.RunSP_Output_String(Connection, "SPADD_STDBatch_BasicProduct", paramList);

                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

           

        public int Delete(string STDBatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_STDBatchID", STDBatchID)
                };

                return Execute.RunSP_Int(Connection, "SPDELETE_STDBatch", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

       

        

        public STDBatch Get(string STDBatchID)
        {


            BasicProduct_DL objBasicProductDL = new BasicProduct_DL(Connection);
            FinishProduct_DL objFinishProductDL = new FinishProduct_DL(Connection);
            STDBatch objSTDBatch = new STDBatch();
            Employee_DL objEmpDL = new Employee_DL(Connection);


            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@STDBatchID", STDBatchID)};

                STDBatch obj = new STDBatch();

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_STDBatch_By_ID", paramList);

                if (dt.Rows.Count > 0)
                {

                    if (dt.Rows[0]["STDBatchID"] != null)
                    {
                        obj.STDBatchID = Convert.ToString(dt.Rows[0]["STDBatchID"]);
                    }

                    if (dt.Rows[0]["STDBatchDescription"] != null)
                    {
                        obj.STDBatchDescription = Convert.ToString(dt.Rows[0]["STDBatchDescription"]);
                    }

                    if (dt.Rows[0]["STDBasicProductCode"] != null)
                    {
                        obj.STDBatchBasicProduct = objBasicProductDL.Get(Convert.ToString(dt.Rows[0]["STDBasicProductCode"]));
                    }

                    if (dt.Rows[0]["STDFinishProductCode"] != null)
                    {
                        obj.STDBatchFinishProduct = objFinishProductDL.Get(Convert.ToString(dt.Rows[0]["STDFinishProductCode"]));
                    }

                    obj.STDBatchSize = Convert.ToDecimal(dt.Rows[0]["STDBatchSize"]);
                    obj.STDBatchInstructedBy = objEmpDL.Get(Convert.ToString(dt.Rows[0]["STDInstructedBy"]));
                    obj.STDInstructedDate = Convert.ToDateTime(dt.Rows[0]["STDInstructedDate"]);


                    obj.STDBatchType = Convert.ToString(dt.Rows[0]["STDBatchType"]);
                    obj.STDDuration = Convert.ToDecimal(dt.Rows[0]["STDDuration"]);
                    obj.EditableBatch = Convert.ToBoolean(dt.Rows[0]["EditableBatch"]);
                    obj.LabourHours = Convert.ToDecimal(dt.Rows[0]["LabourHours"]);
                    obj.MachineHours = Convert.ToDecimal(dt.Rows[0]["MachineHours"]);
                    obj.InputQty = Convert.ToDecimal(dt.Rows[0]["InputQty"]);
                    obj.OutputQty = Convert.ToDecimal(dt.Rows[0]["OutputQty"]);

                    if (dt.Rows[0]["SpecificGravity"] != DBNull.Value)
                    {
                        obj.SpecificGravity = Convert.ToBoolean(dt.Rows[0]["SpecificGravity"]);
                    }

                    if (dt.Rows[0]["Water"] != DBNull.Value)
                    {
                        obj.Water = Convert.ToDecimal(dt.Rows[0]["Water"]);
                    }

                }


                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public DataTable Get_DataView()
        {

            try
            {
                STDBatch obj = new STDBatch();

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_STDBatch");

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable Get_Data_ByProduct(string ProductCode)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Product", ProductCode)};



                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_STDBatch_By_Product", paramList);

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable Get_Data_ByProduct_Size(string ProductCode, decimal Size)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProductCode", ProductCode),
                new SqlParameter("@BatchSize", Size)};



                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_STDBatch_By_Product_Size", paramList);

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public STDBatch Get(string ProductCode,decimal BatchSize)
        {
            BasicProduct_DL objBasicProductDL = new BasicProduct_DL(Connection);
            FinishProduct_DL objFinishProductDL = new FinishProduct_DL(Connection);
            Employee_DL objEmpDL = new Employee_DL(Connection);

            STDBatch obj = new STDBatch();


            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Product", ProductCode),
                 new SqlParameter("@BatchSize", BatchSize)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_STDBatch_By_Product_Size",paramList);

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["STDBatchID"] != null)
                    {
                        obj.STDBatchID = Convert.ToString(dt.Rows[0]["STDBatchID"]);
                    }

                    if (dt.Rows[0]["STDBatchDescription"] != null)
                    {
                        obj.STDBatchDescription = Convert.ToString(dt.Rows[0]["STDBatchDescription"]);
                    }

                    if (dt.Rows[0]["STDBasicProductCode"] != null)
                    {
                        obj.STDBatchBasicProduct = objBasicProductDL.Get(Convert.ToString(dt.Rows[0]["STDBasicProductCode"]));
                    }

                    if (dt.Rows[0]["STDFinishProductCode"] != null)
                    {
                        obj.STDBatchFinishProduct = objFinishProductDL.Get(Convert.ToString(dt.Rows[0]["STDFinishProductCode"]));
                    }

                    obj.STDBatchSize = Convert.ToDecimal(dt.Rows[0]["STDBatchSize"]);
                    obj.STDBatchInstructedBy = objEmpDL.Get(Convert.ToString(dt.Rows[0]["STDInstructedBy"]));
                    obj.STDInstructedDate = Convert.ToDateTime(dt.Rows[0]["STDInstructedDate"]);


                    obj.STDBatchType = Convert.ToString(dt.Rows[0]["STDBatchType"]);
                    obj.STDDuration = Convert.ToDecimal(dt.Rows[0]["STDDuration"]);
                    obj.EditableBatch = Convert.ToBoolean(dt.Rows[0]["EditableBatch"]);
                    obj.LabourHours = Convert.ToDecimal(dt.Rows[0]["LabourHours"]);
                    obj.MachineHours = Convert.ToDecimal(dt.Rows[0]["MachineHours"]);
                    obj.InputQty = Convert.ToDecimal(dt.Rows[0]["InputQty"]);
                    obj.OutputQty = Convert.ToDecimal(dt.Rows[0]["OutputQty"]);
                    obj.SpecificGravity = Convert.ToBoolean(dt.Rows[0]["SpecificGravity"]);
                    obj.Water = Convert.ToDecimal(dt.Rows[0]["Water"]);

                }
                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Get_Count(string ProductCode, decimal BatchSize)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Product", ProductCode),
                 new SqlParameter("@BatchSize", BatchSize)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_STDBatch_By_Product_Size", paramList);

                return dt.Rows.Count;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


    }
}
