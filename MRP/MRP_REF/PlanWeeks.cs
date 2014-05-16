using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class PlanWeeks
    {

        private Int32 _intYear;

        public Int32 Year
        {
            get { return _intYear; }
            set { _intYear = value; }
        }


        private string _strMonth;

        public string Month
        {
            get { return _strMonth; }
            set { _strMonth = value; }
        }



        private Int32 _intWeekID;

        public Int32 WeekID
        {
            get { return _intWeekID; }
            set { _intWeekID = value; }
        }


        private Int32 _intRevisionID;

        public Int32 RevisionID
        {
            get { return _intRevisionID; }
            set { _intRevisionID = value; }
        }


        private DateTime _dtFromDate;

        public DateTime FromDate
        {
            get { return _dtFromDate; }
            set { _dtFromDate = value; }
        }


        private DateTime _dtToDate;

        public DateTime ToDate
        {
            get { return _dtToDate; }
            set { _dtToDate = value; }
        }


        private int _intState;

        public int State
        {
            get { return _intState; }
            set { _intState = value; }
        }



    }


    public class PlanWeeksCollec : CollectionBase
    {
        public void Add(PlanWeeks objPlanWeeks)
        {
            this.InnerList.Add(objPlanWeeks);
        }
    }
}
