using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortAlgorithms
{
    internal class selectionSort
    {
        public static List<int> Sort(List<int> list)
        {
            int n = list.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (list[j] < list[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the first element
                int temp = list[minIndex];
                list[minIndex] = list[i];
                list[i] = temp;
            }
            return list;

        }
    }
}
