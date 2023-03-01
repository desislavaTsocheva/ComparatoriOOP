﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ComparePersons
{
    public class Person:IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Town
        {
            get { return town; }
            set { town = value; }   
        }
        public Person(string name,int age,string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }
        public void Print()
        {
            Console.WriteLine($"{this.Name}, {this.Age} years, from {this.town}");
        }

        public int CompareTo(Person other)
        {
            int result =Name.CompareTo(other.Name);
            if (result == 0)
            {
                result=Age.CompareTo(other.Age);
            }
            else
            {
                result=Town.CompareTo(other.Town);  
            }
            return result;
        }
    }
}
