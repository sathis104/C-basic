using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Reversestr
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Please input the string :");
            string n = Console.ReadLine();
            string Reversestr = "";
            for(int i=0;i<n.Length;i++)
            {
                Reversestr =   n[i]+ Reversestr;
            }
            Console.Write(Reversestr);
            Console.ReadLine();
        }
    }
}
