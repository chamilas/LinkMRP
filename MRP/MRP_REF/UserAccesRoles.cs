using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class UserAccesRoles
    {
        private User _objUser;

        public User User
        {
            get { return _objUser; }
            set { _objUser = value; }
        }

        private UserRole _objUserRole;

        public UserRole UserRole
        {
            get { return _objUserRole; }
            set { _objUserRole = value; }
        }
	
	
    }

    public class UserAccesRolesCollec : CollectionBase
    {
        public void Add(UserAccesRoles objUserAccesRoles)
        {
            this.InnerList.Add(objUserAccesRoles);
        }
    }
}
