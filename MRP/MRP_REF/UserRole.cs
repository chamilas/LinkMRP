using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class UserRole
    {
        private long _lngUserRoleID;

        public long UserRoleID
        {
            get { return _lngUserRoleID; }
            set { _lngUserRoleID = value; }
        }

        private String _strUserRoleName;

        public String UserRoleName
        {
            get { return _strUserRoleName; }
            set { _strUserRoleName = value; }
        }


        private bool _Edit;

        public bool Edit
        {
            get { return _Edit; }
            set { _Edit = value; }
        }
        private bool _Remove;

        public bool Remove
        {
            get { return _Remove; }
            set { _Remove = value; }
        }
	
	
    }

    public class UserRoleCollec : CollectionBase
    {
        public void Add(UserRole objUserRole)
        {
            this.InnerList.Add(objUserRole);
        }
    }
}
