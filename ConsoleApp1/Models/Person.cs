using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal abstract class Person
    {
      public static int IdCounter = 0;
        private int _id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }    
        protected Person()
        {
        _id = ++IdCounter;
        }

        public override string ToString()
        {
            return $"ID: {_id}, Name: {Name}, Surname: {Surname}, Age: {Age}";
        }
    }

   
}
