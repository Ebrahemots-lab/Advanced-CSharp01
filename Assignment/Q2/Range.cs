using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q2
{
    internal class Range<T> where T : IComparable<T>
    {
   
        public T MinValue { get; set; }

        public T MaxValue { get; set; }

        public Range(T minValue, T maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public bool IsInRange(T value) 
        {
            bool isValueLargerThanMin = false;

            bool isValueSmallerThanMax = false;

            if (value.CompareTo(MinValue) == 1 ) 
                isValueLargerThanMin =  true;

            if(value.CompareTo(MaxValue) == -1 ) 
                isValueSmallerThanMax = true;

            return (isValueLargerThanMin && isValueSmallerThanMax);
        }

        public double Length() 
        {
            double minValue = Convert.ToDouble(MinValue);
            double maxValue = Convert.ToDouble(MaxValue);

            return maxValue - minValue; 
        }
    }
}
