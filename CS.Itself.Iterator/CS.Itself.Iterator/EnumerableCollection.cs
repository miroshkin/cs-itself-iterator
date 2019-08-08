using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CS.Itself.Iterator
{
    class EnumerableCollection
    {

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 5; i++)
            {
                yield return i + 1;
            }
        }


    }
}
