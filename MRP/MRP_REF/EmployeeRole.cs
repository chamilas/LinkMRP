using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class EmployeeRole
    {
        private long _lngRoleID;

        public long EmpRoleID
        {
            get { return _lngRoleID; }
            set { _lngRoleID = value; }
        }

        private String _strTitle;

        public String RoleTitle
        {
            get { return _strTitle; }
            set { _strTitle = value; }
        }

        private String _Type;

        public String Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public enum RoleType
        {
            Staff,
            Manager,
            Workforce,
            Plannig_Manager
        }
	
	
    }

    public class EmployeeRoleCollec : CollectionBase
    {
        public void Add(EmployeeRole objEmpRole)
        {
            this.InnerList.Add(objEmpRole);
        }
    }
}
