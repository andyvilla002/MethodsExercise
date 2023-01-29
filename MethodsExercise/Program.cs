namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var favColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var favAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite Band?");
            var favBand = Console.ReadLine();

            Console.WriteLine($"Thanks, {name}! Here is your profile:");

            Console.WriteLine($"Your name is {name}, your favorite color is {favColor} and your favorite animal is {favAnimal}. We also learned that your favorite band is {favBand}!");
        }

    }
}
