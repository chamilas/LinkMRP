using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class User_DL
    {
        SqlConnection Connection = new SqlConnection();
        public User_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(User obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpID", obj.EmployeeID),
                new SqlParameter("@UserName", obj.UserName),
                new SqlParameter("@Password", obj.UserPassword),
                 new SqlParameter("@Question", obj.UserQuestion),
                 new SqlParameter("@Answer", obj.UserAnswer),
                new SqlParameter("@Status", obj.UserStatus)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_User", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(User obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpID", obj.EmployeeID),
                new SqlParameter("@UserName", obj.UserName),
                new SqlParameter("@Password", obj.UserPassword),
                 new SqlParameter("@Question", obj.UserQuestion),
                 new SqlParameter("@Answer", obj.UserAnswer),
                new SqlParameter("@Status", obj.UserStatus),
                new SqlParameter("@UserRoleID", obj.UserRoleID),
                new SqlParameter("@Original_UserID", obj.UserID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_User", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_OnlineState(User obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Online", obj.Online),
                new SqlParameter("@Original_UserID", obj.UserID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_User_OnlineState", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int CheckForPasswordExpiry(User obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                
                new SqlParameter("@UserID", obj.UserID),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output(Connection, "SPGET_User_PsswordExpired", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int Update_Status(User obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Status", obj.UserStatus),
                new SqlParameter("@Original_UserID", obj.UserID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_User_Status", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long UserID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Original_UserID", UserID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_User", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public UserCollec Get()
        {
            UserCollec objUserCollec = new UserCollec();
            Employee_DL objEmpDL = new Employee_DL(Connection);

            try
            {


                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_User");


                for (int i = 0; i < dt.Rows.Count;i++ )
                {
                    User objUser = new User();
                    objUser.UserAnswer = Convert.ToString(dt.Rows[i]["Answer"]);
                    objUser.UserEmp = objEmpDL.Get(Convert.ToString(dt.Rows[i]["EmpID"]));
                    objUser.UserID = Convert.ToInt64(dt.Rows[i]["UserID"]);
                    objUser.UserName = Convert.ToString(dt.Rows[i]["UserName"]);
                    objUser.UserPassword = Convert.ToString(dt.Rows[i]["Password"]);
                    objUser.UserQuestion = Convert.ToString(dt.Rows[i]["Question"]);
                    objUser.UserStatus = Convert.ToBoolean(dt.Rows[i]["Status"]);
                    objUser.UserRoleID = Convert.ToInt64(dt.Rows[i]["UserRoleID"]);

                    objUserCollec.Add(objUser);
                }
                return objUserCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


          
              
        }

        public User Get(long UserID)
        {
           User objUser = new User();
            Employee_DL objEmpDL = new Employee_DL(Connection);

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@UserID", UserID)};


                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_UserByID");

 
                    objUser.UserAnswer = Convert.ToString(dt.Rows[0]["Answer"]);
                    objUser.UserEmp = objEmpDL.Get(Convert.ToString(dt.Rows[0]["EmpID"]));
                    objUser.UserID = Convert.ToInt64(dt.Rows[0]["UserID"]);
                    objUser.UserName = Convert.ToString(dt.Rows[0]["UserName"]);
                    objUser.UserPassword = Convert.ToString(dt.Rows[0]["Password"]);
                    objUser.UserQuestion = Convert.ToString(dt.Rows[0]["Question"]);
                    objUser.UserStatus = Convert.ToBoolean(dt.Rows[0]["Status"]);
                    objUser.UserRoleID = Convert.ToInt64(dt.Rows[0]["UserRoleID"]);

                
                return objUser;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }



        public User Login(String UserName, String Password)
        {
            
            User objUser = new User();
            Employee_DL objEmpDL = new Employee_DL(Connection);


            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@Password", Password)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_User_Login",paramList);

                if (dt.Rows.Count > 0)
                {
                    objUser.UserAnswer = Convert.ToString(dt.Rows[0]["Answer"]);
                    objUser.UserEmp = objEmpDL.Get(Convert.ToString(dt.Rows[0]["EmpID"]));
                    objUser.UserID = Convert.ToInt64(dt.Rows[0]["UserID"]);
                    objUser.UserName = Convert.ToString(dt.Rows[0]["UserName"]);
                    objUser.UserPassword = Convert.ToString(dt.Rows[0]["Password"]);
                    objUser.UserQuestion = Convert.ToString(dt.Rows[0]["Question"]);
                    objUser.UserStatus = Convert.ToBoolean(dt.Rows[0]["Status"]);
                    objUser.UserRoleID = Convert.ToInt64(dt.Rows[0]["UserRoleID"]);

                    if (dt.Rows[0]["LastLoggedIn"] != DBNull.Value)
                    {
                        objUser.LastLoggedIn = Convert.ToDateTime(dt.Rows[0]["LastLoggedIn"]);
                    }

                    if (dt.Rows[0]["Online"] != DBNull.Value)
                    {
                        objUser.Online = Convert.ToBoolean(dt.Rows[0]["Online"]);
                    }

                    if (dt.Rows[0]["ExpiryDate"] != DBNull.Value)
                    {
                        objUser.ExpiryDate = Convert.ToDateTime(dt.Rows[0]["ExpiryDate"]);
                    }
                }
                return objUser;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }
    }
}
