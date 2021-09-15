using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please eneter a number");
            double num1 = Convert.ToInt32(Console.ReadKey());

            Console.WriteLine("Enter a second number");
            double num2 = Convert.ToInt32(Console.ReadKey());


            Console.WriteLine("What operation would you like to do?");
            Console.WriteLine("1 = Add, 2 = Subtract");
            Console.WriteLine("3 = Multiply, 4 = Divide");

            int operation_num = Convert.ToInt32(Console.ReadKey());
            switch (operation_num)
            {
                case 1:
                    //do a add and some stuff
                    break;

                case 2:
                    //do a subtract
                    break;

                case 3:
                    //do a multiply
                    break;

                case 4:
                    //do a divide
                    break;

            }


        }
    }

    class Calculator
    {
         
    }
}
