using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class program
    {
        static void Main(string[] args)
        {
            List<IQuittable> Employee = new List<IQuittable>();

                Cain cain = new Cain();

                Employee.Add(Cain);

                foreach (IQuittable employee in Employee)
                {
                    Employee.Quit();
                }
        }
       // Create an interface called IQuittable and have it define a void method called Quit().
       public interface IQuittable 
       {
        void Quit();

        int legs { get; set; }
       }

       // Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
        public class Cain : IQuittable
        {
            public int legs { get; set; }

            public void Quit()
            {
                Console.WriteLine("Cain is quit");
            }
        }


















    }
}
       














       
    

