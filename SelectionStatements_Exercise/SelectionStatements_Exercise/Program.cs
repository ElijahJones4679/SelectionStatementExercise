using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing game
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            favNumber = 5;
            var counter = 0;
            int userInput;


            do
            {
                Console.WriteLine("Pick a number from 1 - 1000");
                userInput = int.Parse(Console.ReadLine());


                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                counter++;

                Console.WriteLine($"You have guessed {counter} times");


            } while (userInput != favNumber);

            // Exercise 2 (Switch Case)
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                case "calculus":
                    Console.WriteLine("I hate Math!");
                        break;
                case "science":
                case "physics":
                case "biology":
                     Console.WriteLine("I love scince!");
                    break;
                case "pe":
                case "phys ed":
                case "physical education":
                      Console.WriteLine("PE is the best!");
                    break;
                case "history":
                    Console.WriteLine("History is fun.");
                    break;
                case "english":
                    Console.WriteLine("English is boring");
                    break;
                default:
                    Console.WriteLine("I dont know that subject.");
                    break;

            }
           
        }
    }
}