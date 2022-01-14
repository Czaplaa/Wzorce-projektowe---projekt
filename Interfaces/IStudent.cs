using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.Interfaces
{
    internal interface IStudent
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string PESEL { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public List<int> grades { get; set; } 
    }
}
