using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.Interfaces
{
    internal interface IStudent
    {
        int Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        List<int > Grades { get; set; }   

        List <int> Presence { get; set; }
    }
}
