using Projekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.Classes
{
    internal class School : ISchool
    {
        public School(string name, string address, string email, string phone, string fax)
        {
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone = phone;
            this.fax = fax;
        }
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public List<Class> classList { get; set; } = new List<Class>(); 
    }
}