using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class ActivityMachineUsage
    {
        private BatchActivity _objBatchAct;

        public BatchActivity BatchActivity
        {
            get { return _objBatchAct; }
            set { _objBatchAct = value; }
        }

        private Machine _objMachine;

        public Machine BatchActMachine
        {
            get { return _objMachine; }
            set { _objMachine = value; }
        }

        private DateTime _lngStart;

        public DateTime BatchActStartTime
        {
            get { return _lngStart; }
            set { _lngStart = value; }
        }

        private DateTime _lngEnd;

        public DateTime BatchActEndTime
        {
            get { return _lngEnd; }
            set { _lngEnd = value; }
        }
        private long _ID;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }


        private Employee _SupBy;

        public Employee SupBy
        {
            get { return _SupBy; }
            set { _SupBy = value; }
        }


        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        private String _Remarks;

        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }
        private Decimal _HourlyRate;

        public Decimal HourlyRate
        {
            get { return _HourlyRate; }
            set { _HourlyRate = value; }
        }
	
            
	
	}

    public class ActivityMachineUsageCollec : CollectionBase
    {
        public void Add(ActivityMachineUsage objActMachineUsage)
        {
            this.InnerList.Add(objActMachineUsage);
        }
    }
}
