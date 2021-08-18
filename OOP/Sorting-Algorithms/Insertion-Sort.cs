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

            //Insertion Sort Algorithm
            /*
            Time Complexity: O(n^2) AKA Quadratic
            In insertion, we have a wall starting from the first index (index 0).
            Left of our wall = Sorted while right of our wall is unsorted
            Starting from the second index (index 1), we search for the smallest value.
            Once we find it, reference that value and swap it with index o while moving
            the data upward. (Insertion)
            So our array is 0 5 1 9.
            We find 1 and swap it with 5 and move our wall between 0 and 5 to 5 and 1
            which is now 1 and 5.
            Therefore our new array is 0 1 5 9 with our wall between 1 and 5.
            Now we search for the next lowest value and swap it again and move our wall forward.
            Our swap position is based on which value is larger than our reference value.
            We set a condition that checks if our reference value is larger, if so then it moves it before.
            If not, it swaps. This is how it gets sorted based on smallest value scenario.
            */

            for(int partIndex = 1; partIndex < arr.Length; partIndex++)
            {
              int curUnsorted = arr[partIndex];
              int i = 0;
              for(i = partIndex; i > 0 && array[i-1] > curUnsorted; i--)
              {
                array[i] = array[i-1];
              }
              array[i] = curUnsorted;
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
