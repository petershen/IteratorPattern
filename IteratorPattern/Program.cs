using IteratorPattern.Aggregate;
using IteratorPattern.Items;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create items
            var items = new ConcreteAggregation<TestItem>();
            items[0] = new TestItem("Test Item 0");
            items[1] = new TestItem("Test Item 1");
            items[2] = new TestItem("Test Item 2");
            items[3] = new TestItem("Test Item 3");
            items[4] = new TestItem("Test Item 4");
            items[5] = new TestItem("Test Item 5");
            items[6] = new TestItem("Test Item 6");
            items[7] = new TestItem("Test Item 7");
            items[8] = new TestItem("Test Item 8");

            // Create iterator
            var iterator = items.CreateIterator();

            // Skip every other item
            iterator.Step = 2;

            Console.WriteLine("Iterating over items:");

            for (IItem item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Description);
            }

            Console.ReadKey();
        }
    }
}
