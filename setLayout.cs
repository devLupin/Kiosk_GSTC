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
    public partial class setLayout : Form
    {
        string[] setMenu = { "몬스터와퍼세트", "콰트로치즈와퍼세트", "통새우와퍼세트", "트러플통모짜와퍼세트", "통모짜와퍼세트", "불고기치즈와퍼세트" };
        int[] set;
        public setLayout(int []set)
        {
            InitializeComponent();

            this.set = new int[6];
            for (int i = 0; i < 6; i++)
                this.set[i] = set[i];

            set1_btn.Text = setMenu[0];
            set2_btn.Text = setMenu[1];
            set3_btn.Text = setMenu[2];
            set4_btn.Text = setMenu[3];
            set5_btn.Text = setMenu[4];
            set6_btn.Text = setMenu[5];
        }

        private void set1_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(setMenu[0], set[0]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.set[0] = n;
                }
            }
        }

        private void set2_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(setMenu[1], set[1]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.set[1] = n;
                }
            }
        }

        private void set3_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(setMenu[2], set[2]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.set[2] = n;
                }
            }
        }

        private void set4_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(setMenu[3], set[3]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.set[3] = n;
                }
            }
        }

        private void set5_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(setMenu[4], set[4]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.set[4] = n;
                }
            }
        }

        private void set6_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(setMenu[5], set[5]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.set[5] = n;
                }
            }
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            this.returnVal = this.set;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public int[] returnVal { get; set; }
    }
}
