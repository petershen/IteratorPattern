using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Aggregate
{
    public interface IAggregation
    {
        IIterator CreateIterator();
    }
}
