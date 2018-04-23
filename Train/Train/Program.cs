using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            Reiziger reiziger = new Reiziger();
            
                Console.WriteLine(reiziger.VerkrijgBestemming());
                Console.ReadLine();
            
            //Test
        }
    }
}
