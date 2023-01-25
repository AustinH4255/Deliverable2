/*
Author: Austin Hall
Date: 1/19/2023
Description: C# Console Application for calculating letter grades
*/

using System;

namespace Deliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numerical grade: ");

            try
            {
                decimal grade = decimal.Parse(Console.ReadLine());
                string letter = "null";
                
                if (grade >= 90)
                {
                    letter = "A";
                }

                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                }

                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                }

                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";
                }

                else if (grade < 60)
                {
                    letter = "F";
                }

                
                Console.WriteLine("Your expected letter grade in ISM 4300 is " + letter);
            }

            catch
            {
                Console.WriteLine("Please enter an integer value.");
            }
        }
    }
}