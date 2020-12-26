using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STL_01.Models;

namespace STL_01.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<Person> al = new List<Person> {
                                                new Person { FirstName = "John", LastName = "Lord", Age = 70 },
                                                new Person { FirstName = "Jon", LastName = "Gillan", Age = 75 },
                                                new Person { FirstName = "Ritchy", LastName = "Blackmore", Age = 71 },
                                               };
            al[2] = new Person { FirstName = "Robert", LastName = "Plant", Age = 73 };
            al.Insert(3, new Person() { FirstName = "Jimi", LastName = "Page", Age = 75 });

            var s = new Stack<Person>();
            s.Push(new Person { FirstName = "Isaac", LastName = "Newton", Age = 400 });
            s.Push(new Person { FirstName = "Albert", LastName = "Einstain", Age = 100 });
            s.Push(new Person { FirstName = "Michel", LastName = "Faradey", Age = 200 });

            var set = new SortedSet<Person>(new compareByBirth())
                                            {
                                             new Person { FirstName = "Jonann", LastName = "Bach", Birth = 1685 },
                                             new Person { FirstName = "Georg Frideric", LastName = "Handel", Birth = 1685 }
                                            };

            set.Add(new Person { FirstName = "Dmitri", LastName = "Shostakovich", Birth = 1906 });
            set.Add(new Person { FirstName = "Pyotr", LastName = "Tchaykovsky", Birth = 1840 });
            set.Add(new Person { FirstName = "Wolvgang", LastName = "Mozart", Birth = 1756 });

            var queue = new Queue<Person>();
            queue.Enqueue(al[1]);
            queue.Enqueue(new Person { FirstName = "Wolvgang", LastName = "Mozart", Birth = 1756 });

            DataRepository dr = new DataRepository();
            dr.list = al;
            dr.stack = s;
            dr.set = set;
            dr.queue = queue;

            return View(dr);
        }
    }
}
