using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class GenActivitySuperviser
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
	
	
    }

    public class GenActivitySuperviserCollec : CollectionBase
    {
        public void Add(GenActivitySuperviser objGenActivitySuperviser)
        {
            this.InnerList.Add(objGenActivitySuperviser);
        }
    }
}
