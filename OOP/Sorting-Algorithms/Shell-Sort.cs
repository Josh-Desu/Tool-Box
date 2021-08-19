/*
* Copyright (C) Josh Y. - All Rights Reserved
* Unauthorized copying of this file, via any medium is strictly prohibited
* Proprietary and confidential
* Written by Josh Y. <joyang112@gmail.com>, June 2017
*/
//Libraries:
//================================
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class program
    {
        static void Main(string[] args)
        {
            //Array that will be used to be sorted
            int[] arr = new int[] {100, 50, 75, 25, 0};

            //Shell Sorting Algorithm
            /*
            Time Complexity: O(n3/2)
            In Shell, we have a GAP which is our limit. This sorting algorithm is a
            improved insertion sort algorithm. Insertion shifts neighbor elements only so it makes
            it fast on pre-sorted arrays. In shell, we swap elements based on our gap index (0 and 4 then 1 and 5)
            Therefore, it pre-sorts arrays before calling insertion and reducing swap distance elements.
            In summary, shell or array starts with a large gap of unsorted arrays and lowers it by using gap to swap.
            As each gap cycles through our array, it shortens until it gets to 1 and 1 (index 0 and 1 where distnace is 1 index)
            Then it calls an insertion to sort the pre-sorted array.
            The gap works by dividing custom gap by x number so if we had a gap of 6, we divide it by 2 and it'll lower it to 3 as our updated gap.
            This algorithm is unstable
            */
            int gap = 1;
            while(gap < arr.Length / 3)
            {
                gap = 3 * gap + 1;
            }

            while (gap >= 1)
            {
                for(int i = gap; i < arr.Length; i++)
                {
                    for(int j = i; j >= gap && arr[j] < arr[j - gap]; j -= gap)
                    {
                        Swap(arr, j, j - gap);
                    }
                }
                gap /= 3;
            }

            //Print out results
            foreach(var i in arr)
            {
                Console.WriteLine("Sorted Array: ");
                Console.WriteLine(i);
            }
        }
    }

    static void Swap(int[] arr, int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
}
