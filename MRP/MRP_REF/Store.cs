using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Store
    {
        private String _strStoreID;

        public String StoreID
        {
            get { return _strStoreID; }
            set { _strStoreID = value; }
        }

        private Department _objDepartment;

        public Department StoreDepartment
        {
            get { return _objDepartment; }
            set { _objDepartment = value; }
        }

        private String _strName;

        public String StoreName
        {
            get { return _strName; }
            set { _strName = value; }
        }

        private String _strDescription;

        public String StoreDescription
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }

        private Employee _objStoreKeeper;

        public Employee StoreKeeper
        {
            get { return _objStoreKeeper; }
            set { _objStoreKeeper = value; }
        }


        private String _strSKname;
        public String StoreKeeperName
        {
            get 
            {
                _strSKname = StoreKeeper.EmployeeName;
                return _strSKname;
            }
        }

        private String _strDepName;
        public String DepartmentName
        {
            get 
            {
                _strDepName = StoreDepartment.DepName;
                return _strDepName; 
            }
        }
	
    }

    public class StoreCollec : CollectionBase
    {
        public void Add(Store objStore)
        {
            this.InnerList.Add(objStore);
        }
    }
}
