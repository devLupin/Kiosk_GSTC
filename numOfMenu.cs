using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiosk_GSTC
{
    public partial class numOfMenu : Form
    {
        int n;
        public numOfMenu(string name, int n)
        {
            InitializeComponent();
            select_lbl.Text = name + "  수량";

            this.n = n;
            num.Text = n.ToString();
            num.Refresh();
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            if (n > 0)
            {
                n--;
                num.Text = n.ToString();
                num.Refresh();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            n++;
            num.Text = n.ToString();
            num.Refresh();
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            this.returnVal = this.n;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public int returnVal { get; set; }
    }
}
