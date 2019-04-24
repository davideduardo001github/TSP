using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionHomework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Present();
            /////////////////////// Condiciones iniciales
            double
                q1 = 54e12,
                q2 = 5e-6,
                D1 = 50;
                
            double[] R1 = Distance(q1, q2, D1);
            Console.WriteLine("Resultados analíticos");
            Console.WriteLine(R1[0]);
            Console.WriteLine(R1[1]);
            Console.WriteLine("Computando por aproximación");
            double[] R2 = TryBrute(q1, q2, D1, R1[0]);
            Console.WriteLine("Resultados obtenidos");
            Console.WriteLine(R2[0]);
            Console.WriteLine(R2[1]);
            Console.ReadKey();

            ///////////////////////////

            ////////////Impresión de resultados

            ////// Por fuerza bruta

            //Condiciones iniciales

        }

        //Definición de métodos locales (Una librería local para calular la distancia entre cargas)

        public static double[] Distance(double q1, double q2, double D1)
        {
            double[] dst = new double[2];
            dst[0] = (Math.Sqrt(q1) * D1) / (Math.Sqrt(q1) + Math.Sqrt(q2));
            dst[1] = D1 - dst[0];
            return dst;
        }
        public static double[] TryBrute(double q1, double q2, double D1, double Goal)
        {
            double[] R2 = { 0, 0, D1 };
            double err = 10;
            do
            {
                R2 = Brute(q1, q2, R2[0], R2[2], D1);
                Console.WriteLine(R2[0]);
                Console.WriteLine(R2[1]);
                err = Math.Abs(Goal - R2[0]);
            } while (err > 1e-12);
            Console.WriteLine("Presición alcanzada");
            return R2;
        }
        public static double[] Brute(double q1, double q2, double d1, double d2, double D1)
        {
            double a1, b1, e,
            I = Math.Abs(d2 - d1);
            do
            {
                d1 = d1 + I * .01;
                d2 = D1 - d1;
                a1 = (q1 * d2 * d2);
                b1 = (q2 * d1 * d1);
                e = (a1 - b1);
                
            } while (e > 0);
            double[] dst = new double[3];
            dst[0] = d1 - I * .01;
            dst[1] = D1 - dst[0];
            dst[2] = d1;
            return dst;
        }
        public static void Present()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("* Temas selectos de programación *");
            Console.WriteLine("*   Flores Rojas Eduardo David   *");
            Console.WriteLine("*            Grupo 7             *");
            Console.WriteLine("**********************************");
        }
        
    }
}
