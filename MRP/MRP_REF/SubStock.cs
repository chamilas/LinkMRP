using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class SubStock
    {
        private long _SubStockID;

        public long SubStockID
        {
            get { return _SubStockID; }
            set { _SubStockID = value; }
        }


        private long _SectionID;

        public long SectionID
        {
            get { return _SectionID; }
            set { _SectionID = value; }
        }


        private String _MaterialCode;

        public String MaterialCode
        {
            get { return _MaterialCode; }
            set { _MaterialCode = value; }
        }

        private String _FinishProductID;

        public String FinishProductID
        {
            get { return _FinishProductID; }
            set { _FinishProductID = value; }
        }

        private String _BasicProductID;

        public String BasicProductID
        {
            get { return _BasicProductID; }
            set { _BasicProductID = value; }
        }


        private Type _ItemType;

        public Type ItemType
        {
            get { return _ItemType; }
            set { _ItemType = value; }
        }

        public enum Type
        {
            Material,
            BasicProduct,
            FinishProduct
        }

        private Decimal _Quantity;

        public Decimal Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        private Decimal _MinimumQty;

        public Decimal MinimumQty
        {
            get { return _MinimumQty; }
            set { _MinimumQty = value; }
        }

        private Decimal _ReorderQty;

        public Decimal ReorderQty
        {
            get { return _ReorderQty; }
            set { _ReorderQty = value; }
        }
	
    }

    public class SubStockCollec : CollectionBase
    {
        public void Add(SubStock obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
