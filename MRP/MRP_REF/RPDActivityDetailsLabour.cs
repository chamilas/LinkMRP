using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class RPDActivityDetailsLabour
    {
        private long _ActivityDetailsLabourID;

        public long ActivityDetailsLabourID
        {
            get { return _ActivityDetailsLabourID; }
            set { _ActivityDetailsLabourID = value; }
        }

        private long _BatchActID;

        public long BatchActID
        {
            get { return _BatchActID; }
            set { _BatchActID = value; }


        }

        private String _Description;

        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        private String _Helper;

        public String Helper
        {
            get { return _Helper; }
            set { _Helper = value; }
        }

        private string _StartTime;

        public string StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }


        private string _StopTime;

        public string StopTime
        {
            get { return _StopTime; }
            set { _StopTime = value; }
        }

        private DateTime _StartTime_D;

        public DateTime StartTime_D
        {
            get { return _StartTime_D; }
            set { _StartTime_D = value; }
        }


        private DateTime _StopTime_D;

        public DateTime StopTime_D
        {
            get { return _StopTime_D; }
            set { _StopTime_D = value; }
        }


        private Decimal _OTHours;

        public Decimal OTHours
        {
            get { return _OTHours; }
            set { _OTHours = value; }
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


    public class RPDActivityDetailsLabourCollec : CollectionBase
    {
        public void Add(RPDActivityDetailsLabour obj)
        {
            this.InnerList.Add(obj);
        }
    }
}


