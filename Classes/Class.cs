using System;
using System.Collections.Generic;
using System.Text;
using Projekt.Interfaces;

namespace Projekt.Classes
{
    internal class Class : IClaas
    {
        Class(string name)
        {
            this.name = name;
        }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<object> students { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}