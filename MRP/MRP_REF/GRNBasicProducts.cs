using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;

namespace SESD.MRP.REF
{
    public class GRNBasicProducts
    {
        private GRN _objGRN;

        public GRN GRN
        {
            get { return _objGRN; }
            set { _objGRN = value; }
        }

        private BasicProduct _objBasicProduct;

        public BasicProduct BasicProduct
        {
            get { return _objBasicProduct; }
            set { _objBasicProduct = value; }
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
                _strItem = BasicProduct.BasicProductCode + " - " + BasicProduct.BasicProductDescription;
                return _strItem;
            }
        }
    }

    public class GRNBasicProductsCollec : System.Collections.CollectionBase
    {
        public void Add(GRNBasicProducts obj)
        {
            this.InnerList.Add(obj);
        }

        public void Delete(GRNBasicProducts obj)
        {
            this.InnerList.Remove(obj);
        }
    }
}
