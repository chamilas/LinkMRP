using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{

    public class SystemFunction
    {
        private long _lngID;

        public long FunctionID
        {
            get { return _lngID; }
            set { _lngID = value; }
        }

        private String _strFunction;

        public String FunctionName
        {
            get { return _strFunction; }
            set { _strFunction = value; }
        }
	
    }
    public class SystemFunctionCollec : CollectionBase
    {
        public void Add(SystemFunction objSystemFunc)
        {
            this.InnerList.Add(objSystemFunc);
        }
    }
}
