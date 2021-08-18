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

            //Bubble Sort Algorithms
            /*
            Time Complexity: O(n^2) AKA Quadratic
            In bubble sort, we have a wall on the far right and it moves down left
            as each element gets sorted. The elements in our array gets sorted by
            swapping with index 1 and 2, and then 2 and 3. The process continues until
            the wall reaches the left of our array. Then the array is deemed sorted by bubble
            sort.
            */
            for(int o = arr.length - 1; o > 0; o--)
            {
                for(int i = 0; i < o; i++)
                {
                    if(arr[i] > arr[i+1])
                    {
                        Swap(arr, i, i++);
                    }
                }
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
