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

        private void btn_genrate_Click(object sender, EventArgs e)
        {
            gb_Z_Equation.Controls.Clear();
            int num_variable;
            num_variable = Convert.ToInt16(nud_variable.Value);
            TextBox txt;
            Label lb;
            for (int i = 0; i < num_variable; i++)
            {
                txt = new TextBox();
                lb=new Label();
                lb.Text = "X" + i.ToString();
                gb_Z_Equation.Controls.Add(txt);
                gb_Z_Equation.Controls.Add(lb);

            }

        }
    }
}
