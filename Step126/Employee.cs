using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step126
{
    public class Employee : Person, IQuittable
    {
        public  void SayName()
        {
            Console.WriteLine(FirstName + LastName);

        }
        public void Quit()
        {
            Console.WriteLine(FirstName + LastName);


            
            
        }

    }

}
