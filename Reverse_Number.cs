using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Reverse_Number
    {
        public void reverse()
        {
            Console.WriteLine("Enter a number");

            int number=Convert.ToInt32(Console.ReadLine());
            int reverse = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }
            Console.WriteLine("The reverse of the given number is: " + reverse);
        
        }
           
     
    }
}
