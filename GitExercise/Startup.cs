using System;

namespace GitExercise
{
    public class Startup
    {
        public static void Main()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Console Calculator App");
                Console.WriteLine(new string('-', 15));

                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.WriteLine("Choose one from the listed options:");
                foreach (string option in OptionsManager.OptionsList)
                {
                    Console.WriteLine($"\t{option}");
                }

                Console.Write("Option: ");
                string choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    OptionsManager.Add(a, b);
                    break;
                case "s":
                    OptionsManager.Subtract(a, b);
                    break;
                case "m":
                    OptionsManager.Multiply(a, b);
                    break;
                    case "dr":
                        OptionsManager.DivideRemainder(a, b);
                        break;
                    case "exit":
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        Console.ReadKey(intercept: true);
                        return;
                    case "pow":
                    OptionsManager.Power(a, b);
                    break;
                case "log":
                    OptionsManager.Log(a, b);
                    break;
                case "fact":
                    OptionsManager.Factorial(a, b);
                    break;
            }
            
        }
    }
}
