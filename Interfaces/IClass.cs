using System;
using System.Collections.Generic;
using Projekt.Classes;
using System.Text;

namespace Projekt.Interfaces
{
    internal interface IClass
    {
        public string name { get; set; }
        public string type { get; set; }
        public List<Student> studentList { get; set; }
    }
}
