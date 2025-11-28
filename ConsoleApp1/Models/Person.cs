

namespace ConsoleApp1.Models
{
    internal abstract class Person
    {
      public static int IdCounter = 0;
        private int _id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }    
        protected Person(string name,string surname,int age)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            { 
            throw new ArgumentException("Name ve ya Surname deyeri bosh ola bilmez.");
            }
            _id = ++IdCounter;
            Name = name;
            Surname = surname;
            Age = age;

        }


        public virtual string ShowInfo()
        {
            return "ID: {_id} Name: {Name} Surname: {Surname} Age: {Age}";
        }
    }

   
}
