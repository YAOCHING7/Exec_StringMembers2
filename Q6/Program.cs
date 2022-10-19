using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入英文Allen:");
            string name = Console.ReadLine();
            string s1 = "Allen";

            bool result = name.Equals(s1);
            Console.WriteLine(result);
        }
    }
}
