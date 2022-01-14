using System;
using System.Collections.Generic;
using System.Text;


namespace Projekt.IteratorDir.Interfaces
{
    internal interface IIteratorInterface
    {
        object First();
        object Next();
        bool IsDone();
        object CurrentItem();
    }
}
