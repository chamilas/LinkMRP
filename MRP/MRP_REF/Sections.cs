using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
   public class Sections
    {
       private long _lngSectionID;

       public long SectionID
        {
            get { return _lngSectionID; }
            set { _lngSectionID = value; }
        }

       private String _strSectionName;

       public String SectionName
        {
            get { return _strSectionName; }
            set { _strSectionName = value; }
        }

       private Employee _objSectionHead;

       public Employee SectionHead
        {
            get { return _objSectionHead; }
            set { _objSectionHead = value; }
        }

       


       private long _DepID;

       public long DepID
        {
            get { return _DepID; }
            set { _DepID = value; }
        }

        
	

    }

    public class SectionsCollec : CollectionBase
    {
        public void Add(Sections objSections)
        {
            this.InnerList.Add(objSections);
        }

        public void Delete(Sections objSections)
        {
            this.InnerList.Remove(objSections);
        }
    }
}
