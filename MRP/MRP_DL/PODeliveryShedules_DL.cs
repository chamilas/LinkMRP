using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class PODeliveryShedules_DL
    {
        SqlConnection Connection = new SqlConnection();

        public PODeliveryShedules_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public long Add(PODeliveryShedule obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PONO", obj.PONO),
                new SqlParameter("@MaterialCode", obj.MaterialCode),
                new SqlParameter("@Qty", obj.Qty),
                new SqlParameter("@DeliveryOrder", obj.ID),
                 new SqlParameter("@ExpectedDate", obj.ExpectedDate),
                 new SqlParameter("@ShipmentDate", obj.ShipmentDate)

                
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_PODeliverySchedule", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(PODeliveryShedule obj)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MaterialCode", obj.MaterialCode),
                new SqlParameter("@Qty", obj.Qty),
                new SqlParameter("@ExpectedDate", obj.ExpectedDate),
                new SqlParameter("@ShipmentDate", obj.ShipmentDate),
                new SqlParameter("@ID", obj.ID)

                
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PODeliveryShedule", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        
        public int Update_Issue(MR obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@IssuedBy", obj.MRIssuedBy),
                new SqlParameter("@Status", obj.MRStatus),
                new SqlParameter("@MRNO", obj.MRNO)
                
                                                                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MR_Issue", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Delete(long MRNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_MRNO", MRNO)
                
                                                                };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MR", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public DataTable Get_ByPOID(String PONO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PONO", PONO)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_PODeliverySchedule_By_PO", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public PODeliveryShedule Get(String ID)
        {
            try
            {
                DataTable dt = new DataTable();
                PODeliveryShedule obj = new PODeliveryShedule();

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ID", ID)
                                                                };

                dt = Execute.RunSP_DataTable(Connection, "SPGET_PODeliverySchedule_By_ID", paramList);


                if (dt.Rows.Count>0)
                {


                    obj.ExpectedDate = Convert.ToDateTime(dt.Rows[0]["ExpectedDate"]);
                    obj.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
                    obj.MaterialCode = Convert.ToString(dt.Rows[0]["MaterialCode"]);
                    obj.PONO = Convert.ToString(dt.Rows[0]["PONO"]);
                    obj.Qty = Convert.ToDecimal(dt.Rows[0]["Qty"]);
                    obj.ShipmentDate = Convert.ToDateTime(dt.Rows[0]["ShipmentDate"]);

                }

                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }






        
    }
}
