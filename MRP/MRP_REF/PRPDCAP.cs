using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace SESD.MRP.REF
{
   public class PRPDCAP
    {
       private long _lngPRPDCAPID;

       public long PRPDCAPID
        {
            get { return _lngPRPDCAPID; }
            set { _lngPRPDCAPID = value; }
        }


        private String _MaterialCode;

        public String MaterialCode
        {
            get { return _MaterialCode; }
            set { _MaterialCode = value; }
        }
	


       private long _lngGRNNO;

       public long GRNNO
        {
            get { return _lngGRNNO; }
            set { _lngGRNNO = value; }
        }

       private decimal? _dcmCAPQty;

        public decimal? CAPQty
        {
            get { return _dcmCAPQty; }
            set { _dcmCAPQty = value; }

        }

       private string _strInstructions;

       public string Instructions
        {
            get { return _strInstructions; }
            set { _strInstructions = value; }

        }

       private decimal? _dcmReworkQty;

       public decimal? ReworkQty
        {
            get { return _dcmReworkQty; }
            set { _dcmReworkQty = value; }

        }

       private decimal? _dcmDisposeQty;

       public decimal? DisposeQty
        {
            get { return _dcmDisposeQty; }
            set { _dcmDisposeQty = value; }

        }

       private decimal? _dcmAcceptQty;

       public decimal? AcceptQty
        {
            get { return _dcmAcceptQty; }
            set { _dcmAcceptQty = value; }

        }

       private Employee _objEnteredBy;

        public Employee EnteredBy
        {
            get { return _objEnteredBy; }
            set { _objEnteredBy = value; }
        }

        private DateTime? _dtEnteredDate;

        public DateTime? EnteredDate
        {
            get { return _dtEnteredDate; }
            set { _dtEnteredDate = value; }
        }


        private Employee _objApprovedBy;

        public Employee ApprovedBy
        {
            get { return _objApprovedBy; }
            set { _objApprovedBy = value; }
        }
        private DateTime? _dtApprovedDate;

        public DateTime? ApprovedDate
        {
            get { return _dtApprovedDate; }
            set { _dtApprovedDate = value; }
        }

        private Employee _objTestedBy;

        public Employee TestedBy
        {
            get { return _objTestedBy; }
            set { _objTestedBy = value; }
        }
        private DateTime? _dtTestedDate;

        public DateTime? TestedDate
        {
            get { return _dtTestedDate; }
            set { _dtTestedDate = value; }
        }

        private string _strRemarks;

       public string Remarks
        {
            get { return _strRemarks; }
            set { _strRemarks = value; }
        }

       public enum CAPStatus
        {
            Created = 0,
            Instructed = 1,
            InProcess = 2,
            Transferd = 6,
            Finish = 3

        }

       private CAPStatus _enumCapStatus;

       public CAPStatus Status
        {
            get { return _enumCapStatus; }
            set { _enumCapStatus = value; }
        }

        private long? _ReworkMTN;

        public long? ReworkMTN
        {
            get { return _ReworkMTN; }
            set { _ReworkMTN = value; }
        }

        private long? _DisposeMTN;

        public long? DisposeMTN
        {
            get { return _DisposeMTN; }
            set { _DisposeMTN = value; }
        }
	



    }

    public class PRPDCAPCollec : CollectionBase
    {
        public void Add(PRPDCAP objPRPDCAP)
        {
            this.InnerList.Add(objPRPDCAP);
        }
        public void Delete(PRPDCAP objPRPDCAP)
        {
            this.InnerList.Remove(objPRPDCAP);
        }

    }
}
