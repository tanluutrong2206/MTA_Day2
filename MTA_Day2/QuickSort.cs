using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTA_Day2
{
    public sealed class QuickSort
    {
        public static void Sort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                /* pi is partitioning index, arr[p] is now at right place */
                int rightIndex = Partition(array, lowIndex, highIndex);

                Sort(array, lowIndex, rightIndex - 1);
                Sort(array, rightIndex + 1, highIndex);
            }
        }

        private static int Partition(int[] array, int lowIndex, int highIndex)
        {
            int pivotIndex = highIndex;
            for (int i = lowIndex; i < highIndex; i++)
            {
                if (array[i] > array[pivotIndex])
                {
                    int temp = array[i];
                    array[i] = array[pivotIndex];
                    array[pivotIndex] = temp;
                }
            }
            return pivotIndex;
        }
    }
}
