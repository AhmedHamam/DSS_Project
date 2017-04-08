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
    public partial class main : DevExpress.XtraEditors.XtraForm
    {

        private List<int> Zlist = new List<int>();
        private List<int> Equationlist = new List<int>();
        private List<List<int>> Conlist = new List<List<int>>();
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zlist.Add(Convert.ToInt16(txt_z1.Text));
            Zlist.Add(Convert.ToInt16(txt_z2.Text));
            Zlist.Add(Convert.ToInt16(txt_z3.Text));
            Zlist.Add(Convert.ToInt16(txt_z4.Text));

        }
        
    }
}
