using System;

namespace FirstExercise
{
	class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");

            Console.WriteLine("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter option: ");
            Console.WriteLine("+ : Add");
            Console.WriteLine("- : Substract");
            Console.WriteLine("* : Multiply");
            Console.WriteLine("/ : Devide");
            Console.ReadKey();

        }
    }
}

