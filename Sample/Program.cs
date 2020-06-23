using System;
using Core;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var app = new SampleApp();
            User userA = new User("User A");
            var koru = new Core.Koru();
            Role role = new Role("RoleA", "This role can do action a");
            koru.AddRole(role);
            koru.AddRoleToUser<User>(userA, role);
            koru.AddPermissionToRole(role, "PermissionA");
            app.MethodA();
            app.MethodB();
            app.MethodC();
        }
    }
}
