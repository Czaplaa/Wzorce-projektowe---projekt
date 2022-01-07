using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.Classes
{
    internal class Class
    {
        public Class(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
        public string name { get; set; }
        public string type { get; set; }
        public List<Student> studentList { get; set; }
    }
}