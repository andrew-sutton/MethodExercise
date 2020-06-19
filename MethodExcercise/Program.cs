using System;

namespace MethodExercise
{
    class Program
    {
        public static void UserCommand(string input)
        {
            Console.WriteLine($"I need {input}:");
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Mulitply(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the adlib story!");
            //Asking for a noun
            UserCommand("a noun");
            var noun1 = Console.ReadLine();
            //Asking for a verb
            UserCommand("a verb");
            var verb1 = Console.ReadLine();
            //Asking for an adjective
            UserCommand("an adjective");
            var adjective1 = Console.ReadLine();
            //Asking for a second noun
            UserCommand("a noun");
            var noun2 = Console.ReadLine();
            //Asking for your name
            UserCommand("your name");
            var name = Console.ReadLine();

            Console.WriteLine($"An Ode to {noun1}");
            Console.WriteLine($"I love to {verb1} with {noun1}");
            Console.WriteLine($"It has such a {adjective1} {noun2}");
            Console.WriteLine($"Signed, {name}");
            Console.WriteLine();
            Console.WriteLine($"Now we are going to add and mulitpy");
            UserCommand("your first number");
            int num1 = int.Parse(Console.ReadLine());
            UserCommand("your second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} plus {num2} is {Sum(num1, num2)}");
            Console.WriteLine($"{num1} times {num2} is {Mulitply(num1, num2)}");
        }
    }
}
