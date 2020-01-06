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
    public partial class singleLayout : Form
    {
        string []singleMenu = {"트러플머쉬룸와퍼", "더블와퍼", "베이컨치즈와퍼", "콰트로치즈와퍼", "통새우와퍼", "비프칠리 통모짜와퍼"};
        int[] single;

        public singleLayout(int []single)
        {
            InitializeComponent();

            this.single = new int[6];
            for (int i = 0; i < 6; i++)
                this.single[i] = single[i];

            single1_btn.Text = singleMenu[0];
            single2_btn.Text = singleMenu[1];
            single3_btn.Text = singleMenu[2];
            single4_btn.Text = singleMenu[3];
            single5_btn.Text = singleMenu[4];
            single6_btn.Text = singleMenu[5];
        }

        private void single1_btn_Click(object sender, EventArgs e)
        {
            using(numOfMenu menu = new numOfMenu(singleMenu[0], single[0]))
            {
                var result = menu.ShowDialog();
                if(result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.single[0] = n;
                }
            }
        }

        private void single2_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(singleMenu[1], single[1]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.single[1] = n;
                }
            }
        }

        private void single3_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(singleMenu[2], single[2]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.single[2] = n;
                }
            }
        }

        private void single4_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(singleMenu[3], single[3]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.single[3] = n;
                }
            }
        }

        private void single5_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(singleMenu[4], single[4]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.single[4] = n;
                }
            }
        }

        private void single6_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(singleMenu[5], single[5]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.single[5] = n;
                }
            }
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            this.returnVal = this.single;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public int[] returnVal { get; set; }
    }
}
