Change with torto21

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitcoin
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoin = double.Parse(Console.ReadLine())* 1168;
            double ioana = double.Parse(Console.ReadLine())*0.15*1.76;
            double komisionna = double.Parse(Console.ReadLine()) / 100;
            double bitcointoeu = bitcoin / 1.95;
            double ioanatoeu = ioana / 1.95;
            Console.WriteLine((bitcointoeu+ioanatoeu)-((bitcointoeu+ioanatoeu))*komisionna);
        }
    }
}
