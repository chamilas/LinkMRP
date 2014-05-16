using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class CAP
    {
        private String _strCAPNo;

        public String CAPNo
        {
            get { return _strCAPNo; }
            set { _strCAPNo = value; }
        }

        private DateTime _dtCAPDate;

        public DateTime CAPDate
        {
            get { return _dtCAPDate; }
            set { _dtCAPDate = value; }
        }

        private Employee _objEnterdBy;

        public Employee CAPEnterdBy
        {
            get { return _objEnterdBy; }
            set { _objEnterdBy = value; }
        }

        private Employee _CAPInstructedBy;

        public Employee CAPInstructedBy
        {
            get { return _CAPInstructedBy; }
            set { _CAPInstructedBy = value; }
        }

        private DateTime _CAPEnterdDate;

        public DateTime CAPEnterdDate
        {
            get { return _CAPEnterdDate; }
            set { _CAPEnterdDate = value; }
        }

        public enum Status : int
        {
            Initial = 1,
            InPrograss = 2,
            Finished = 3
        }

        private Status _CAPStatus;

        public Status CAPStatus
        {
            get { return _CAPStatus; }
            set { _CAPStatus = value; }
        }


        private String _EnterdBy;

        public String EnterdBy_Name
        {
            get 
            {
                _EnterdBy = CAPEnterdBy.EmployeeNameID;
                return _EnterdBy; 
            }
           
        }

        private String _InstructedBy;

        public String InstructedBy_Name
        {
            get 
            {
                _InstructedBy = CAPInstructedBy.EmployeeNameID;
                return _InstructedBy; 
            }
           
        }
	
	
	
	}

    public class CAPCollec : CollectionBase
    {
        public void Add(CAP objCap)
        {
            this.InnerList.Add(objCap);
        }
    }
}
