using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TDDAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KataCalculator obj = new KataCalculator();
            obj.add("3,4");
            WriteLine(obj.add("3,4"));
        }
    }
}
