using Projekt.Classes;
using Projekt.IteratorDir.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.IteratorDir.Classes
{
    internal class IteratorClass : IIteratorInterface
    {
        public List<Student> collection;
        private int current;

        public IteratorClass(List<Student> newCollection)
        {
            this.collection = newCollection;
        }

        public object CurrentItem()
        {
            current = 0;
            return collection[current];
        }

        public object First()
        {
            return collection[0];
        }

        public bool IsDone()
        {
            return current >= collection.Count;
        }

        public object Next()
        {
            object ret = null;
            if (current < collection.Count)
            {
                ret = collection[current];
                current++;
            }
            return ret;
        }
    }
}
