using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MTNBasicProduct
    {
        private MTN _objMTN;

        public MTN MTN
        {
            get { return _objMTN; }
            set { _objMTN = value; }
        }

        private BasicProduct _objBasicProduct;

        public BasicProduct BasicProduct
        {
            get { return _objBasicProduct; }
            set { _objBasicProduct = value; }
        }

        private String _objBatch;

        public String Batch
        {
            get { return _objBatch; }
            set { _objBatch = value; }
        }

        private String _strDescription;

        public String Description
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }

        private Decimal _lngTransferQty;

        public Decimal TransferQty
        {
            get { return _lngTransferQty; }
            set { _lngTransferQty = value; }
        }


        private Decimal _lngUnitRate;

        public Decimal UnitRate
        {
            get { return _lngUnitRate; }
            set { _lngUnitRate = value; }
        }

        private Decimal _lngUnitRate_Budget;

        public Decimal UnitRate_Budget
        {
            get { return _lngUnitRate_Budget; }
            set { _lngUnitRate_Budget = value; }
        }


        private Decimal _lngRecievedQty;

        public Decimal ReceivedQty
        {
            get { return _lngRecievedQty; }
            set { _lngRecievedQty = value; }
        }
	
    }

    public class MTNBasicProductCollec : CollectionBase
    {
        public void Add(MTNBasicProduct objMTNBasicProduct)
        {
            this.InnerList.Add(objMTNBasicProduct);
        }
    }
}
