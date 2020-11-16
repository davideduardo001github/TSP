using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecas
{
    public class Compuertas
    {
        public class And : compuertas
        {
            public And(int imput1, int imput2)
            {
                carry = imput1 + imput2;
                if (carry >= 2)
                {
                    output = 1;
                }
                else
                {
                    output = 0;
                };
            }

        }
        public class Or : compuertas
        {
            public Or(int imput1, int imput2)
            {
                carry = imput1 + imput2;
                if (carry >= 1)
                {
                    output = 1;
                }
                else
                {
                    output = 0;
                };
            }
        }
        public class Xor : compuertas
        {
            public Xor(int imput1, int imput2)
            {
                carry = imput1 + imput2;
                if (carry == 1)
                {
                    output = 1;
                }
                else
                {
                    output = 0;
                };
            }
        }
        public class Not : compuertas
        {
            public Not(int imput1)
            {
                if (imput1 == 1)
                {
                    output = 0;
                }
                else
                {
                    output = 1;
                }
            }
        }
        public abstract class compuertas
        {
            #region Propiedades
            public int output { get; set; }
            public int carry { get; set; }

            #endregion

        }
    }
}
