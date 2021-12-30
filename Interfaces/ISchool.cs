using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.Interfaces
{
    interface ISchool
    {
        string name { get; set; }

        string address { get; set; }

        List<object> classes { get; set; }

        void AddClass();

        void RemoveClass();

    }
}
