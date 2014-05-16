using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SESD.MRP.REF
{
   public class BatchPackingMR
    {

        private long _ID;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private String _strBatchID;

        public String BatchID
        {
            get { return _strBatchID; }
            set { _strBatchID = value; }
        }

        private long _batchpackingID;

        public long BatchPackingID
        {
            get { return _batchpackingID; }
            set { _batchpackingID = value; }
        }


        private String _MaterialCode;

        public String MaterialCode
        {
            get { return _MaterialCode; }
            set { _MaterialCode = value; }
        }

        private long _MRNO;

        public long MRNO
        {
            get { return _MRNO; }
            set { _MRNO = value; }
        }

        private decimal _StartQty;

        public decimal StartQty
        {
            get { return _StartQty; }
            set { _StartQty = value; }
        }

        private decimal _BatchUsed;

        public decimal BatchUsed
        {
            get { return _BatchUsed; }
            set { _BatchUsed = value; }
        }


        private decimal _BatchDamaged;

        public decimal BatchDamaged
        {
            get { return _BatchDamaged; }
            set { _BatchDamaged = value; }
        }

       private decimal _BatchReturned;

        public decimal BatchReturned
        {
            get { return _BatchReturned; }
            set { _BatchReturned = value; }
        }


        private int _State;
        public int State
        {
            get { return _State; }
            set { _State = value; }
        }


        private string _IssuedBy;
        public string IssuedBy
        {
            get { return _IssuedBy; }
            set { _IssuedBy = value; }
        }



        private DateTime _IssuedDate;
        public DateTime IssuedDate
        {
            get { return _IssuedDate; }
            set { _IssuedDate = value; }
        }



        private int _BulkPrint;
        public int BulkPrint
        {
            get { return _BulkPrint; }
            set { _BulkPrint = value; }
        }

    }
}
