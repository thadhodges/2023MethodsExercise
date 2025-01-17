﻿using System;

namespace MethodsExercise
{
    public class Program
    {
        static void Main( string[] args )
        {
            //Console.WriteLine("Welcome to the C# Mad Libs game!");

            //// Prompt the user for various inputs
            //Console.Write("Enter an adjective: ");
            //string? adjective1 = Console.ReadLine();

            //Console.Write("Enter a noun: ");
            //string? noun1 = Console.ReadLine();

            //Console.Write("Enter a verb (past tense): ");
            //string? verb1 = Console.ReadLine();

            //Console.Write("Enter an adverb: ");
            //string? adverb = Console.ReadLine();

            //Console.Write("Enter a noun (plural): ");
            //string? pluralNoun = Console.ReadLine();

            //Console.Write("Enter a verb (present tense): ");
            //string? verb2 = Console.ReadLine();

            //// Construct the Mad Libs story
            //string madLibsStory = $"Today, I saw a {adjective1} {noun1} that {verb1} {adverb} " +
            //                      $"across the park. Later, it joined a group of {pluralNoun} " +
            //                      $"and they all started to {verb2} together.";

            //// Display the resulting story
            //Console.WriteLine("\nHere's your Mad Libs story:");
            //Console.WriteLine(madLibsStory);

            //Console.ReadLine(); // Wait for user to press Enter to exit


            //Methods practice

            static int Add2Numbers( int num1, int num2 )
            {
                return num1 + num2;

            }

            int result1 = Add2Numbers(34, 67);
            Console.WriteLine(result1);

            static int AddNumbers( params int[] numbers )//an array named "numbers"
            {
                int sum = 0;//start with zero
                foreach ( int num in numbers )// iterate through the array
                {

                    sum += num;//adds all numbers

                }
                return sum;//returns total

            }
            int result2 = AddNumbers(34, 56, 78, 23, 57);//sample array
            Console.WriteLine(result2);//result

            static double AverageNumbers( params double[] numbers )//method for averaging an array of numbers
            {
                double value = 0;
                foreach ( double num in numbers )
                {
                    value += num; //adds all numbers in the array
                }

                return value / numbers.Length;//Average created with total from array divided by number in array
            }
            double result3 = AverageNumbers(1.4, 2, 3, 4.4, 5.5678, 6, 7.456, 8, 90);
            Console.WriteLine(result3);

            static void Answer()
            {
                Console.WriteLine("QUIT IT");
            }

            Answer();

            static void Magic8Ball()
            {
                List<string> answers = new()
                {
                    "YES",
                    "NO",
                    "Maybe",
                    "Don't Do It",
                    "The Stars say Go For It!!!",
                };//list of strings

                Random rand = new();//instantiates a random objec
                string answer = answers[rand.Next(answers.Count)];//gets random string from list using index
                Console.WriteLine(answer);//output of method
            }
            Magic8Ball();//call the magic8ball method

            

            static void MyMethod(params int[] numbers )
            {
                
                foreach (int num in numbers )
                {
                    int value = 0;
                    value += num;
                   
                }
                Console.WriteLine(value); //need to figure this one out.

            }

            MyMethod(2, 5, 8, 0, 98, 89, 45, 23, 45, 67, 8, 6, 5, 4, 3);

            static int MyParamsLength( params int[] numbers )
            {

                //foreach ( int num in numbers )
                //{
                //    //int ans = ans += num;
                //    Console.WriteLine(numbers.Length);
                //}
                return numbers.Length;
               

            }

            Console.WriteLine(MyParamsLength(2, 5, 8, 0, 98, 89, 45, 23, 45, 67, 8, 6, 5, 4, 3)); 

        }
    }
}
