

using System.Runtime.CompilerServices;

namespace Generic_Constraint_List_ArrayList.Models
{
    internal class GroupMate
    {
        private Student[] _student;
        public GroupMate(int size)
        {
            _student = new Student[size];
        }
        public Student this[int index]
        {
            get 
            {
                return _student[index];
            }
            set
            { 
             _student[index] = value;
            }
        }
        public int Count
        {
            get { return _student.Length; }
        }
        public void Sort()
        {
            for (int i = 0; i < _student.Length - 1; i++)
            {
                for (int j = i; j < _student.Length; i++)
                {
                    if (_student[i] > _student[j])
                    {
                        var tem = _student[i];
                        _student[i] = _student[j];
                        _student[j] = tem;
                    }
                }
            }
        }
    }
}