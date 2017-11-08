﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Quick
    {
        /* O(n log n) typical run time and O(log n) space.
         * O(n^2) worst case.
         * 
         */

        public static int[] QuickSort(this int[] arry)
        {
            QuickSort(arry, 0, arry.Length - 1);

            return arry;
        }

        public static void QuickSort(int[] arry, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex) return;

            int index = Partition(arry, leftIndex, rightIndex);

            QuickSort(arry, leftIndex, index -1);   //Sort left side
            QuickSort(arry, index, rightIndex);     //Sort right side
        }

        private static int Partition(int[] array, int leftIndex, int rightIndex)
        {
            int pivot = array[(leftIndex + rightIndex) / 2];

            while (leftIndex <= rightIndex)
            {
                while(array[leftIndex] < pivot) leftIndex++;        //Check numbers until one needs to be swaped to right side of the pivot.
                while (array[rightIndex] > pivot) rightIndex--;     //Check numbers until one needs to be swaped to left side of the pivot.

                if (leftIndex <= rightIndex)
                {
                    Common.Swap(array, leftIndex, rightIndex);

                    leftIndex++;
                    rightIndex--;
                }
            }

            return leftIndex;
        }
    }
}
