using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortAlgorithms
{
    internal class mergeSort
    {
        public static void Sort(List<int> list)

        {
            if (list.Count <= 1)
                return;

            int mid = list.Count / 2;
            List<int> left = new List<int>(list.GetRange(0, mid));
            List<int> right = new List<int>(list.GetRange(mid, list.Count - mid));

            // Recursively sort left and right sublists
            Sort(left);
            Sort(right);

            // Merge the sorted sublists
            Merge(list, left, right);
        }

        static void Merge(List<int> list, List<int> left, List<int> right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i] < right[j])
                {
                    list[k] = left[i];
                    i++;
                }
                else
                {
                    list[k] = right[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements from left sublist
            while (i < left.Count)
            {
                list[k] = left[i];
                i++;
                k++;
            }

            // Copy remaining elements from right sublist
            while (j < right.Count)
            {
                list[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
