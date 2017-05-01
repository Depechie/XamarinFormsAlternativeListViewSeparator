using System;
namespace ListViewSeparator.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}