using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class SalesForecast
    {
        private Int32 _intID;

        public Int32 ID
        {
            get { return _intID; }
            set { _intID = value; }
        }

        private Int32 _intRevisionNo;

        public Int32 RevisionNo
        {
            get { return _intRevisionNo; }
            set { _intRevisionNo = value; }
        }

        private Int32 _intYear;

        public Int32 Year
        {
            get { return _intYear; }
            set { _intYear = value; }
        }

        private String _strMonth;

        public String Month 
        {
            get { return _strMonth; }
            set { _strMonth = value; }
        }

        private Int32 _intWeekID;

        public Int32 WeekID
        {
            get { return _intWeekID; }
            set { _intWeekID = value; }
        }

        private DateTime _dtDate;

        public DateTime Date
        {
            get { return _dtDate; }
            set { _dtDate = value; }
        }

        private String _strAccuracy;

        public String Accuracy
        {
            get { return _strAccuracy; }
            set { _strAccuracy = value; }
        }

        private int _intState;

        public int State
        {
            get { return _intState; }
            set { _intState = value; }
        }

        private String _EenteredBy;

	    public String EenteredBy
        {
            get { return _EenteredBy; }
            set { _EenteredBy = value; }
        }
	
    }

    public class SalesForecastCollec : CollectionBase
    {
        public void Add(SalesForecast objSalesForecast)
        {
            this.InnerList.Add(objSalesForecast);
        }
    }
}
