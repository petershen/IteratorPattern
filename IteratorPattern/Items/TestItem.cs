using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Items
{
    public class TestItem : IItem
    {
        private string _description;

        public TestItem(string descrption)
        {
            _description = descrption;
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
