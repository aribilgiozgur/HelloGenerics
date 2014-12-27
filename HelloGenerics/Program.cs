using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Silah<NormalSarjor> silah = new Silah<NormalSarjor>(new NormalSarjor());
            Console.WriteLine(silah.getSarjor().getText());
            Console.ReadLine();
            
        }
    }
}
