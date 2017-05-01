using System;
using System.Collections.Generic;
using ListViewSeparator.Models;

namespace ListViewSeparator.Services
{
    public static class DataService
    {
        private static List<Person> _persons;

        static DataService()
        {
            _persons = new List<Person>();

            _persons.Add(new Person() { FirstName = "Glenn", LastName = "Versweyveld", Profession = "Mobile developer" });
            _persons.Add(new Person() { FirstName = "Bart", LastName = "Lannoeye", Profession = ".Net architect" });
            _persons.Add(new Person() { FirstName = "Jan", LastName = "Van de Poel", Profession = "Entrepreneur" });
        }

        public static List<Person> GetPersons()
        {
            return _persons;
        }
    }
}