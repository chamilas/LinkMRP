using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class ExtractionDetailsLabour
    {
        private long _ExtractionDetailsLabourID;

        public long ExtractionDetailsLabourID
        {
            get { return _ExtractionDetailsLabourID; }
            set { _ExtractionDetailsLabourID = value; }
        }
        private long _ExtractionDetailsID;

        public long ExtractionDetailsID
        {
            get { return _ExtractionDetailsID; }
            set { _ExtractionDetailsID = value; }

        }

        private String _Helper;

        public String Helper
        {
            get { return _Helper; }
            set { _Helper = value; }
        }
        private String _Description;

        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        private DateTime? _StartTime;

        public DateTime? StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }

        private DateTime? _StopTime;

        public DateTime? StopTime
        {
            get { return _StopTime; }
            set { _StopTime = value; }
        }
        private Decimal _OTHours;

        public Decimal OTHours
        {
            get { return _OTHours; }
            set { _OTHours = value; }
        }


        private String _Remarks;

        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
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

    public class ExtractionDetailsLabourCollec : CollectionBase
    {
        public void Add(ExtractionDetailsLabour obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
