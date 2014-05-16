using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class PackingType_DL
    {
        SqlConnection Connection = new SqlConnection();

        Form_DL objForm_DL = new Form_DL(ConnectionStringClass.GetConnection());
        Unit_DL objUnit_DL = new Unit_DL(ConnectionStringClass.GetConnection());

        public PackingType_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public int Add(PackingType obj)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PackingTitle", obj.PackingTitle),
                new SqlParameter("@PackingUnitID", obj.PackingUnit.UnitID),
                new SqlParameter("@PackingQty", obj.PackingQty),
                new SqlParameter("@Type", obj.Type),
                new SqlParameter("@PackingID", obj.PackingID)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_PackingType", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(PackingType obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PackingTitle", obj.PackingTitle),
                new SqlParameter("@Type", obj.Type),
                new SqlParameter("@PackingUnitID", obj.PackingUnit.UnitID),
                new SqlParameter("@PackingQty", obj.PackingQty),
                new SqlParameter("@PackingID", obj.PackingID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PackingType", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long PackingTypeID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PackingID",PackingTypeID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_PackingType", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public PackingTypeCollec Get()
        {
            return null;
        }

        public PackingType Get(long PackingTypeID)
        {
            
            
             try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PackingType",PackingTypeID)};

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_PackingTypeByID", paramList);


                PackingType obj = new PackingType();


                obj.Type = Convert.ToString(dt.Rows[0]["Type"]);
                obj.PackingID = Convert.ToInt64(dt.Rows[0]["PackingID"]);
                obj.PackingTitle = Convert.ToString(dt.Rows[0]["PackingTitle"]);
                obj.PackingQty = Convert.ToDecimal(dt.Rows[0]["PackingQty"]);
                obj.PackingUnit = objUnit_DL.Get(Convert.ToInt64(dt.Rows[0]["PackingUnitID"]));


                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView()
        {
            try
            {

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PackingTypeDataView");

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataComboList()
        {


            try
            {


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PackingTypeComboList");

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataByType(string Type)
        {


            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Type",Type
                    )};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PackingTypeByType", paramList);


                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
