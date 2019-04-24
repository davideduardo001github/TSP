using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bibliotecas;


//Este programa está diseñado para hacer todas las pruebas necesarias
namespace ConsoleApp1
{
    class Prueba
    {
        static void Main()
        {

            Mat.Present();
            // Entradas
            double[][] entrada =
            {
                new double[] { 0, 0 },
                new double[] { 1, 0 },
                new double[] { 0, 1 },
                new double[] { 1, 1 }
            };

            double[] salida =
            {
                0,
                0,
                0,
                1
            };
            // Visualizador
            Mat.view(entrada);

            // Neurona
            Neurona N1 = new Neurona(2, Neurona.TypeofFunction.hardlim);

            N1.GsImput = entrada[0];
            N1.Run();

            double error = salida[0] - N1.GsOutput;
            double[] delta = new double[N1.GsImput.Length];
            N1.GsImput = new double[]
            N1.GsB = .24;
            N1.Gsn = .25;
            for (int i = 0; i < delta.Length; i++)
            {
                delta[i] = N1.Gsn * error * N1.GsImput[i];
            }
            for (int i = 0; i < N1.Gsw.Length; i++)
            {
                N1.Gsw[i] = N1.Gsw[i] * delta[i];
            }





            Console.ReadKey();
        }




       
        #region Funciones Matlab Privadas

        public static double Inte(double[] x,double[] y)
        {
            double vint = 0, h = x[1]-x[0];
            // The Trapz method will be restringed to equal distance separation
            vint = y.Sum() * h;
            return vint;
        }
        #endregion

        ///Esto es un ejemplo que se utilizó para moestrar como podias hacer un enumerador y despues 
        ///especificar el tipo de integral que se va a realizar
        #region Enumeradores
        public enum TypeIntegral
            {
                simpson, trapezoidal
            }
        #endregion
    }
}
