using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Role
    {
        public Role()
        {

        }
        public Role(string name, string description="")
        {

        }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Permission> Permissions { get; set; }

        public void AddPermission(Permission permission)
        {
            Permissions.Add(permission);
        }
        public void RemovePermission(Permission permission)
        {
            Permissions.Remove(permission);
        }
    }
}
