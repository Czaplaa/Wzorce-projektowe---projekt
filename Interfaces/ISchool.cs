using System;
using System.Collections.Generic;
using Projekt.Classes;
using System.Text;

namespace Projekt.Interfaces
{
    internal interface ISchool
    {
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public List<Class> classList { get; set; } 
    }
}
