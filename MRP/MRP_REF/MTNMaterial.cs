using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MTNMaterial
    {
        private MTN _objMTN;

        public MTN MTN
        {
            get { return _objMTN; }
            set { _objMTN = value; }
        }

        private Material _objMaterial;

        public Material Material
        {
            get { return _objMaterial; }
            set { _objMaterial = value; }
        }

        private long _objMTNNO;

        public long MTNNO
        {
            get { return _objMTNNO; }
            set { _objMTNNO = value; }
        }


        private string _objMaterialName;

        public string MaterialName
        {
            get { return _objMaterialName; }
            set { _objMaterialName = value; }
        }



        private string _objBatch;

        public string Batch
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
            set 
            {

                if (TransferQty < value)
                {
                    throw new Exception("You can't Enter Received Value more than Transferd");

                }
                else
                {
                    _lngRecievedQty = value;

                }

            }
        }




        /*
         
                 private Decimal _lngIssuedQty;

        public Decimal IssuedQty
        {
            get { return _lngIssuedQty; }
            set
            {
                if (ReqdQty < value)
                {
                    throw new  Exception("Qty");
                    
                }
                else
                {
                    _lngIssuedQty = value; 

                }
            
            }
        }
         */
    }

    public class MTNMaterialCollc : CollectionBase
    {
        public void Add(MTNMaterial objMTNMaterial)
        {
            this.InnerList.Add(objMTNMaterial);
        }
    }
}
