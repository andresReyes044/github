using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4.classes
{
    class SelectionSort
    {
        public static void  selectionSort<T>(T[] array) where T :IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                T min = array[i];
                int minId = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(min) < min.CompareTo(min))
                    {
                        min = array[j];
                        minId = j;
                    }
                }
                // swapping
                T temp = array[i];
                array[i] = min;
                array[minId] = temp;
            }
        }
    }
}
