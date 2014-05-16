using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class DepartmentEmployees
    {
        private Department _objDepartment;

        public Department Department
        {
            get { return _objDepartment; }
            set { _objDepartment = value; }
        }

        private Employee _objEmployee;

        public Employee Employee
        {
            get { return _objEmployee; }
            set { _objEmployee = value; }
        }

        private DateTime _dtSince;

        public DateTime Since
        {
            get { return _dtSince; }
            set { _dtSince = value; }
        }
	
	
    }

    public class DepartmentEmployeeCollec:CollectionBase
    {
        public void Add(DepartmentEmployees objDepartmentEmployee)
        {
            this.InnerList.Add(objDepartmentEmployee);
        }
    }
}
