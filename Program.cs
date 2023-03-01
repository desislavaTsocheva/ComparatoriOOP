using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparePersons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("IVAN", 23, "PLOVDIV");
            Person p2 = new Person("MARIYA", 18, "SOFIYA");
            Console.WriteLine(p1.CompareTo(p2));
        }
    }
}
