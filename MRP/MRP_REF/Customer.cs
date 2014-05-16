using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Customer
    {
        private String _CustomerID;

        public String CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }

        private String _Name;

        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private String _Address;

        public String Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private String _Telephone;

        public String Telephone
        {
            get { return _Telephone; }
            set { _Telephone = value; }
        }

        private String _ProductType;

        public String ProductType
        {
            get { return _ProductType; }
            set { _ProductType = value; }
        }

        private String _SalesMethod;

        public String SalesMethod
        {
            get { return _SalesMethod; }
            set { _SalesMethod = value; }
        }

        private String _Territory;

        public String Territory
        {
            get { return _Territory; }
            set { _Territory = value; }
        }

    }

    public class CustomerCollec : CollectionBase
    {
        public void Add(Customer objCustomer)
        {
            this.InnerList.Add(objCustomer);
        }

    }

}
