﻿using System;

namespace MethodsExerciseConsole2
{
    class Program
    {
        public static int Addition(int num1, int num2)
        {
            //just perform Addition here; return answer to called method at lines 54 & 56
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2) 
        {
            return num1 * num2;
        }

        static void Main(string[] args)
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


            //Calling Addition Method
            int anwser1 = Addition(2, 4);

            int anwser2 = Addition(1, 3);

            Console.WriteLine($"Did you know that 2 + 4 = {anwser1}?");

            Console.WriteLine($"And that 3 + 1 = {anwser2}?");

            //Calling Multipy Method
            Console.WriteLine($"Hey, do you know what 10 * 2 =?");

            int anwser3 = Multiply(10, 2);

            Console.WriteLine($"The anwser is {anwser3}");

            //Moved Console.ReadLine here:
            //Console.WriteLines to ask user for number input
            Console.WriteLine("What is the 1st number you'd like to multiply?");

            //Console.ReadLine gets strings from user. int.Parse converts string to an int so Multiply method can solve
            var factor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What's the 2nd number?");

            var factor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{factor1} * {factor2} = ");

            Console.WriteLine(Multiply(factor1, factor2));

        }
    }
}
