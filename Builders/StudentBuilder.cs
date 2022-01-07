using System;
using System.Collections.Generic;
using System.Text;
using Projekt.Classes;

namespace Projekt.Builders
{
    internal class StudentBuilder
    {
        string _firstName = "";
        string _lastName = "";
        string _PESEL = "";
        string _email = "";
        string _phone = "";
        string _address = "";

        public StudentBuilder FirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }
        public StudentBuilder LastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }
        public StudentBuilder PESEL(string PESEL)
        {
            _PESEL = PESEL;
            return this;
        }
        public StudentBuilder Email(string email)
        {
            _email = email;
            return this;
        }
        public StudentBuilder Phone(string phone)
        {
            _phone = phone;
            return this;
        }
        public StudentBuilder Address(string address)
        {
            _address = address;
            return this;
        }

        public Student Build()
        {
            return new Student(_firstName, _lastName, _PESEL, _email, _phone, _address);
        }
    }
}