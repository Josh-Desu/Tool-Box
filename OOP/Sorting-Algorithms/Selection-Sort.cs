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

            //Selection Sort Algorithm
            /*
            Time Complexity: O(n^2) AKA Quadratic
            In Selection, we either pick the minimum or maximum value. (Smallest or largest value)
            If we pick the smallest value, then our sorted/wall starts from the left or smallest
            side. For largest value, it'll be our right/largest side.
            Our "temp" data will find the smallest/largest value (Depending on the pick)
            and then sort it after our wall.
            Our wall will be before index 0. So when we find the smallest value, it'll be
            swapped with index 0 and the wall moves up. Therefore, we have a sorted side before the
            wall (Index 0) and the unsorted side after our wall where index 1 will be swapped
            with the next smallest value.
            */
            //We picked the smallest value in this case (Minimum value)
            for(int o = arr.Length - 1; o > 0; o--)
            {
                int temp = 0;
                for(int i = 0; int i <= o; i++)
                {
                    if(arr[i] > arr[temp])
                    {
                        temp = i;
                    }
                }
                Swap(arr, temp, o);
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
