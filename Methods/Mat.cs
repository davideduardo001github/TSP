using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Methods
{
       /// <summary>
       /// Librería con métodos útiles, 
       /// nota algunos trabajan con Console
       /// </summary>
    public class Mat
    {
        // Presentación para un programa Console
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
        // Generación de un vector de un tamaño específico
        public static double[] linspace(double d1, double d2, int ndatos)
        {
            double[] line = new double[ndatos];
            try
            {
                if (ndatos == 1)
                {
                    throw new Exception();
                }

                for (int i = 0; i < ndatos; i++)
                {
                    line[i] = d1 + ((d2 - d1) / (ndatos - 1)) * i;
                }
                return line;
            }
            catch (Exception)
            {
                line[0] = d2;
                return line;
            }
        }
        // Visualisación de un arreglo de arreglos
        public static void view(double[][] line)
        {
            for (int j = 0; j < line.GetLength(1); j++)
            {
                for (int i = 0; i < line.GetLength(1); i++)
                {
                    Console.Write("({0},{1}): " + line[j][i] + "     ", i + 1, j + 1);
                    Console.WriteLine("\t");
                }
                Console.WriteLine("\n");
            }
        }
        // Visualización de un vector de nxn dimensiones (queda pendiente por probar)
        public static void view(double[,] line)
        {
            for (int j = 0; j < line.GetLength(1); j++)
            {
                for (int i = 0; i < line.GetLength(1); i++)
                {
                    Console.Write("({0},{1}): " + line[j,i] + "     ", i + 1, j + 1);
                    Console.WriteLine("\t");
                }
                Console.WriteLine("\n");
            }
        }
        // Visualización de un vector de 1xn dimensiones
        public static void view(double[] line)
        {
            for (int i = 0; i < line.GetLength(1); i++)
            {
                Console.Write("({0},{1}): " + line[i] + "     ", i + 1);
            }
            Console.WriteLine("\n");
        }
        // Visualización de un vector de 1xn dimensiones Y EL NOMBRE    
        public static void view(double[] line, string name)
        {
            Console.WriteLine("Vector {0} = \n", name);
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write("{0}: " + line[i] + "     ", i + 1);
            }
            Console.WriteLine("\n");
        }
        // Visualizacion de un valor con la entrada de su nombre
        public static void view(double x,string name)
        {
            Console.WriteLine(name + "= {0}", x);
        }
        // Case without the name
        public static void view(double x)
        {
            Console.WriteLine("Result= {0}", x);
        }
        // Compute PI
        public static double coputePI(double pre)
        {
            double Pi = 0, e = 0, a = 0;
            int i = 2, d = 1;
            
            do
            {
                a = Math.Pow(-1, i)*4/d;
                Pi = Pi + a;
                d = d + 2;
                i = i + 1;
                e = Math.Abs(Pi - Math.PI);
                Console.WriteLine("Pi= "+ Pi + " Error= " + e + " Iteración = " + (i-1));
            } while (e > pre);
            return Pi;
        }

        /// <summary>
        /// Fución para generar números aleatorios y arreglos aleatoreos
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        // Genera un vector aleatoreo
        public static double[] randn(double[] input)
        {

            Random random = new Random();
            double[] output = new double[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                output[0] = random.NextDouble();
            }
            return output;
        }
        // Genera un valor aleatoreo
        public static double randn()
        {
            Random random = new Random();
            double output = random.NextDouble();
            return output;
        }
        public static int hardlim(double input)
        {
            return input >= 0 ? 1 : 0;
        }

    }
}
