using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Generics
{
    internal static class GenList<T>
    {

        private static T[] myArr = new T[10];

        public static void Add(T item,int index) 
        {
            if (myArr[index].Equals(0)) 
            {
                myArr[index] = item;

                Console.WriteLine($"{item} has been saved to index {index}");
            }
            else 
            {
                Console.WriteLine($"This Index Is Not Empty it has {myArr[index]}");
            }
        }

        public static T Get(int index) 
        {
            return myArr[index];
        }

        public static int SearchArray(T[] arr , T value) 
        {
            int result = 0;

            if(arr is not null) 
            {
                for(int i = 0; i < arr.Length; i++) 
                {
                    if (arr[i].Equals(value))  //Invalid because we can't use == in Gericics with Struct
                    {
                        result =  i;
                        break;
                    }
                    result = -1;
                   
                }
                
            }

            return result;

        }
    }
}
