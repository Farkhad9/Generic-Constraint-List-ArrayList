

using ConsoleApp1.Models;

namespace Generic_Constraint_List_ArrayList.Models
{
    internal class Teacher : Person
    {
        public decimal Salary { get; set; }

        public Teacher(string name,string surname,int age, decimal salary): base (name, surname, age)
        {
         Salary = salary;   
        }
        public override string ShowInfo()
        { 
         return $"ID: {IdCounter} Name: {Name} Surname: {Surname} Age: {Age} Salary: {Salary}";
        }
        public static bool operator >(Teacher t1, Teacher t2)
        { 
        return t1.Salary > t2.Salary;
        }
        public static bool operator <(Teacher t1, Teacher t2)
        { 
        return t1.Salary < t2.Salary;
        }
    }
}
