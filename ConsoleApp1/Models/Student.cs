

using ConsoleApp1.Models;
using System.Numerics;

namespace Generic_Constraint_List_ArrayList.Models
{
    internal class Student : Person
    {
        public int Point { get; set; }

        public Student(string name, string surname,int age, int point): base(name, surname, age)
         {
            Point = point;
        }
        public static bool operator >(Student s1, Student s2 )
        {
            return s1.Point > s2.Point;
        }
        public static bool operator <(Student s1, Student s2)
        {
            return s1.Point < s2.Point;
        }
        override public string ShowInfo()
        {
            return $"ID: {IdCounter} Name: {Name} Surname: {Surname} Age: {Age} Point: {Point}";
        }

    }
}
