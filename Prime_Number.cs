using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Prime_Number
    {
        public void prime()
        {
            Console.WriteLine("Enter a Number");
            int n= Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                   
                }
            }
            if (a==2)
             {
                 Console.WriteLine("{0} is a Prime Number", n);
             }
             else
             {
                 Console.WriteLine("Not a Prime Number");
             }
            
            Console.ReadLine();

        }
    }
}
