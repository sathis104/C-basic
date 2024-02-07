using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecentCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of RecentCounter
            Recentcount recentCounter = new Recentcount();

            // Test the Ping method
            Console.WriteLine(recentCounter.Ping(1)); // Output: 1
            Console.WriteLine(recentCounter.Ping(100)); // Output: 2
            Console.WriteLine(recentCounter.Ping(3001)); // Output: 3
            Console.WriteLine(recentCounter.Ping(6002)); // Output: 1
        }
    }

}
