using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Librería con opciones estadísticas para vectores de una sola dimensión
//Nota:  Todo es ejecutado en un Console.
namespace bibliotecas
{
    public class Stat
    {
        // Obtención de la media de un vector
        public static double mean(double[] v1)
        {
            double avg = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                avg = avg + v1[i];
            }
            avg = avg / (v1.Length);
            return avg;
        }
        // Obtención de la varianza de un vector
        public static double var(double[] v1)
        {
            try
            {
                if (v1.Length == 1)
                {
                    throw new DivideByZeroException();
                }
                double m = mean(v1);
                double var = 0;
                for (int i = 0; i < v1.Length; i++)
                {
                    var = var + Math.Pow((v1[i] - m), 2);
                }
                var = var / (v1.Length - 1);
                return var;
            }
            catch (Exception)
            {
                double var = 1;
                return var;
            }

        }
        // Obtención de la desviación estandar de un vector
        public static double std(double[] v1)
        {
            double std = Math.Sqrt(var(v1));
            return std;
        }

        // In this section the diferent normal probability density function are defined
        #region
        // Generación de Normal probability desnsity function whit only a vector
        public static double[] normpdf(double[] x)
        {
            double mu = mean(x), sigma = std(x);
            double[] nor = new double[x.Length];
            for (int i = 0; i < nor.Length; i++)
            {
                nor[i] = (1 / (sigma * Math.Sqrt(2 * Math.PI))) * (Math.Pow(Math.E, -(Math.Pow(x[i] - mu, 2) / (2 * sigma * sigma))));
            }
            return nor;
        }
        // NPDF with a vector and mu
        public static double[] normpdf(double[] x, double mu)
        {
            double sigma = std(x);
            double[] nor = new double[x.Length];
            for (int i = 0; i < nor.Length; i++)
            {
                nor[i] = (1 / (sigma * Math.Sqrt(2 * Math.PI))) * (Math.Pow(Math.E, -(Math.Pow(x[i] - mu, 2) / (2 * sigma * sigma))));
            }
            return nor;
        }
        // NPDF with a vector, mu and sigma
        public static double[] normpdf(double[] x, double mu, double sigma)
        {
            double[] nor = new double[x.Length];
            for (int i = 0; i < nor.Length; i++)
            {
                nor[i] = (1 / (sigma * Math.Sqrt(2 * Math.PI))) * (Math.Pow(Math.E, -(Math.Pow(x[i] - mu, 2) / (2 * sigma * sigma))));
            }
            return nor;
        }
        #endregion
        //Numerical Integration Method
        
        
    }
}
