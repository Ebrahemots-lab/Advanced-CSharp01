using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Models
{
    internal class Emp : IComparable
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string? Name { get; set; }

        public override string ToString()
        {
            return $"Emp Number: {Number} : Id: {Id} : Name: {Name}";
        }


        #region Operator overloading
        public static bool operator ==( Emp left, Emp right) 
        {
            return (left.Id == right.Id) && (left.Number == right.Number) && (left.Name == right.Name);
        }

        public static bool operator !=(Emp left, Emp right)
        {
            bool result = (left.Id == right.Id) && (left.Number == right.Number) && (left.Name == right.Name);
            return !result ;
        }
        #endregion

        #region Overrride

        public override bool Equals(object? obj)
        {
            Emp? convertedObj = (Emp?)obj;
            return (this.Id == convertedObj?.Id) && (this.Name == convertedObj.Name) && (this.Number == convertedObj.Number);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Number,Name,Id);
        }

        public int CompareTo(object? obj)
        {
           /* Emp? convertedObj = (Emp?)obj;*/ //unsafe
                                           //May throw Exceptions

            #region Is Operator [True - False]
            //will return true in two casses
            // 1 - obj is Emp 
            // 2 - obj is a object from class inherit from Emp

            //if(obj is Emp convertedEmp) 
            //{
            //    return Number.CompareTo(convertedEmp?.Number);
            //}
            //return 1;
            #endregion

            #region As Operator
            // will sucssed in two casses
            // 1 - obj is Emp 
            // 2 - obj is a object from class inherit from Emp

            Emp? convertedEmp = obj as Emp;

            return this.Number.CompareTo(convertedEmp?.Number);


            #endregion



        }
        #endregion
    }
}
