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
    public partial class drinkLayout : Form
    {
        string[] drinkMenu = { "스프라이트(중)", "스프라이트(대)", "코카-콜라 제로(중)", "코카-콜라 제로(대)", "환타오렌지", "미닛메이드" };
        int[] drink;

        public drinkLayout(int[] drink)
        {
            InitializeComponent();

            this.drink = new int[6];
            for (int i = 0; i < 6; i++)
                this.drink[i] = drink[i];

            drink1_btn.Text = drinkMenu[0];
            drink2_btn.Text = drinkMenu[1];
            drink3_btn.Text = drinkMenu[2];
            drink4_btn.Text = drinkMenu[3];
            drink5_btn.Text = drinkMenu[4];
            drink6_btn.Text = drinkMenu[5];
        }

        private void drink1_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(drinkMenu[0], drink[0]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.drink[0] = n;
                }
            }
        }

        private void drink2_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(drinkMenu[1], drink[1]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.drink[1] = n;
                }
            }
        }

        private void drink3_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(drinkMenu[2], drink[2]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.drink[2] = n;
                }
            }
        }

        private void drink4_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(drinkMenu[3], drink[3]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.drink[3] = n;
                }
            }
        }

        private void drink5_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(drinkMenu[4], drink[4]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.drink[4] = n;
                }
            }
        }

        private void drink6_btn_Click(object sender, EventArgs e)
        {
            using (numOfMenu menu = new numOfMenu(drinkMenu[5], drink[5]))
            {
                var result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int n = menu.returnVal;

                    this.drink[5] = n;
                }
            }
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            this.returnVal = this.drink;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public int[] returnVal { get; set; }
    }
}
