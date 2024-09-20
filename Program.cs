using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// In the Main() method of the console app, instantiate the class.
namespace ConsoleApplication_Class1
{
    class Program 
       //Call the method in the class, passing in two numbers.
       static void Main(string[] args)
       {
          Class1 ob = new Class1();

          Console.Write("Sum = " + ob.sum(56, 23));
          ob.Display();
          Console.Read();

       }





}
