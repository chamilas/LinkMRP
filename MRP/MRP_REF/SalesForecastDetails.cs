using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace SESD.MRP.REF
{
    public class SalesForecastDetails
    {
        private Int32 _intSalesForecastID;

        public Int32 SalesForecastID
        {
            get { return _intSalesForecastID; }
            set { _intSalesForecastID = value; }
        }

        private Int32 _intRevisionID;

        public Int32 RevisionID
        {
            get { return _intRevisionID; }
            set { _intRevisionID = value; }
        }

        private String _strProductCode;

        public String ProductCode
        {
            get { return _strProductCode; }
            set { _strProductCode = value; }
        }

        private Int32 _intQty;

        public Int32 Qty
        {
            get { return _intQty; }
            set { _intQty = value; }
        }


        public class SalesForecastDetailsCollec : CollectionBase
        {
            public void Add(SalesForecastDetails objSalesForecastDetails)
            {
                this.InnerList.Add(objSalesForecastDetails);
            }
        }

    }
}
