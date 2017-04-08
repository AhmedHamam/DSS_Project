using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSS_Project
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = "";
                double[] s1 = new double[7];
                double[] s2 = new double[7];
                double[] s3 = new double[7];
                double[] z = new double[7];
                string[] names = new string[4]{"s1","s2","s3","z"};
                
                //fill in first array s1 values
                s1[0] = double.Parse(textBox1.Text);
                s1[1] = double.Parse(textBox2.Text);
                s1[2] = double.Parse(textBox3.Text);
                s1[3] = 1.0;
                s1[4] = 0.0;
                s1[5] = 0.0;
                s1[6] = double.Parse(textBox4.Text);
                //fill in s2 values
                s2[0] = double.Parse(textBox5.Text);
                s2[1] = double.Parse(textBox6.Text);
                s2[2] = double.Parse(textBox7.Text);
                s2[3] = 0.0;
                s2[4] = 1.0;
                s2[5] = 0.0;
                s2[6] = double.Parse(textBox8.Text);
                //fill in s3 values
                s3[0] = double.Parse(textBox9.Text);
                s3[1] = double.Parse(textBox10.Text);
                s3[2] = double.Parse(textBox11.Text);
                s3[3] = 0.0;
                s3[4] = 0.0;
                s3[5] = 1.0;
                s3[6] = double.Parse(textBox12.Text);
                //fill in z values after multipling by -1

                z[0] = -1.0 * (double.Parse(textBox13.Text));
                z[1] = -1.0 * (double.Parse(textBox14.Text));
                z[2] = -1.0 * (double.Parse(textBox15.Text));
                z[3] = 0.0;
                z[4] = 0.0;
                z[5] = 0.0;
                z[6] = 0.0;
                //finished entering initial data
                
                int iterations = 1;
                richTextBox1.Text = "Iteration " + iterations + "\n\n";
                richTextBox1.Text += print(names, s1, s2, s3, z);
                double min = 0.0;
                int offset = 0;
                int num = 0;
                while (check(z) == false)
                {
                    min = minimum(z);
                    iterations++;
                    for (int i = 0; i < z.Length; i++)
                    {
                        if (z[i] == min)
                        {
                            offset = i;
                            break;
                        }
                    }
                    num = divides(s1[6], s2[6], s3[6], s1[offset], s2[offset], s3[offset]);

                    if (num == 1)
                    {
                        double divnum = s1[offset];
                        double[] ns2 = new double[7];
                        double[] ns3 = new double[7];
                        double[] nz = new double[7];
                        if (offset == 0)
                            names[0] = "A";
                        if (offset == 1)
                            names[0] = "B";
                        if (offset == 2)
                            names[0] = "C";
                        if (offset == 3)
                            names[0] = "s1";
                        if (offset == 4)
                            names[0] = "s2";
                        if (offset == 5)
                            names[0] = "s3";
                        for (int o = 0; o < s1.Length; o++)
                        {
                            s1[o] /= divnum;
                        }
                        for (int o = 0; o < s1.Length; o++)
                        {
                            ns2[o] = s2[o] - (s2[offset] * s1[o]);
                            ns3[o] = s3[o] - (s3[offset] * s1[o]);
                            nz[o] = z[o] - (z[offset] * s1[o]);
                        }
                        for (int o = 0; o < 7; o++)
                        {
                            s2[o] = ns2[o];
                            s3[o] = ns3[o];
                            z[o] = nz[o];
                        }
                    }
                    if (num == 2)
                    {
                        double divnum = s2[offset];
                        double[] ns1 = new double[7];
                        double[] ns3 = new double[7];
                        double[] nz = new double[7];
                        if (offset == 0)
                            names[1] = "A";
                        if (offset == 1)
                            names[1] = "B";
                        if (offset == 2)
                            names[1] = "C";
                        if (offset == 3)
                            names[1] = "s1";
                        if (offset == 4)
                            names[1] = "s2";
                        if (offset == 5)
                            names[1] = "s3";

                        for (int o = 0; o < s2.Length; o++)
                        {
                            s2[o] /= divnum;
                        }
                        for (int o = 0; o < s2.Length; o++)
                        {
                            ns1[o] = s1[o] - (s1[offset] * s2[o]);
                            ns3[o] = s3[o] - (s3[offset] * s2[o]);
                            nz[o] = z[o] - (z[offset] * s2[o]);
                        }
                        for (int o = 0; o < 7; o++)
                        {
                            s1[o] = ns1[o];
                            s3[o] = ns3[o];
                            z[o] = nz[o];
                        }
                    }
                    if (num == 3)
                    {
                        double divnum = s3[offset];
                        double[] ns1 = new double[7];
                        double[] ns2 = new double[7];
                        double[] nz = new double[7];
                        if (offset == 0)
                            names[2] = "A";
                        if (offset == 1)
                            names[2] = "B";
                        if (offset == 2)
                            names[2] = "C";
                        if (offset == 3)
                            names[2] = "s1";
                        if (offset == 4)
                            names[2] = "s2";
                        if (offset == 5)
                            names[2] = "s3";
                        for (int o = 0; o < s3.Length; o++)
                        {
                            s3[o] /= divnum;
                        }
                        for (int o = 0; o < s3.Length; o++)
                        {
                            ns1[o] = s1[o] - (s1[offset] * s3[o]);
                            ns2[o] = s2[o] - (s2[offset] * s3[o]);
                            nz[o] = z[o] - (z[offset] * s3[o]);
                        }
                        for (int o = 0; o < 7; o++)
                        {
                            s1[o] = ns1[o];
                            s2[o] = ns2[o];
                            z[o] = nz[o];
                        }
                    }
                    richTextBox1.Text += "\n\n";
                    richTextBox1.Text += "Iteration " + iterations + "\n\n";
                    richTextBox1.Text += print(names, s1, s2, s3, z);
                }
                if (names[0] == "A")
                {
                    textBox16.Text = String.Format("{0:0.##}", s1[6]);
                }
                if (names[0] == "B")
                {
                    textBox17.Text = String.Format("{0:0.##}", s1[6]);
                }
                if (names[0] == "C")
                {
                    textBox19.Text = String.Format("{0:0.##}", s1[6]);
                }
                if (names[1] == "A")
                {
                    textBox16.Text = String.Format("{0:0.##}", s2[6]);
                }
                if (names[1] == "B")
                {
                    textBox17.Text = String.Format("{0:0.##}", s2[6]);
                }
                if (names[1] == "C")
                {
                    textBox19.Text = String.Format("{0:0.##}", s2[6]);
                }

                if (names[2] == "A")
                {
                    textBox16.Text = String.Format("{0:0.##}", s3[6]);
                }
                if (names[2] == "B")
                {
                    textBox17.Text = String.Format("{0:0.##}", s3[6]);
                }
                if (names[2] == "C")
                {
                    textBox19.Text = String.Format("{0:0.##}", s3[6]);
                }
                if (names.Contains("A") == false)
                    textBox16.Text = "0.0";
                if (names.Contains("B") == false)
                    textBox17.Text = "0.0";
                if (names.Contains("C") == false)
                    textBox19.Text = "0.0";
                textBox18.Text = String.Format("{0:0.##}", z[6]);
            }
            catch
            {
                MessageBox.Show("Please fill in all values correctly");
            }
        }
        public static string print(string[]name,double[]ps1,double[]ps2,double[]ps3,double[]pz)
        {
            string output = "";
            for (int j = 0; j < 4; j++)
            {
                if (j == 0)
                {
                    output += "B V";
                    output += "            ";
                    output += "       A      ";
                    output += "       B      ";
                    output += "       C      ";
                    output += "       s1      ";
                    output += "       s2      ";
                    output += "       s3      ";
                    output += "      RHS      ";
                    output += "\n\n";
                }
                output += name[j];
                for (int i = 0; i < 7; i++)
                {
                    if (j == 0)
                    {
                        if (i == 0)
                        {
                            output += "                    " + String.Format("{0:0.##}", ps1[i]) + "   ";
                        }
                        else
                            output += "            " + String.Format("{0:0.##}", ps1[i]) + "   ";
                    }
                    if (j == 1)
                    {
                        if (i == 0)
                        {
                            output += "                    " + String.Format("{0:0.##}", ps2[i]) + "   ";
                        }
                        else
                            output += "            " + String.Format("{0:0.##}", ps2[i]) + "   ";
                    }
                    if (j == 2)
                    {
                        if (i == 0)
                        {
                            output += "                    " + String.Format("{0:0.##}", ps3[i]) + "   ";
                        }
                        else
                            output += "            " + String.Format("{0:0.##}", ps3[i]) + "   ";
                    }
                    if (j == 3)
                    {
                        if (i == 0)
                        {
                            output += "                    " + String.Format("{0:0.##}", pz[i]) + "   ";
                        }
                        else
                            output += "            " + String.Format("{0:0.##}", pz[i]) + "   ";
                    }
                    if (i == 6)
                    {
                        output += "\n\n";
                    }
                }
            }
            return output;
        }
        //the function check sees if z has any numbers less than 0 (negative numbers)
        public static bool check(double[]z)
        {
            for (int i = 0; i < z.Length; i++)
            {
                if (z[i] < 0)
                    return false;
            }
            return true;
        }
        //minimum function returns the smallest negative number in z
        public static double minimum(double[] z)
        {
            double mymin=0;
            for (int i = 0; i < z.Length; i++)
            {
                if (z[i] < 0 && z[i] < mymin)
                    mymin = z[i];
            }
            return mymin;
        }
        //divides function is used to find min positive number
        public static int divides(double r1, double r2, double r3, double x, double y, double z)
        {
            int num = 0;
            double d=0;
            if (x == 0)
            {
                d = 0;
            }
            else
            {
                if ((r1 / x) > 0)
                {
                    d = r1 / x;
                    num = 1;
                }
                else
                    d = 0;
            }
            if (y == 0)
            {
            }
            else
            {
                if ((d == 0)&&((r2/y)>0))
                {
                    d = r2 / y;
                    num = 2;
                }
                else
                {
                    if (((r2 / y) > 0) && ((r2 / y) < d))
                    {
                        d = r2 / y;
                        num = 2;
                    }
                }
            }
            if (z == 0)
            {
            }
            else
            {
                if ((d == 0)&&((r3/z)>0))
                {
                    d = r3 / z;
                    num = 3;
                }
                else
                {
                    if (((r3 / z) > 0) && ((r3 / z) < d))
                    {
                        d = r3 / z;
                        num = 3;
                    }
                }
            }
            return num;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox2.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox2.Clear();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox3.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox3.Clear();
                }
            }
        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox4.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox4.Clear();
                }
            }
        }
        
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox13.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox13.Clear();
                }
            }
        }
        
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox5.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox5.Clear();
                }
            }
        }
        
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox6.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox6.Clear();
                }
            }
        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox7.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox7.Clear();
                }
            }
        }
        
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox12.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox12.Clear();
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox8.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox8.Clear();
                }
            }
        }
        
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox9.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox9.Clear();
                }
            }
        }
        
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox10.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox10.Clear();
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox11.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox11.Clear();
                }
            }
        }
        
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox14.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox14.Clear();
                }
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox15.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox15.Clear();
                }
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            foreach (char c in textBox1.Text)
            {
                if (char.IsDigit(c) || (c == '.' && count < 1) || (c == '-' && count1 < 1))
                {
                    if (c == '.')
                        count++;
                    if (c == '-')
                        count1++;
                }
                else
                {
                    textBox1.Clear();
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
