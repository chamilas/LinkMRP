using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class UserRoleFunction
    {
        private UserRole _objUserRole;

        public UserRole UserRole
        {
            get { return _objUserRole; }
            set { _objUserRole = value; }
        }

        private SystemFunction _objFunc;

        public SystemFunction SystemFunction
        {
            get { return _objFunc; }
            set { _objFunc = value; }
        }
	
	
    }
    public class UserRoleFunctionCollec : CollectionBase
    {
        public void Add(UserRoleFunction objUserRoleFunction)
        {
            this.InnerList.Add(objUserRoleFunction);
        }
    }
}
