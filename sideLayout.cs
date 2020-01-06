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
    public partial class sideLayout : Form
    {
        string[] sideMenu = { "콘샐러드", "치즈프라이", "바삭킹 2조각", "볼케이노칠리프라이", "칠리프라이", "바삭킹(까망베르치즈소스)" };
        int[] side;

        public sideLayout(int[] side)
        {
            InitializeComponent();

            this.side = new int[6];
            for (int i = 0; i < 6; i++)
                this.side[i] = side[i];

            side1_btn.Text = sideMenu[0];
            side2_btn.Text = sideMenu[1];
            side3_btn.Text = sideMenu[2];
            side4_btn.Text = sideMenu[3];
            side5_btn.Text = sideMenu[4];
            side6_btn.Text = sideMenu[5];
        }

        private void side1_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(sideMenu[0], side[0]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.side[0] = n;
                }
            }
        }

        private void side2_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(sideMenu[1], side[1]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.side[1] = n;
                }
            }
        }

        private void side3_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(sideMenu[2], side[2]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.side[2] = n;
                }
            }
        }

        private void side4_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(sideMenu[3], side[3]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.side[3] = n;
                }
            }
        }

        private void side5_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(sideMenu[4], side[4]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.side[4] = n;
                }
            }
        }

        private void side6_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(sideMenu[5], side[5]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.side[5] = n;
                }
            }
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            this.returnVal = this.side;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public int[] returnVal { get; set; }
    }
}