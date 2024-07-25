using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Generics
{
    internal class Helper<T> where T : IComparable<T> 
        //T must Implement the I Comparable Interace
    {

        public static void BubbleSort(T[] arr) 
        {
            //Loop through the Array sort it 
            if(!Validation.IsNull(arr)) 
            {
                //5 6 2 1 3 
                for (int i = 0; i < arr.Length; i++) // 1 
                {
                    for (int j = 0; j < arr.Length - i - 1; j++) //0 1 2 3 
                    {
                        if (arr[j].CompareTo(arr[j + 1]) == 1) 
                        {
                            Swap(ref arr[j], ref arr[j + 1]);
                        }
                            
                    }
                }
            }

        }

        public static void Swap(ref T firstItem,ref  T secondItem) 
        {
            T temp = firstItem;
            firstItem = secondItem;
            secondItem = temp;
        }

 

      
    }
}
