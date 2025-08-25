using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int No1 = 0, No2 = 0, Sum = 0;

            Console.WriteLine("\n\t Welcome To Arithmetic App");

            Console.Write("\n Enter 1st Number : ");
            No1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter 2nd Number : ");
            No2 = Convert.ToInt32(Console.ReadLine());

            Sum = No1 + No2;

            Console.WriteLine("\n Addition of " + No1 + " And " + No2 + " = " + Sum + ".");

            Console.ReadKey();
        }
    }
}
