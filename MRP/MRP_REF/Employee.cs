using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Employee
    {
        private String _strID;

        public String EmployeeID
        {
            get { return _strID; }
            set { _strID = value; }
        }

        private String _strName;

        public String EmployeeName
        {
            get { return _strName; }
            set { _strName = value; }


        }

        private String _strEmpNameID;
        public String EmployeeNameID
        {
            get 
            {
                _strEmpNameID = EmployeeID + " - " + EmployeeName;
                return _strEmpNameID; 
            
            }
        }
	

        private EmployeeRole _objRole;

        public EmployeeRole EmployeeRole
        {
            get { return _objRole; }
            set { _objRole = value; }
        }

        private bool _boolStatus;

        public bool EmpStatus
        {
            get { return _boolStatus; }
            set { _boolStatus = value; }
        }

        private Decimal _RatePerHour;

        public Decimal RatePerHour
        {
            get { return _RatePerHour; }
            set { _RatePerHour = value; }
        }

        private Decimal _OTRatePerHour;

        public Decimal OTRatePerHour
        {
            get { return _OTRatePerHour; }
            set { _OTRatePerHour = value; }
        }

        private String _EmpType;

        public String EmpType
        {
            get { return _EmpType; }
            set { _EmpType = value; }
        }

        private long? _Section;

        public long? Section
        {
            get { return _Section; }
            set { _Section = value; }
        }
	
	
	
    }

    public class EmployeeCollec : CollectionBase
    {
        public void Add(Employee objEmployee)
        {
            this.InnerList.Add(objEmployee);
            
        }
    }
}
