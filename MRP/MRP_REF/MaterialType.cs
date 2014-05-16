using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MaterialType
    {
        private String _lngMatType;

        public String MatType
        {
            get { return _lngMatType; }
            set { _lngMatType = value; }
        }

        private String _strMatType;

        public String MaterialTypeTitle
        {
            get { return _strMatType; }
            set { _strMatType = value; }
        }

        private decimal _LeadTime;

        public decimal LeadTime
        {
            get { return _LeadTime; }
            set { _LeadTime = value; }
        }

        


    }
    public class MaterialTypeCollec : CollectionBase
    {
        public void Add(MaterialType objMatType)
        {
            this.InnerList.Add(objMatType);
        }
    }
}
