/* 
   Summary: The program applies a modified versions of Bubble, Selection,
            Merge, and Quick Sort algorithms. The Main() method has two
            functions: 1. Sorts a given array of strings in reverse. 2.
            Stores text of a .txt file in an array and creates 4 distinct
            arrays, and sorts each file with a specific algorithm
            and outputs the runtime in milliseconds.
   Date: 5/25/2019
   Author: John Hong
*/   

using System;
using System.IO;
using System.Diagnostics;


namespace ReverseSorters
{
    class Program
    {
        static void Main()
        {
            string[] arrAnimals = { "Dog", "Cat", "Fish", "Weasel", "Zebra", "Horse" };

            Console.WriteLine("String array BEFORE sorting: ");
            foreach (string animals in arrAnimals)
            {
                Console.Write(animals + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //// Methods that will sort in reverse the above string array.
            ////Utility.bubbleReverseSort(arrAnimals);
            ////Utility.selectionReverseSort(arrAnimals);
            ////Utility.mergeReverseSort(arrAnimals);
            ////Utility.quickReverseSort(arrAnimals);

            Console.WriteLine("String array AFTER sorting and reversing: ");
            foreach (string animals in arrAnimals)
            {
                Console.Write(animals + " ");
            }
            Console.WriteLine();

            //Reads the input.txt and creates 4 copies of distinct arrays
            // that will be used in respective sorting methods.

            //string[] bubbleRead = File.ReadAllLines("C:/input.txt");
            //string[] selectionRead = File.ReadAllLines("C:/input.txt");
            //string[] mergeRead = File.ReadAllLines("C:/input.txt");
            //string[] quickRead = File.ReadAllLines("C:/input.txt");

            //var watch1 = Stopwatch.StartNew();
            //Utility.bubbleReverseSort(bubbleRead);
            //watch1.Stop();
            //var elapsedMs1 = watch1.ElapsedMilliseconds;

            //var watch2 = Stopwatch.StartNew();
            //Utility.selectionReverseSort(selectionRead);
            //watch2.Stop();
            //var elapsedMs2 = watch2.ElapsedMilliseconds;

            //var watch3 = Stopwatch.StartNew();
            //Utility.mergeReverseSort(mergeRead);
            //watch3.Stop();
            //var elapsedMs3 = watch3.ElapsedMilliseconds;

            //var watch4 = Stopwatch.StartNew();
            //Utility.quickReverseSort(quickRead);
            //watch4.Stop();
            //var elapsedMs4 = watch4.ElapsedMilliseconds;

            //Console.WriteLine("Elapsed Time Bubble Reverse Sort: {0} milliseconds", elapsedMs1); // 35904 milliseconds
            //Console.WriteLine("Elapsed Time Selection Reverse Sort: {0} milliseconds", elapsedMs2); // 28498 milliseconds
            //Console.WriteLine("Elapsed Time Merge Reverse Sort: {0} milliseconds", elapsedMs3); // 49 milliseconds
            //Console.WriteLine("Elapsed Time Quick Reverse Sort: {0} milliseconds", elapsedMs4); // 53 milliseconds
        }
    }

    class Utility
    {
        public static void bubbleReverseSort(string[] arr) // Worse case run time: O(n^2)
        {                                                  // Best case: Omega(n)

            // The count variable will be used to count the times the method compares the values.
            // The flag variable will be used to create a separate function that will prevent the
            // program from comparing all the values in a situation where the array is already
            // sorted.
            string tmp;
            long count = 0;
            bool flag = false;

            for (int j = arr.Length - 1; j > 0; j--) // The first for loop will iterate and compare the values
            {
                flag = false;
                for (int i = 0; i < j; i++)

                    // Since strings do not return a numeric value, CompareTo method is used to compare the string
                    // values returned from arr[i] and arr[i+1]. By setting the expression to equal LESS than 0,
                    // the algorithm will sort the values BACKWARDS. This is because the CompareTo() method is
                    // checking if the statement arr[i] compared to arr[i+1] returns a negative value, i.e., is
                    // arr[i] less than the succeeding value, arr[i+1]? If the condition is true, the higher value
                    // (letters/words that appear later in the alphabet) will be placed before the lower value
                    // strings. The statement can be altered to > 0 to sort the values in alphabetical order but
                    // that would require another function to reverse it.

                    if (arr[i].CompareTo(arr[i + 1]) < 0)
                    {

                        // The count variable here will count every time the algorithm compares the values.
                        tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                        count++;
                        flag = true;
                    }

                // The flag here will break algorithm's loop if the array was already sorted.
                if (flag == false)
                    break;

            }
            Console.WriteLine("Number of comparisons Bubble Reverse Sort: {0}", count);
            Console.WriteLine();

        }

        public static void selectionReverseSort(string[] arr) // Best and worst case run time is O(n^2).
        {
            long count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minPos = i;


                for (int j = i + 1; j < arr.Length; j++)
                {
                    // The original algorithm checked to see if the succeeding value
                    // arr[minPos+1] was less than arr[min]. If the condition was true,
                    // the two values would switch places to sort them in order. Thus,
                    // the new algorithm would only have to check if the opposite is true
                    // in order for a sorted array to return backwards; the new algorithm
                    // will need to return a value greater than 0 to allow the array to
                    // be sorted from greatest string ("Zebra") to the least string ("Cat").

                    if (arr[j].CompareTo(arr[minPos]) > 0)
                    {
                        // The count variable here will increase incrementally whenever a
                        // comparison is made.
                        minPos = j;
                        count++;
                    }

                }

                // The value of i will switch position with minPos.
                string tmp = arr[i];
                arr[i] = arr[minPos];
                arr[minPos] = tmp;

            }

            // Code to display the number of comparisons made
            Console.WriteLine("Number of comparisons Selection Reverse Sort: {0}", count);
            Console.WriteLine();

        }

        public static void mergeReverseSort(string[] arr) // Runtime for both case is O(n log n)
        {
            // The count variable is declared and assigned so that it
            // can pass the value and used by following functions.
            long count = 0;

            string[] tmp = new string[arr.Length];
            MergeSortHelper(arr, 0, arr.Length - 1, tmp, ref count);

            // Code to display the number of comparisons made
            Console.WriteLine("Number of comparisons Merge Reverse Sort: {0}", count);
            Console.WriteLine();

        }
        // The best and worst case runtime is O(1).
        public static void MergeSortHelper(string[] arr, int first, int last, string[] tmp, ref long count)
        {
            // The ref long count will pass the value to the same variable
            // in the mergeReverseSort.
            if (first < last)
            {
                int mid = (first + last) / 2;
                MergeSortHelper(arr, first, mid, tmp, ref count);
                MergeSortHelper(arr, mid + 1, last, tmp, ref count);
                Merge(arr, first, mid + 1, last, tmp, ref count);
            }

        }
        // This method's runtime is O(n log n)
        public static void Merge(string[] arr, int first, int mid, int last, string[] tmp, ref long count)
        {
            int i = first;
            int j = mid;
            int k = first;

            while (i < mid && j <= last)
            {
                // The original condition checked to see if the arr[i] value
                // was less than arr[j] and placed the it into temporary
                // variable if true. The opposite condition will have to be
                // true if the modified algorithm is to sort backwards from
                // greatest to least string value.
                if (arr[i].CompareTo(arr[j]) > 0)
                {
                    tmp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    tmp[k] = arr[j];
                    j++;
                    k++;
                }

                // The count variable will increase incrementally
                // every time the values are compared. Its value
                // will be passed to MergeSortHelper and
                // mergeReverseSort.
                count++;

            }

            // The while loops will place the remaining elements.
            // The first loop will only execute if there are
            // elements remaining in the first half of the array.
            while (i < mid) 
            {
                tmp[k] = arr[i];
                k++;
                i++;
            }

            while (j <= last)
            {
                tmp[k] = arr[j];
                j++;
                k++;
            }

            // The temporary buffer is placed back into the
            // array.
            for (int p = first; p <= last; p++)
            {
                arr[p] = tmp[p];
            }

        }

        public static void quickReverseSort(string[] arr) // Best and worst case is
        {                                                 // O(n log n)

            // The ref long count will pass the value to the same variable
            // in the quickReverseSort method.
            long count = 0;
            QuickSortHelper(arr, 0, arr.Length - 1, ref count);
           
            //Code to display the number of comparisons made
            Console.WriteLine("Number of comparisons Quick Reverse Sort: {0}", count);
            Console.WriteLine();

        }


        public static void QuickSortHelper(string[] arr, int first, int last, ref long count) // Best and worst case is O(1)
        {                                                                                
            // The condition statement executes when there are at least
            // two elements in the subarray that will be sorted.
            if (first < last)
            {
                 // A pivot variable is assigned to the Partition method.
                int p = Partition(arr, first, last, ref count);
                QuickSortHelper(arr, first, p - 1, ref count);
                QuickSortHelper(arr, p + 1, last, ref count);
            }

        }

        // The method will return the index of the variable p after it is run.
        public static int Partition(string[] arr, int first, int last, ref long count) // Best and worst is O(n log n)
        {

            string pivot = arr[last];
            int lessIndex = first - 1;


            for (int j = first; j < last; j++)
            {
                // tmp is declared string here to prevent the code from
                // constantly declaring it as string whenever it's used
                // during the condition statement executes.
                string tmp;

                // The original method sorted the values from least to
                // greatest if arr[j] was less than or equal to pivot;
                // the opposite will have to be true for the method to
                // sort from greatest to least.
                if (arr[j].CompareTo(pivot) >= 0)
                {
                    lessIndex++;
                    tmp = arr[j];
                    arr[j] = arr[lessIndex];
                    arr[lessIndex] = tmp;

                }

                // The count variable will increase incrementally
                // whenever the values are compared and its final
                // value will be passed to quickReverseSort method.
                // Placing the code inside the block will only count
                // the instances when the condition is true.
                count++;
            }

            // Pivot is put into place. 
            arr[last] = arr[lessIndex + 1];
            arr[lessIndex + 1] = pivot;

            // The value returned is the new position of the pivot.
            return lessIndex + 1;

        }

    }
}
   
