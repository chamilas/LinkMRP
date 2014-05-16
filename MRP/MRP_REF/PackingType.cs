using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class PackingType
    {
        private long _lngPackingID;

        public long PackingID
        {
            get { return _lngPackingID; }
            set { _lngPackingID = value; }
        }

        private String _strTitle;

        public String PackingTitle
        {
            get { return _strTitle; }
            set { _strTitle = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private Unit _objUnit;

        public Unit PackingUnit
        {
            get { return _objUnit; }
            set { _objUnit = value; }
        }

        private Decimal _lngQty;

        public Decimal PackingQty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }
	
    }

    public class PackingTypeCollec : CollectionBase
    {
        public void Add(PackingType objPackingType)
        {
            this.InnerList.Add(objPackingType);
        }
    }
}
