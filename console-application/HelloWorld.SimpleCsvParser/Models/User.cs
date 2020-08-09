using System;

namespace HelloWorld.SimpleCsvParser.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public DateTime RegistrationDate { get; set; }

        public bool IsEnabled { get; set; }
    }
}
