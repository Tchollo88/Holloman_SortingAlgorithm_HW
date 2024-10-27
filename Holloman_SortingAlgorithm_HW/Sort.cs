using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holloman_SortingAlgorithm_HW
{
    public static class Sort
    {
        #region ** Bubble Sorting Algorithm **
        public static int[] BubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
            }
            return arr;
        }
        #endregion

        #region ** Insertion Sorting Algorithm **
        public static int[] InsertionSort(int[] array, int length)
        {
            for (int i = 1; i < length; i++)
            {
                var key = array[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
            return array;
        }

        //public static int[] InsertionSort(int[] array, int length)
        //{
        //    if (length <= 1)
        //    {
        //        return array;
        //    }
        //    InsertionSort(array, length - 1);
        //    var key = array[length - 1];
        //    var k = length - 2;
        //    while (k >= 0 && array[k] > key)
        //    {
        //        array[k + 1] = array[k];
        //        k = k - 1;
        //    }
        //    array[k + 1] = key;
        //    return array;
        //}
        #endregion

        #region ** Merge Sorting Algorithm **
        public static int[] MergeSortAlgorithm(int[] arr, int n)
        {
            MergeSort(arr, 0, arr.Length - 1);
            return arr;
        }

        private static void Merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        private static void MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {

                // Find the middle point
                int m = l + (r - l) / 2;

                // QuickSort first and second halves
                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);

                // Merge the sorted halves
                Merge(arr, l, m, r);
            }
        }
        #endregion

        #region ** Quick Sorting Algorithm **

        // The QuickSort function implementation
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                QuickSort(arr, left, pivot - 1);
                QuickSort(arr, pivot + 1, right);


            }
        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp1;

            return i + 1;
        }



        //public static int[] QuickSort(int[] array, int low, int high)
        //{
        //    int i = low;
        //    int j = high;
        //    int c = array[low];

        //    while (i <= j)
        //    {
        //        while (array[i] < c)
        //        {
        //            i++;
        //        }

        //        while (array[j] > c)
        //        {
        //            j--;
        //        }
        //        if (i <= j)
        //        {
        //            int temp = array[i];
        //            array[i] = array[j];
        //            array[j] = temp;
        //            i++;
        //            j--;
        //        }
        //    }

        //    if (low < j)
        //    { QuickSort(array, low, j); }
        //    if (i < high)
        //    { QuickSort(array, i, high); }
        //    return array;
        //}

        //public static void QuickSort(int[] arr, int low, int high)
        //{
        //    if (low < high)
        //    {

        //        // pi is the partition return index of c
        //        int pi = Partition(arr, low, high);

        //        // Recursion calls for smaller elements
        //        // and greater or equals elements
        //        QuickSort(arr, low, pi - 1);
        //        QuickSort(arr, pi + 1, high);
        //    }

        //    // Swap function
        //    static void Swap(int[] arr, int i, int j)
        //    {
        //        int temp = arr[i];
        //        arr[i] = arr[j];
        //        arr[j] = temp;
        //    }

        //    // Partition function
        //    static int Partition(int[] arr, int low, int high)
        //    {

        //        // Choose the c
        //        int c = arr[high];

        //        // Index of smaller element and indicates 
        //        // the right position of c found so far
        //        int i = low - 1;

        //        // Traverse arr[low..high] and move all smaller
        //        // elements to the left side. Elements from low to 
        //        // i are smaller after every iteration
        //        for (int j = low; j <= high - 1; j++)
        //        {
        //            if (arr[j] < c)
        //            {
        //                i++;
        //                Swap(arr, i, j);
        //            }
        //        }

        //        // Move c after smaller elements and
        //        // return its position
        //        Swap(arr, i + 1, high);
        //        return i + 1;
        //    }

    }
        #endregion
}
