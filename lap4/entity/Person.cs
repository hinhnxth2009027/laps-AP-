using System;

namespace lap4.entity
{
    public class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"Name : {Name} - Email : {Email}";
        }
    }
    
}
