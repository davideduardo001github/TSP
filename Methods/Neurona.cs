using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecas
{
    public class Neurona
    {
        #region Variables globales
        double[] P, W;
        double output,B, n, epw;
        #endregion


        #region Constructor
        public Neurona(int input, TypeofFunction Fx)
        {
            this.P = new double[input];
            this.W = new double[input];
            this.W = Mat.randn(W);
            this.B = Mat.randn();

        }
        #endregion

        #region Accesos

        public double[] GsImput
        {
            get { return P; }
            set {
                if (value.Length == P.Length)
                P = value;
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public double GsOutput
        {
            get
            {
                //Funcion(epw);  // Es una forma de correr la función cada que quieras el valor
                return output;
            }
        }

        /// <summary>
        /// Coeficiente de aprendizaje
        /// </summary>
        public double Gsn
        {
            get { return n; }
            set { n = value; }
        }

        public double[] Gsw
        {
            get { return this.W; }
            set { this.W = value; }
        }
        public double GsB
        {
            get { return this.B; }
            set { this.B = value; }
        }
        /// <summary>
        /// Devuelve el valor de la sumatoria antes de procesarse en la función menos theta
        /// </summary>
        public double GEpw
        {
            get { return this.epw; }
        }
        #endregion

        #region Metodos privados

        private void funcion (double input)
        {
            //NO encuentra a epw
            //this.ewp = W * P - B;
            this.epw = input;
            this.output = Mat.hardlim(this.epw);
        }

        #endregion

        #region Enumeradores
        public enum TypeofFunction
        {
            hardlim
        }
        #endregion

        #region Public Methods
        
        public void Run()
        {
            //Hay que revisar que pasa con esto por que dice que no existe
            //funcion(epw);
        }

        private double mtimes (double[] input1, double[] input2)
        {
            if (input1.Length == input2.Length)
            {
                double output = 0;
                for (int i = 0; i < input1.Length; i++)
                {
                    output = output + input1[i] * input2[i];
                }
                return output;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }
        #endregion

    }


}

