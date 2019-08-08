using System;

namespace CS.Itself.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            EnumerableCollection collection = new EnumerableCollection();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
