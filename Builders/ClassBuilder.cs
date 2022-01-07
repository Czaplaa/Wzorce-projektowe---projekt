using Projekt.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.Builders
{
    internal class ClassBuilder
    {
        public string _name = "";
        public string _type = "";

        public ClassBuilder Name(string name)
        {
            _name = name;
            return this;
        }
        public ClassBuilder Type(string type)
        {
            _type = type;
            return this;
        }

        public Class Build()
        {
            return new Class(_name, _type);
        }
    }
}
