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

            Catalogue catalogue = new Catalogue();
            foreach (SparePart sparePart in catalogue.GetSpareParts(5))
            {
                Console.WriteLine($"Detail - {sparePart.Name}, Code - {sparePart.Code}, Price - {sparePart.Price}");
            }

        }
    }
}
