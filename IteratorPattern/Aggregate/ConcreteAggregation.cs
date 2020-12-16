
using IteratorPattern.Iterator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Aggregate
{
    public class ConcreteAggregation : IAggregation
    {
        private ArrayList _items = new ArrayList();

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
