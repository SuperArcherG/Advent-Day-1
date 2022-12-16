using System;
using System.IO;

namespace Day1
{
    class Program
    {
        static readonly string inputPath = Directory.GetCurrentDirectory().Replace("Day1/bin/Release/netcoreapp3.1", "") + "Input.txt"; //The directory of your input text file, create an Input.txt at your "System.AppContext.BaseDirectory" folder

        static void Main()
        {
            var text = File.ReadAllText(inputPath);
            string[] sections = text.Split("\n\n");
            int[] totalCalories = new int[sections.Length];

            //Repeats for every section
            int l = 0;
            foreach (string section in sections)
            {
                string[] line = section.Split("\n");
                int[] calories = new int[line.Length];

                //Converts string array to integer array
                int i = 0;
                foreach (string caloriesSting in line)
                {
                    calories[i] = int.Parse(caloriesSting);
                    i++;
                }

                //Adds up all the calories for the section
                int temporaryTotalCaloriess = 0;
                foreach (int val in calories)
                {
                    temporaryTotalCaloriess += val;
                }

                //Updates total calories array
                totalCalories[l] = temporaryTotalCaloriess;

                l++;
            }

            //Finds biggest number and print it
            Array.Sort(totalCalories);
            Array.Reverse(totalCalories);
            Console.WriteLine("Part 1: " + totalCalories[0]);
            Console.WriteLine("Part 2: " + (totalCalories[0] + totalCalories[1] + totalCalories[2]));
        }
    }
}
