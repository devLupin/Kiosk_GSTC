using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_GSTC
{
    public partial class orderLayout : Form
    {
        public orderLayout(string order_list)
        {
            InitializeComponent();
            order_lbox.Text = order_list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
