using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q1
{
    internal static class Helper<T> where T : IComparable<T>
    {
        //We put a boolean flag to check in the first iteration 
        //if there is any swaps then continue 
        //else the the array is already sorted then brea;

        public static void BubbleSort(T[] arr) 
        {
            bool swapped;

            for (int i = 0; i < arr.Length; i++) // 1 
            {
                swapped = false;
                for (int j = 0; j < arr.Length - i - 1; j++) //0 1 2 3 
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                    {
                        //Swap
                        Swap(ref arr[j],ref arr[j + 1]);
                        swapped = true;
                    }

                }

                if (swapped == false)
                    break;
            }
        }

        public static void Swap(ref T item1, ref T item2) 
        {
            T temp = item1;
            item1 = item2;
            item2 = temp;
        }
    }
}
