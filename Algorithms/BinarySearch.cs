﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BinarySearch
    {
        /*
        The binary search algo takes an ordered list of numbers and finds the target in O(log n)
        */
       
        public BinarySearch()
        {
            List<int> randList = new List<int>();
            var random = new Random();
            for(int i = 0; i < 100; i++)
            {
                randList.Add(random.Next(100));
            }
            BinSearch(randList.OrderBy(o=>o).ToArray(), 99);
        }
        public int BinSearch(int[] arry, int target)
        {
            int low=0;
            int high=arry.Length-1;
            int mid;

            while(low<=high)
            {
                mid = (low + high) / 2;//get middle position.
                if(arry[mid] < target)
                    low = mid + 1;
                else if(arry[mid] > target)
                    high = mid - 1;
                else
                    return mid;   
            }
            return -1; //error!
        }
    }
}