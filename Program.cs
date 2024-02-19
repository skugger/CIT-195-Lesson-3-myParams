using System;
using System.Drawing;

namespace CIT_195_Lesson_3_myParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many random numbers do you want?");
            int count = int.Parse(Console.ReadLine());                  // prompt for number of values to create

            Random rand = new Random();                                 // create random object
            int[] randomNumbers = new int[count];                       // create int numbers array

            for (int i = 0; i < count; i++)
            {
                randomNumbers[i] = rand.Next(1,100);                    // for loop to fill in the array
            }

            Console.WriteLine("Generated random numbers:");
            foreach (int num in randomNumbers)
            {
                Console.WriteLine(num);                                 // for loop to print out numbers in array
            }

            Console.WriteLine($"The sum of all those numbers is {Addemup(randomNumbers)}");         // display sum
            Console.WriteLine($"The product of all those numbers is {Multemup(randomNumbers)}");    // display product
        }
        static int Addemup(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        static int Multemup(params int[] numbers)
        {
            int product = 1;
            foreach (int number in numbers)
            {
                product *= number;
            }
            return product;
        }
    }
}
