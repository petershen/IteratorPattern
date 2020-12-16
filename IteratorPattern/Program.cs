using IteratorPattern.Aggregate;
using IteratorPattern.Items;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection

            var collection = new ConcreteAggregation();
            collection[0] = new TestItem("Test Item 0");
            collection[1] = new TestItem("Test Item 1");
            collection[2] = new TestItem("Test Item 2");
            collection[3] = new TestItem("Test Item 3");
            collection[4] = new TestItem("Test Item 4");
            collection[5] = new TestItem("Test Item 5");
            collection[6] = new TestItem("Test Item 6");
            collection[7] = new TestItem("Test Item 7");
            collection[8] = new TestItem("Test Item 8");

            // Create iterator
            var iterator = collection.CreateIterator();

            // Skip every other item
            iterator.Step = 2;

            Console.WriteLine("Iterating over collection:");

            for (IItem item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Description);
            }

            Console.ReadKey();
        }
    }
}
