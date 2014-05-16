using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace SESD.MRP.REF
{
   public class PRPDBatchActivity
    {


        private long _lngPRPDBatchActivity;

        public long PRPDBatchActivityID
        {
            get { return _lngPRPDBatchActivity; }
            set { _lngPRPDBatchActivity = value; }
        }



        private string _strPRPDBatchID;

        public string PRPDBatchID
        {
            get { return _strPRPDBatchID; }
            set { _strPRPDBatchID = value; }
        }



        private long _lngMianActID;

        public long MainActID
        {
            get { return _lngMianActID; }
            set { _lngMianActID = value; }
        }



        private string _comments;

        public string Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }



        public enum ActStatus : int
       {
           Started = 1,
           Finished = 2,
           Initial = 3
       }

        private ActStatus _enumState;

        public ActStatus State
        {
            get { return _enumState; }
            set { _enumState = value; }
        }



        private Decimal _SectionOverHeadRate;

        public Decimal SectionOverHeadRate
        {
            get { return _SectionOverHeadRate; }
            set { _SectionOverHeadRate = value; }
        }



        private DateTime _dtStartedDate;

        public DateTime StartedDate
        {
            get { return _dtStartedDate; }
            set { _dtStartedDate = value; }
        }



        private Decimal _StartQty;

        public Decimal StartQty
        {
            get { return _StartQty; }
            set { _StartQty = value; }
        }



        private DateTime _dtEndDate;

        public DateTime EndDate
        {
            get { return _dtEndDate; }
            set { _dtEndDate = value; }
        }



        private Decimal _StopQty;

        public Decimal StopQty
        {
            get { return _StopQty; }
            set { _StopQty = value; }
        }



        private Employee _objSupervisedBy;

        public Employee SupervisedBy
        {
            get { return _objSupervisedBy; }
            set { _objSupervisedBy = value; }
        }



    }

    public class PRPDBatchActivityCollec : CollectionBase
    {
        public void Add(PRPDBatchActivity objPRPDBatchActivity)
        {
            this.InnerList.Add(objPRPDBatchActivity);
        }
        public void Delete(PRPDBatchActivity objPRPDBatchActivity)
        {
            this.InnerList.Remove(objPRPDBatchActivity);
        }

    }
}
