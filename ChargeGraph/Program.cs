using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChargeGraph
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            double
                q1 = 54e12,
                q2 = 5e-6,
                D1 = 50;
            double[] R1 = Form1.Distance(q1, q2, D1);
            double[] R2 = Form1.TryBrute(q1, q2, D1, R1[0]);
        }
       
    }
        
    }
