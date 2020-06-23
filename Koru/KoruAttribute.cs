using System;

namespace Core
{
    public class KoruAttribute : Attribute
    {
        //before execution 
        //get user permissions
        //check permission is in this list
        public KoruAttribute()
        {

        }
        public KoruAttribute(string permission)
        {
        }
        public bool Check(string text)
        {
            Console.WriteLine(text);
            return true;
        }
    }
}
