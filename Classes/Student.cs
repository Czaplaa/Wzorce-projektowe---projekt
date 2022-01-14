using Projekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
namespace Projekt.Classes
{
    public class Student : IStudent
    {
        public Student(string firstName, string lastName, string PESEL, string email, string phone, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.PESEL = PESEL;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }

        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string PESEL { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public List<int> grades { get; set; } = new List<int>();
    }
}