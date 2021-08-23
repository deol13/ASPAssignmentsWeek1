using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPAssignment1.Models
{
    public static class FeverCheck
    {
        static int minFeverTemp = 37;

        public static string CheckForFever(int input)
        {
            string returnMsg = "You do not have fever!";

            if (input >= minFeverTemp)
            {
                returnMsg = "You have fever!";
            }

            return returnMsg;
        }
    }
}
