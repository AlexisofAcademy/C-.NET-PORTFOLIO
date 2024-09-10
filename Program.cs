using System;

namespace Operators
{
   //In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their properties. Then compare the two Employee objects using the newly overloaded operators and display the results.
     class Program 
     {
        static void Main(string[] args)
        {
             Employee emp1 = new Employee();
             emp1.Id = 1;
             emp1.FirstName = "Bob";
             emp1.LastName = "Jones";

             Employee emp2 = new Employee();
             emp2.Id = 1;
             emp2.FirstName = "Bob";
             emp2.LastName = "Jones";

             if (emp1 == emp2)
             {
                Console.WriteLine("emp1 is equal to emp2");
             }
             else 
             {
                Console.WriteLine("emp1 is not equal to emp2");
             }
         Console.ReadKey();








        }










}
}