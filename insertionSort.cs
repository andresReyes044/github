using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace examen3ej2.classes
{
    class insertionSort<t>
    {
        public static void insertionSor(int[] Icomparable, int n)
        {
            int i, key, j;
            for (i = 1; i < n; i++)
            {
                key = Icomparable[i];
                j = i - 1;

                /* Move elements of arr[0..i-1], that are
                   greater than key, to one position ahead
                   of their current position */
                while (j >= 0 && Icomparable[j] > key)
                {
                    Icomparable[j + 1] = Icomparable[j];
                    j = j - 1;
                }
                Icomparable[j + 1] = key;
            }
        }

    }
}
