using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Formula
    {
        private long _lngID;

        public long FormulaID
        {
            get { return _lngID; }
            set { _lngID = value; }
        }

        private long _lngQty;

        public long FormulaQty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }

        private Unit _objUnit;

        public Unit FormulaUnit
        {
            get { return _objUnit; }
            set { _objUnit = value; }
        }

        private Employee _objEmp;

        public Employee FormulaInstructedBy
        {
            get { return _objEmp; }
            set { _objEmp = value; }
        }

        private DateTime _dtDate;

        public DateTime FormulaInstructedDate
        {
            get { return _dtDate; }
            set { _dtDate = value; }
        }
	
    }

    public class FormulaCollec : CollectionBase
    {
        public void Add(Formula objFormula)
        {
            this.InnerList.Add(objFormula);
        }
    }
}
