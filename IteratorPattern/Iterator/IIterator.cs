using IteratorPattern.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Iterator
{
    public interface IIterator
    {
        IItem First();
        IItem Next();
        bool IsDone { get; }
        IItem CurrentItem { get; }
        int Step { get; set; }
    }
}
