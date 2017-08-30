using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    
    public class Dart
    {

        public int Score { get; set; }
        public bool IsDouble { get; set; }
        public bool IsTriple { get; set; }


        private Random _Random = new Random();

        public Dart(Random random)
        {
            _Random = random; 
        }

        public void Throw()
        {
            Score = _Random.Next(0, 21);

            int multiplier = _Random.Next(1, 101);
            if (multiplier > 95) IsTriple = true;
            else if (multiplier > 90) IsDouble = true;

        }
    }
}
