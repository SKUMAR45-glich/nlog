using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace ConsoleApp3
{
    class Addnumbers
    {
        private readonly NLog nLog = new NLog();
        public int Sum(int firstNumber, int secondNumber)
        {
            if(firstNumber == 0 || secondNumber ==0)
            {
                nLog.LogDebug("Debug Unsuccesful");
                nLog.LogError("Expecting NULL values");
                nLog.LogWarn("firstNumber or secondNumber should not equla to 0");

            }
            int result = firstNumber + secondNumber;
            nLog.LogDebug("Debug succesful");
            nLog.LogInfo("Sum is " + result);
        }
    }
}
