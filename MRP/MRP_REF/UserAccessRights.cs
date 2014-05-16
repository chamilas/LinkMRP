using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class UserAccessRights
    {
        public override string ToString()
        {
            return _MenuName;
        }

        private String _MenuName;

        public String MenuName
        {
            get { return _MenuName; }
            set { _MenuName = value; }
        }


        private String _MenuID;

        public String MenuID
        {
            get { return _MenuID; }
            set { _MenuID = value; }
        }


        private long _UserRoleID;

        public long UserRoleID
        {
            get { return _UserRoleID; }
            set { _UserRoleID = value; }
        }

        private String _Permision;

        public String Permission
        {
            get { return _Permision; }
            set { _Permision = value; }
        }
	
    }

    public class UserAccessRightsCollec : CollectionBase
    {
        public void Add(UserAccessRights obj)
        {
            this.InnerList.Add(obj);
        }
    }


}
