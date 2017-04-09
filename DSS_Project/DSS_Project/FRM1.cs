using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DSS_Project
{
    public partial class FRM1 : DevExpress.XtraEditors.XtraForm
    {
        private List<double> Zlist = new List<double>();// to store the Z equation
        private List<List<double>> ConEq = new List<List<double>>();// to store all constrain equation 
        private List<double> Equ = new List<double>();// to store just one equation 
        public FRM1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel p1 ;
            TextBox t1;
            P_Constrain.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {

                p1= new Panel();
                p1.BackColor = Color.Red;
               // p1.Dock = DockStyle.Top;
                p1.SetBounds(0,i*50,500,40);
                for (int j = 0; j < 4; j++)
                {
                    t1 = new TextBox();
                    t1.SetBounds(10+60*j,5,40,30);
                    p1.Controls.Add(t1);
                }
                P_Constrain.Controls.Add(p1);
            }
            MessageBox.Show(P_Constrain.Controls.Count.ToString());
        }

        private void nud_variable_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown t1;
           // TextBox t1;
            Panel p1=new Panel();;
            Label l1;
            panel2.Controls.Clear();
            P_Zequation.Controls.Clear();
            //=====================================
            l1 = new Label();
            l1.Text = "Z = ";
            l1.SetBounds(0, 30, 40, 20);
            l1.BackColor = Color.Yellow;
            P_Zequation.Controls.Add(l1);
            //--------------------------------
            l1 = new Label();
            l1.Text = "Variable";
            l1.SetBounds(20, 5, 60, 20);
            l1.BackColor = Color.Yellow;
            P_Zequation.Controls.Add(l1);
            //-------------------------------
            l1 = new Label();
            l1.Text = "Factor";
            l1.SetBounds(20, 60, 60, 20);
            l1.BackColor = Color.Yellow;
            P_Zequation.Controls.Add(l1);

            //=====================================
            l1 = new Label();
            l1.Text = "C = ";
            l1.SetBounds(0, 30 , 40, 20);
            l1.BackColor = Color.Yellow;
            panel2.Controls.Add(l1);
           //-------------------------------------
            l1 = new Label();
            l1.Text = "Variable";
            l1.SetBounds(15, 5, 70, 20);
            l1.BackColor = Color.Yellow;
            panel2.Controls.Add(l1);
            //-------------------------------
            l1 = new Label();
            l1.Text = "Factor";
            l1.SetBounds(15, 60, 70, 20);
            l1.BackColor = Color.Yellow;
            panel2.Controls.Add(l1);
            //=====================================================
            int nvariable = Convert.ToInt16(nud_variable.Value);
         
                for (int j = 0; j < nvariable; j++)
                {
                    //p1.BackColor = Color.Red;
                    //p1.SetBounds(10 + 60 * j, 5, 40, 30);
                    //t1 = new TextBox();
                   // p1.Controls.Add(t1);
                    //==========================================================

                    l1 = new Label();
                    l1.SetBounds((130 + (60 * j)), 5, 50, 30);
                    l1.Text = "X" + (j + 1).ToString();
                    t1 = new NumericUpDown();
                    // t1 = new TextBox();
                    t1.SetBounds((120 + (60 * j)), 50, 55, 30);
                    t1.Name = "NZ" + j.ToString();
                    t1.Minimum = -100;
                    t1.Maximum = 100;
                    t1.Value = 0;

                    P_Zequation.Controls.Add(t1);
                    P_Zequation.Controls.Add(l1);
                    //==========================================================
                    l1 = new Label();
                    l1.SetBounds((130 + (60 * j)), 5, 50, 30);
                    l1.Text = "X" + (j + 1).ToString();
                    t1 = new NumericUpDown();
                   // t1 = new TextBox();
                    t1.SetBounds((120 + (60 * j)), 60, 55, 30);
                    t1.Name = "NC" + j.ToString();
                    t1.Minimum = -100;
                    t1.Maximum = 100;
                    t1.Value = 0;
                   // t1.KeyPress+=textBox1_KeyPress(object sender1, KeyPressEventArgs e1);
                    panel2.Controls.Add(t1);
                    panel2.Controls.Add(l1);
                  //  panel2.Controls.Add(p1);
                }

            //MessageBox.Show(panel2.Controls.Count.ToString());
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
    }
}