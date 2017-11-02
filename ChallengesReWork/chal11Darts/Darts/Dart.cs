using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        Random random = new Random();
        public string Throw()
        {
            string throwResult = "";
            int dartThrow = random.Next(0, 20);
            int multiplier = random.Next(0, 100);
            if (dartThrow == 0 && multiplier > 94) throwResult += "InnerBullseye";
            else if (dartThrow == 0) throwResult += "OuterBullseye";
            else if (dartThrow > 0 && multiplier > 94) throwResult += dartThrow * 2;
            else if (dartThrow > 0 && multiplier > 90 && multiplier < 94) throwResult += dartThrow * 3;
            else throwResult += dartThrow;
            return throwResult;
        }
    }
}
