using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CS.Itself.Iterator
{
    class Catalogue
    {
        public SparePart[] SpareParts { get; set; }

        public Catalogue()
        {
            SpareParts = new []
            {
                new SparePart() {Code ="12345", Name = "Wheel", Price = 100D }, 
                new SparePart() {Code ="23456", Name = "Nut", Price = 200D }, 
                new SparePart() {Code ="34567", Name = "Bolt", Price = 300D }, 
                new SparePart() {Code ="45678", Name = "Brake", Price = 400D }, 
                new SparePart() {Code ="56789", Name = "Lamp", Price = 500D }, 
            };
        }

        public int Count => SpareParts.Length;

        public IEnumerable GetSpareParts(int number)
        {
            for (int i = 0; i < Count; i++)
            {
                if (i == Count)
                {
                    yield break;
                }
                else
                {
                    yield return SpareParts[i];
                }
            }
        }


    }
}
