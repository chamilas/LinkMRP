using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class User
    {
        private long _lnguserID;

        public long UserID
        {
            get { return _lnguserID; }
            set { _lnguserID = value; }
        }

        private Employee _objEmpID;

        public Employee UserEmp
        {
            get { return _objEmpID; }
            set { _objEmpID = value; }
        }

        private String _strName;

        public String UserName
        {
            get { return _strName; }
            set { _strName = value; }
        }


        private String _strPassword;

        public String UserPassword
        {
            get { return _strPassword; }
            set { _strPassword = value; }
        }

        private String _strQuiz;

        public String UserQuestion
        {
            get { return _strQuiz; }
            set { _strQuiz = value; }
        }

        private String _strAnswer;

        public String UserAnswer
        {
            get { return _strAnswer; }
            set { _strAnswer = value; }
        }

        private bool _boolStatus;

        public bool UserStatus
        {
            get { return _boolStatus; }
            set { _boolStatus = value; }
        }

        private String _strEmpID;
        public String EmployeeID
        {
            get 
            {
                _strEmpID = UserEmp.EmployeeID;
                return _strEmpID; }
        }

        private String _strEmpName;
        public String EmpName
        {
            get 
            {
                _strEmpName = UserEmp.EmployeeName;
                return _strEmpName; }
        }

        private long _UserRole;

        public long UserRoleID
        {
            get { return _UserRole; }
            set { _UserRole = value; }
        }
	
	 private DateTime _ExpiryDate;

        public DateTime ExpiryDate
        {
            get { return _ExpiryDate; }
            set { _ExpiryDate = value; }
        }

	 private bool    _Online;

        public bool Online
        {
            get { return _Online; }
            set { _Online = value; }
        }

        private DateTime _LastLoggedIn;

         public DateTime LastLoggedIn

        {
            get { return _LastLoggedIn; }
            set { _LastLoggedIn = value; }
        }



    }

    public class UserCollec : CollectionBase
    {
        public void Add(User objUser)
        {
            this.InnerList.Add(objUser);
        }
    }
}
