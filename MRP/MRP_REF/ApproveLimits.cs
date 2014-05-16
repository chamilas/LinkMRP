using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class ApproveLimits
    {

        private long _ID;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private String _Employee;

        public String Employee
        {
            get { return _Employee; }
            set { _Employee = value; }
        }

        private String _DocumentType;

        public String DocumentType
        {
            get { return _DocumentType; }
            set { _DocumentType = value; }
        }

        private long _Department;

        public long Department
        {
            get { return _Department; }
            set { _Department = value; }
        }


        private Decimal _FromValue;

        public Decimal FromValue
        {
            get { return _FromValue; }
            set { _FromValue = value; }
        }


        private Decimal _ToValue;

        public Decimal ToValue
        {
            get { return _ToValue; }
            set { _ToValue = value; }
        }
	
    }
    public class ApproveLimitsCollec : CollectionBase
    {
        public void Add(ApproveLimits obj)
        {
            this.InnerList.Add(obj);
        }
    }

}
