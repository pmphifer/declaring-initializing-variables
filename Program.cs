using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace WeekOneHomework
{
    class Program
    {
        static void Main(string[] args)

        {
            //Code Exercise 1 (tada!)

            //Code Exercise 2: declare and initialize boolean, string, integer, character, and double
            bool BOOL = false;
            string title = "Harry Potter";
            int myInt = 30;
            char letter = 'P';
            double dubs = 6.22;

            //Code Exercise 2 continued

            bool Boolio = true;
            int age = 35;
            double deci = 59.8;
            char g = 'G';
            string DV = "DevYou";

            //Code Exercise 3: Printing variables to the console
            Console.WriteLine();
            Console.WriteLine("This is " + Boolio);
            Console.WriteLine("I am almost " + age);
            Console.WriteLine(deci);
            Console.WriteLine(g);
            Console.WriteLine(DV);

            Console.WriteLine();

            //Code Exercise 4: Madlib

            String adj1 = "polka-dotted";
            String noun1 = "hippogriff";
            String pastTenseVerb1 = "glided";
            String adv = "longingly";
            String adj2 = "nonchalant";
            String noun2 = "french press";
            String noun3 = "fruit basket";

            Console.WriteLine("Today I went to the zoo. I saw a " + adj1 + " "  + noun1 + " jumping up and down in its tree.");
            Console.WriteLine("It {0} {1} through the large tunnel that led to its {2} {3}.", pastTenseVerb1, adv, adj2, noun2);
            Console.WriteLine($"I got some peanuts and passed them through the cage to the gigantic grey {noun3} towering about my head.");


            //Challenge
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter an adjective:");
            string adjective = Console.ReadLine();
            Console.Write("Enter an animal:");
            string animal = Console.ReadLine();
            Console.Write("Enter a past tense verb:");
            string verb = Console.ReadLine();
            Console.Write("Enter a adverb:");
            string adverb = Console.ReadLine();
            Console.Write("Enter another adjective:");
            string adject2 = Console.ReadLine();
            Console.Write("Enter a noun:");
            string no = Console.ReadLine();
            Console.Write("Enter a another noun:");
            string no2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine($"Today I went to the zoo. I saw a {adjective} {animal} jumping up and down in its tree.");
            Console.WriteLine($"It {verb} {adverb} through the large tunnel that led to its {adject2} {no}.");
            Console.WriteLine($"I got some peanuts and passed them through the cage to the gigantic grey {no2} towering about my head.");













            Console.ReadLine();


        }
    }
}

