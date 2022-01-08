using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.Lists
{
    public class AllLists
    {
        public List<Sschool> schoolList { get; set; }
    }

    public class Sschool
    {
        public string schoolName { get; set; }
        public string schoolAddress { get; set; }
        public List<Cclass> classList { get; set; }
    }

    public class Cclass
    {
        public string className { get; set; }
        public string classType { get; set; }
        public List<Sstudent> studentList { get; set; }
    }

    public class Sstudent
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
