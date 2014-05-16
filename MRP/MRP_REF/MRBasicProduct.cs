using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MRBasicProduct
    {
        private MR _objMR;

        public MR MR
        {
            get { return _objMR; }
            set { _objMR = value; }
        }

        private BasicProduct _objBasicProduct;

        public BasicProduct BasicProduct
        {
            get { return _objBasicProduct; }
            set { _objBasicProduct = value; }
        }

        private String _strDescription;

        public String Description
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }

        private Decimal _lngReqdQty;

        public Decimal ReqdQty
        {
            get { return _lngReqdQty; }
            set { _lngReqdQty = value; }
        }

        private Decimal _lngIssuedQty;

        public Decimal IssuedQty
        {
            get { return _lngIssuedQty; }
            set
            {
                if (ReqdQty < value)
                {
                    throw new Exception("Qty");

                }
                else
                {
                    _lngIssuedQty = value;

                }

            }
        }


        private String _strMRBINNo;

        public String MRBINNo
        {
            get { return _strMRBINNo; }
            set { _strMRBINNo = value; }
        }

        private String _strItemCode;
        public String ItemCode
        {
            get { return _strItemCode; }
            set { _strItemCode = value; }


        }


        private String _strItem;
        public String Item
        {
            get { return _strItem; }
            set { _strItem = value; }
        }

        private String _strUnitCode;
        public String UnitCode
        {
            get { return _strUnitCode; }
            set { _strUnitCode = value; }
        }

        private Decimal _decUnitRate;

        public Decimal UniRate
        {
            get { return _decUnitRate; }
            set { _decUnitRate = value; }
        }
	
    }

    public class MRBasicProductCollec : CollectionBase
    {
        public void Add(MRBasicProduct objMRBasicProduct)
        {
            this.InnerList.Add(objMRBasicProduct);
        }

        public void Delete(MRBasicProduct objMRBasicProduct)
        {
            this.InnerList.Remove(objMRBasicProduct);
        }
    }
}
