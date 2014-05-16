using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class SalesForecastContent
    {
        private SalesForecast _objSalesForecast;

        public SalesForecast SalesForecast
        {
            get { return _objSalesForecast; }
            set { _objSalesForecast = value; }
        }

        private FinishProduct _objFinishProduct;

        public FinishProduct FinishProduct
        {
            get { return _objFinishProduct; }
            set { _objFinishProduct = value; }
        }

        private Decimal _lngDemandQty;

        public Decimal DemandQty
        {
            get { return _lngDemandQty; }
            set { _lngDemandQty = value; }
        }

        private Decimal _lngDecideQty;

        public Decimal FinalDecideQty
        {
            get { return _lngDecideQty; }
            set { _lngDecideQty = value; }
        }

        private SKU _objSKU;

        public SKU SKU
        {
            get { return _objSKU; }
            set { _objSKU = value; }
        }

        public enum SFStatus:int
        {
            Enable = 0,
            Disable = 1
        }

        private SFStatus _Status;

        public SFStatus Status
        {
            get { return _Status; }
            set { _Status = value; }
        }


        private String _Product;
        public String Product
        {
            get 
            {
                _Product = FinishProduct.Code;
                return _Product;
            
            }
        }

        private String _SKUTitle;
        public String SKUTitle
        {
            get 
            {
                _SKUTitle = SKU.SKUDescription;
                return _SKUTitle; 
            
            }
        }
	
	
	
	
	
    }

    public class SalesForecastContentCollec : CollectionBase
    {
        public void Add(SalesForecastContent objSalesForecastContent)
        {
            this.InnerList.Add(objSalesForecastContent);
        }

        public void Delete(SalesForecastContent obj)
        {
            this.InnerList.Remove(obj);
        }
    }
}
