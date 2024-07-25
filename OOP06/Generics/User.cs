using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Generics
{
    internal struct User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }


        public static bool operator == (User left , User Right) 
        {
            return left.Equals(Right);
        }


        public static bool operator !=(User left, User Right)
        {
            return !left.Equals(Right);
        }
    }
}
