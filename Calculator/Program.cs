using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        private static double num1;
        private static double num2;
        //public static double num1 { get; set; }
        //private static double num2 { get; set; }

        static void Main(string[] args)
        {
            string toContinue = "";
            Console.WriteLine("Welcome to the calculator application");
            do
            {
                Console.WriteLine("Choose an option from the following list. Please enter");
                Console.WriteLine("1 for addition");
                Console.WriteLine("2 for subtraction");
                Console.WriteLine("3 for multiplication");
                Console.WriteLine("4 for division");
                Console.WriteLine("5 for addition with the array input");
                Console.WriteLine("6 for subtraction with the array input");
                Console.WriteLine("7 to find the highest value of  two numbers.");
                Console.WriteLine("8 to find the lowest value of  two numbers.");
                int input = GetIntFromUser();
                switch (input)
                {
                    case 1:
                        GetTWoNumberFromUser();
                        Console.WriteLine($"{num1} + {num2} = " + Addition(num1, num2));
                        break;
                    case 2:
                        GetTWoNumberFromUser();
                        Console.WriteLine($"{num1} - {num2} = " + Subtraction(num1, num2));
                        break;
                    case 3:
                        GetTWoNumberFromUser();
                        Console.WriteLine($"{num1} * {num2} = " + Multiplication(num1, num2));
                        break;
                    case 4:
                        GetTWoNumberFromUser();
                        Console.WriteLine($"{num1} / {num2} = " + Division(num1, num2));

                        break;
                    case 5:
                        int size = GetSizeofArrayFromUser();
                        double[] numbers = new double[size];
                        Console.WriteLine("Please enter the numbers consequently");
                        for (int i = 0; i < size; i++)
                        {
                            numbers[i] = GetDoubleFromUSer();
                        }
                        Console.WriteLine("The total sum is: " + Addition(numbers));
                        break;
                    case 6:
                        size = GetSizeofArrayFromUser();
                        double[] number = new double[size];
                        Console.WriteLine("Please enter the numbers consequently");
                        for (int i = 0; i < size; i++)
                        {
                            number[i] = GetDoubleFromUSer();
                        }
                        Console.WriteLine("The total difference is: " + Subtraction(number));
                        break;

                    case 7:
                        GetTWoNumberFromUser();
                        Console.WriteLine("The maximum number is " + Math.Max(num1, num2));
                        break;
                    case 8:
                        GetTWoNumberFromUser();
                        Console.WriteLine("The minimum number is " + Math.Min(num1, num2));
                        break;
                    default:
                        Console.WriteLine("You have entered an incorrect option");
                        break;
                }
                Console.WriteLine("Please enter 'Q' to quit the application and any other key to continue");
                toContinue = Console.ReadLine();
                Console.Clear();
            } while (toContinue.ToUpper() != "Q");

        }
        static double GetDoubleFromUSer()
        {
            bool Successed = false;
            double userInput = 0.0;
            while (!Successed)
            {
                Successed = Double.TryParse(Console.ReadLine(), out userInput);
            }
            return userInput;
        }
        static int GetIntFromUser()
        {
            bool Successed = false;
            int userInput = 0;
            while (!Successed)
            {
                Successed = Int32.TryParse(Console.ReadLine(), out userInput);

            }
            return userInput;
        }
        static void GetTWoNumberFromUser()
        {
            Console.WriteLine("Please enter the first number");
            num1 = GetDoubleFromUSer();
            Console.WriteLine("Please enter the second number");
            num2 = GetDoubleFromUSer();
        }
        static int GetSizeofArrayFromUser()
        {
            int size = 0;
            bool positive = false;
            do
            {
                Console.WriteLine("Please enter the total numbers (The size of the array)");
                size = GetIntFromUser();
                if (size > 0)
                {
                    positive = true;
                }
            } while (!positive);
            return size;
        }
        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Addition(double[] number)
        {
            double result = 0.0;
            foreach (double num in number)
            {
                result += num;
            }
            return result;
        }
        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Subtraction(double[] number)
        {
            double result = 0.0;
            for (int i = 0; i < number.Length; i++)
            {
                if (i == 0)
                {
                    result = number[i];
                }
                else
                {
                    result -= number[i];
                }
            }
            return result;
        }
        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Division by zero is impossible.");
            }

            return num1 / num2;
        }
    }
}

