using System;

namespace Operators
{   
   //Create an Employee class with Id, FirstName and LastName properties.    
   public class Employee
       {
           public int Id { get; set; }
           public string FirstName { get; set; }
           public string LastName { get; set; }

          //In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property. Remember that comparison operators must be overloaded in pairs. 
           public static bool operator ==(Employee emp1, Employee emp2)
           {
               if (emp1.Id.Equals(emp2.Id))
               {
                    return true;
               }
                 return false;
           }
           public static bool operator !=(Employee emp1, Employee emp2)
           {
               if (!emp1.Id.Equals(emp2.Id))
               {
                    return true;
               }
                 return false;
           }
           
           





       }
}











