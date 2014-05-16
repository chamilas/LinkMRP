using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class WorkShift
    {
        private long _lngShiftID;

        public long ShiftID
        {
            get { return _lngShiftID; }
            set { _lngShiftID = value; }
        }

        private String _strName;

        public String ShiftName
        {
            get { return _strName; }
            set { _strName = value; }
        }

        private DateTime _lngStart;

        public DateTime ShiftStart
        {
            get { return _lngStart; }
            set { _lngStart = value; }
        }

        private DateTime _lngShiftEnd;

        public DateTime ShiftEnd
        {
            get { return _lngShiftEnd; }
            set { _lngShiftEnd = value; }
        }
    }

    public class WorkShiftCollec : CollectionBase
    {
        public void Add(WorkShift objWorkShift)
        {
            this.InnerList.Add(objWorkShift);
        }
    }
}
