using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STL_01.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Birth { get; set; }
        public string ToString()
        {
            return $"{FirstName} {LastName}, {Age} years old";
        }
    }

    class compareByBirth : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            if (first.Birth > second.Birth)
            {
                return 1;
            };

            if (first.Birth < second.Birth)
            {
                return -1;
            }

            return 0;
        }
    }
};



