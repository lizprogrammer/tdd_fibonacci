using System;
﻿using System.Collections.Generic;
﻿using System.Linq;
﻿using System.Text;
﻿using System.Threading.Tasks;
﻿using System.Diagnostics;
﻿
namespace Fibonacci
{
    /* Sequence of Fibonacci Numbers
     * 1,1,2,3,5,8,13,21,34
     * or
     * 0,1,1,2,3,5,8,13,21,34
     */
     //[TestFixture]
     public class FibonacciTests
     {
       //  [Test]
         public void TestFibonacci()
         {
             //Assert.AreEqual(0,GetFibonacci(0));
             //Assert.AreEQual(0,GetFibonacci(0));
             if(GetFibonacci(0) == 0)
                Console.WriteLine("Equals zero!");
            else
                Console.WriteLine("Not equal to zero");
                
                
         }
         
         private int GetFibonacci(int index)
         {
             if(index == 0)return 0;
             if(index <=2) return 1;
             return GetFibonacci(index - 1) + GetFibonacci(index - 2);
         }
     }
    class Program
    {
        //[Test]
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var newFib = new FibonacciTests();
            newFib.TestFibonacci();
        }
    }
}
