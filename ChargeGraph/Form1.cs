using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChargeGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void chart1_Click(object sender, EventArgs e)
        {

        }
        public static void AddData(double x, double y)
        {
            // NO podemos declarar esto aquí por que no se encuentra la gráfica
            //GraphP1.Series["Points"].Points.AddXY(x,y);
        }
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
    }
}
