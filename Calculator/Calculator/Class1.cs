namespace Calculator
{
    public class Class1
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter option: ");
                Console.WriteLine(" + : Add");
                Console.WriteLine("- : Substract");
                Console.WriteLine("* : Multiply");
                Console.WriteLine("/ : Devide");
                Console.Write("Enter a sign as option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($"Result: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine($"Result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine($"Result: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "/":
                        Console.WriteLine($"Result: {num1} / {num2} = " + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("That is not a valid option");
                        break;
                }
                Console.Write("Would you like to continue? (Y = yes, N = No): ");

            } while (Console.ReadLine().ToUpper() == "Y");
        }
    }
}