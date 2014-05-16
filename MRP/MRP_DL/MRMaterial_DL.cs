using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MRMaterial_DL
    {
        SqlConnection Connection = new SqlConnection();

        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        Formula_DL objFormula_DL = new Formula_DL(ConnectionStringClass.GetConnection());
        MR_DL objMR_DL = new MR_DL(ConnectionStringClass.GetConnection());

        public MRMaterial_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(MRMaterial obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", obj.MR.MRNO),
                new SqlParameter("@MRMaterialCode", obj.Material.MaterialCode),
                new SqlParameter("@MRDescription", obj.Description),
                new SqlParameter("@MRReqdQty", obj.ReqdQty),
                new SqlParameter("@MRIssuedQty", obj.IssuedQty),
                new SqlParameter("@MRBINNo", obj.MRBINNo)
                
             };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MRMaterial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(MRMaterial obj,long OriginalMRNO,String OriginalMaterialCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", obj.MR.MRNO),
                new SqlParameter("@MRMaterialCode", obj.Material.MaterialCode),
                new SqlParameter("@MRDescription", obj.Description),
                new SqlParameter("@MRReqdQty", obj.ReqdQty),
                new SqlParameter("@MRIssuedQty", obj.IssuedQty),
                new SqlParameter("@MRBINNo", obj.MRBINNo),
                new SqlParameter("@Original_MRNO",OriginalMRNO),
                new SqlParameter("@Original_MRFinishMaterialCode", OriginalMaterialCode)
                
             };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MRMaterial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Issue(MRMaterial obj,String StoreID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", obj.MR.MRNO),
                new SqlParameter("@MRMaterialCode", obj.Material.MaterialCode),
                new SqlParameter("@MRIssuedQty", obj.IssuedQty),
                new SqlParameter("@StoreID",StoreID)
                
             };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MRMaterial_Issue", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long MRNO, String MaterialCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO",MRNO),
                new SqlParameter("@MRMaterialCode", MaterialCode)
                
             };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MRMaterial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public MRMaterialCollec Get()
        {
          
               try
            {

               DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_MRMaterial");

               MRMaterialCollec objMRMaterialCollec = new MRMaterialCollec();

                for (int i=0;i<dt.Rows.Count;i++)
                {
                    MRMaterial objMRMaterial = new MRMaterial();

                    objMRMaterial.Description = Convert.ToString(dt.Rows[i]["MRDescription"]);
                    objMRMaterial.Material = objMaterial_DL.Get(Convert.ToString(dt.Rows[i]["MRMaterialCode"]));
                    objMRMaterial.MR = objMR_DL.Get(Convert.ToInt64(dt.Rows[i]["MRNO"]));
                    objMRMaterial.MRBINNo = Convert.ToString(dt.Rows[i]["MRBINNo"]);
                    objMRMaterial.ReqdQty = Convert.ToDecimal(dt.Rows[i]["MRReqdQty"]);
                    objMRMaterial.IssuedQty = Convert.ToDecimal(dt.Rows[i]["MRIssuedQty"]);

                    if (dt.Rows[i]["MRUnitRate"] != null)
                    {
                        objMRMaterial.UniRate = Convert.ToDecimal(dt.Rows[i]["MRUnitRate"]);
                    }
                    else
                    {
                        objMRMaterial.UniRate = 0;
                    }
                    objMRMaterial.UnitCode = objMaterial_DL.Get(Convert.ToString(dt.Rows[i]["MRMaterialCode"])).MatUnit.UnitCode;

                    objMRMaterialCollec.Add(objMRMaterial);

                }
                return objMRMaterialCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



             
        }


        public MRMaterialCollec Get(long MRNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", MRNO)
                
             };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MRMaterial_By_MR", paramList);

                MRMaterialCollec objMRMaterialCollec = new MRMaterialCollec();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    MRMaterial objMRMaterial = new MRMaterial();

                    if (dt.Rows[i]["MRDescription"] != null)
                    {
                        objMRMaterial.Description = Convert.ToString(dt.Rows[i]["MRDescription"]);
                    }
                    if (dt.Rows[i]["MRMaterialCode"] != null)
                    {
                        objMRMaterial.Material = objMaterial_DL.Get(Convert.ToString(dt.Rows[i]["MRMaterialCode"]));
                    }

                    if (dt.Rows[i]["MRNO"] != null)
                    {
                        objMRMaterial.MR = objMR_DL.Get(Convert.ToInt64(dt.Rows[i]["MRNO"]));
                    }
                    objMRMaterial.MRBINNo = Convert.ToString(dt.Rows[i]["MRBINNo"]);
                    objMRMaterial.ReqdQty = Convert.ToDecimal(dt.Rows[i]["MRReqdQty"]);
                    objMRMaterial.IssuedQty = Convert.ToDecimal(dt.Rows[i]["MRIssuedQty"]);

                    if (dt.Rows[i]["MRUnitRate"] != null)
                    {
                        objMRMaterial.UniRate = Convert.ToDecimal(dt.Rows[i]["MRUnitRate"]);
                    }
                    else
                    {
                        objMRMaterial.UniRate = 0;
                    }

                    objMRMaterial.Item = objMRMaterial.Material.MaterialCode + " - " + objMRMaterial.Material.MaterialDescription;
                    objMRMaterial.UnitCode = objMaterial_DL.Get(Convert.ToString(dt.Rows[i]["MRMaterialCode"])).MatUnit.UnitCode;

                    objMRMaterialCollec.Add(objMRMaterial);

                }
                return objMRMaterialCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public MRMaterial Get(long MRNO, String MaterialCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", MRNO),
                 new SqlParameter("@MaterialCode", MaterialCode)
                
             };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MRMaterialByID",paramList);

                 MRMaterial objMRMaterial = new MRMaterial();

                if (dt.Rows.Count > 0)
                {
                   

                    if (dt.Rows[0]["MRDescription"] != null)
                    {
                        objMRMaterial.Description = Convert.ToString(dt.Rows[0]["MRDescription"]);
                    }
                    objMRMaterial.Material = objMaterial_DL.Get(Convert.ToString(dt.Rows[0]["MRMaterialCode"]));
                    objMRMaterial.MR = objMR_DL.Get(Convert.ToInt64(dt.Rows[0]["MRNO"]));
                    objMRMaterial.MRBINNo = Convert.ToString(dt.Rows[0]["MRBINNo"]);
                    objMRMaterial.ReqdQty = Convert.ToDecimal(dt.Rows[0]["MRReqdQty"]);
                    objMRMaterial.IssuedQty = Convert.ToDecimal(dt.Rows[0]["MRIssuedQty"]);

                    if (dt.Rows[0]["MRUnitRate"] != DBNull.Value)
                    {
                        objMRMaterial.UniRate = Convert.ToDecimal(dt.Rows[0]["MRUnitRate"]);
                    }
                    else
                    {
                        objMRMaterial.UniRate = 0;
                    }

                    

                }
                return objMRMaterial;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public System.Data.DataTable Get_RequestedMaterial(string BatchNo,string PartNo)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchNo),
                 new SqlParameter("@PartID", PartNo)
                
             };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MaterialRequested_By_BatchID_Part", paramList);

                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }




        public System.Data.DataTable GetDataView(long MRNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", MRNO)
                
             };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MRMaterial_ByMRNO_Dataview", paramList);

                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public int Get_StockByStore(String StoreID,String MaterialCode,Decimal IssuedQty)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID", StoreID), 
                new SqlParameter("@MRMaterialCode", MaterialCode),
                 new SqlParameter("@MRIssuedQty", IssuedQty)
                
             };


                return Execute.RunSP_Int(Connection, "SPGET_MRMaterial_StockByStoreID", paramList);



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


      

    }
}
