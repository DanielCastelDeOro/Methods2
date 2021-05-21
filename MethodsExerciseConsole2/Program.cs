using System;

namespace MethodsExerciseConsole2
{
    class Program
    {
        
        public static void thebody()
        {
            Console.WriteLine("Hello, What is you name?");

            var name = Console.ReadLine();

            Console.WriteLine($"Hey {name}");

            Console.WriteLine("Whats your favorite color?");

            var color = Console.ReadLine();

            Console.WriteLine($"{color}?");

            Console.WriteLine($"Not what I thought. But hey we all cant be perfect! Whats your favorite animal?");

            var animal = Console.ReadLine();

            Console.WriteLine($"Okay, I like {animal}");

            Console.WriteLine($"Tell me {name}, whats your favorite type of food?");

            var food = Console.ReadLine();

            Console.WriteLine($"I love {food}! {name}, I need to go. Thanks for talking. Have a great day.");
        }
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;

            int anwser1 = Addition(2, 4);

            int anwser2 = Addition(1, 3);

            Console.WriteLine($"Did you know that 2 + 4 = {anwser1}?");

            Console.WriteLine($"And that 3 + 1 = {anwser2}?");
        }

        public static int Multiply(int num1, int num2) 
        {
            
            return num1 * num2;

            Console.WriteLine($"Hey, do you know what 10 * 2 =?");

            int anwser3 = Multiply(10, 2);

            var anwser = Console.ReadLine();

            Console.WriteLine($"The anwser is {anwser3}");
        }
        static void Main(string[] args)
        {

            thebody();
                               
                      
                      

           
        }
    }
}
