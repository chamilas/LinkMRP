using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class GRNMaterials_DL
    {
        SqlConnection Connection = new SqlConnection();

        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        GRN_DL objGRN_DL = new GRN_DL(ConnectionStringClass.GetConnection());

        public GRNMaterials_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(GRNMaterials obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", obj.GRN.GRNNo),
                new SqlParameter("@MaterialCode", obj.Material.MaterialCode),
                new SqlParameter("@GrossQty", obj.GrossQty),
                new SqlParameter("@NetQty", obj.NetQty),
                new SqlParameter("@UnitPrice", obj.UnitPrice),
                new SqlParameter("@Remarks", obj.Remarks)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_GRNMaterials", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Add_FromDeliverNote(GRNMaterials obj,string DeliverNote)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", obj.GRN.GRNNo),
                new SqlParameter("@MaterialCode", obj.Material.MaterialCode),
                new SqlParameter("@GrossQty", obj.GrossQty),
                new SqlParameter("@NetQty", obj.NetQty),
                new SqlParameter("@UnitPrice", obj.UnitPrice),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@DeliverNote", DeliverNote)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_GRNMaterials_FromDeliverNote", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Delete(long GRNNO, String MaterialCode)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", GRNNO),
                new SqlParameter("@MaterialCode", MaterialCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_GRNMaterials", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Update(GRNMaterials obj,long GRNNO, String MaterialCode)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", obj.GRN.GRNNo),
                new SqlParameter("@MaterialCode", obj.Material.MaterialCode),
                new SqlParameter("@GrossQty", obj.GrossQty),
                new SqlParameter("@NetQty", obj.NetQty),
                new SqlParameter("@UnitPrice", obj.UnitPrice),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@Original_GRNNO", GRNNO),
                new SqlParameter("@Original_MaterialCode", MaterialCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_GRNMaterials", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public GRNMaterialsCollec Get()
        {
            try
            {

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_GRNMaterials");

                GRNMaterialsCollec objGRNMatCollec = new GRNMaterialsCollec();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    GRNMaterials objGRNMaterial = new GRNMaterials();
                    objGRNMaterial.GRN = objGRN_DL.Get(Convert.ToInt64(dt.Rows[i]["GRNNO"]));
                    objGRNMaterial.GrossQty = Convert.ToDecimal(dt.Rows[i]["GrossQty"]);
                    objGRNMaterial.Material = objMaterial_DL.Get( Convert.ToString(dt.Rows[i]["MaterialCode"]));
                    objGRNMaterial.NetQty = Convert.ToDecimal(dt.Rows[i]["NetQty"]);
                    objGRNMaterial.Remarks = Convert.ToString(dt.Rows[i]["Remarks"]);
                    objGRNMaterial.UnitPrice = Convert.ToDecimal(dt.Rows[i]["UnitPrice"]);


                    objGRNMatCollec.Add(objGRNMaterial);
                }

                return objGRNMatCollec;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
                    
               
        
        }

        public GRNMaterials Get(long GRNNO, String MaterialCode)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", GRNNO),
                new SqlParameter("@MaterialCode", MaterialCode)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_GRNMaterials_ByID ");


                 GRNMaterials objGRNMaterial = new GRNMaterials();

                    objGRNMaterial.GRN = objGRN_DL.Get(Convert.ToInt64(dt.Rows[0]["GRNNO"]));
                    objGRNMaterial.GrossQty = Convert.ToDecimal(dt.Rows[0]["GrossQty"]);
                    objGRNMaterial.Material = objMaterial_DL.Get(Convert.ToString(dt.Rows[0]["MaterialCode"]));
                    objGRNMaterial.NetQty = Convert.ToDecimal(dt.Rows[0]["NetQty"]);
                    objGRNMaterial.Remarks = Convert.ToString(dt.Rows[0]["Remarks"]);
                    objGRNMaterial.UnitPrice = Convert.ToDecimal(dt.Rows[0]["UnitPrice"]);


                    return objGRNMaterial;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public Decimal Get_AvailableQty(long GRNNO,String MaterialCode)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNO", GRNNO),
                new SqlParameter("@MaterialCode", MaterialCode)};

                return Execute.RunSP_Decimal(Connection, "SPGET_GRNMaterials_ByID ", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        
        }

        //public System.Data.DataTable GetDataByRPDBatchID(long RPDBatchID)
        //{

        //    tblGRNMaterialsTableAdapter da = new tblGRNMaterialsTableAdapter();
        //    da.Connection = Connection;
        //    try
        //    {
        //        return da.GetDataByQtyOfRPDBatch(RPDBatchID);
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


        //public GRNMaterialsCollec GetByRPDBatchID(long RPDBatchID)
        //{
        //    tblGRNMaterialsTableAdapter da = new tblGRNMaterialsTableAdapter();
        //    da.Connection = Connection;
        //    MRPDataSet1 dsMRP = new MRPDataSet1();
        //    GRN_DL objGRNDL = new GRN_DL(Connection);
        //    Material_DL objMaterialDL = new Material_DL(Connection);
        //    GRNMaterialsCollec objGRNMaterialCollec = new GRNMaterialsCollec();
        //    try
        //    {

        //        da.FillByQtyOfRPDBatch(dsMRP.tblGRNMaterials, RPDBatchID);
        //        foreach (MRPDataSet1.tblGRNMaterialsRow dr in dsMRP.tblGRNMaterials)
        //        {
        //            GRNMaterials objGRNMaterial = new GRNMaterials();
        //            objGRNMaterial.GRN = objGRNDL.Get(Convert.ToInt64(dr.GRNNO));
        //            objGRNMaterial.GrossQty = Convert.ToDecimal(dr.GrossQty);
        //            objGRNMaterial.Material = objMaterialDL.Get(dr.MaterialCode);
        //            objGRNMaterial.NetQty = Convert.ToDecimal(dr.NetQty);
        //            objGRNMaterial.Remarks = dr.Remarks;
        //            objGRNMaterial.UnitPrice = Convert.ToDecimal(dr.UnitPrice);
        //            objGRNMaterialCollec.Add(objGRNMaterial);
        //        }
        //        return objGRNMaterialCollec;

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

    }
}
