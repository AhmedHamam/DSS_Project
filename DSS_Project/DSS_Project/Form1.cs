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
        private GroupBox gr_z_equation;
        private void btn_genrate_Click(object sender, EventArgs e)
        {
            gr_z_equation = new GroupBox();
            gr_z_equation.Text = "Z Equation";
            gr_z_equation.Width = 200;
            gr_z_equation.Height = 200;
            tlp_z.Controls.Add(gr_z_equation);
            gr_z_equation.Text = "X Equation";
            tlp_z.Controls.Add(gr_z_equation);
            //int width = this.Width;
            //int high = this.Height;
            //int x = groupBox2.Location.X;
            //int y = groupBox2.Location.Y;
            //gr_z_equation.Location = new Point(width/2,high/2);
            //this.Controls.Add(gr_z_equation);


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Name == "txt1")
                        MessageBox.Show(c.Text);
                }
            }
        }
    }
}
