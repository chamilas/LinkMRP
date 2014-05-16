using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Unit
    {
        private long _lngunitID;

        public long UnitID
        {
            get { return _lngunitID; }
            set { _lngunitID = value; }
        }

        private String _strUnit;

        public String UnitName
        {
            get { return _strUnit; }
            set { _strUnit = value; }
        }

        private String _strUnitCode;

        public String UnitCode
        {
            get { return _strUnitCode; }
            set { _strUnitCode = value; }
        }
	
    }
    public class UnitCollec : CollectionBase
    {
        public void Add(Unit objUnit)
        {
            this.InnerList.Add(objUnit);
        }
    }
}
