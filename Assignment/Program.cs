using Assignment.Q1;
using Assignment.Q2;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Where is the problem here?
            /*
             * the problem occures when we already have a sorted array 
             * the bubble sort algorithm will make a loops the check
             * so we need a way to check if it's already sorted or not
             * 
             */
            //int[] arr = { 1, 3, 2,};

            //Helper<int>.BubbleSort(arr);


            //foreach(int i in arr) 
            //{
            //    Console.WriteLine(i);
            //}

            //User[] users = 
            //{
            //    new User() {Id = 10 , Name ="Ebrahem",Salary = 10000 },
            //    new User() {Id =20 , Name ="Ashraf",Salary = 1000 },
            //    new User() {Id = 30 , Name ="Ahmed",Salary = 2000 },
            //    new User() {Id = 40 , Name ="Alhebashy",Salary = 4000 },
            //};


            //Helper<User>.BubbleSort(users);

            //foreach (User i in users)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region Q2
            /*
             * Requirments
             * create Generics class Range<T>
             * represent values from min to max 
             * range should support basic operations such check if value with in the range
             * - determine the length of the range
             * 
             */


            User u1 = new User() {Id = 10 , Name = "Ebrahem" , Salary = 4000 };
            Range<int> range = new Range<int>(3000,5000);

            bool result = range.IsInRange(u1.Salary);
            Console.WriteLine(result);

           double length =  range.Length();
            Console.WriteLine(length);


            #endregion
        }
    }
}
