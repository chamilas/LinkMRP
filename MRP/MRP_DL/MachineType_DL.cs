using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MachineType_DL
    {
        SqlConnection Connection = new SqlConnection();


        public MachineType_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public int Add(MachineType obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MachineType", obj.MachineTypeTitle)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MachineType", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(MachineType obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MachineType", obj.MachineTypeTitle),
                new SqlParameter("@Original_MachineTypeID", obj.MachineTypeID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MachineType", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long MachineTypeID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_MachineTypeID", MachineTypeID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MachineType", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public MachineTypeCollec Get()
        {
            return null;
        }

        public MachineType Get(long MachineTypeID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MachineTypeID", MachineTypeID)};

                DataTable dt=Execute.RunSP_DataTable(Connection, "SPGET_MachineTypeByID", paramList);

                MachineType objMachineType = new MachineType();

                objMachineType.MachineTypeID = Convert.ToInt64(dt.Rows[0]["MachineTypeID"]);
                objMachineType.MachineTypeTitle = Convert.ToString(dt.Rows[0]["MachineType"]);

                return objMachineType;

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


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MachineType");


                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
