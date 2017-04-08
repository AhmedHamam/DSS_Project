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
    public partial class Ahmed : DevExpress.XtraEditors.XtraForm
    {
        public Ahmed()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            try
            {
                int txtno = int.Parse(txt1.Text);
                int pointX = 30;
                int pointY = 40;
                panel2.Controls.Clear();
                for (int i = 0; i < txtno; i++)
                {
                    TextBox a = new TextBox();
                   // a.Text = (i + 1).ToString();
                    a.Location = new Point(pointX, pointY);
                    panel2.Controls.Add(a);
                    panel2.Show();
                    pointX += 110;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}