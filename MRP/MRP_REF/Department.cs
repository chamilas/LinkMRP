using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Department
    {
        private long _lngDepID;

        public long DepID
        {
            get { return _lngDepID; }
            set { _lngDepID = value; }
        }

        private String _strName;

        public String DepName
        {
            get { return _strName; }
            set { _strName = value; }
        }

        private Employee _objDepHead;

        public Employee DepHead
        {
            get { return _objDepHead; }
            set { _objDepHead = value; }
        }

        private String _strDescription;

        public String DepDescription
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }

        private String _DepType;

        public String DepType
        {
            get { return _DepType; }
            set { _DepType = value; }
        }


        private long _DivisionID;

        public long DivisionID
        {
            get { return _DivisionID; }
            set { _DivisionID = value; }
        }

        public enum Type
        {
            RPD,
            PRPD,
            STORE,
            LAB,
            OTHER,
            AGRI,
            PRODUCTION,
            SUPPLY
        }



	

    }

    public class DepartmentCollec : CollectionBase
    {
        public void Add(Department objDep)
        {
            this.InnerList.Add(objDep);
        }

        public void Delete(Department objDep)
        {
            this.InnerList.Remove(objDep);
        }
        public void Sort()
        {
            Department obj1 = new Department();
            Department obj2 = new Department();
            for (int i = this.InnerList.Count - 1; i >= 0; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    obj1 = (Department)InnerList[j - 1];
                    obj2 = (Department)InnerList[j];

                    this.Delete(obj1);
                    this.Delete(obj2);
                    if (obj1.DepName.CompareTo(obj2.DepName) > 0)
                    {
                        InnerList.Insert(j - 1, obj2);
                        InnerList.Insert(j, obj1);
                    }
                    else
                    {
                        InnerList.Insert(j - 1, obj1);
                        InnerList.Insert(j, obj2);
                    }
                }
            }
        }

        /*            Department obj1 = new Department();
            Department obj2 = new Department();
            for (int i = 0; i < this.InnerList.Count; i++)
            {

                for (int j = 0; j < this.InnerList.Count-1; j++)
                {
                    obj1 = (Department)InnerList[j];
                    obj2 = (Department)InnerList[j + 1];

                    this.Delete(obj1);
                    this.Delete(obj2);
                    if (obj1.DepName.CompareTo(obj2.DepName)> 0)
                    {
                        InnerList.Insert(j, obj2);
                        InnerList.Insert(j + 1, obj1);
                    }
                    else
                    {
                        InnerList.Insert(j, obj1);
                        InnerList.Insert(j + 1, obj2);
                    }
                }
           }*/

    }
}
