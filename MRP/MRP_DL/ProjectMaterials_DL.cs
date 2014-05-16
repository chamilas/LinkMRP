using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DL
{
    public class ProjectMaterials_DL
    {
        SqlConnection Connection = new SqlConnection();
        private SqlConnection sqlConnection;

        public ProjectMaterials_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(ProjectMaterials Obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProjectID", Obj.ProjectID),
                new SqlParameter("@ItemCode", Obj.MaterialID),
                new SqlParameter("@UsedQty", Obj.UsedQty),
                new SqlParameter("@DamagedQty", Obj.DamagedQty),
                new SqlParameter("@UnitPrice", Obj.UnitPrice),
                new SqlParameter("@EnteredBy", Obj.EnteredBy),
                new SqlParameter("@ItemTypeName",Obj.ItemTypeName),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_ProjectMaterials", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetProjectMaterials_DataView(int ProjectID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProjetID",ProjectID)
                };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_ProjectMaterials", paramList);

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

//----------------------------------------------------------------------------------------------------

        public System.Data.DataTable GetDataView(String StoreID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID", StoreID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Stock_ByStore", paramList);


                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public System.Data.DataTable GetProjectMaterial_Availability(String MaterialCode, Double quantity,String MaterialType)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                 new SqlParameter("@MaterialID", MaterialCode),
                 new SqlParameter("@MaterialType", MaterialType),
                 new SqlParameter("@Qty",quantity)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_ProjectMaterial_Availability", paramList);


                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

    }
}
