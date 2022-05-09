using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Perfect_Number
    {
        
        public void number()
        {
            int sum;
            Console.Write("Enter a Number:");
            int x=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<x;i++)
            {
                if(x % i == 0)
                {
                     sum =+ i;

                }
            }
        }
    }
}
