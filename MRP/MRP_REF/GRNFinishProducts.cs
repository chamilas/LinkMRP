using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Collections;

namespace SESD.MRP.REF
{
    public class GRNFinishProducts
    {
        private GRN _objGRN;

        public GRN GRN
        {
            get { return _objGRN; }
            set { _objGRN = value; }
        }

        private FinishProduct _objFinishProducts;

        public FinishProduct FinishProducts
        {
            get { return _objFinishProducts; }
            set { _objFinishProducts = value; }
        }
	
        private Decimal _decGrossQty;

        public Decimal GrossQty
        {
            get { return _decGrossQty; }
            set { _decGrossQty = value; }
        }

        private Decimal _decNetQty;

        public Decimal NetQty
        {
            get { return _decNetQty; }
            set { _decNetQty = value; }
        }

        private Decimal _decUnitPrice;

        public Decimal UnitPrice
        {
            get { return _decUnitPrice; }
            set { _decUnitPrice = value; }
        }

        private String _strRemarks;

        public String Remarks
        {
            get { return _strRemarks; }
            set { _strRemarks = value; }
        }

        private String _strItem;
        public String Item
        {
            get
            {
                _strItem = FinishProducts.FinishProductCode + " - " + FinishProducts.FinishProductDescription;
                return _strItem;
            }
        }
    }

    public class GRNFinishProductsCollec : CollectionBase
    {
        public void Add(GRNFinishProducts obj)
        {
            this.InnerList.Add(obj);
        }

        public void Delete(GRNFinishProducts obj)
        {
            this.InnerList.Remove(obj);
        }
    }
}
