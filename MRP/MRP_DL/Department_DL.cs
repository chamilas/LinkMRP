using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class Department_DL
    {
        SqlConnection Connection = new SqlConnection();

        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());

        public Department_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public int Add(Department objDepartment)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepName", objDepartment.DepName),
                new SqlParameter("@ExecutiveID", objDepartment.DepHead.EmployeeID),
                new SqlParameter("@DepDescription", objDepartment.DepDescription),
                new SqlParameter("@Type", objDepartment.DepType),
                new SqlParameter("@DivisionID", objDepartment.DivisionID)};


                return Execute.RunSP_RowsEffected(Connection, "SPADD_Department", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            
        }


        public long Add_New(Department objDepartment)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepName", objDepartment.DepName),
                new SqlParameter("@ExecutiveID", objDepartment.DepHead.EmployeeID),
                new SqlParameter("@DepDescription", objDepartment.DepDescription),
                new SqlParameter("@Type", objDepartment.DepType),
                new SqlParameter("@DivisionID", objDepartment.DivisionID)};


                return Execute.RunSP_RowsEffected(Connection, "SPADD_Department_Update", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int Update(Department objDepartment, long Original_DepID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepName", objDepartment.DepName),
                new SqlParameter("@ExecutiveID", objDepartment.DepHead.EmployeeID),
                new SqlParameter("@DepDescription", objDepartment.DepDescription),
                new SqlParameter("@Type", objDepartment.DepType),
                new SqlParameter("@DivisionID", objDepartment.DivisionID),
                new SqlParameter("@Original_DepID", Original_DepID)};


                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Department", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long DepID)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_DepID", DepID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Department", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        //public DepartmentCollec Get()
        //{
        //    tblDepartmentTableAdapter da = new tblDepartmentTableAdapter();
        //    da.Connection = Connection;
        //    MRPDataSet1 dsMRP = new MRPDataSet1();

        //    Employee_DL objEmpDL = new Employee_DL(Connection);

        //    DepartmentCollec objDepCollec = new DepartmentCollec();

        //    try
        //    {
        //        da.Fill(dsMRP.tblDepartment);
        //        foreach (MRPDataSet1.tblDepartmentRow dr in dsMRP.tblDepartment)
        //        {
        //            Department objDep = new Department();
        //            objDep.DepDescription = dr.DepDescription;
        //            objDep.DepHead = objEmpDL.Get(dr.ExecutiveID);
        //            objDep.DepID = Convert.ToInt64(dr.DepID);
        //            objDep.DepName = dr.DepName;
        //            objDep.DepType = dr.Type;
        //            objDep.DivisionID = Convert.ToInt64(dr.DivisionID);

        //            objDepCollec.Add(objDep);
        //        }
        //        return objDepCollec;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //        dsMRP.Dispose();
        //        objEmpDL = null;
        //    }
        //}

        public Department Get(long DepID)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepID", DepID)};

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_DepartmentByID", paramList);


                Department obj = new Department();


                obj.DepDescription = Convert.ToString(dt.Rows[0]["DepDescription"]);
                obj.DepHead = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["ExecutiveID"]));
                obj.DepID = Convert.ToInt64(dt.Rows[0]["DepID"]);
                obj.DepName = Convert.ToString(dt.Rows[0]["DepName"]);
                obj.DepType = Convert.ToString(dt.Rows[0]["Type"]);
                obj.DivisionID = Convert.ToInt64(dt.Rows[0]["DivisionID"]);


                return obj;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }


        public long Get(string ProductCode,string Type)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProductCode", ProductCode),
                 new SqlParameter("@Type", Type)};

                return Execute.RunSP_Long(Connection, "SPGET_ProductManufacturing_ByID", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }



        public Department GetBySectionID(int SectionID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SectionID", SectionID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_DepartmentBySectionID", paramList);


                Department obj = new Department();


                obj.DepDescription = Convert.ToString(dt.Rows[0]["DepDescription"]);
                obj.DepHead = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["ExecutiveID"]));
                obj.DepID = Convert.ToInt64(dt.Rows[0]["DepID"]);
                obj.DepName = Convert.ToString(dt.Rows[0]["DepName"]);
                obj.DepType = Convert.ToString(dt.Rows[0]["Type"]);
                obj.DivisionID = Convert.ToInt64(dt.Rows[0]["DivisionID"]);


                return obj;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public Department GetByDepType(string DepType)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepType", DepType)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_DepartmentByType", paramList);


                Department obj = new Department();


                obj.DepDescription = Convert.ToString(dt.Rows[0]["DepDescription"]);
                obj.DepHead = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["ExecutiveID"]));
                obj.DepID = Convert.ToInt64(dt.Rows[0]["DepID"]);
                obj.DepName = Convert.ToString(dt.Rows[0]["DepName"]);
                obj.DepType = Convert.ToString(dt.Rows[0]["Type"]);
                obj.DivisionID = Convert.ToInt64(dt.Rows[0]["DivisionID"]);


                return obj;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public Department GetByDepType_Division(string DepType,long DivisionID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepType", DepType),
                new SqlParameter("@DivisionID", DivisionID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_DepartmentByType_Division", paramList);


                Department obj = new Department();


                obj.DepDescription = Convert.ToString(dt.Rows[0]["DepDescription"]);
                obj.DepHead = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["ExecutiveID"]));
                obj.DepID = Convert.ToInt64(dt.Rows[0]["DepID"]);
                obj.DepName = Convert.ToString(dt.Rows[0]["DepName"]);
                obj.DepType = Convert.ToString(dt.Rows[0]["Type"]);
                obj.DivisionID = Convert.ToInt64(dt.Rows[0]["DivisionID"]);


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


                return Execute.RunSP_DataTable(Connection, "SPGET_Department_DataView");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView_ByUserID(long UserID)
        {


            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UserID", UserID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Department_DataView_UserID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable GetDataView(String EmployeeID)
        {
            

             try
            {

                 SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmployeeID", EmployeeID)};

                 return Execute.RunSP_DataTable(Connection, "SPGET_Department_DataView_EmployeeID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView(long DivisionID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DivisionID", DivisionID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Department_DataView_By_DivisionID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DepartmentCollec Get()
        {
            DepartmentCollec objCollec = new DepartmentCollec();

            try
            {


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Department");

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    Department obj = new Department();


                    obj.DepDescription = Convert.ToString(dt.Rows[0]["DepDescription"]);
                    obj.DepHead = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["ExecutiveID"]));
                    obj.DepID = Convert.ToInt64(dt.Rows[0]["DepID"]);
                    obj.DepName = Convert.ToString(dt.Rows[0]["DepName"]);
                    obj.DepType = Convert.ToString(dt.Rows[0]["Type"]);
                    obj.DivisionID = Convert.ToInt64(dt.Rows[0]["DivisionID"]);

                    objCollec.Add(obj);
                }

                return objCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public Department GetByName(string DepName)
        {

            try
            {


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_DepartmentByName");

                    Department obj = new Department();

                if(dt.Rows.Count>0)
                {

                    obj.DepDescription = Convert.ToString(dt.Rows[0]["DepDescription"]);
                    obj.DepHead = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["ExecutiveID"]));
                    obj.DepID = Convert.ToInt64(dt.Rows[0]["DepID"]);
                    obj.DepName = Convert.ToString(dt.Rows[0]["DepName"]);
                    obj.DepType = Convert.ToString(dt.Rows[0]["Type"]);
                    obj.DivisionID = Convert.ToInt64(dt.Rows[0]["DivisionID"]);

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
