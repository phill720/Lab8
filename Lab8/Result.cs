using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_batting
{
    class Result
    {
        public static int BasesEarned(string result)
        {
            result = result.ToUpper();
            if (result == "OUT")
            {
                return 0;
            }
            else if (result == "SINGLE")
            {
                return 1;
            }
            else if (result == "DOUBLE")
            {
                return 2;
            }
            else if (result == "TRIPLE")
            {
                return 3;
            }
            else if (result == "HOMERUN")
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
    }
}
