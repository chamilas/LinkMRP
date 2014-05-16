using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Stock
    {
        private long _lngStockID;

        public long StockID
        {
            get { return _lngStockID; }
            set { _lngStockID = value; }
        }

        private Store _objStore;

        public Store StockStore
        {
            get { return _objStore; }
            set { _objStore = value; }
        }

        public enum Type : int
        {
            Material = 1,
            BasicProduct = 2,
            FinishProduct = 3
        }

        private Type _intStockType;

        public Type StockType
        {
            get { return _intStockType; }
            set { _intStockType = value; }
        }
	

        private Material _objmaterial;

        public Material StockMaterial
        {
            get { return _objmaterial; }
            set { _objmaterial = value; }
        }

        private BasicProduct _objBasicProduct;

        public BasicProduct StockBasicProduct
        {
            get { return _objBasicProduct; }
            set { _objBasicProduct = value; }
        }

        private FinishProduct _objFinishProduct;

        public FinishProduct StockFinishProduct
        {
            get { return _objFinishProduct; }
            set { _objFinishProduct = value; }
        }

        private Decimal _lngQty;

        public Decimal StockQty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }

        private Decimal _lngReorderLevel;

        public Decimal StockReorderLevel
        {
            get { return _lngReorderLevel; }
            set { _lngReorderLevel = value; }
        }

        private Decimal _lngMinimumQty;

        public Decimal StockMinimumQty
        {
            get { return _lngMinimumQty; }
            set { _lngMinimumQty = value; }
        }

        private Decimal _lngMaximumQty;

        public Decimal StockMaximumQty
        {
            get { return _lngMaximumQty; }
            set { _lngMaximumQty = value; }
        }

        private Decimal _lngEconomicalQty;

        public Decimal StockEconomicalQty
        {
            get { return _lngEconomicalQty; }
            set { _lngEconomicalQty = value; }
        }

        private Decimal _lngReservedQty;

        public Decimal StockReservedQty
        {
            get { return _lngReservedQty; }
            set { _lngReservedQty = value; }
        }

        public enum Status:int
        {
            Enable = 1,
            Disable = 0
        }

        private Status _intStatus;

        public Status StockStatus
        {
            get { return _intStatus; }
            set { _intStatus = value; }
        }

        private String _strItemCode;

        public String ItemCode
        {
            get { return _strItemCode; }
            set { _strItemCode = value; }
        }

        private String _StockUnitPrice;

         public String StockUnitPrice
        {
            get { return _StockUnitPrice; }
            set { _StockUnitPrice = value; }
        }

	
	
	
    }

    public class StockCollec : CollectionBase
    {
        public void Add(Stock objStock)
        {
            this.InnerList.Add(objStock);
        }
    }
}
