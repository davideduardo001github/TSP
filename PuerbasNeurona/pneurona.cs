using bibliotecas;
using System;
using System.Linq;

namespace PuerbasNeurona
{
    class pneurona
    {
        static void Main(string[] args)
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
        
    }
}
