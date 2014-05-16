using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using SESD.MRP.REF;
using DL;
using System.Data;

namespace DL
{
    public class RPDBatchActPackingDetails_DL
    {

        SqlConnection Connection = new SqlConnection();

        public RPDBatchActPackingDetails_DL(SqlConnection conn)
        {
            Connection = conn;
        }

        public long Add(RPDBatchActPackingDetails obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {

                new SqlParameter("@RPDPackDetails", obj.RPDPackDetails),
                new SqlParameter("@RPDBatchActID", obj.RPDBatchActID),
                new SqlParameter("@MaterialCode", obj.MaterialCode),
                new SqlParameter("@NoOfPackets", obj.NoOfPackets),
                new SqlParameter("@PackSize", obj.PackSize),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output(Connection, "SPADD_RPDBatchActPackingDetails_Update", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Delete(long ID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_RPDPackDetails" , ID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_RPDBatchActPackingDetails", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public RPDBatchActPackingDetails Get(long ID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDPackDetails",ID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActPackingDetails_By_ID", paramList);

                RPDBatchActPackingDetails obj = new RPDBatchActPackingDetails();

                if (dt.Rows.Count > 0)
                {

                    obj.RPDPackDetails = Convert.ToInt64(dt.Rows[0]["RPDPackDetails"]);
                    obj.RPDBatchActID = Convert.ToInt64(dt.Rows[0]["RPDBatchActID"]);
                    obj.MaterialCode = Convert.ToString(dt.Rows[0]["MaterialCode"]);
                    obj.NoOfPackets = Convert.ToInt64(dt.Rows[0]["NoOfPackets"]);
                    obj.PackSize = Convert.ToDecimal(dt.Rows[0]["PackSize"]);

                }

                return obj;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public RPDBatchActPackingDetailsCollec Get_By_BatchAct(long ID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchActID", ID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActPackingDetails_BatchActID", paramList);

                RPDBatchActPackingDetailsCollec objCollec = new RPDBatchActPackingDetailsCollec();
                RPDBatchActPackingDetails obj = new RPDBatchActPackingDetails();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {


                        obj.RPDPackDetails = Convert.ToInt64(dt.Rows[i]["RPDPackDetails"]);
                        obj.RPDBatchActID = Convert.ToInt64(dt.Rows[i]["RPDBatchActID"]);
                        obj.MaterialCode = Convert.ToString(dt.Rows[i]["MaterialCode"]);
                        obj.NoOfPackets = Convert.ToInt64(dt.Rows[i]["NoOfPackets"]);
                        obj.PackSize = Convert.ToDecimal(dt.Rows[i]["PackSize"]);

                        objCollec.Add(obj);
                    }
                }

                return objCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_By_BatchAct_View(long ID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {

                 new SqlParameter("@RPDBatchActID",ID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActPackingDetails_View_By_RPDBatchActID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
