using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class FibonacciSeries
    {
        public void Series()
        {
            int x = 0;
            int y = 1;
            int z, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            // print 0;
            Console.Write(x);   
            //here we start form 1;
            for (i = 1; i < number; i++)    
            {
                z = x + y;
                Console.Write(z + " ");
                x = y;
                y = z;
            }
        }
    }
}
