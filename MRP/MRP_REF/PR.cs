using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class PR
    {
        private long _lngPRNO;

        public long PRNO
        {
            get { return _lngPRNO; }
            set { _lngPRNO = value; }
        }

        private String _strType;

        public String PRType
        {
            get { return _strType; }
            set { _strType = value; }
        }

        private DateTime _dtDate;

        public DateTime PRDate
        {
            get { return _dtDate; }
            set { _dtDate = value; }
        }

        private Department _objDepFrom;

        public Department DepartmentFrom
        {
            get { return _objDepFrom; }
            set { _objDepFrom = value; }
        }

        private Employee _objApprovedBy;

        public Employee PRApprovedBy
        {
            get { return _objApprovedBy; }
            set { _objApprovedBy = value; }
        }

        private DateTime? dtApprovedDate;

        public DateTime? PRApprovedDate
        {
            get { return dtApprovedDate; }
            set { dtApprovedDate = value; }
        }

        private Employee _objEnterdBy;

        public Employee PREnterdBy
        {
            get { return _objEnterdBy; }
            set { _objEnterdBy = value; }
        }

        private Employee _objReceivedBy;

        public Employee PRRecivedBy
        {
            get { return _objReceivedBy; }
            set { _objReceivedBy = value; }
        }

        private DateTime? _dtReceivedDate;

        public DateTime? PRReceivedDate
        {
            get { return _dtReceivedDate; }
            set { _dtReceivedDate = value; }
        }

        private int _intPriority;

        public int Priority
        {
            get { return _intPriority; }
            set { _intPriority = value; }
        }

        private int _intStatus;

        public int Status
        {
            get { return _intStatus; }
            set { _intStatus = value; }
        }
        public enum PRPriority : int
        {
            Low = 0,
            Average = 1,
            High = 2
        }

        public enum PRStatus: int
        {
            Initial = 0,
            SPRInitial = 6,
            Approved = 1,
            Received = 2,
            InPrograss = 3,
            Finalize = 4,
            RejectBySupply = 5
        }



        private String _strEnterdByName;
        public String EnterdByName
        {
            get
            {
                _strEnterdByName = this.PREnterdBy.EmployeeName;
                return _strEnterdByName; 
            }
        }

        private String _strApprovedByname;
        public String ApprovedByName
        {
            get
            {
                _strApprovedByname = this.PRApprovedBy.EmployeeName;
                return _strApprovedByname; 
            }
        }

        private String _streceivedByName;

        public String RecivedByName
        {
            get
            {
                _streceivedByName = this.PRRecivedBy.EmployeeName;
                return _streceivedByName; 
            }
           
        }

        private String _strDepName;
        public String DepName
        {
            get
            {
                _strDepName = this.DepartmentFrom.DepName;
                return _strDepName; 
            }
        }
	
	
	

    }

    public class PRCollec : CollectionBase
    {
        public void Add(PR objPR)
        {
            this.InnerList.Add(objPR);
        }

        public void Delete(PR objPR)
        {
            this.InnerList.Remove(objPR);
        }
    }
}
