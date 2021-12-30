using System;
using System.Collections.Generic;
using System.Text;
using Projekt.Interfaces;

namespace Projekt.Classes
{
    internal class School : ISchool
    {
        School(string name, string address) 
        {
            this.name = name;
            this.address = address;
        } 
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<object> classes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddClass()
        {
            throw new NotImplementedException();
        }

        public void RemoveClass()
        {
            throw new NotImplementedException();
        }
    }
}
