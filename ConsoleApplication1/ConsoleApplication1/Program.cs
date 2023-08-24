using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TenToaDo.ToString());
            ToaDo td = new ToaDo();
            Console.WriteLine(td.ToString());
            Console.WriteLine(td.ToString());
            Console.ReadLine();

        }
    }
}


