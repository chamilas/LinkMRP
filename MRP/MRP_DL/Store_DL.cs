using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class Store_DL
    {
        SqlConnection Connection = new SqlConnection();
        public Store_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(Store obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID", obj.StoreID),
                new SqlParameter("@StoreDepID", obj.StoreDepartment.DepID),
                 new SqlParameter("@StoreName", obj.StoreName),
                 new SqlParameter("@StoreDesription", obj.StoreDescription),
                new SqlParameter("@StoreKeeper", obj.StoreKeeper.EmployeeID)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Store", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int SetDefault(String StoreID, long DepID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID",StoreID),
                new SqlParameter("@DepID", DepID)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Store_Default", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(Store obj, String Original_StoreID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID", obj.StoreID),
                new SqlParameter("@StoreDepID", obj.StoreDepartment.DepID),
                 new SqlParameter("@StoreName", obj.StoreName),
                 new SqlParameter("@StoreDesription", obj.StoreDescription),
                new SqlParameter("@StoreKeeper", obj.StoreKeeper.EmployeeID),
                new SqlParameter("@Original_StoreID", obj.StoreKeeper.EmployeeID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Store", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(String StoreID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Original_StoreID", StoreID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Store", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public StoreCollec Get()
        {
         


            Department_DL objDep_DL = new Department_DL(Connection);
            Employee_DL objEmp_DL = new Employee_DL(Connection);
            StoreCollec objStoreCollec = new StoreCollec();

            try
            {


                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_Store");


                for (int i = 0; i < dt.Rows.Count;i++)
                {
                    Store objStore = new Store();
                    objStore.StoreDepartment = objDep_DL.Get(Convert.ToInt64(dt.Rows[i]["StoreDepID"]));
                    objStore.StoreDescription = Convert.ToString(dt.Rows[i]["StoreDesription"]);
                    objStore.StoreID = Convert.ToString(dt.Rows[i]["StoreID"]);
                    objStore.StoreKeeper = objEmp_DL.Get(Convert.ToString(dt.Rows[i]["StoreKeeper"]));
                    objStore.StoreName = Convert.ToString(dt.Rows[i]["StoreName"]);

                    objStoreCollec.Add(objStore);
                }

                return objStoreCollec;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

           
        }

        public StoreCollec Get(long DepID)
        {

            Department_DL objDep_DL = new Department_DL(Connection);
            Employee_DL objEmp_DL = new Employee_DL(Connection);
            StoreCollec objStoreCollec = new StoreCollec();

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@DepID", DepID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Stores_ByDep",paramList);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Store objStore = new Store();
                    objStore.StoreDepartment = objDep_DL.Get(Convert.ToInt64(dt.Rows[i]["StoreDepID"]));
                    objStore.StoreDescription = Convert.ToString(dt.Rows[i]["StoreDesription"]);
                    objStore.StoreID = Convert.ToString(dt.Rows[i]["StoreID"]);
                    objStore.StoreKeeper = objEmp_DL.Get(Convert.ToString(dt.Rows[i]["StoreKeeper"]));
                    objStore.StoreName = Convert.ToString(dt.Rows[i]["StoreName"]);

                    objStoreCollec.Add(objStore);
                }

                return objStoreCollec;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public Store Get(String StoreID)
        {
            Department_DL objDep_DL = new Department_DL(Connection);
            Employee_DL objEmp_DL = new Employee_DL(Connection);
            Store objStore = new Store();

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@StoreID", StoreID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_StoreByID", paramList);

                if (dt.Rows.Count > 0)
                {

                    objStore.StoreDepartment = objDep_DL.Get(Convert.ToInt64(dt.Rows[0]["StoreDepID"]));
                    objStore.StoreDescription = Convert.ToString(dt.Rows[0]["StoreDesription"]);
                    objStore.StoreID = Convert.ToString(dt.Rows[0]["StoreID"]);
                    objStore.StoreKeeper = objEmp_DL.Get(Convert.ToString(dt.Rows[0]["StoreKeeper"]));
                    objStore.StoreName = Convert.ToString(dt.Rows[0]["StoreName"]);
                }
                return objStore;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public Store Get_Default(String DepID)
        {
            Department_DL objDep_DL = new Department_DL(Connection);
            Employee_DL objEmp_DL = new Employee_DL(Connection);
            Store objStore = new Store();

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@StoreDepID", DepID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Store_Default", paramList);


                objStore.StoreDepartment = objDep_DL.Get(Convert.ToInt64(dt.Rows[0]["StoreDepID"]));
                objStore.StoreDescription = Convert.ToString(dt.Rows[0]["StoreDesription"]);
                objStore.StoreID = Convert.ToString(dt.Rows[0]["StoreID"]);
                objStore.StoreKeeper = objEmp_DL.Get(Convert.ToString(dt.Rows[0]["StoreKeeper"]));
                objStore.StoreName = Convert.ToString(dt.Rows[0]["StoreName"]);

                return objStore;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }



        public StoreCollec Get_By_User(long UserID)
        {
            Department_DL objDep_DL = new Department_DL(Connection);
            Employee_DL objEmp_DL = new Employee_DL(Connection);
            StoreCollec objStoreCollec = new StoreCollec();

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@UserID", UserID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Stores_By_EmployeeID", paramList);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Store objStore = new Store();
                    objStore.StoreDepartment = objDep_DL.Get(Convert.ToInt64(dt.Rows[i]["StoreDepID"]));
                    objStore.StoreDescription = Convert.ToString(dt.Rows[i]["StoreDesription"]);
                    objStore.StoreID = Convert.ToString(dt.Rows[i]["StoreID"]);
                    objStore.StoreKeeper = objEmp_DL.Get(Convert.ToString(dt.Rows[i]["StoreKeeper"]));
                    objStore.StoreName = Convert.ToString(dt.Rows[i]["StoreName"]);

                    objStoreCollec.Add(objStore);
                }

                return objStoreCollec;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public Store Get_Default(long DepID)
        {
            Department_DL objDep_DL = new Department_DL(Connection);
            Employee_DL objEmp_DL = new Employee_DL(Connection);
            Store objStore = new Store();

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@StoreDepID", DepID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Store_Default", paramList);

                    objStore.StoreDepartment = objDep_DL.Get(Convert.ToInt64(dt.Rows[0]["StoreDepID"]));
                    objStore.StoreDescription = Convert.ToString(dt.Rows[0]["StoreDesription"]);
                    objStore.StoreID = Convert.ToString(dt.Rows[0]["StoreID"]);
                    objStore.StoreKeeper = objEmp_DL.Get(Convert.ToString(dt.Rows[0]["StoreKeeper"]));
                    objStore.StoreName = Convert.ToString(dt.Rows[0]["StoreName"]);


                return objStore;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public System.Data.DataTable GetData()
        {

            try
            {


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Store");


                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

           
        }

    }
}
