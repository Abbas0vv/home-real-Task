using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Group
    {
        public Group(Student[] students, string groupNo, int studentLimit)
        {
            _students = students;
            _groupNo = groupNo;
            _studentLimit = studentLimit;
        }

        private Student[] _students = new Student[0];
        public string _groupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (GetAndValidateGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }
        public int _studentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (5 < value && value < 18)
                {
                    _studentLimit = value;
                }
            }
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[^1] = student;
        }

        public Student GetStudent(int id)
        {
            foreach (Student student in _students)
            {
                if (student._id == id)
                    return student;
            }
            return null;
        }

        public Student[] GetAllStudents()
        {
            if (_students != null)
                return _students;
            else
                return null;
        }

        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo == _groupNo)
            {
                return true;
            }
            return false;
        }

        public bool GetAndValidateGroupNo(string groupNo)
        {
            return ValidateLength(groupNo) && IsUpper(groupNo);
        }

        public bool ValidateLength(string word)
        {
            if (word.Length > 2)
                return true;
            else
                return false;
        }

        public bool IsUpper(string word)
        {
            char[] upperCaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                            'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
                            'U', 'V', 'W', 'X', 'Y', 'Z' };
            bool firstIsUpper = false;
            bool secondIsUpper = false;

            for (int i = 0; i < upperCaseLetters.Length; i++)
            {
                if (word[0] == upperCaseLetters[i])
                    firstIsUpper = true;

                if (word[1] == upperCaseLetters[i])
                    secondIsUpper = true;
            }

            return firstIsUpper && secondIsUpper;

        }

    }
}
