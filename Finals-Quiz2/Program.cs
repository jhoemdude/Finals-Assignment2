using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals_Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Princess Joem Perida";
            foreach (char c in s)
            {
                Console.WriteLine(System.Convert.ToInt32(c));
            }
            Console.ReadLine();

        }
    }
}
