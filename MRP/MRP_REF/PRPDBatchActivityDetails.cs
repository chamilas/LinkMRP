using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
  public  class PRPDBatchActivityDetails
    {

      private long _lngPRPDBatchActDetailsID;

      public long PRPDBatchActDetailsID
        {
            get { return _lngPRPDBatchActDetailsID; }
            set { _lngPRPDBatchActDetailsID = value; }
        }

      private PRPDBatchActivity _objPRPDBatchActivity;

      public PRPDBatchActivity PRPDBatchActivity
        {
            get { return _objPRPDBatchActivity; }
            set { _objPRPDBatchActivity = value; }
        }


        private string _strSubActivity;

        public string SubActivity
        {
            get { return _strSubActivity; }
            set { _strSubActivity = value; }
        }

        private DateTime _dtActivityDate;

        public DateTime ActivityDate
        {
            get { return _dtActivityDate; }
            set { _dtActivityDate = value; }
        }


        private DateTime _dtstartTime;

        public DateTime StartTime
        {
            get { return _dtstartTime; }
            set { _dtstartTime = value; }
        }

        private DateTime? _dtstopTime;

        public DateTime? StopTime
        {
            get { return _dtstopTime; }
            set { _dtstopTime = value; }
        }


        private decimal _startQty;

        public decimal StartQty
        {
            get { return _startQty; }
            set { _startQty = value; }
        }

        private decimal _stopQty;

      public decimal StopQty
        {
            get { return _stopQty; }
            set { _stopQty = value; }
        }

        private Employee _supervisedBy;

        public Employee SupervisedBy
        {
            get { return _supervisedBy; }
            set { _supervisedBy = value; }
        }
        private string _remarks;

        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        
      private long _lngnoOfTrays;

      public long NoOfTrays
        {
            get { return _lngnoOfTrays; }
            set { _lngnoOfTrays = value; }
        }

      private decimal _dcmweightLoss;

      public decimal WeightLoss
        {
            get { return _dcmweightLoss; }
            set { _dcmweightLoss = value; }
        }


      public class PRPDBatchActivityDetailsCollc : CollectionBase
        {
          public void Add(PRPDBatchActivityDetails objPRPDBatchActivityDetails)
            {
                this.InnerList.Add(objPRPDBatchActivityDetails);
            }

            public void Delete(PRPDBatchActivityDetails objPRPDBatchActivityDetails)
            {
                this.InnerList.Remove(objPRPDBatchActivityDetails);
            }

        }
    }
}



  