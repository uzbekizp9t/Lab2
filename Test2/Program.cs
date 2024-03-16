namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char operation;

            num1 = Convert.ToDouble(Console.ReadLine());

            operation = Convert.ToChar(Console.ReadLine());

            num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    break;
                default:
                    break;
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine($"Result: {result}");
            Console.WriteLine("---------------------------");
        }
    }
}
}
