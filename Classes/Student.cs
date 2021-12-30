using System;
using System.Collections.Generic;
using System.Text;
using Projekt.Interfaces;
namespace Projekt.Classes
{
    internal class Student : IStudent
    {
        Student(int Id, string FirstName, string LastName)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<int> Grades { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<int> Presence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}