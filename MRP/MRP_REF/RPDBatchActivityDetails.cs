using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
  public  class RPDBatchActivityDetails
    {

        private long _BatchActDetailsID;

        public long BatchActDetailsID
        {
            get { return _BatchActDetailsID; }
            set { _BatchActDetailsID = value; }
        }
        private long _RPDBatchActID;

        public long RPDBatchActID
        {
            get { return _RPDBatchActID; }
            set { _RPDBatchActID = value; }
        }
        private Decimal _StartQty;

        public Decimal StartQty
        {
            get { return _StartQty; }
            set { _StartQty = value; }
        }

        private Decimal _StopQty;

        public Decimal StopQty
        {
            get { return _StopQty; }
            set { _StopQty = value; }
        }

        private DateTime? _StartTime;

        public DateTime? StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }
        private DateTime? _StopTime;

        public DateTime? StopTime
        {
            get { return _StopTime; }
            set { _StopTime = value; }
        }
        private Decimal _Frequency;

        public Decimal Frequency
        {
            get { return _Frequency; }
            set { _Frequency = value; }
        }
        private Decimal _InitialVolume;

        public Decimal InitialVolume
        {
            get { return _InitialVolume; }
            set { _InitialVolume = value; }
        }
        private Decimal _FinalQty;

        public Decimal FinalQty
        {
            get { return _FinalQty; }
            set { _FinalQty = value; }
        }
        private Decimal _LossQty;

        public Decimal LossQty
        {
            get { return _LossQty; }
            set { _LossQty = value; }
        }
        private String _SieveSize;

        public String SieveSize
        {
            get { return _SieveSize; }
            set { _SieveSize = value; }
        }
        private String _Comments;

        public String Comments
        {
            get { return _Comments; }
            set { _Comments = value; }
        }
        private Decimal _NoOfTrays;

        public Decimal NoOfTrays
        {
            get { return _NoOfTrays; }
            set { _NoOfTrays = value; }
        }

        private String _SupervisedBy;

        public String SupervisedBy
        {
            get { return _SupervisedBy; }
            set { _SupervisedBy = value; }
        }
	
	
	
    }


    public class RPDBatchActivityDetailsCollc : CollectionBase
        {
            public void Add(RPDBatchActivityDetails objRPDBatchActivityDetails)
            {
                this.InnerList.Add(objRPDBatchActivityDetails);
            }

            public void Delete(RPDBatchActivityDetails objRPDBatchActivityDetails)
            {
                this.InnerList.Remove(objRPDBatchActivityDetails);
            }

        }
}



  