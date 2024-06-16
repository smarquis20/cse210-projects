using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int userNumber = -1;

        List<int> listNum = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            
            if (userNumber != 0)
            {
                listNum.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int num in listNum)
        {
            sum += num;
        }

        float avg = ((float)sum) / listNum.Count;

        int largestNumber;
        largestNumber = listNum.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine ($"The largest number is: {largestNumber}");
        
    }

}