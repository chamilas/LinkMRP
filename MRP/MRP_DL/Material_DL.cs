using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class Material_DL
    {
        SqlConnection Connection = new SqlConnection();

        Form_DL objForm_DL = new Form_DL(ConnectionStringClass.GetConnection());
        Unit_DL objUnit_DL= new Unit_DL(ConnectionStringClass.GetConnection());
        
        MaterialType_DL objMaterialType_DL = new MaterialType_DL(ConnectionStringClass.GetConnection());
        MaterialCategory_DL objMaterialCategory_DL = new MaterialCategory_DL(ConnectionStringClass.GetConnection());

        public Material_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

      
        public int Add(Material obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MaterialCode", obj.MaterialCode),
                new SqlParameter("@MaterialDescription", obj.MaterialDescription),
                new SqlParameter("@MatMainType", obj.MaterialMainType),
                new SqlParameter("@MatTypeID", obj.MateialType.MatType),
                new SqlParameter("@ItemFormID", obj.MatForm.FormID),
                new SqlParameter("@UnitID",  obj.MatUnit.UnitID),
                new SqlParameter("@AVGCost", obj.MatCost),
                new SqlParameter("@Seasanal", obj.IsSeasanal),
                new SqlParameter("@Local", obj.IsLocal),
                new SqlParameter("@Export", obj.IsExport),
                new SqlParameter("@SeasanFrom", obj.MatSeasonFrom),
                new SqlParameter("@SeasanTo", obj.MatSeasonTo),
                new SqlParameter("@BasicMaterialCode", obj.MatBasicMaterial),
                new SqlParameter("@BasicQty", obj.MatBasicQty),
                new SqlParameter("@ParticalSize", obj.MatParticleSize),
                new SqlParameter("@Status", obj.MaterialStatus),
                new SqlParameter("@MaterialType", obj.MaterialType),
                new SqlParameter("@MatCatID", obj.MaterialCategory)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Material", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }


        public int Update(Material obj, String OriginalCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MaterialCode", obj.MaterialCode),
                new SqlParameter("@MaterialDescription", obj.MaterialDescription),
                new SqlParameter("@MatMainType", obj.MaterialMainType),
                new SqlParameter("@MatTypeID", obj.MateialType.MatType),
                new SqlParameter("@ItemFormID", obj.MatForm.FormID),
                new SqlParameter("@UnitID",  obj.MatUnit.UnitID),
                new SqlParameter("@AVGCost", obj.MatCost),
                new SqlParameter("@Seasanal", obj.IsSeasanal),
                new SqlParameter("@Local", obj.IsLocal),
                new SqlParameter("@Export", obj.IsExport),
                new SqlParameter("@SeasanFrom", obj.MatSeasonFrom),
                new SqlParameter("@SeasanTo", obj.MatSeasonTo),
                new SqlParameter("@BasicMaterialCode", obj.MatBasicMaterial),
                new SqlParameter("@BasicQty", obj.MatBasicQty),
                new SqlParameter("@ParticalSize", obj.MatParticleSize),
                new SqlParameter("@Status", obj.MaterialStatus),
                new SqlParameter("@MaterialType", obj.MaterialType),
                new SqlParameter("@MatCatID", obj.MaterialCategory),
                new SqlParameter("@Original_MaterialCode", OriginalCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Material", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Delete(String MaterialCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_MaterialCode", MaterialCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Material", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public MaterialCollec Get()
        {
            try
            {

                Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_Material");

                MaterialCollec objMatCollec = new MaterialCollec();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Material objMaterial = new Material();
                    objMaterial.IsExport = Convert.ToBoolean(dt.Rows[i]["Export"]);
                    objMaterial.IsLocal = Convert.ToBoolean(dt.Rows[i]["Local"]);
                    objMaterial.IsSeasanal = Convert.ToBoolean(dt.Rows[i]["Seasanal"]);
                    if (dt.Rows[i]["BasicMaterialCode"] != dt.Rows[i]["MaterialCode"])
                    {
                        objMaterial.MatBasicMaterial = dt.Rows[i]["BasicMaterialCode"].ToString();
                    }

                    objMaterial.MatBasicQty = Convert.ToDecimal(dt.Rows[i]["BasicQty"]);
                    objMaterial.MatCost = Convert.ToDecimal(dt.Rows[i]["AVGCost"]);
                    objMaterial.MateialType = objMaterialType_DL.Get(Convert.ToString(dt.Rows[i]["MatTypeID"]));

                    objMaterial.MaterialMainType = Convert.ToString(dt.Rows[i]["MatMainType"]);
                    objMaterial.MaterialCode = Convert.ToString(dt.Rows[i]["MaterialCode"]);
                    objMaterial.MaterialDescription = Convert.ToString(dt.Rows[i]["MaterialDescription"]);
                    objMaterial.MaterialStatus = Convert.ToInt32(dt.Rows[i]["Status"]);
                    objMaterial.MaterialCategory = Convert.ToString(dt.Rows[i]["MatCatID"]);
                    objMaterial.MatForm = objForm_DL.Get(Convert.ToInt64(dt.Rows[i]["ItemFormID"]));
                    objMaterial.MatParticleSize = Convert.ToString(dt.Rows[i]["ParticalSize"]);
                    objMaterial.MatSeasonFrom = Convert.ToString(dt.Rows[i]["SeasanFrom"]);
                    objMaterial.MatSeasonTo = Convert.ToString(dt.Rows[i]["SeasanTo"]);
                    objMaterial.MatUnit = objUnit_DL.Get(Convert.ToInt64(dt.Rows[i]["UnitID"]));
          
                    



                    objMatCollec.Add(objMaterial);

                }

                return objMatCollec;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public Material Get(String MaterialCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MaterialCode", MaterialCode)};


                Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MaterialByID",paramList);

                Material objMaterial = new Material();

                if (dt.Rows.Count > 0)
                {

                    objMaterial.IsExport = Convert.ToBoolean(dt.Rows[0]["Export"]);
                    objMaterial.IsLocal = Convert.ToBoolean(dt.Rows[0]["Local"]);
                    objMaterial.IsSeasanal = Convert.ToBoolean(dt.Rows[0]["Seasanal"]);
                    if (dt.Rows[0]["BasicMaterialCode"] != dt.Rows[0]["MaterialCode"])
                    {
                        objMaterial.MatBasicMaterial = dt.Rows[0]["BasicMaterialCode"].ToString();
                    }

                    objMaterial.MatBasicQty = Convert.ToDecimal(dt.Rows[0]["BasicQty"]);
                    objMaterial.MatCost = Convert.ToDecimal(dt.Rows[0]["AVGCost"]);
                    objMaterial.MateialType = objMaterialType_DL.Get(Convert.ToString(dt.Rows[0]["MatTypeID"]));

                    objMaterial.MaterialMainType = Convert.ToString(dt.Rows[0]["MatMainType"]);
                    objMaterial.MaterialCode = Convert.ToString(dt.Rows[0]["MaterialCode"]);
                    objMaterial.MaterialDescription = Convert.ToString(dt.Rows[0]["MaterialDescription"]);
                    objMaterial.MaterialStatus = Convert.ToInt32(dt.Rows[0]["Status"]);
                    objMaterial.MaterialCategory = Convert.ToString(dt.Rows[0]["MatCatID"]);
                    objMaterial.MatForm = objForm_DL.Get(Convert.ToInt64(dt.Rows[0]["ItemFormID"]));
                    objMaterial.MatParticleSize = Convert.ToString(dt.Rows[0]["ParticalSize"]);
                    objMaterial.MatSeasonFrom = Convert.ToString(dt.Rows[0]["SeasanFrom"]);
                    objMaterial.MatSeasonTo = Convert.ToString(dt.Rows[0]["SeasanTo"]);
                    objMaterial.MatUnit = objUnit_DL.Get(Convert.ToInt64(dt.Rows[0]["UnitID"]));
                    objMaterial.MaterialType = Convert.ToString(dt.Rows[0]["MaterialType"]);

                }
                

                return objMaterial;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public MaterialCollec Get(string MatMainType, string MatCategory)
        {
            try
            {
                Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MatMainType", MatMainType),
                new SqlParameter("@MatMainCategory", MatCategory)};

                

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MaterialByCategories");

                MaterialCollec objMatCollec = new MaterialCollec();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Material objMaterial = new Material();
                    objMaterial.IsExport = Convert.ToBoolean(dt.Rows[i]["Export"]);
                    objMaterial.IsLocal = Convert.ToBoolean(dt.Rows[i]["Local"]);
                    objMaterial.IsSeasanal = Convert.ToBoolean(dt.Rows[i]["Seasanal"]);
                    if (dt.Rows[i]["BasicMaterialCode"] != dt.Rows[i]["MaterialCode"])
                    {
                        objMaterial.MatBasicMaterial = dt.Rows[i]["BasicMaterialCode"].ToString();
                    }

                    objMaterial.MatBasicQty = Convert.ToDecimal(dt.Rows[i]["BasicQty"]);
                    objMaterial.MatCost = Convert.ToDecimal(dt.Rows[i]["AVGCost"]);
                    objMaterial.MateialType = objMaterialType_DL.Get(Convert.ToString(dt.Rows[i]["MatTypeID"]));

                    objMaterial.MaterialMainType = Convert.ToString(dt.Rows[i]["MatMainType"]);
                    objMaterial.MaterialCode = Convert.ToString(dt.Rows[i]["MaterialCode"]);
                    objMaterial.MaterialDescription = Convert.ToString(dt.Rows[i]["MaterialDescription"]);
                    objMaterial.MaterialStatus = Convert.ToInt32(dt.Rows[i]["Status"]);
                    objMaterial.MaterialCategory = Convert.ToString(dt.Rows[i]["MatCatID"]);
                    objMaterial.MatForm = objForm_DL.Get(Convert.ToInt64(dt.Rows[i]["ItemFormID"]));
                    objMaterial.MatParticleSize = Convert.ToString(dt.Rows[i]["ParticalSize"]);
                    objMaterial.MatSeasonFrom = Convert.ToString(dt.Rows[i]["SeasanFrom"]);
                    objMaterial.MatSeasonTo = Convert.ToString(dt.Rows[i]["SeasanTo"]);
                    objMaterial.MatUnit = objUnit_DL.Get(Convert.ToInt64(dt.Rows[i]["UnitID"]));





                    objMatCollec.Add(objMaterial);

                }


                return objMatCollec;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        //public MaterialCollec Get(string MatMainType, string MatCategory, string BasicMaterialCode)
        //{
        //    try
        //    {

        //        SqlParameter[] paramList = new SqlParameter[] {
                
        //        new SqlParameter("@MatMainType", MatMainType),
        //        new SqlParameter("@MatMainCategory", MatCategory)};


        //        DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MaterialByCategories");

        //        MaterialCollec objMatCollec = new MaterialCollec();

        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            Material objMaterial = new Material();
        //            objMaterial.IsExport = Convert.ToBoolean(dt.Rows[i]["Export"]);
        //            objMaterial.IsLocal = Convert.ToBoolean(dt.Rows[i]["Local"]);
        //            objMaterial.IsSeasanal = Convert.ToBoolean(dt.Rows[i]["Seasanal"]);
        //            if (dt.Rows[i]["BasicMaterialCode"] != dt.Rows[i]["MaterialCode"])
        //            {
        //                objMaterial.MatBasicMaterial = objMaterial_DL.Get(dt.Rows[i]["BasicMaterialCode"].ToString());
        //            }

        //            objMaterial.MatBasicQty = Convert.ToDecimal(dt.Rows[i]["BasicQty"]);
        //            objMaterial.MatCost = Convert.ToDecimal(dt.Rows[i]["AVGCost"]);
        //            objMaterial.MateialType = objMaterialType_DL.Get(Convert.ToString(dt.Rows[i]["MatTypeID"]));

        //            objMaterial.MaterialMainType = Convert.ToString(dt.Rows[i]["MatMainType"]);
        //            objMaterial.MaterialCode = Convert.ToString(dt.Rows[i]["MaterialCode"]);
        //            objMaterial.MaterialDescription = Convert.ToString(dt.Rows[i]["MaterialDescription"]);
        //            objMaterial.MaterialStatus = Convert.ToInt32(dt.Rows[i]["Status"]);
        //            objMaterial.MaterialSubCategory = Convert.ToString(dt.Rows[i]["MatSubCategoryID"]);
        //            objMaterial.MatForm = objForm_DL.Get(Convert.ToInt64(dt.Rows[i]["FormID"]));
        //            objMaterial.MatParticleSize = Convert.ToString(dt.Rows[i]["ParticalSize"]);
        //            objMaterial.MatSeasonFrom = Convert.ToString(dt.Rows[i]["SeasanFrom"]);
        //            objMaterial.MatSeasonTo = Convert.ToString(dt.Rows[i]["SeasanTo"]);
        //            objMaterial.MatUnit = objUnit_DL.Get(Convert.ToInt64(dt.Rows[i]["UnitID"]));
        //            objMaterial.MaterialCategory = Convert.ToString(dt.Rows[i]["UnitID"]);
        //            objMaterial.ProductCategory = Convert.ToString(dt.Rows[i]["ProductCategory"]);




        //            objMatCollec.Add(objMaterial);

        //        }


        //        return objMatCollec;

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //}



        public System.Data.DataTable GetDataView()
        {
            try
            {


                return Execute.RunSP_DataTable(Connection, "SPGET_Material_DataVeiw_ALL");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        
        public System.Data.DataTable GetData_Search(string Key, int Status,string MatCatID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Key", Key),
                new SqlParameter("@Status", Status),
                new SqlParameter("@MatCatID", MatCatID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Material_DataVeiw_Search_All",paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        

        public System.Data.DataTable GetDataView(String Category)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Category", Category)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Material_DataVeiw_By_Category", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataViewByCategory(String MainType, String Category, String SubCategory, int Status)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MatMainType", MainType),
                new SqlParameter("@MatCategory", Category),
                new SqlParameter("@SubCategory", SubCategory),
                new SqlParameter("@Status", Status)};

                return Execute.RunSP_DataTable(Connection, "SPGET_MaterialByCategory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        //public System.Data.DataTable GetDataViewByCategoryType(String MainType, String Category, String SubCategory, int Status)
        //{
        //    tblMaterialByCategoryTableAdapter da = new tblMaterialByCategoryTableAdapter();
        //    da.Connection = Connection;
        //    try
        //    {

        //        return da.GetDataByCategoryType(MainType, Category, SubCategory, Status);

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //    }
        //}

        //-- New
        
        public System.Data.DataTable GetDataView_Store(String StoreID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID", StoreID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Material_Dataview_ByStore", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        //public System.Data.DataTable GetDataViewByMainCategory(String MainType, String Category)
        //{
        //    tblMaterialTableAdapter da = new tblMaterialTableAdapter();
        //    da.Connection = Connection;
        //    try
        //    {

        //        return da.GetDataByCategories(MainType, Category);

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //    }
        //}

        public System.Data.DataTable GetDataViewIntermediates(String Material)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BasicMaterialCode", Material)};

                return Execute.RunSP_DataTable(Connection, "SPGET_MaterialIntermediates", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public Material GetProcessdMaterial(String BasicMaterialCode)
        {
            try
            {
                Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MaterialCode", BasicMaterialCode)};

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_Material_Procesed_By_MaterialCode", paramList);

                Material objMaterial = new Material();

                if (dt.Rows.Count > 0)
                {
                    objMaterial.IsExport = Convert.ToBoolean(dt.Rows[0]["Export"]);
                    objMaterial.IsLocal = Convert.ToBoolean(dt.Rows[0]["Local"]);
                    objMaterial.IsSeasanal = Convert.ToBoolean(dt.Rows[0]["Seasanal"]);
                    if (dt.Rows[0]["BasicMaterialCode"] != dt.Rows[0]["MaterialCode"])
                    {
                        objMaterial.MatBasicMaterial = dt.Rows[0]["BasicMaterialCode"].ToString();
                    }

                    objMaterial.MatBasicQty = Convert.ToDecimal(dt.Rows[0]["BasicQty"]);
                    objMaterial.MatCost = Convert.ToDecimal(dt.Rows[0]["AVGCost"]);
                    objMaterial.MateialType = objMaterialType_DL.Get(Convert.ToString(dt.Rows[0]["MatType"]));

                    objMaterial.MaterialMainType = Convert.ToString(dt.Rows[0]["MatMainType"]);
                    objMaterial.MaterialCode = Convert.ToString(dt.Rows[0]["MaterialCode"]);
                    objMaterial.MaterialDescription = Convert.ToString(dt.Rows[0]["MaterialDescription"]);
                    objMaterial.MaterialStatus = Convert.ToInt32(dt.Rows[0]["Status"]);
                    objMaterial.MaterialCategory = Convert.ToString(dt.Rows[0]["MatCatID"]);
                    objMaterial.MatForm = objForm_DL.Get(Convert.ToInt64(dt.Rows[0]["FormID"]));
                    objMaterial.MatParticleSize = Convert.ToString(dt.Rows[0]["ParticalSize"]);
                    objMaterial.MatSeasonFrom = Convert.ToString(dt.Rows[0]["SeasanFrom"]);
                    objMaterial.MatSeasonTo = Convert.ToString(dt.Rows[0]["SeasanTo"]);
                    objMaterial.MatUnit = objUnit_DL.Get(Convert.ToInt64(dt.Rows[0]["UnitID"]));
                    objMaterial.MaterialCategory = Convert.ToString(dt.Rows[0]["UnitID"]);

                }

                return objMaterial; ;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public Material GetDryMaterial(String BasicMaterialCode)
        {
            try
            {
                Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MaterialCode", BasicMaterialCode)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Material_Green_By_MaterialCode", paramList);

                Material objMaterial = new Material();

                if (dt.Rows.Count > 0)
                {
                    objMaterial.IsExport = Convert.ToBoolean(dt.Rows[0]["Export"]);
                    objMaterial.IsLocal = Convert.ToBoolean(dt.Rows[0]["Local"]);
                    objMaterial.IsSeasanal = Convert.ToBoolean(dt.Rows[0]["Seasanal"]);
                    if (dt.Rows[0]["BasicMaterialCode"] != dt.Rows[0]["MaterialCode"])
                    {
                        objMaterial.MatBasicMaterial = dt.Rows[0]["BasicMaterialCode"].ToString();
                    }

                    objMaterial.MatBasicQty = Convert.ToDecimal(dt.Rows[0]["BasicQty"]);
                    objMaterial.MatCost = Convert.ToDecimal(dt.Rows[0]["AVGCost"]);
                    objMaterial.MateialType = objMaterialType_DL.Get(Convert.ToString(dt.Rows[0]["MatType"]));

                    objMaterial.MaterialMainType = Convert.ToString(dt.Rows[0]["MatMainType"]);
                    objMaterial.MaterialCode = Convert.ToString(dt.Rows[0]["MaterialCode"]);
                    objMaterial.MaterialDescription = Convert.ToString(dt.Rows[0]["MaterialDescription"]);
                    objMaterial.MaterialStatus = Convert.ToInt32(dt.Rows[0]["Status"]);
                    objMaterial.MaterialCategory = Convert.ToString(dt.Rows[0]["MatCatID"]);
                    objMaterial.MatForm = objForm_DL.Get(Convert.ToInt64(dt.Rows[0]["FormID"]));
                    objMaterial.MatParticleSize = Convert.ToString(dt.Rows[0]["ParticalSize"]);
                    objMaterial.MatSeasonFrom = Convert.ToString(dt.Rows[0]["SeasanFrom"]);
                    objMaterial.MatSeasonTo = Convert.ToString(dt.Rows[0]["SeasanTo"]);
                    objMaterial.MatUnit = objUnit_DL.Get(Convert.ToInt64(dt.Rows[0]["UnitID"]));
                    objMaterial.MaterialCategory = Convert.ToString(dt.Rows[0]["UnitID"]);

                }

                return objMaterial; ;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable Get_Proccesd_DataView(String MaterialCode)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MaterialCode", MaterialCode)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Material_Procesed_By_MaterialCode", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        //public System.Data.DataTable Get_MainType_Category(String MainType,long Category, long SubCategory)
        //{
        //    try
        //    {
        //        SqlParameter[] paramList = new SqlParameter[] {
                
        //        new SqlParameter("@MatSubCatID", SubCatID)};

        //        return Execute.RunSP_DataTable(Connection, "SPGET_MaterialByCategories", paramList);

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //}


        public System.Data.DataTable Search(String Key, int Status)
        {
            

           
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Key", Key),
                new SqlParameter("@Status", Status)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Material_DataVeiw_Search_All", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            } 
        }

        public System.Data.DataTable Search(String Key,String Category, int Status)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Key", Key),
                new SqlParameter("@Status", Status),
                new SqlParameter("@Category", Category)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Material_DataVeiw_Search_By_Category_All", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            } 
        }

        public System.Data.DataTable Search_MainType(String Key, String MainType, int Status)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Key", Key),
                new SqlParameter("@Status", Status),
                new SqlParameter("@MatMainType", MainType)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Material_DataVeiw_Search_By_MainType_All", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            } 
        }


        public System.Data.DataTable Search_MainType_Category(String Key, String MainType, String Category, int Status)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Key", Key),
                new SqlParameter("@Status", Status),
                new SqlParameter("@MatMainType", MainType),
                new SqlParameter("@Category", Category)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Material_DataVeiw_Search_By__Category_MainType_All", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
