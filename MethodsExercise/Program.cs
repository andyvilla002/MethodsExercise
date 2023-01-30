namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        static void Main(string[] args)
        {
            var amountOfCars = Sum(2, 6);
            var something = Multiply(60, 2, 4);

            //-------------------------Exercise 1------------------------------------------------------
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
