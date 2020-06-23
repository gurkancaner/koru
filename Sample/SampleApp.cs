using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class SampleApp
    {
        [Koru("PermissionA")]
        public void MethodA()
        {
            Console.WriteLine("Method A");
        }

        [Koru("PermissionB")]
        public void MethodB()
        {
            Console.WriteLine("Method B");
        }
        [Koru("PermissionC")]
        public void MethodC()
        {
            Console.WriteLine("Method C");
        }
    }
}
