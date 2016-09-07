using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab8_batting;

namespace Lab8Test
{
    [TestClass]
    public class AverageTests
    {
        [TestMethod]
        public void BattingPercentageIs0WhenNoRuns()
        {
            int[] BattingSheet = new int[5];
            BattingSheet[0] = 0;
            BattingSheet[1] = 0;
            BattingSheet[2] = 0;
            BattingSheet[4] = 0;
            BattingSheet[5] = 0;
            int makes = 0;
            int res = 0;
            for (int i = 0; i < 5; i++)
            {
                res = res + BattingSheet[i];
                if (res >= 1)
                { makes++; }
            }
            double average = Program.BatAverage(5, makes);
            double slugg = Program.SlugPercent(res, 5);
            Assert.AreEqual(0, average);
            //Assert.AreEqual(0, slugg);
            //double average = Program.;
        }
        [TestMethod]
        public void TestBattingPercentageis60()
        {
            //int[] battingSheet = new int[5];
            //battingSheet[0] = 0;
            //battingSheet[1] = 0;
            //battingSheet[2] = 2;
            //battingSheet[3] = 4;
            //battingSheet[4] = 1;
            double average = Program.BatAverage(5, 3);
            Assert.AreEqual(0.6, average);
        }
    }
}
