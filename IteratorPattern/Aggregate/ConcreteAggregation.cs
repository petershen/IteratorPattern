
using IteratorPattern.Iterator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Aggregate
{
    public class ConcreteAggregation<T> : IAggregation
    {
        private IList<T> _items = new List<T>();

        public IIterator CreateIterator()
        {
            return new ConcreteIterator<T>(this);
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
            set { _items.Add((T)value); }
        }
    }
}
