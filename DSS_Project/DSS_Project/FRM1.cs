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
        public FRM1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel p1 ;
            TextBox t1;
            p_Constrain.Controls.Clear();
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
                p_Constrain.Controls.Add(p1);
            }
            MessageBox.Show(p_Constrain.Controls.Count.ToString());
        }

        private void nud_variable_ValueChanged(object sender, EventArgs e)
        {
            TextBox t1;
            Panel p1=new Panel();;
            Label l1;
            panel2.Controls.Clear();
            l1 = new Label();
            l1.Text = "Variable";
            l1.SetBounds(10, 5, 70, 30);
            l1.BackColor = Color.Yellow;
            panel2.Controls.Add(l1);
            l1 = new Label();
            l1.Text = "Factor";
            l1.SetBounds(10, 50, 70, 30);
            l1.BackColor = Color.Yellow;
            panel2.Controls.Add(l1);
            int nvariable = Convert.ToInt16(nud_variable.Value);

                for (int j = 0; j < nvariable; j++)
                {
                    //p1.BackColor = Color.Red;
                    //p1.SetBounds(10 + 60 * j, 5, 40, 30);
                    //t1 = new TextBox();
                    //t1.Name = "t" + j.ToString();
                   // p1.Controls.Add(t1);
                    t1 = new TextBox();
                    l1 = new Label();
                    l1.SetBounds((120 + (60 * j)), 5, 40, 30);
                    l1.Text = "X" + (j + 1).ToString();
                    t1.SetBounds( (120+(60 * j)), 50, 40, 30);
                    
                    panel2.Controls.Add(t1);
                    panel2.Controls.Add(l1);
                  //  panel2.Controls.Add(p1);
                }

            //MessageBox.Show(panel2.Controls.Count.ToString());
        }

     
    }
}