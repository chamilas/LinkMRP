using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class GenActivityWork
    {
        private GeneralActivity _objGenAct;

        public GeneralActivity GeneralActivity
        {
            get { return _objGenAct; }
            set { _objGenAct = value; }
        }

        private WorkShift _objWorkShift;

        public WorkShift WorkShift
        {
            get { return _objWorkShift; }
            set { _objWorkShift = value; }
        }

        private Employee _objEmployee;
                
        public Employee Employee
        {
            get { return _objEmployee; }
            set { _objEmployee = value; }
        }



        private DateTime _lngStartTime;

        public DateTime StartTime
        {
            get { return _lngStartTime; }
            set { _lngStartTime = value; }
        }



        private DateTime _lngEndTime;

        public DateTime EndTime
        {
            get { return _lngEndTime; }
            set { _lngEndTime = value; }
        }

        private Decimal _lngOTHours;

        public Decimal OTHours
        {
            get { return _lngOTHours; }
            set { _lngOTHours = value; }
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

    public class GenActivityWorkCollec : CollectionBase
    {
        public void Add(GenActivityWork objGenActivityWork)
        {
            this.InnerList.Add(objGenActivityWork);
        }
    }
}
