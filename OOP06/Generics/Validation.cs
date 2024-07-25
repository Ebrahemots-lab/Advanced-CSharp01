using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Generics
{
    internal static class Validation
    {
        //this method will check if any reference type is null or not 
        public static bool IsNull<T>(T value) where T : class
        {
            return value == null;
        }
    }
}
