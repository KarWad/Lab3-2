using System;
using System.Collections.Generic;

namespace Lab3_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Dictionary<string, string> dick = new Dictionary<string, string>();
            dick.Add("001", "David");
            dick.Add("002", "Karolina");
            dick.Add("003", "Goncalo");
            System.Console.WriteLine("One of my best friend is: {0}", dick["001"] + ".");
        }
    }
}
