using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SESD.MRP.REF
{
    public class ProjectMaterials
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private int _ProjectID;

        public int ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }
        private String _MaterialCode;

        public String MaterialCode
        {
            get { return _MaterialCode; }
            set { _MaterialCode = value; }
        }
        private String _BasicProductCode;

        public String BasicProductCode
        {
            get { return _BasicProductCode; }
            set { _BasicProductCode = value; }
        }
        private String _FinishProductCode;

        public String FinishProductCode
        {
            get { return _FinishProductCode; }
            set { _FinishProductCode = value; }
        }
        private Double _UsedQty;

        public Double UsedQty
        {
            get { return _UsedQty; }
            set { _UsedQty = value; }
        }
        private Double _DamagedQty;

        public Double DamagedQty
        {
            get { return _DamagedQty; }
            set { _DamagedQty = value; }
        }
        private int _GRNNO;

        public int GRNNO
        {
            get { return _GRNNO; }
            set { _GRNNO = value; }
        }
        private Double _UnitPrice;

        public Double UnitPrice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }
        private String _EnteredBy;

        public String EnteredBy
        {
            get { return _EnteredBy; }
            set { _EnteredBy = value; }
        }
        private DateTime _EnteredDate;

        public DateTime EnteredDate
        {
            get { return _EnteredDate; }
            set { _EnteredDate = value; }
        }
        private String _ItemTypeName;

        public String ItemTypeName
        {
            get { return _ItemTypeName; }
            set { _ItemTypeName = value; }
        }
        private String _MaterialID;

        public String MaterialID
        {
            get { return _MaterialID; }
            set { _MaterialID = value; }
        }

        public class ProjectMaterialsCollec : CollectionBase
        {
            public void Add(ProjectMaterials objCat)
            {
                this.InnerList.Add(objCat);
            }
        }
    }
}
