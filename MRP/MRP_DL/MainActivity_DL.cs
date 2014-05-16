using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MainActivity_DL
    {
        SqlConnection Connection = new SqlConnection();


        public MainActivity_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(MainActivity objMainActivity)
        {
            return 0;
        }

        public int Update(MainActivity objMainActivity)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepID", objMainActivity.DepID),
                 new SqlParameter("@MainActID", objMainActivity.MainActID),
                new SqlParameter("@SectionID", objMainActivity.SectionID),
                new SqlParameter("@Type", objMainActivity.Type)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MainActivity", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Delete(long MainActivityID)
        {
            return 0;
        }

        public MainActivityCollec Get()
        {
            try
            {

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MainActivity_View");

                MainActivityCollec objMainActivityCollec = new MainActivityCollec();

                for (int i = 0; i < dt.Rows.Count;i++ )
                {
                    MainActivity objMainActivity = new MainActivity();
                    objMainActivity.MainActID = Convert.ToInt64(dt.Rows[i]["MainActID"]);
                    objMainActivity.MainActivityTitle = Convert.ToString(dt.Rows[i]["MainActivity"]);
                    objMainActivity.DepID = Convert.ToInt64(dt.Rows[i]["DepID"]);
                    objMainActivity.Type = (MainActivity.LayoutType)Convert.ToInt64(dt.Rows[i]["Type"]);

                    objMainActivityCollec.Add(objMainActivity);
                }
                return objMainActivityCollec;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            } 
            
                
            
        }


        public MainActivityCollec Get(String DepType)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepType", DepType)
                };

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MainActivity_By_DepType",paramList);

                MainActivityCollec objMainActivityCollec = new MainActivityCollec();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    MainActivity objMainActivity = new MainActivity();
                    objMainActivity.MainActID = Convert.ToInt64(dt.Rows[i]["MainActID"]);
                    objMainActivity.MainActivityTitle = Convert.ToString(dt.Rows[i]["MainActivity"]);
                    objMainActivity.DepID = Convert.ToInt64(dt.Rows[i]["DepID"]);
                    objMainActivity.Type = (MainActivity.LayoutType)Convert.ToInt64(dt.Rows[i]["Type"]);

                    objMainActivityCollec.Add(objMainActivity);
                }
                return objMainActivityCollec;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            } 
        }

        public MainActivity Get(long MainActivityID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MainActivityID", MainActivityID)
                };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MainActivityByID", paramList);

                MainActivity objMainActivity = new MainActivity();

                
                    objMainActivity.MainActID = Convert.ToInt64(dt.Rows[0]["MainActID"]);
                    objMainActivity.MainActivityTitle = Convert.ToString(dt.Rows[0]["MainActivity"]);
                    objMainActivity.DepID = Convert.ToInt64(dt.Rows[0]["DepID"]);
                    objMainActivity.Type = (MainActivity.LayoutType)Convert.ToInt64(dt.Rows[0]["Type"]);
                    objMainActivity.SectionID = Convert.ToInt64(dt.Rows[0]["SectionID"]);

                return objMainActivity;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            } 
        }

        public string GetNameByID(long ActID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MainActID", ActID)
                };


                return Execute.RunSP_String(Connection, "SPGET_MainActivityNameByID", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            } 
        }

        public MainActivity GetByName(string ActName)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActName", ActName)
                };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MainActivityByName", paramList);

                MainActivity objMainActivity = new MainActivity();


                objMainActivity.MainActID = Convert.ToInt64(dt.Rows[0]["MainActID"]);
                objMainActivity.MainActivityTitle = Convert.ToString(dt.Rows[0]["MainActivity"]);
                objMainActivity.DepID = Convert.ToInt64(dt.Rows[0]["DepID"]);
                objMainActivity.Type = (MainActivity.LayoutType)Convert.ToInt64(dt.Rows[0]["Type"]);
                objMainActivity.SectionID = Convert.ToInt64(dt.Rows[0]["SectionID"]);

                return objMainActivity;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            } 
        }



        public System.Data.DataTable Get_Data_View()
        {
            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_MainActivity_View");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

     

      
        public System.Data.DataTable GetByDepID(long DepID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepID", DepID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MainActivityByDepID", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            } 
        }

        public System.Data.DataTable GetByDepType(String DepartmentType)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepType", DepartmentType)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MainActivity_By_DepType", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            } 
        
        }

        public System.Data.DataTable Get_Data_PRPD_Activity(string PRPDBatchID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDBatchID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MainActivity_ByPRPDBatchID", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }




    }
}
