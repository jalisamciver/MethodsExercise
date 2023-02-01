using System;
using Internal;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //-------------------------Exercise 1-------------------------
            //Name: Jalisa
            //Favorite Color: Purple
            //Favorite Animal: Red Pandas
            //Favorite Band: Paramore

            Console.WriteLine("Hello - what is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favorite band?");
            var band = Console.ReadLine();
        }
    }
}
