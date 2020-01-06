using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Speech;
using Microsoft.Speech.Synthesis;

namespace Kiosk_GSTC
{
    public partial class firstLayout : Form
    {
        private SpeechSynthesizer ts;

        int[] singleMenu = new int[6];
        int[] setMenu = new int[6];
        int[] drinkMenu = new int[6];
        int[] sideMenu = new int[6];

        string[] single = { "트러플머쉬룸와퍼", "더블와퍼", "베이컨치즈와퍼", "콰트로치즈와퍼", "통새우와퍼", "비프칠리 통모짜와퍼" };
        string[] set = { "몬스터와퍼세트", "콰트로치즈와퍼세트", "통새우와퍼세트", "트러플통모짜와퍼세트", "통모짜와퍼세트", "불고기치즈와퍼세트" };
        string[] drink = { "스프라이트(중)", "스프라이트(대)", "코카-콜라 제로(중)", "코카-콜라 제로(대)", "환타오렌지", "미닛메이드" };
        string[] side = { "콘샐러드", "치즈프라이", "바삭킹 4조각", "볼케이노칠리프라이", "바삭킹(칠리소스)", "바삭킹(까망베르치즈소스)" };

        private int[] set_price = { 10500, 9900,
            9900, 9300, 8700, 9300 };

        private int[] single_price = { 8600, 7200,
            7300, 9200, 8600, 8600 };

        private int[] side_price = { 3200, 6000,
            3300, 11800, 11800, 11800};

        private int[] drink_price = { 2200, 2200,
            2400, 2200, 2400, 3000 };

        public firstLayout()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Show();

            richBox_init();

            for(int i=0; i<6; i++)
            {
                singleMenu[i] = 0;
                setMenu[i] = 0;
                drinkMenu[i] = 0;
                sideMenu[i] = 0;
            }
        }

        private void singleOrder_btn_Click(object sender, EventArgs e)
        {
            using (singleLayout single = new singleLayout(this.singleMenu))
            {
                var result = single.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int[] val = single.returnVal;           
                    this.singleMenu = val;

                    orderRefresh();
                }
            }
        }

        private void setOrder_btn_Click(object sender, EventArgs e)
        {
            using (setLayout set = new setLayout(this.setMenu))
            {
                var result = set.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int[] val = set.returnVal;
                    this.setMenu = val;

                    orderRefresh();
                }
            }
        }

        private void drinkOrder_btn_Click(object sender, EventArgs e)
        {
            using (drinkLayout set = new drinkLayout(this.drinkMenu))
            {
                var result = set.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int[] val = set.returnVal;
                    this.drinkMenu = val;

                    orderRefresh();
                }
            }
        }

        private void sideOrder_btn_Click(object sender, EventArgs e)
        {
            using (sideLayout set = new sideLayout(this.sideMenu))
            {
                var result = set.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int[] val = set.returnVal;
                    this.sideMenu = val;

                    orderRefresh();
                }
            }
        }

        private void deleteOrder_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택했던 모든 주문이 지워집니다. 정말 지우시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("장바구니가 비워졌습니다!");
                richBox_init();

                for (int i = 0; i < 6; i++)
                {
                    singleMenu[i] = 0;
                    setMenu[i] = 0;
                    drinkMenu[i] = 0;
                    sideMenu[i] = 0;
                }
            }
            else
            {
                MessageBox.Show("주문내역이 유지됩니다");
            }
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            using (orderLayout order = new orderLayout(name_richBox.Text, num_richBox.Text, price_richBox.Text))
            {
                var result = order.ShowDialog();
                if (result == DialogResult.OK)
                {
                    bool val = order.returnVal;
                    richBox_init();

                    for (int i = 0; i < 6; i++)
                    {
                        singleMenu[i] = 0;
                        setMenu[i] = 0;
                        drinkMenu[i] = 0;
                        sideMenu[i] = 0;
                    }
                }
            }
        }

        private void richBox_init()
        {
            name_richBox.Text = "상품명\n\n";
            num_richBox.Text = "수량(개)\n";
            price_richBox.Text = "단가(원)\n\n";
            total_lbl.Text = "";
        }

        private void orderRefresh()
        {
            richBox_init();

            int total = 0;

            string name = "";
            string num = "";
            string price = "";

            for(int i=0; i<6; i++)
            {
                if(singleMenu[i] > 0)
                {
                    name += single[i] + "\n";
                    num += singleMenu[i].ToString() + "\n";
                    price += (single_price[i] * singleMenu[i]).ToString() + "\n";

                    total += single_price[i] * singleMenu[i];
                }
                if(setMenu[i] > 0)
                {
                    name += set[i] + "\n";
                    num += setMenu[i].ToString() + "\n";
                    price += (set_price[i] * setMenu[i]).ToString() + "\n";

                    total += set_price[i] * setMenu[i];
                }
                if(sideMenu[i] > 0)
                {
                    name += side[i] + "\n";
                    num += sideMenu[i].ToString() + "\n";
                    price += (side_price[i] * sideMenu[i]).ToString() + "\n";

                    total += side_price[i] * sideMenu[i];
                }
                if(drinkMenu[i] > 0)
                {
                    name += drink[i] + "\n";
                    num += drinkMenu[i].ToString() + "\n";
                    price += (drink_price[i] * drinkMenu[i]).ToString() + "\n";

                    total += drink_price[i] * drinkMenu[i];
                }
            }
            name_richBox.Text += name;
            num_richBox.Text += num;
            price_richBox.Text += price;

            total_lbl.Text = "총 금액 : " + total.ToString() + "원";
        }

        private void num_richBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
