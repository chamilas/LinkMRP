using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace SESD.MRP.REF
{
   public class DepartmentPlans
    {

       private int _MonthlyDeptPlanningID;

       public int   MonthlyDeptPlanningID
        {
            get { return _MonthlyDeptPlanningID; }
            set { _MonthlyDeptPlanningID = value; }
        }

        private long _DepID;

        public long DepID
        {
            get { return _DepID; }
            set { _DepID = value; }
        }
        private int _Year;

        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }

        private string _Month;

        public string Month
        {
            get { return _Month; }
            set { _Month = value; }
        }

        private int _WeekID;

        public int WeekID
        {
            get { return _WeekID; }
            set { _WeekID = value; }
        }

        private DateTime _CreatedDate;

        public DateTime CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }

        private string _CreatedBy;

        public string CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }

        private DateTime _LastUpdatedOn;

        public DateTime LastUpdatedOn
        {
            get { return _LastUpdatedOn; }
            set { _LastUpdatedOn = value; }
        }

        private string _LastUpdatedBy;

        public string LastUpdatedBy
        {
            get { return _LastUpdatedBy; }
            set { _LastUpdatedBy = value; }
        }


        private bool _Freeze;

        public bool Freeze
        {
            get { return _Freeze; }
            set { _Freeze = value; }
        }

        public enum Months : int
        {
            January=1,
            February=2,
            March=3,
            April=4,
            May=5,
            June=6,
            July=7,
            August=8,
            September=9,
            October=10,
            November=11,
            December=12
        }

        private Months _TheMonths;

        public Months TheMonths
        {
            get { return _TheMonths; }
            set { _TheMonths = value; }
        }


        public class DepartmentPlansCollec : CollectionBase
        {
            public void Add(DepartmentPlans objDepartmentPlans)
            {
                this.InnerList.Add(objDepartmentPlans);
            }
        }


    }
}
