using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Models
{
    internal class Point : IComparable<Point>
    {
        public int X;

        public int Y;


        public Point()
        {
            
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }


        public int CompareTo(Point? other)
        {
            if (X != other?.X)
            {
                return X.CompareTo(other?.X);
            }
            else
            {
                return Y.CompareTo(other.Y);
            }
        }

        public override string ToString()
        {
            return $"X = {X} - Y = {Y}";
        }

        //public int CompareTo(object? obj)
        //{
        //    //(2,3) (5,7)
        //    Point? convertedObj = obj as Point;

        //    if(this.X != convertedObj?.X) 
        //    {
        //        return this.X.CompareTo(convertedObj.X);
        //    }
        //    else 
        //    {
        //        return this.Y.CompareTo(convertedObj.Y);
        //    }
        //}
    }
}
