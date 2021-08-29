using System;
using System.Collections.Generic;
using System.Text;

namespace shopbeta.Core.Helper
{
   public class GenerateOrderNumber
    {
        public static int generate()
        {
            var random = new Random();
            var generatedNumber = random.Next(100000, 1000000);

            return generatedNumber;
        }
    }
}
