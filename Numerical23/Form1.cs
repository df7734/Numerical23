using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;


namespace Numerical23
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  
            double[] X2 = new double[2];
            double[] C2 = new double[2];
            X2 = PolynomLezhandr(2);
            C2 = Weight(2);

            double[] X3 = new double[3];
            double[] C3 = new double[3];
            X3 = PolynomLezhandr(3);
            C3 = Weight(3);

            double[] X4 = new double[4];
            double[] C4 = new double[4];
            X4 = PolynomLezhandr(4);
            C4 = Weight(4);

            double[] X5 = new double[5];
            double[] C5 = new double[5];
            X5 = PolynomLezhandr(5);
            C5 = Weight(5);

            Function f = new Function("f", "x*sin(x)", "x");
            Expression e = new Expression("int(f(x), x, -1, 1)", f);
            
            double L2 = myFunction(X2[0]) * C2[0] + myFunction(X2[1]) * C2[1];
            double L3 = myFunction(X3[0]) * C3[0] + myFunction(X3[1]) * C3[1] + myFunction(X3[2]) * C3[2];
            double L4 = myFunction(X4[0]) * C4[0] + myFunction(X4[1]) * C4[1] + myFunction(X4[2]) * C4[2] + myFunction(X4[3]) * C4[3];

            double L5 = myFunction(X5[0]) * C5[0] + myFunction(X5[1]) * C5[1] + myFunction(X5[2]) * C5[2] + myFunction(X5[3]) * C5[3]
                                                                                                          + myFunction(X5[4]) * C5[4];
            richTextBox1.Text += "Function: x * sin(x)";
            richTextBox1.Text += Environment.NewLine;

            richTextBox1.Text += "Integral   : " + e.calculate();
            richTextBox1.Text += Environment.NewLine;
            richTextBox1.Text += "Gauss L2: " + L2;
            richTextBox1.Text += Environment.NewLine;
            richTextBox1.Text += "Gauss L3: " + L2;
            richTextBox1.Text += Environment.NewLine;
            richTextBox1.Text += "Gauss L4: " + L4;
            richTextBox1.Text += Environment.NewLine;
            richTextBox1.Text += "Gauss L5: " + L5;

        }

        public double myFunction(double x)
        {
            return x * Math.Sin(x);
        }
        public double[] PolynomLezhandr(int n)
        {
            if(n == 2)
            {
                double[] array = new double[2];
                array[0] = - 1 / Math.Sqrt(3);
                array[1] =   1 / Math.Sqrt(3);
                return array; 
            }
            if (n == 3)
            {
                double[] array = new double[3];
                array[0] = - Math.Sqrt(3/5);
                array[1] =   0;
                array[2] =   Math.Sqrt(3/5);
                return array;
            }
            if (n == 4)
            {
                double[] array = new double[4];
                array[0] = -0.8611363;
                array[1] = -0.3399810;
                array[2] =  0.3399810;
                array[3] =  0.8611363;
                return array;
            }
            if (n == 5)
            {
                double[] array = new double[5];
                array[0] = -0.9061798;
                array[1] = -0.5384693;
                array[2] =  0;
                array[3] =  0.5384693;
                array[4] =  0.9061798;
                return array;
            }
            double[] def = new double[1];
            def[0] = 0;
            return def;
        }

        public double[] Weight(int n)
        {
            // Ci = 2/(1-Xi^2)([P'(Xi)]^2)
            if (n == 2)
            {
                double[] array = new double[2];
                array[0] = 1;
                array[1] = 1;
                return array;
            }
            if (n == 3)
            {
                double[] array = new double[3];
                array[0] = 10/18;
                array[1] = 8/9;
                array[2] = 10/18;
                return array;
            }
            if (n == 4)
            {
                double[] array = new double[4];
                array[0] = 0.3478548;
                array[1] = 0.6521451;
                array[2] = 0.6521451;
                array[3] = 0.3478548;
                return array;
            }
            if (n == 5)
            {
                double[] array = new double[5];
                array[0] = 0.4786287;
                array[1] = 0.2369269;
                array[2] = 0.5688888;
                array[3] = 0.2369269;
                array[4] = 0.4786287;
                return array;
            }
            double[] def = new double[1];
            def[0] = 0;
            return def;
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
