using System;

namespace Ssh2fa.Users
{
    public struct UserStruct
    {
        private string Name { get; set; }
        private string WhatIsThisNamingConvention { get; set; }
        
        public string PascalCaseFtw { get; set; }

        public void Bla()
        {
            Console.WriteLine($"I am living in the stack! {Name}");
        }
        
    }

    public class UserClass
    {
        private string Name { get; set; }
        private string WhatIsThisNamingConvention { get; set; }
        
        public string PascalCaseFtw { get; set; }
        
        public void Bla()
        {
            Console.WriteLine($"I am living in the heap! {Name}");
        }
    }
}