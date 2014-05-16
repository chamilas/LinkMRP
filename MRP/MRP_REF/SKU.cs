using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class SKU
    {
        private long _lngSKUID;

        public long SKUID
        {
            get { return _lngSKUID; }
            set { _lngSKUID = value; }
        }

        private PackingType _objPacking;

        public PackingType SKUPackingType
        {
            get { return _objPacking; }
            set { _objPacking = value; }
        }

        private String _strDescription;

        public String SKUDescription
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }

        private Decimal _lngQty;

        public Decimal SKUQty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }

        private Decimal _lngCost;

        public Decimal SKUCost
        {
            get { return _lngCost; }
            set { _lngCost = value; }
        }
	
    }

    public class SKUCollec : CollectionBase
    {
        public void Add(SKU objSKU)
        {
            this.InnerList.Add(objSKU);
        }
    }
}
