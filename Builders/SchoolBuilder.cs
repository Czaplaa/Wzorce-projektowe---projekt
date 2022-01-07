using System;
using System.Collections.Generic;
using System.Text;
using Projekt.Classes;

namespace Projekt.Builders
{
    internal class SchoolBuilder
    {
        string _name = "";
        string _address = "";
        string _email = "";
        string _phone = "";
        string _fax = "";

        public SchoolBuilder Name(string name)
        {
            _name = name;
            return this;
        }
        public SchoolBuilder Address(string address)
        {
            _address = address;
            return this;
        }
        public SchoolBuilder Email(string email)
        {
            _email = email;
            return this;
        }
        public SchoolBuilder Phone(string phone)
        {
            _phone = phone;
            return this;
        }
        public SchoolBuilder Fax(string fax)
        {
            _fax = fax;
            return this;
        }

        public School Build()
        {
            return new School(_name, _address, _email, _phone, _fax);

        }

    }
}
