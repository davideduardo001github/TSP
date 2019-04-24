using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plot
{
    public partial class Plotting : Form
    {
        public Plotting()
        {
            InitializeComponent();
            chart1.Series.Clear();
            chart1.Series.Add("Pureba");
            for (int i = 0; i < x.Length; i++)
            {
                chart1.Series["Series1"].Points.AddXY(, 2);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(textBox1.Text);
            
            
        }
        public void DataPlot(double[] x,double[] y)
        {
            for (int i = 0; i < x.Length; i++)
            {
                
            }
        }
    }
}
