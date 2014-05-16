using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Form
    {
        private long _lngFormID;

        public long FormID
        {
            get { return _lngFormID; }
            set { _lngFormID = value; }
        }

        private String _strForm;

        public String FormName
        {
            get { return _strForm; }
            set { _strForm = value; }
        }


	
    }

    public class FormCollec : CollectionBase
    {
        public void Add(Form objForm)
        {
            this.InnerList.Add(objForm);
        }
    }
}
