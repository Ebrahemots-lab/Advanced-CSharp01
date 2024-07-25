using OOP06.Generics;
using OOP06.Models;

namespace OOP06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics
            //What is Generics? 
            //Simple we user generics to reduce code complixity and make a readable code 
            //we use generics instead of using objects How?
            //if we need to create a method that take a value and store it into an array 
            //if we need to make a function to store more than one type we will overload this method to create more types
            //instead we use generics to create only one method that work with all data types


            #endregion

            #region Generics Ex01

            //GenList<int>.Add(3,0);
            //GenList<int>.Add(4,1);
            //GenList<int>.Add(5,1);

            #endregion

            #region Generics Ex02
            //User user = new User() { Id = 10 , Age = 20 , Name = "Ebrahem"};
            //User user1 = new User() { Id = 20 , Age = 30 , Name = "Ashraf" };

            //User user03 = new User();

            //User[] users = {user , user1 , user03}; 

            //int result = GenList<User>.SearchArray(users, user03);
            //Console.WriteLine(result);
            #endregion

            #region Classes

            Emp emp1 = new Emp() { Id = 10 , Number = 1010 , Name = "Ebrahem"};
            Emp emp2 = new Emp() { Id = 10 , Number = 1010 , Name = "Ebrahem"};

            /*
             * if we use == to compare between two classes it will only compare the reference togeather
             * not the object state so we need to modify it 
             * 1 - Modify the == 
             * 2 - Modify the Equals that inherited from the object
             */

            if(emp1 == emp2) //After operator overloading  it will print equal
            {
                Console.WriteLine("Equals");
            }
            else 
            {
                Console.WriteLine("Not Equals");
            }


            if (emp1.Equals(emp2)) 
            {
                Console.WriteLine("Equals");
            }
            else 
            {
                Console.WriteLine("not equals");
            }


            //we need to override getHashcode also because in this time both statment will print equals 
            //because they have the same ojbect state but the address is different

            Console.WriteLine(emp1.GetHashCode());
            Console.WriteLine(emp2.GetHashCode());
            //it will return the same Hashcode

            #endregion

            #region BubbleSort
            //int[] myarr = { 8, 2, 6, 4, 1 };

            //foreach(int e in myarr) 
            //{
            //    Console.Write(e);
            //}

            //Helper<int>.BubbleSort(myarr);


            //foreach (int e in myarr)
            //{
            //    Console.Write(e);
            //}

            //Emp[] emps = 
            //{
            //    new Emp() {Id = 10 , Name = "Ebrahem" , Number = 100},
            //    new Emp() {Id = 20 , Name = "Ashraf" , Number = 50},
            //    new Emp() {Id = 40 , Name = "Ahmed" , Number = 300},
            //    new Emp() {Id = 50 , Name = "aLHEBASHY" , Number = 20},
            //};

            //Helper<Emp>.BubbleSort(emps);

            //foreach (Emp  e in emps)
            //{
            //    Console.WriteLine(e);
            //}

            #endregion

            #region BubbleSortPointExample
            //Point[] points =
            //{

            //    new Point(4,5),
            //    new Point(2,2),
            //    new Point(),
            //    new Point(7,5),
            //    new Point(3,3),
            //    new Point(5,9),
            //};

            //Helper<Point>.BubbleSort(points);



            //foreach(Point p in points) 
            //{
            //    Console.WriteLine(p);
            //}
            #endregion


        }
    }
}
