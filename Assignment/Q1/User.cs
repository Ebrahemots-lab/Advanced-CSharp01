using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q1
{
    internal class User : IComparable<User>
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Salary { get; set; }

        public int CompareTo(User? other)
        {
            if(other is not null) 
            {
                return this.Salary.CompareTo(other.Salary);
            }
            return 1;
        }

        public override string ToString()
        {
            return $"Id:{Id} , Name: {Name} , Salary:{Salary}";
        }

    }
}
