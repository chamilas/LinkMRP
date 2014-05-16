using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class TestParameter
    {

        private long _ParameterID;

        public long ParameterID
        {
            get { return _ParameterID; }
            set { _ParameterID = value; }
        }

        private String _Parameter;

        public String Parameter
        {
            get { return _Parameter; }
            set { _Parameter = value; }
        }

        private String _Description;

        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }


        private String _Type;

        public String Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
	
            
    }

    public class TestParameterCollec : CollectionBase
    {
        public void Add(TestParameter obj)
        {
            this.InnerList.Add(obj);
        }
    
    }
}
