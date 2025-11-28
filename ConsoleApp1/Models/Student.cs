

using ConsoleApp1.Models;
using System.Numerics;

namespace Generic_Constraint_List_ArrayList.Models
{
    internal class Student : Person
    {
        public double Point { get; set; }
    
        public static bool operator >(Student s1, Student s2 )
        {
            return s1.Point > s2.Point;
        }
        public static bool operator <(Student s1, Student s2)
        {
            return s1.Point < s2.Point;
        }

    }
}
