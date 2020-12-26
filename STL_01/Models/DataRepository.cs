using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STL_01.Models
{
    public class DataRepository
    {
        public List<Person> list { get; set; }
        public Stack<Person> stack { get; set; }
        public Queue<Person> queue { get; set; }
        public SortedSet<Person> set { get; set; }
        public Dictionary<string, Person> dictionary { get; set; }
    }
}
