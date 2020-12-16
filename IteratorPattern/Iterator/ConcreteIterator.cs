using IteratorPattern.Aggregate;
using IteratorPattern.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Iterator
{
    public class ConcreteIterator<T> : IIterator
    {
        private readonly ConcreteAggregation<T> _collection;
        private int _current = 0;
        private int _step = 1;

        public ConcreteIterator(ConcreteAggregation<T> collection)
        {
            _collection = collection;
        }

        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        public bool IsDone { get { return _current >= _collection.Count; } }

        public IItem CurrentItem { get { return _collection[_current] as TestItem; } }

        public IItem First()
        {
            _current = 0;
            return _collection[_current] as TestItem;
        }

        public IItem Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection[_current] as TestItem;
            else
                return null;
        }
    }
}
