using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Supplier
    {
        private long _lngSupplierID;

        public long SupplierID
        {
            get { return _lngSupplierID; }
            set { _lngSupplierID = value; }
        }

        private String _SupplierCode;

        public String SupplierCode
        {
            get { return _SupplierCode; }
            set { _SupplierCode = value; }
        }


	

        private string _SupplierType;

        public string SupplierType
        {
            get { return _SupplierType; }
            set { _SupplierType = value; }
        }

        private String _strName;

        public String SupplieName
        {
            get { return _strName; }
            set { _strName = value; }
        }

        private String _strAddress;

        public String SupplierAddress
        {
            get { return _strAddress; }
            set { _strAddress = value; }
        }

        private String _strPhone;

        public String SupplierPhone
        {
            get { return _strPhone; }
            set { _strPhone = value; }
        }

        private String _strMobile;

        public String SupplierMobile
        {
            get { return _strMobile; }
            set { _strMobile = value; }
        }

        private String _strEmail;

        public String SupplierEmail
        {
            get { return _strEmail; }
            set { _strEmail = value; }
        }

        private String _strFax;

        public String SupplierFax
        {
            get { return _strFax; }
            set { _strFax = value; }
        }

        private String _strVatNumber;

        public String SupplierVATNo
        {
            get { return _strVatNumber; }
            set { _strVatNumber = value; }
        }

        private String _strContactPerson;

        public String SupplierContactPerson
        {
            get { return _strContactPerson; }
            set { _strContactPerson = value; }
        }

        private bool _boolStatus;

        public bool SupplierStatus
        {
            get { return _boolStatus; }
            set { _boolStatus = value; }
        }

        private bool _boolVat;

        public bool SupplierVat
        {
            get { return _boolVat; }
            set { _boolVat = value; }
        }



        private String _SupplierNameCode;
        public String SupplierNameCode  
        {
            get {
                _SupplierNameCode = SupplierCode + " - " + SupplieName;
                return _SupplierNameCode; 
            
            }
        }
	
	

    }
    public class SuppliersCollec : CollectionBase
    {
        public void Add(Supplier objSupplier)
        {
            this.InnerList.Add(objSupplier);
        }
    }
}
