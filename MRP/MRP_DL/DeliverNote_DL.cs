using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using SESD.MRP.REF;

namespace DL
{
    public class DeliverNote_DL
    {
        SqlConnection Connection = new SqlConnection();

        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());

        public DeliverNote_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(DeliverNote obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DeliverNoteNo", obj.DeleveryNoteID),
                new SqlParameter("@DeliverDate", obj.DeleveryNoteDate),
                new SqlParameter("@DeliverEnterdBy", obj.DeleveryNoteEnterdBy.EmployeeID),
                new SqlParameter("@SupplierCode", obj.Supplier),
                new SqlParameter("@Remarks", obj.Remarks)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_DeliverNote", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            
        }

        public int Add_Import(DeliverNote obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DeliverNoteNo", obj.DeleveryNoteID),
                new SqlParameter("@DeliverPONO", obj.DeleveryNotePO),
                new SqlParameter("@DeliverDate", obj.DeleveryNoteDate),
                new SqlParameter("@DeliverEnterdBy", obj.DeleveryNoteEnterdBy.EmployeeID),
                new SqlParameter("@SupplierCode", obj.Supplier),
                new SqlParameter("@Remarks", obj.Remarks)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_DeliverNote_Import", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }


        public int Update(DeliverNote obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                
                new SqlParameter("@DeliverNoteNo", obj.DeleveryNoteID),
                new SqlParameter("@DeliverPONO", obj.DeleveryNotePO),
                new SqlParameter("@DeliverDate", obj.DeleveryNoteDate),
                new SqlParameter("@DeliverEnterdBy", obj.DeleveryNoteEnterdBy.EmployeeID),
                new SqlParameter("@SupplierCode", obj.Supplier),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@Original_DeliverNoteNo", obj.DeleveryNoteID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_DeliverNote", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Delete(string DeliverNoteID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_DeliverNoteNo", DeliverNoteID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_DeliverNote", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DeliverNote Get(string DeliverNoteID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DeliverNoteNo", DeliverNoteID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_DeliverNoteNoByID", paramList);

                DeliverNote obj = new DeliverNote();

                if (dt.Rows.Count>0)
                {
                    obj.DeleveryNoteID = Convert.ToString(dt.Rows[0]["DeliverNoteNo"]);
                    obj.DeleveryNoteEnterdBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["DeliverEnterdBy"]));
                    obj.DeleveryNoteDate = Convert.ToDateTime(dt.Rows[0]["DeliverDate"]);
                    obj.DeleveryNoteEnterdDate = Convert.ToDateTime(dt.Rows[0]["DeliverEnterdDate"]);
                    obj.DeleveryNotePO = Convert.ToString(dt.Rows[0]["DeliverPONO"]);
                    obj.DeleveryNoteStatus = (DeliverNote.Status)(dt.Rows[0]["Status"]);
                    obj.Supplier=Convert.ToInt64(dt.Rows[0]["SupplierCode"]);
                    obj.Remarks = Convert.ToString(dt.Rows[0]["Remarks"]);
                }

                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }



        public DataTable GetData(string DeliverNoteNo)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DeliverNoteNo", DeliverNoteNo)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_DeliverNoteMaterials_By_DeliverNote", paramList);

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }


        public DataTable GetData(int Status, string MatCatID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status", Status),
                new SqlParameter("@MatCatID", MatCatID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_DeliverNote_ByState", paramList);

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }





    }
}
