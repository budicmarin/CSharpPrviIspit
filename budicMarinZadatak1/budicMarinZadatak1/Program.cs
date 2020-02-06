using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinZadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int zbroj=0;
            for (int i=0;i<3;i++)
            {
                Console.WriteLine("Upisi broj");
                a = Convert.ToInt32(Console.ReadLine());
                zbroj += a;
            }
            Console.WriteLine("Prosjek brojeva je"+(float)zbroj/(float)3);
            Console.ReadKey();
        }
       
    }
}
