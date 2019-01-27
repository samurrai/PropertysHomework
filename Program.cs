using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertysHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversalArray array = new UniversalArray(4);
            array[3] = 4;
            Console.WriteLine(array[3]);
            Console.ReadLine();
        }
    }
}
