using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.Lists
{
    public class SchoolList
    {
        public List<School> schoolList { get; set; }
    }

    public class School
    {
        public string schoolName { get; set; }
        public string schoolAddress { get; set; }
        public List<Class> classList { get; set; }
    }

    public class Class
    {
        public string className { get; set; }
        public string classType { get; set; }
        public List<Student> studentList { get; set; }
    }

    public class Student
    {
        
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string PESEL { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public List<int> grades { get; set; }
    }
}
