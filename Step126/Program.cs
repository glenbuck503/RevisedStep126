using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step126
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee persons = new Employee();
            persons.FirstName = "Tech";
            persons.LastName = " Academy";
            persons.SayName();
            
            Console.ReadLine();

            IQuittable employees = new Employee();
            employees.Quit();
            Console.ReadLine();






           


        }
    }
}
