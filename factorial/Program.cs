using System;


namespace factorial
{
   class Program
    {
        
        static void Main()
        {
            Console.Write("Please input the number of Factorial terms:");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                int fact = 1;
                for (int j = 1; j <= i; j++)
                {
                    fact *= j;
                }
                Console.WriteLine("{0}! is {1}", i,fact);

            }

            
            Console.ReadLine();
        }
    }
}
