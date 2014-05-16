using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class QCReportDetails
    {
        private long _TestDetailsID;

        public long TestDetailsID
        {
            get { return _TestDetailsID; }
            set { _TestDetailsID = value; }
        }

        private long _QCReportID;

        public long QCReportID
        {
            get { return _QCReportID; }
            set { _QCReportID = value; }
        }
        private long _TestParameterID;

        public long TestParameterID
        {
            get { return _TestParameterID; }
            set { _TestParameterID = value; }
        }
        private String _MaterialCode;

        public String MaterialCode
        {
            get { return _MaterialCode; }
            set { _MaterialCode = value; }
        }
        private String _Result;

        public String Result
        {
            get { return _Result; }
            set { _Result = value; }
        }
        private String _Comment;

        public String Comment
        {
            get { return _Comment; }
            set { _Comment = value; }
        }
        private bool _Acceptence;

        public bool Acceptence
        {
            get { return _Acceptence; }
            set { _Acceptence = value; }
        }
	

    }

    public class QCReportDetailsColle : CollectionBase
    {
        public void Add(QCReportDetails obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
