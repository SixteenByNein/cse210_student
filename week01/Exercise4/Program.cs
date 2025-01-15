using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers. Type 0 to close.");

        int num;

        List<int> numbers = []; //The quick fix dialogue recomended I do this in the place of "new List" ¯\_(ツ)_/¯

        do{

            Console.Write("ENTER NUMBER:  ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                
                numbers.Add(num);
            
            }

        } while(num != 0);

        int sum = 0;

        int max = -2147483648;

        List<int> positive = [];

        foreach (int item in numbers){

            sum += item;

            if(item > max){

                max = item;

            }

            if(item > 0){

                positive.Add(item);

            }

        }

        int min = 2147483647;

        foreach (int item in positive){

            if (item < min){

                min = item;

            }

        }

        Console.WriteLine ($"The sum is {sum},");


        float avg = sum / numbers.Count;

        Console.WriteLine ($"the average is {avg},");

        Console.WriteLine ($"and the highest was {max}.");

        if (positive.Count > 0)
        {

            Console.WriteLine($"The smallest positive number is {min}");

        } else
        {

            Console.WriteLine("There were no positive numbers in this list.");

        }

        numbers.Sort();
        Console.WriteLine($"Here's your list in order: {string.Join(",", numbers)}");

    }
}