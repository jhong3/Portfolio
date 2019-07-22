/* 
 * Source: St. Martin's University CSC395 Summer 2019 Sorting Algorithms Lecture Slide by
 *         Dr. Razvan Mezei.
 * Summary: The program implements Binary Search methods, one with a
 *          regular implementation and another using recursion.
 * 
 * Date: 7/22/19
 * 
 * Author: John Hong
 *  
*/

using System;

namespace BinarySearch
{
    class Program
    {
        static void Main()
        {
            int[] test1 = { 2, 10, 35, 15, 18 }; // Indices { 0, 1, 2, 3, 4 }
            Console.WriteLine(binarySearch(test1, 35)); // 35 is the third element, i.e., index 2
            Console.WriteLine(BinarySearchRec(test1, 10));
        }

        // non-recursive method
        static int binarySearch(int[] arr, int key)
        {
            // set variables
            int index = -1; // index variable set to -1 by default in case there is no matching key!
            int low = 0;
            int high = arr.Length - 1;
            int mid;

            // continuosly loop as long as the conditions
            // are met
            while (low <= high && index == -1)
            {
                // set the value of mid
                mid = (low + high) / 2;

                // following conditional statements will execute until
                // key is found/not found
                if (arr[mid] == key)
                {
                    index =  mid;
                }

                else if (arr[mid] <  key)
                {
                    low = mid + 1;
                }

                else
                {
                    high = mid - 1;
                }
            }

            return index;
        }

        // Using recursion
        static int BinarySearchRec(int[] arr, int key)
        {
            return BinarySearchRecHelper(arr, key, 0, arr.Length - 1);
        }

        static int BinarySearchRecHelper(int[] arr, int key, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }

            int mid = (low + high) / 2;
            
            if (arr[mid] == key)
            {
                return mid;
            }

            // check upper bound/top half
            else if(arr[mid] < key)
            {
                return BinarySearchRecHelper(arr, key, mid + 1, high);
            }

            // check lower bound/bottom half
            else
            {
                return BinarySearchRecHelper(arr, key, low, mid - 1);
            }
        }

    }


}
