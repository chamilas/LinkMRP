using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace SESD.MRP.REF
{
    public class PlanBatch
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



        private Int32 _intRevisionID;

        public Int32 RevisionID
        {
            get { return _intRevisionID; }
            set { _intRevisionID = value; }
        }



        private string _strProductCode;

        public string ProductCode
        {
            get { return _strProductCode; }
            set { _strProductCode = value; }
        }



        private Int32 _intWeekID;

        public Int32 WeekID
        {
            get { return _intWeekID; }
            set { _intWeekID = value; }
        }



        private decimal _lngBatchSize;

        public decimal BatchSize
        {
            get { return _lngBatchSize; }
            set { _lngBatchSize = value; }
        }



        private Int32 _intNos;

        public Int32 Nos
        {
            get { return _intNos; }
            set { _intNos = value; }
        }

        private Int32 _Status;

        public Int32 Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private Int32 _BatchLevel;

        public Int32 BatchLevel
        {
            get { return _BatchLevel; }
            set { _BatchLevel = value; }
        }

        public class PlanBatchCollec : CollectionBase
        {
            public void Add(PlanBatch objPlanBatch)
            {
                this.InnerList.Add(objPlanBatch);
            }
        }

    }
}
