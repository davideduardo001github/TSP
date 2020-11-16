using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bibliotecas;
using C = bibliotecas.Compuertas;

namespace TestCompuertasLogicas
{
    class PruebaCompuertas
    {
        static void Main(string[] args)
        {
            C.And and1 = new C.And(1, 0);
            Console.WriteLine(and1.output);
            C.Or or1 = new C.Or(and1.output,1);
            Console.WriteLine(or1.output);
            C.Not not1 = new C.Not(or1.output);
            Console.WriteLine(not1.output);
            C.Xor xor1 = new C.Xor(1, 1);
            Console.WriteLine(xor1.output);
            Console.ReadKey();
        }
    }
    
}
