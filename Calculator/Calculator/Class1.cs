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
                Console.WriteLine("a) + : Add");
                Console.WriteLine("s) - : Substract");
                Console.WriteLine("m) * : Multiply");
                Console.WriteLine("d) / : Devide");
                Console.Write("Enter a letter of option: ");
                Console.ReadKey();

                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"Result: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "s":
                        Console.WriteLine($"Result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "m":
                        Console.WriteLine($"Result: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "d":
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