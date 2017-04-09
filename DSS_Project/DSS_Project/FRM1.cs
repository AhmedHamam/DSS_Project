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
        private List<int> Zlist = new List<int>();// to store the Z equation
        private List<List<int>> ConEq = new List<List<int>>();// to store all constrain equation 
        private List<int> Equ = new List<int>();// to store just one equation 
        bool max;
        int numOfvariables;
        public FRM1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel p1;
            TextBox t1;
            P_Constrain.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {

                p1 = new Panel();
                p1.BackColor = Color.Red;
                // p1.Dock = DockStyle.Top;
                p1.SetBounds(0, i * 50, 500, 40);
                for (int j = 0; j < 4; j++)
                {
                    t1 = new TextBox();
                    t1.SetBounds(10 + 60 * j, 5, 40, 30);
                    p1.Controls.Add(t1);
                }
                P_Constrain.Controls.Add(p1);
            }
            MessageBox.Show(P_Constrain.Controls.Count.ToString());
        }

        private void nud_variable_ValueChanged(object sender, EventArgs e)
        {
            numOfvariables = Convert.ToInt16(nud_variable.Value);
            NumericUpDown t1;
            // TextBox t1;
            Panel p1 = new Panel(); ;
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
            l1.SetBounds(0, 30, 40, 20);
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
                l1.Text = "X" + (j).ToString();
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
                l1.Text = "X" + (j).ToString();
                t1 = new NumericUpDown();
                // t1 = new TextBox();
                t1.SetBounds((120 + (60 * j)), 60, 55, 30);
                t1.Name = "NC" + j.ToString();
                t1.Minimum = -100;
                t1.Maximum = 100;
                t1.Value = 0;
                panel2.Controls.Add(t1);
                panel2.Controls.Add(l1);
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

        private void btn_Add_Zequation_Click(object sender, EventArgs e)
        {
            try
            {
                Zlist.Clear();
                string z = "Z  = ";

                if (P_Zequation.Controls.Count > 0)
                {
                    foreach (Control c in P_Zequation.Controls)
                    {
                        if (c is NumericUpDown)
                        {
                            //c.Enabled = false;
                            c.BackColor = Color.Bisque;
                            //z+=c.Text+" X"+count.ToString()+" +";
                            //count++;
                            Zlist.Add(Convert.ToInt16(c.Text));
                        }
                        // z += c.Value.ToString()+" X ";   

                    }
                    for (int i = 0; i < Zlist.Count; i++)
                    {
                        if (Zlist[i] > 0)
                        {
                            if (i > 0)
                                z += "+" + Zlist[i].ToString() + "*X" + i.ToString() + " ";
                            else
                                z += Zlist[i].ToString() + "*X" + i.ToString() + " ";
                        }
                        else if (Zlist[i] < 0)
                        {
                            z += Zlist[i].ToString() + "*X" + i.ToString() + " ";
                        }
                        else
                            z += "       ";
                    }
                    MessageBox.Show(z);
                    Label l = new Label();
                    l.Name = "Z";
                    l.Text = z;
                    l.SetBounds(P_Constrain.Width / 2 - 100, 10, 9 * z.Length, 20);
                    l.BackColor = Color.Yellow;
                    P_Constrain.Controls.Add(l);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }



        private void btn_Add_Constrain_Click(object sender, EventArgs e)
        {
            try
            {
                Equ.Clear();
                string con = "C " + ConEq.Count.ToString() + " = ";

                if (panel2.Controls.Count > 0)
                {
                    foreach (Control c in panel2.Controls)
                    {
                        if (c is NumericUpDown)
                        {
                            //c.Enabled = false;
                            c.BackColor = Color.Bisque;
                            //z+=c.Text+" X"+count.ToString()+" +";
                            //count++;
                            Equ.Add(Convert.ToInt16(c.Text));
                        }
                        // z += c.Value.ToString()+" X ";   

                    }
                    for (int i = 0; i < Equ.Count; i++)
                    {
                        if (Equ[i] > 0)
                        {
                            if (i > 0)
                                con += "+" + Equ[i].ToString() + "*X" + i.ToString() + " ";
                            else
                                con += Equ[i].ToString() + "*X" + i.ToString() + " ";
                        }
                        else if (Equ[i] < 0)
                        {
                            con += Equ[i].ToString() + "*X" + i.ToString() + " ";
                        }
                        else
                            con += "          ";
                    }
                    MessageBox.Show(con);
                    Label l = new Label();
                    l.Name = "C" + ConEq.Count.ToString();
                    l.Text = con;
                    l.SetBounds(P_Constrain.Width / 2 - 100, 50 + 20 * ConEq.Count, 9 * con.Length, 20);
                    l.BackColor = Color.Yellow;
                    P_Constrain.Controls.Add(l);
                    ConEq.Add(Equ);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void rb_Max_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Max.Checked)
            {
                max = true;

            }
            else
            {
                max = false;
            }
        }

        private void clculate()
        {
            for (int i = 0; i < Zlist.Count; i++)
            {
                Zlist[i] = Zlist[i] * -1;
            }
            if (max)
            {

                while (true)
                {
                    bool id = true;
                    for (int i = 0; i < Zlist.Count; i++)
                    {
                        if (Zlist[i] < 0)
                            id = false;
                    }
                    if (id == false)
                    {
                        //comparing z
                        //set pivot colomn
                        int smaller = Zlist[0];
                        int valueCol = 0;//pivot column

                        for (int i = 1; i < Zlist.Count; i++)
                            if (Zlist[i] < 0)
                                if (Zlist[i] < smaller)
                                {
                                    smaller = Zlist[i];
                                    valueCol = i;//pivot column
                                }

                        //set pivot row
                        List<int> calculation = new List<int>();
                        for (int i = 0; i < ConEq.Count; i++)
                        {
                            List<int> temp = new List<int>();
                            temp = ConEq[i];
                            if (temp[valueCol] != 0)
                                calculation.Add(temp[temp.Count - 1] / temp[valueCol]);
                            //////////////////////////////
                            ///////////////////////////////////
                            else
                                calculation.Clear();

                        }
                        int smaller1 = calculation[0];
                        int valueRow = 0;//poivot row
                        for (int i = 1; i < calculation.Count; i++)
                        {
                            if (calculation[i] > 0)
                                if (calculation[i] < smaller1)
                                {
                                    smaller1 = calculation[i];
                                    valueRow = i;//poivot row
                                }
                        }
                        //set pivot nmber
                        int valueNum;//pivot nmber
                        List<int> forPnum = new List<int>();
                        forPnum = ConEq[valueRow];
                        valueNum = forPnum[valueCol];



                        //new etration
                        for (int i = 0; i < forPnum.Count; i++)
                        {
                            forPnum[i] = forPnum[i] / valueNum;
                        }
                        ConEq[valueRow] = forPnum;
                        for (int i = 0; i < ConEq.Count; i++)
                        {
                            List<int> temp = new List<int>();
                            temp = ConEq[i];
                            for (int k = 0; k < temp.Count; k++)
                            {
                                if (temp[k] == forPnum[i])
                                    continue;
                            }
                            for (int j = 0; j < temp.Count; j++)
                            {
                                temp[j] = temp[j] - (forPnum[j] * temp[valueCol]);
                            }
                            ConEq[i] = temp;
                        }
                        //z itration
                        for (int i = 0; i < numOfvariables; i++)
                        {
                            Zlist[i] = Zlist[i] - (forPnum[i] * Zlist[valueCol]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Zlist.Count - 1; i++)
                        {
                            MessageBox.Show(Zlist[i].ToString());

                        }
                        break;
                    }
                }
            }

        }

        private void btn_Clc_Click(object sender, EventArgs e)
        {
            clculate();
        }
    }

}
