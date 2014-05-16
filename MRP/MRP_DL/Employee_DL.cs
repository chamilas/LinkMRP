using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class Employee_DL
    {
        SqlConnection Connection = new SqlConnection();

        EmployeeRole_DL objEmployeeRole_DL = new EmployeeRole_DL(ConnectionStringClass.GetConnection());


        public Employee_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public int Add(Employee objEmployee)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpID", objEmployee.EmployeeID),
                new SqlParameter("@EmpName", objEmployee.EmployeeName),
                new SqlParameter("@EmpRoleID", objEmployee.EmployeeRole.EmpRoleID),
                new SqlParameter("@EmpStatus", objEmployee.EmpStatus),
                new SqlParameter("@RatePerHour", objEmployee.RatePerHour),
                new SqlParameter("@OTRatePerHour", objEmployee.RatePerHour),
                new SqlParameter("@EmpType", objEmployee.EmpType),
                new SqlParameter("@SectionID", objEmployee.Section)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Employee", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Add_Staff(Employee objEmployee)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpID", objEmployee.EmployeeID),
                new SqlParameter("@EmpName", objEmployee.EmployeeName),
                new SqlParameter("@EmpRoleID", objEmployee.EmployeeRole.EmpRoleID),
                new SqlParameter("@EmpStatus", objEmployee.EmpStatus),
                new SqlParameter("@RatePerHour", objEmployee.RatePerHour),
                new SqlParameter("@OTRatePerHour", objEmployee.RatePerHour),
                new SqlParameter("@EmpType", objEmployee.EmpType)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Employee_Staff", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int Update(Employee objEmployee)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpID", objEmployee.EmployeeID),
                new SqlParameter("@EmpName", objEmployee.EmployeeName),
                new SqlParameter("@EmpRoleID", objEmployee.EmployeeRole.EmpRoleID),
                new SqlParameter("@EmpStatus", objEmployee.EmpStatus),
                new SqlParameter("@RatePerHour", objEmployee.RatePerHour),
                new SqlParameter("@OTRatePerHour", objEmployee.OTRatePerHour),
                new SqlParameter("@EmpType", objEmployee.EmpType),
                new SqlParameter("@SectionID", objEmployee.Section)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Employee", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Update_Staff(Employee objEmployee, String OriginalEmpID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpID", objEmployee.EmployeeID),
                new SqlParameter("@EmpName", objEmployee.EmployeeName),
                new SqlParameter("@EmpRoleID", objEmployee.EmployeeRole.EmpRoleID),
                new SqlParameter("@EmpStatus", objEmployee.EmpStatus),
                new SqlParameter("@RatePerHour", objEmployee.RatePerHour),
                new SqlParameter("@OTRatePerHour", objEmployee.RatePerHour),
                new SqlParameter("@EmpType", objEmployee.EmpType)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Employee_Staff", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(String EmployeeID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpID", EmployeeID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Employee", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public EmployeeCollec Get()
        {
            Section_DL objSectionDL = new Section_DL(Connection);
            EmployeeRole_DL objEmpRole = new EmployeeRole_DL(Connection);
            EmployeeCollec objEmployeeCollec = new EmployeeCollec();

            try
            {



                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_Employee");


                for (int i=0;i<dt.Rows.Count;i++)
                {

                    Employee objEmp = new Employee();

                    objEmp.EmployeeID = Convert.ToString(dt.Rows[i]["EmpID"]);
                    objEmp.EmployeeName = Convert.ToString(dt.Rows[i]["EmpName"]);
                    objEmp.EmployeeRole = objEmpRole.Get(Convert.ToInt64(dt.Rows[i]["EmpRoleID"]));
                    objEmp.EmpStatus = Convert.ToBoolean(dt.Rows[i]["EmpStatus"]);
                    objEmp.EmpType = Convert.ToString(dt.Rows[i]["EmpType"]);
                    objEmp.OTRatePerHour = Convert.ToDecimal(dt.Rows[i]["OTRatePerHour"]);
                    objEmp.RatePerHour = Convert.ToDecimal(dt.Rows[i]["RatePerHour"]);
                    objEmp.Section = Convert.ToInt64(dt.Rows[i]["SectionID"]);

                    objEmployeeCollec.Add(objEmp);
                }
                return objEmployeeCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            
            }
        

        public Employee Get(String EmployeeID)
        {
           Section_DL objSectionDL = new Section_DL(Connection);
            EmployeeRole_DL objEmpRole = new EmployeeRole_DL(Connection);
            Employee objEmp = new Employee();

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpID", EmployeeID)};

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_EmployeeByID",paramList);

                if (dt.Rows.Count > 0)
                {
                    objEmp.EmployeeID = Convert.ToString(dt.Rows[0]["EmpID"]);
                    objEmp.EmployeeName = Convert.ToString(dt.Rows[0]["EmpName"]);
                    objEmp.EmployeeRole = objEmpRole.Get(Convert.ToInt64(dt.Rows[0]["EmpRoleID"]));
                    objEmp.EmpStatus = Convert.ToBoolean(dt.Rows[0]["EmpStatus"]);
                    objEmp.EmpType = Convert.ToString(dt.Rows[0]["EmpType"]);
                    objEmp.OTRatePerHour = Convert.ToDecimal(dt.Rows[0]["OTRatePerHour"]);
                    objEmp.RatePerHour = Convert.ToDecimal(dt.Rows[0]["RatePerHour"]);
                    objEmp.Section = Convert.ToInt64(dt.Rows[0]["SectionID"]);

                }
               
                return objEmp;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            
            }
        

        //public System.Data.DataTable GetDataView(int Type)
        //{
        //    try
        //    {


        //        SqlParameter[] paramList = new SqlParameter[] {
                
        //        new SqlParameter("@EmpID", EmployeeID)};

        //        return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Employee", paramList);

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //}

        public System.Data.DataTable GetDataView()
        {
            try
            {


                return Execute.RunSP_DataTable(Connection, "SPGET_Employee");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView(long DepID)
        {
         try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepID", DepID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Employee_By_Department");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable Get_By_RoleType(String RoleType, bool Type)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpRoleType", RoleType),
                 new SqlParameter("@Type", Type)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Employee_View_By_EmpRoleType",paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

   public System.Data.DataTable Get_Workers_BySection(int SectionID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                 new SqlParameter("@SectionID", SectionID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Employee_Workers_BySection", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



   public System.Data.DataTable Get_Workers()
   {
       try
       {
           return Execute.RunSP_DataTable(Connection, "SPGET_Employee_Workers");

       }
       catch (Exception ex)
       {

           throw new Exception(ex.Message, ex);
       }
   }



   public System.Data.DataTable Get_Workers_Outsource(int SectionID)
   {
       try
       {
           SqlParameter[] paramList = new SqlParameter[] {
                
                 new SqlParameter("@SectionID", SectionID)};

           return Execute.RunSP_DataTable(Connection, "SPGET_Employee_Workers_Outsource", paramList);

       }
       catch (Exception ex)
       {

           throw new Exception(ex.Message, ex);
       }
   }




        public System.Data.DataTable Get_By_DepType(String DepType, bool Status)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepType", DepType),
                 new SqlParameter("@Status", Status)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Employee_View_DepType",paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable Get_By_DepType(String DepType, EmployeeRole.RoleType EmpRoleType, bool Status, bool IsEmpType)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepType", DepType),
                 new SqlParameter("@EmpType", EmpRoleType),
                  new SqlParameter("@Status", Status),
                 new SqlParameter("@IsEmpType", IsEmpType)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Employee_View_DepType_RoleType");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        //public System.Data.DataTable Get_By_RoleType(String RoleType, bool Type)
        //{
        //    try
        //    {
        //        SqlParameter[] paramList = new SqlParameter[] {
        //         new SqlParameter("@EmpRoleType", RoleType),
        //         new SqlParameter("@Type", Type)};

        //        return Execute.RunSP_DataTable(Connection, "SPGET_Employee_View_By_EmpRoleType_All",paramList);

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //}

        //public System.Data.DataTable Get_By_RoleType(String RoleType1, String RoleType2, String DivisionType, bool Type)
        //{
        //    try
        //    {
        //        SqlParameter[] paramList = new SqlParameter[] {
        //         new SqlParameter("@EmpRoleType1", RoleType1),
        //         new SqlParameter("@EmpRoleType2", RoleType2),
        //        new SqlParameter("@DivisionType", DivisionType)};

        //        return Execute.RunSP_DataTable(Connection, "SPGET_Employee_View_By_EmpRoleTypes");

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //}

        public System.Data.DataTable GetDataView_All()
        {

        

        try
            {



                return Execute.RunSP_DataTable(Connection, "SPGET_EmployeesFull");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView_By_Section(long SectionID)
        {


            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@SectionID", SectionID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Employee_View_Section");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView_By_Section(String RoleType, long SectionID, bool Type)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@EmpRoleType", RoleType),
                 new SqlParameter("@SectionID", SectionID),
                 new SqlParameter("@Type", Type)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Employee_View_By_EmpRoleType_Section");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetInstructors()
        {
            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_EmployeeByInstructors");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

    }
}
