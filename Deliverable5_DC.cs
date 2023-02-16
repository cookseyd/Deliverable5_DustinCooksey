/*
 * Author: Dustin Cooksey
 * Date: 02/10/2023
 * Description: This C# Console application takes a number from a user
 * between 5 and 15, validates the users entry and then writes and array 
 * equal to the length of the users entry while summing the total of the array.
 * 
*/

using System;

namespace Deliverable5_DustinCooksey
{
    class Deliverable5_DC
    {
        static int[] first_array(int array_len)
        {
            Random random = new Random();
            int[] secondArray = new int[array_len];
            for (int x = 0; x < array_len; x++)
            {
                secondArray[x] = random.Next(10, 50);
            }

            return secondArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            try
            {
                int input = 0;
                while (input < 5 || input > 15)
                {
                    Console.WriteLine("Enter an integer between 5 and 15");
                    input = int.Parse(Console.ReadLine());
                }

                int[] thirdArray = first_array(input);
                Console.WriteLine("The element in the random array are: ");

                foreach (int element in thirdArray)
                {
                    Console.WriteLine(element);
                }

                Console.WriteLine(" ");
                Console.WriteLine("The sum is: " + sum(thirdArray));
            }

            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
