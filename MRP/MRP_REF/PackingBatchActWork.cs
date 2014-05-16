using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class PackingBatchActWork
    {
        private long _PackingBatchActWorkID;

        public long PackingBatchActWorkID
        {
            get { return _PackingBatchActWorkID; }
            set { _PackingBatchActWorkID = value; }
        }

        private long _PackingBatchActID;

        public long PackingBatchActID
        {
            get { return _PackingBatchActID; }
            set { _PackingBatchActID = value; }
        }

        private String _EmployeeID;

        public String EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }


        private DateTime _StartTime;

        public DateTime StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }


        private DateTime _StopTime;

        public DateTime StopTime
        {
            get { return _StopTime; }
            set { _StopTime = value; }
        }

        private String _SupBy;

        public String SupBy
        {
            get { return _SupBy; }
            set { _SupBy = value; }
        }


        private String _Remarks;

        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        private Decimal _OT;

        public Decimal OT
        {
            get { return _OT; }
            set { _OT = value; }
        }

        private Decimal _OTRate;

        public Decimal OTRate
        {
            get { return _OTRate; }
            set { _OTRate = value; }
        }

        private Decimal _HourlyRate;

        public Decimal HourlyRate
        {
            get { return _HourlyRate; }
            set { _HourlyRate = value; }
        }
	

    }

    public class PackingBatchActWorkCollec : CollectionBase
    {
        public void Add(PackingBatchActWork obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
