using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class PO
    {


        private string _strPONO;

        public string PONO
        {
            get { return _strPONO; }
            set { _strPONO = value; }
        }


        private int _intPOSupplierID;

        public int POSupplierID
        {
            get { return _intPOSupplierID; }
            set { _intPOSupplierID = value; }
        }


        private DateTime _PODate;

        public DateTime PODate
        {
            get { return _PODate; }
            set { _PODate = value; }
        }



        private string _strPOApporvedBy;

        public string POApporvedBy
        {
            get { return _strPOApporvedBy; }
            set { _strPOApporvedBy = value; }
        }



        private DateTime _POApprovedDate;

        public DateTime POApprovedDate
        {
            get { return _POApprovedDate; }
            set { _POApprovedDate = value; }
        }



        private string _strPOEnterdBy;

        public string POEnterdBy
        {
            get { return _strPOEnterdBy; }
            set { _strPOEnterdBy = value; }
        }



        private DateTime _POEnterdDate;

        public DateTime POEnterdDate
        {
            get { return _POEnterdDate; }
            set { _POEnterdDate = value; }
        }



        private string _strPOPaymentType;

        public string POPaymentType
        {
            get { return _strPOPaymentType; }
            set { _strPOPaymentType = value; }
        }


        private DateTime _PORequiredDate;

        public DateTime PORequiredDate
        {
            get { return _PORequiredDate; }
            set { _PORequiredDate = value; }
        }



        private string _strPOReference;

        public string POReference
        {
            get { return _strPOReference; }
            set { _strPOReference = value; }
        }



        private int _intPOStatus;

        public int POStatus
        {
            get { return _intPOStatus; }
            set { _intPOStatus = value; }
        }




        private string _strPOChangedRemarks;

        public string POChangedRemarks
        {
            get { return _strPOChangedRemarks; }
            set { _strPOChangedRemarks = value; }
        }



        private string _strPOChangedBy;

        public string POChangedBy
        {
            get { return _strPOChangedBy; }
            set { _strPOChangedBy = value; }
        }



        private DateTime _POChangedDate;

        public DateTime POChangedDate
        {
            get { return _POChangedDate; }
            set { _POChangedDate = value; }
        }



        private string _strPOChangedApprove;

        public string POChangedApprove
        {
            get { return _strPOChangedApprove; }
            set { _strPOChangedApprove = value; }
        }


        private DateTime _POChangedApprovedDate;

        public DateTime POChangedApprovedDate
        {
            get { return _POChangedApprovedDate; }
            set { _POChangedApprovedDate = value; }
        }



        private long _lngPOValidityPeriod;

        public long POValidityPeriod
        {
            get { return _lngPOValidityPeriod; }
            set { _lngPOValidityPeriod = value; }
        }

        private string _POType;

        public string POType
        {
            get { return _POType; }
            set { _POType = value; }
        }

        private string _POCategory;

        public string POCategory
        {
            get { return _POCategory; }
            set { _POCategory = value; }
        }



    }

    public class POCollec : CollectionBase
    {
        public void Add(PO objPO)
        {
            this.InnerList.Add(objPO);
        }
    }
}
