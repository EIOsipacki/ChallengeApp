using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; set; }

        public float Max { get; set; }

        public float Average { get; set; }

        public char AverageLetter { get; set; }

        public void WriteLineStatistics()
        {
            Console.WriteLine("Result");
            Console.WriteLine($"Average: {Average:N2}");
            Console.WriteLine($"Min: {Min}");
            Console.WriteLine($"Max: {Max}");
            Console.WriteLine($"Litera AverageLetter = {AverageLetter}");
        }

    }
    
}
