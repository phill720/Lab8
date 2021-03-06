﻿using System;

namespace Lab8_batting
{
    public class Program
    {                   
        public static void Main(string[] args)
        {
            Console.Write("Welcome to Batting Average Calculator!\nEnter number of times at bat:\t");
            int BatTimes = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter 'OUT', 'SINGLE', 'DOUBLE', 'TRIPLE', or 'HOMERUN' \n");
            int slug = 0;
            int makes = 0;
            //---"What did they get?:" (Answer)---
            for (int count = 0; count < BatTimes; count++)
            {
                Console.Write($"Result for at-bat {count}:\t");
                string res = Console.ReadLine();
                slug = slug + Result.BasesEarned(res);
                if (Result.BasesEarned(res) >= 1)
                {
                    makes++;
                }
            }
            Console.WriteLine($"\nBatting avg:\t\t{BatAverage(BatTimes, makes)}");
            Console.WriteLine($"Slugging percentage:\t{SlugPercent(slug, BatTimes)}");
        }
        //------Slugging Percentage------
        public static double SlugPercent(double slug, double BatTimes)
        {
            double slugP = slug / BatTimes;
            return Math.Round(slugP, 4);
        }
        //------Batting Average------
        public static double BatAverage(double BatTimes, double makes)
        {
            double BatAvg = makes / BatTimes;
            return Math.Round(BatAvg, 4);
        }
    }
}