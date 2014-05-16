using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class DispatchNoteList
    {
        private String _strDispatchID;

        public String DispatchID
        {
            get { return _strDispatchID; }
            set { _strDispatchID = value; }
        }

        private String _FinishProduct;

        public String FinishProduct
        {
            get { return _FinishProduct; }
            set { _FinishProduct = value; }
        }

        private string _BatchNo;

        public string BatchNo
        {
            get { return _BatchNo; }
            set { _BatchNo = value; }
        }


        private Int64 _Qty;

        public Int64 Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }


        private string _ProductName;

        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

    }

    public class DispathcNoteListCollec : CollectionBase
    {
        public void Add(DispatchNoteList objDispatch)
        {
            this.InnerList.Add(objDispatch);
        }

        public void Delete(DispatchNoteList objDispatch)
        {
            this.InnerList.Remove(objDispatch);
        }

    }
}
