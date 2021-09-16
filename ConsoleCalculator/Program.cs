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
            double number1, number2, answer = 0;                                                              //These are the actual numbers that are converted from the input strings
            int operation_choice = 0;                                                                         //Number value of the desired operation
            bool canconvert;                                                                                  //Test value used in checking the validity of input

            //***** Start the main code
            Console.WriteLine("Welcome to the Calculator program");                                           //Print out a welcome message
            
            do
            {
                Console.Write("Enter a number:");                                                             //Ask for input
                num1 = Console.ReadLine();                                                                    //Read input to the first string
                canconvert = double.TryParse(num1, out number1);                                              //canconvert is a boolean value returned by the Tryparse function and if it works
                                                                                                              //it gets passed ot the number1 number value
            } while (canconvert == false);                                                                    //Keeps asking for a valid number until it gets one


            do
            {
                Console.Write("Enter another number:");                                                       //Asks for the second numeber
                num2 = Console.ReadLine();
                canconvert = double.TryParse(num2, out number2);                                              //Keep asking until you get valid input

            } while (canconvert == false);

                                                                                                              //Write to the screen to ask for the desired operation.
                                                                                                              //The @ symbol is makes it print all cahracters the way you see it
            Console.Write(@"What do you want to do with the numbers?                                          
                          1 = Add
                          2 = Subtract
                          3 = Multiply
                          4 = Divide
                          :");
            operation = Console.ReadLine();                                                                   //Read input for operation
            operation_choice = Convert.ToInt32(operation);                                                    //Convert to an int value

            if ((operation_choice == 4 && number1 == 0) || (operation_choice == 4 && number2 == 0))           //Do some checking and comparison to make sure we arent dividing by 0
            {
                Console.WriteLine("You can not divide by 0!");
                Console.Read();
                return;
            }
            //answer = number1;
            answer = Calculator.doOperation(number1, number2, operation_choice);                              //Get the answer from the Calculator class doOperation function

            Console.Write($"The answer is {answer}");                                                         //Seems weird, but the only way i could get this to print answer. its printing as a string???
            Console.WriteLine(". Thank you for using my calculator.");
            Console.Write("Press enter to exit...");
            Console.Read();                                                                                   //Cya Later

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