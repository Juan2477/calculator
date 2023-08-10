using System;
namespace  ConsoleCalculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Result();
        }

        public static void Result()
        {


            string tipoDeOperacion = "";
            int Number1 = 0;
            int Number2 = 0;

            Console.WriteLine("put the first number  ");
           Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" which operation do you wish to perform ");
            tipoDeOperacion = (Console.ReadLine());
            Console.WriteLine(" put the second number");
           Number2 = int.Parse(Console.ReadLine());

            if (tipoDeOperacion == "+")
            {
                Console.WriteLine(Number1 + Number2);
            }
            else if (tipoDeOperacion == "-")
            {
                Console.WriteLine(Number1 - Number2);
            }
            else if (tipoDeOperacion == "*")
            {
                Console.WriteLine(Number1 * Number2);
            }
            else if (tipoDeOperacion == "/")
            {
                Console.WriteLine(Number1 / Number2);
            }
            else
            {
                Console.WriteLine(" which operation do you wish to perform ");
            }
            Console.ReadLine();
        }
    }
}