using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
  public  class DepartmentalPlanningWeeks
    {

      private int _MonthlyDeptPlanningID;

      public int MonthlyDeptPlanningID
        {
            get { return _MonthlyDeptPlanningID; }
            set { _MonthlyDeptPlanningID = value; }
        }

       
        private int _WeekID;

        public int WeekID
        {
            get { return _WeekID; }
            set { _WeekID = value; }
        }

        private DateTime _FromDate;

        public DateTime FromDate
        {
            get { return _FromDate; }
            set { _FromDate = value; }
        }



        private DateTime _ToDate;

        public DateTime ToDate
        {
            get { return _ToDate; }
            set { _ToDate = value; }
        }


        private bool _Freeze;

        public bool Freeze
        {
            get { return _Freeze; }
            set { _Freeze = value; }
        }



        public class DepartmentalPlanningWeeksCollec : CollectionBase
        {
            public void Add(DepartmentalPlanningWeeks objDepartmentalPlanningWeeks)
            {
                this.InnerList.Add(objDepartmentalPlanningWeeks);
            }
        }


    }
}
