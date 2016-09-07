using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_batting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Welcome to Batting Average Calculator!\nEnter number of times at bat:\t");
            int BatTimes = int.Parse(Console.ReadLine());
            Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");
            int slug = 0;
            int makes = 0;
            for (int count = 0; count < BatTimes; count++)
            {
                Console.Write($"Result for at-bat {count}:\t");
                int res = int.Parse(Console.ReadLine());
                slug = slug + res;
                if (res >= 1)
                {
                    makes++;
                }
            }
            Console.WriteLine($"\nBatting avg:\t\t{BatAverage(BatTimes, makes)}");
            Console.WriteLine($"Slugging percentage:\t{SlugPercent(slug, BatTimes)}");
        }
        public static double SlugPercent(double slug, double BatTimes)
        {
            double slugP = slug / BatTimes;
            return Math.Round(slugP,4);
        }
        public static double BatAverage(double BatTimes, double makes)
        {
            double BatAvg = makes / BatTimes;
            return Math.Round(BatAvg,4);
        }
    }
} 