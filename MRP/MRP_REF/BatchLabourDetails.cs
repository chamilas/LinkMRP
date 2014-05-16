using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class BatchLabourDetails
    {   

        private long _labourRecID;

        public long LabourRecID
        {
            get { return _labourRecID; }
            set { _labourRecID = value; }
        }
	

        private BatchActivity _objBatchAct;

        public BatchActivity BatchAct
        {
            get { return _objBatchAct; }
            set { _objBatchAct = value; }
        }


        private Employee _objEmployee;

        public Employee Emp
        {
            get { return _objEmployee; }
            set { _objEmployee = value; }
        }

        private string _WorkStart;

        public string WorkStart
        {
            get { return _WorkStart; }
            set { _WorkStart = value; }
        }


        private string _WorkStop;

        public string WorkStop
        {
            get { return _WorkStop; }
            set { _WorkStop = value; }
        }


        private DateTime _WorkStart_Date;

        public DateTime WorkStart_Date
        {
            get { return _WorkStart_Date; }
            set { _WorkStart_Date = value; }
        }


        private DateTime _WorkStop_Date;

        public DateTime WorkStop_Date
        {
            get { return _WorkStop_Date; }
            set { _WorkStop_Date = value; }
        }


        private Decimal _lngOTHours;

        public Decimal OTHours
        {
            get { return _lngOTHours; }
            set { _lngOTHours = value; }
        }


        private Decimal _HourlyRate;

        public Decimal HourlyRate
        {
            get { return _HourlyRate; }
            set { _HourlyRate = value; }
        }

        private Decimal _OTRate;

        public Decimal OTRate
        {
            get { return _OTRate; }
            set { _OTRate = value; }
        }
	
    }

    public class BatchLaourDetailsCollec : CollectionBase
    {
        public void Add(BatchLabourDetails objBatchLaourDetails)
        {
            this.InnerList.Add(objBatchLaourDetails);
        }
    }
}
