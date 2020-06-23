using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Koru
    {
        public void AddRole(Role role)
        {

        }

        public void AddRoleToUser<T>(T user, Role role)
        {

        }

        public bool CheckPermission<T>(T user, Permission permission)
        {
            return true;
        }

        public bool AddPermissionToRole(Role role, string permissionName)
        {
            return true;
        }
    }
}
