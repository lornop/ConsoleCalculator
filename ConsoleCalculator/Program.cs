using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Loren Olsen
 * ECET 230 - Wayne
 * Lab 02 - Console Calculator
 * 16 Sep 2021
 * 
 * A program to do some number crunching on the commandline.
 * First shot at making a new class and running fucntions from another class
 */

namespace Lab02ConsoleCalculator
{                                                                                                  //Theres a close bracket at the end of the commented out code at the bottom. 
    class Program
    {

        static void Main(string[] args)
        {
            
            //***** Declare some variables 
            string num1, num2, operation = "";                                                                //These need to be strings to be read from the keyboard
            double number1, number2, answer = 0;
            int operation_choice = 0;
            bool canconvert;

            //***** Start the main code
            Console.WriteLine("Welcome to the Calculator program");
            
            do
            {
                Console.Write("Enter a number:");
                num1 = Console.ReadLine();
                canconvert = double.TryParse(num1, out number1);

            } while (canconvert == false);


            do
            {
                Console.Write("Enter another number:");
                num2 = Console.ReadLine();
                canconvert = double.TryParse(num2, out number2);

            } while (canconvert == false);


            Console.Write(@"What do you want to do with the numbers?
                          1 = Add
                          2 = Subtract
                          3 = Multiply
                          4 = Divide
                          :");
            operation = Console.ReadLine();
            operation_choice = Convert.ToInt32(operation);

            if ((operation_choice == 4 && number1 == 0) || (operation_choice == 4 && number2 == 0))
            {
                Console.WriteLine("You can not divide by 0!");
                Console.Read();
                return;
            }
            //answer = number1;
            answer = Calculator.doOperation(number1, number2, operation_choice);

            Console.Write($"The answer is {answer}");
            Console.WriteLine(". Thank you for using my calculator.");
            Console.Write("Press enter to exit...");
            Console.Read();

        }
    }

    class Calculator
    {
        public static double doOperation(double number1, double number2, int operation_num)
        {
            double result = 0;


            switch(operation_num)
            {
                case 1:             //Addition
                    result = number1 + number2;
                    break;

                case 2:             //Subtraction
                    result = number1 - number2;
                    break;
                
                case 3:             //Multiplication
                    result = number1 * number2;
                    break;

                case 4:             //Division
                    result = number1 / number2;
                    break;

            }

            return result;
        }



    }

}