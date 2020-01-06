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
    public partial class startLayout : Form
    {

        /*// 회전형 경로
        private string setMenu_path = @"C:\Users\회전형키오스크2\Desktop\새 폴더\새 폴더\setMenu_pictures\";
        private string singleMenu_path = @"C:\Users\회전형키오스크2\Desktop\새 폴더\새 폴더\singleMenu_pictures\";
        private string drink_path = @"C:\Users\회전형키오스크2\Desktop\새 폴더\새 폴더\drink_pictures\";
        private string sideMenu_path = @"C:\Users\회전형키오스크2\Desktop\새 폴더\새 폴더\sideMenu_pictures\";
        private string logo_path = @"C:\Users\회전형키오스크2\Desktop\새 폴더\새 폴더\logo.JPG";
        */

        
        private string setMenu_path = @"C:\Users\devLupin\Source\Repos\Kiosk_GSTC\Kiosk_GSTC\setMenu_pictures\";
        private string singleMenu_path = @"C:\Users\devLupin\Source\Repos\Kiosk_GSTC\Kiosk_GSTC\singleMenu_pictures\";
        private string drink_path = @"C:\Users\devLupin\Source\Repos\Kiosk_GSTC\Kiosk_GSTC\drink_pictures\";
        private string sideMenu_path = @"C:\Users\devLupin\Source\Repos\Kiosk_GSTC\Kiosk_GSTC\sideMenu_pictures\";
        private string logo_path = @"C:\Users\devLupin\Source\Repos\Kiosk_GSTC\Kiosk_GSTC\logo.JPG";
        

        private int[] setMenu_orderList;
        private int[] singleMenu_orderList;
        private int[] sideMenu_orderList;
        private int[] drink_orderList;

        private string[] setMenu_list = {"", "몬스터와퍼세트", "콰트로치즈와퍼세트", "통새우와퍼세트", "비프칠리 통모짜와퍼 세트", "트러플통모짜와퍼 세트",
                    "통모짜와퍼 세트", "치즈와퍼세트", "불고기와퍼세트", "불고기치즈와퍼세트"};
        private int[] set_price = { 0, 9900, 9500, 9600, 10500, 9900,
            9900, 9300, 8700, 9300 };

        private string[] singleMenu_list = {"", "트러플머쉬룸와퍼", "더블와퍼", "베이컨치즈와퍼", "몬스터와퍼", "콰트로치즈와퍼", "통새우와퍼",
        "비프칠리 통모짜와퍼", "트러플통모짜와퍼", "통모짜와퍼"};
        private int[] single_price = { 0, 6700, 9200, 8200, 8600, 7200,
            7300, 9200, 8600, 8600 };

        private string[] sideMenu_list = { "", "콘샐러드", "트러플프라이", "치즈프라이", "바삭킹2조각", "바삭킹4조각", "볼케이노칠리프라이", "바삭킹8조각,칠리소스",
        "바삭킹8조각,까망베르치즈소스", "바삭킹8조각,디아블로소스"};
        private int[] side_price = { 0, 2100, 2500, 3000, 3200, 6000,
            3300, 11800, 11800, 11800};

        private string[] drink_list = {"", "코카-콜라(대)", "코카-콜라(중)", "스프라이트(대)", "스프라이트(중)", "코카-콜라 제로(중)",
            "코카-콜라 제로(대)", "환타오렌지(중)", "환타오렌지(대)", "미닛메이드"};
        private int[] drink_price = {0, 2400, 2200, 2400, 2200, 2200,
            2400, 2200, 2400, 3000 };

        private string order;

        private void menu_tab_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font TabFont;
            Brush BackBrush = new SolidBrush(Color.White); //Set background color
            Brush ForeBrush = new SolidBrush(Color.Black);//Set foreground color
            if (e.Index == this.menu_tab.SelectedIndex)
            {
                TabFont = new Font(e.Font, FontStyle.Bold);
            }
            else
            {
                TabFont = e.Font;

            }
            string TabName = this.menu_tab.TabPages[e.Index].Text;
            StringFormat sf = new StringFormat();
            //sf.Alignment = StringAlignment.Center;
            e.Graphics.FillRectangle(BackBrush, e.Bounds);

            Rectangle r = e.Bounds;
            r = new Rectangle(r.X, r.Y + 3, r.Width, r.Height - 3);
            e.Graphics.DrawString(TabName, TabFont, ForeBrush, r, sf);
            //Dispose objects
            sf.Dispose();
            if (e.Index == this.menu_tab.SelectedIndex)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Aqua), e.Bounds);
                e.Graphics.DrawString(TabName, new Font(e.Font, FontStyle.Bold), ForeBrush, r, sf);

                TabFont.Dispose();
                BackBrush.Dispose();
            }
            else
            {
                BackBrush.Dispose();
                ForeBrush.Dispose();
            }
        }

        public startLayout()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            menu_tab.DrawItem += new DrawItemEventHandler(menu_tab_DrawItem);

            setMenu_orderList = new int[10];
            singleMenu_orderList = new int[10];
            drink_orderList = new int[10];
            sideMenu_orderList = new int[10];
            for (int i = 0; i < 10; i++)
            {
                setMenu_orderList[i] = 0;
                singleMenu_orderList[i] = 0;
                drink_orderList[i] = 0;
                sideMenu_orderList[i] = 0;
            }

            logo_picture.Load(this.logo_path);
            logo_picture.SizeMode = PictureBoxSizeMode.StretchImage;

            /*Set the pictures.*/
            picture_single1.Load(this.singleMenu_path + "1.jpg");
            picture_single2.Load(this.singleMenu_path + "2.jpg");
            picture_single3.Load(this.singleMenu_path + "3.jpg");
            picture_single4.Load(this.singleMenu_path + "4.jpg");
            picture_single5.Load(this.singleMenu_path + "5.jpg");
            picture_single6.Load(this.singleMenu_path + "6.jpg");
            picture_single7.Load(this.singleMenu_path + "7.jpg");
            picture_single8.Load(this.singleMenu_path + "8.jpg");
            picture_single9.Load(this.singleMenu_path + "9.jpg");
            picture_single1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_single2.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_single3.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_single4.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_single5.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_single6.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_single7.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_single8.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_single9.SizeMode = PictureBoxSizeMode.StretchImage;

            picture_set1.Load(this.setMenu_path + "1.jpg");
            picture_set2.Load(this.setMenu_path + "2.jpg");
            picture_set3.Load(this.setMenu_path + "3.jpg");
            picture_set4.Load(this.setMenu_path + "4.jpg");
            picture_set5.Load(this.setMenu_path + "5.jpg");
            picture_set6.Load(this.setMenu_path + "6.jpg");
            picture_set7.Load(this.setMenu_path + "7.jpg");
            picture_set8.Load(this.setMenu_path + "8.jpg");
            picture_set9.Load(this.setMenu_path + "9.jpg");
            picture_set1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_set2.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_set3.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_set4.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_set5.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_set6.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_set7.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_set8.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_set9.SizeMode = PictureBoxSizeMode.StretchImage;

            picture_drink1.Load(this.drink_path + "1.jpg");
            picture_drink2.Load(this.drink_path + "2.jpg");
            picture_drink3.Load(this.drink_path + "3.jpg");
            picture_drink4.Load(this.drink_path + "4.jpg");
            picture_drink5.Load(this.drink_path + "5.jpg");
            picture_drink6.Load(this.drink_path + "6.jpg");
            picture_drink7.Load(this.drink_path + "7.jpg");
            picture_drink8.Load(this.drink_path + "8.jpg");
            picture_drink9.Load(this.drink_path + "9.jpg");
            picture_drink1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_drink2.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_drink3.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_drink4.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_drink5.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_drink6.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_drink7.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_drink8.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_drink9.SizeMode = PictureBoxSizeMode.StretchImage;

            picture_side1.Load(this.sideMenu_path + "1.jpg");
            picture_side2.Load(this.sideMenu_path + "2.jpg");
            picture_side3.Load(this.sideMenu_path + "3.jpg");
            picture_side4.Load(this.sideMenu_path + "4.jpg");
            picture_side5.Load(this.sideMenu_path + "5.jpg");
            picture_side6.Load(this.sideMenu_path + "6.jpg");
            picture_side7.Load(this.sideMenu_path + "7.jpg");
            picture_side8.Load(this.sideMenu_path + "8.jpg");
            picture_side9.Load(this.sideMenu_path + "9.jpg");
            picture_side1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_side2.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_side3.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_side4.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_side5.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_side6.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_side7.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_side8.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_side9.SizeMode = PictureBoxSizeMode.StretchImage;

            RefreshOrderList();
            notice_usage();
        }

        private void single1_m_btn_Click(object sender, EventArgs e)
        {
            if (singleMenu_orderList[1] > 0)
                singleMenu_orderList[1]--;
            single_1.Text = singleMenu_orderList[1].ToString();
            single_1.Refresh();

            RefreshOrderList();
        }

        private void single1_p_btn_Click(object sender, EventArgs e)
        {
            singleMenu_orderList[1]++;
            single_1.Text = singleMenu_orderList[1].ToString();
            single_1.Refresh();

            RefreshOrderList();
        }

        private void single2_m_btn_Click(object sender, EventArgs e)
        {
            if (singleMenu_orderList[2] > 0)
                singleMenu_orderList[2]--;
            single_2.Text = singleMenu_orderList[2].ToString();
            single_2.Refresh();

            RefreshOrderList();
        }

        private void single2_p_btn_Click(object sender, EventArgs e)
        {
            singleMenu_orderList[2]++;
            single_2.Text = singleMenu_orderList[2].ToString();
            single_2.Refresh();

            RefreshOrderList();
        }

        private void single3_m_btn_Click(object sender, EventArgs e)
        {
            if (singleMenu_orderList[3] > 0)
                singleMenu_orderList[3]--;
            single_3.Text = singleMenu_orderList[3].ToString();
            single_3.Refresh();

            RefreshOrderList();
        }

        private void single3_p_btn_Click(object sender, EventArgs e)
        {
            singleMenu_orderList[3]++;
            single_3.Text = singleMenu_orderList[3].ToString();
            single_3.Refresh();

            RefreshOrderList();
        }

        private void single4_m_btn_Click(object sender, EventArgs e)
        {
            if (singleMenu_orderList[4] > 0)
                singleMenu_orderList[4]--;
            single_4.Text = singleMenu_orderList[4].ToString();
            single_4.Refresh();

            RefreshOrderList();
        }

        private void single4_p_btn_Click(object sender, EventArgs e)
        {
            singleMenu_orderList[4]++;
            single_4.Text = singleMenu_orderList[4].ToString();
            single_4.Refresh();

            RefreshOrderList();
        }

        private void single5_m_btn_Click(object sender, EventArgs e)
        {
            if (singleMenu_orderList[5] > 0)
                singleMenu_orderList[5]--;
            single_5.Text = singleMenu_orderList[5].ToString();
            single_5.Refresh();

            RefreshOrderList();
        }

        private void single5_p_btn_Click(object sender, EventArgs e)
        {
            singleMenu_orderList[5]++;
            single_5.Text = singleMenu_orderList[5].ToString();
            single_5.Refresh();

            RefreshOrderList();
        }

        private void single6_m_btn_Click(object sender, EventArgs e)
        {
            if (singleMenu_orderList[6] > 0)
                singleMenu_orderList[6]--;
            single_6.Text = singleMenu_orderList[6].ToString();
            single_6.Refresh();

            RefreshOrderList();
        }

        private void single6_p_btn_Click(object sender, EventArgs e)
        {
            singleMenu_orderList[6]++;
            single_6.Text = singleMenu_orderList[6].ToString();
            single_6.Refresh();

            RefreshOrderList();
        }

        private void single7_m_btn_Click(object sender, EventArgs e)
        {
            if (singleMenu_orderList[7] > 0)
                singleMenu_orderList[7]--;
            single_7.Text = singleMenu_orderList[7].ToString();
            single_7.Refresh();

            RefreshOrderList();
        }

        private void single7_p_btn_Click(object sender, EventArgs e)
        {
            singleMenu_orderList[7]++;
            single_7.Text = singleMenu_orderList[7].ToString();
            single_7.Refresh();

            RefreshOrderList();
        }

        private void single8_m_btn_Click(object sender, EventArgs e)
        {
            if (singleMenu_orderList[8] > 0)
                singleMenu_orderList[8]--;
            single_8.Text = singleMenu_orderList[8].ToString();
            single_8.Refresh();

            RefreshOrderList();
        }

        private void single8_p_btn_Click(object sender, EventArgs e)
        {
            singleMenu_orderList[8]++;
            single_8.Text = singleMenu_orderList[8].ToString();
            single_8.Refresh();

            RefreshOrderList();
        }

        private void single9_m_btn_Click(object sender, EventArgs e)
        {
            if (singleMenu_orderList[9] > 0)
                singleMenu_orderList[9]--;
            single_9.Text = singleMenu_orderList[9].ToString();
            single_9.Refresh();

            RefreshOrderList();
        }

        private void single9_p_btn_Click(object sender, EventArgs e)
        {
            singleMenu_orderList[9]++;
            single_9.Text = singleMenu_orderList[9].ToString();
            single_9.Refresh();

            RefreshOrderList();
        }

        private void set1_m_btn_Click(object sender, EventArgs e)
        {
            if (setMenu_orderList[1] > 0)
                setMenu_orderList[1]--;
            set_1.Text = setMenu_orderList[1].ToString();
            set_1.Refresh();

            RefreshOrderList();
        }

        private void set1_p_btn_Click(object sender, EventArgs e)
        {

            setMenu_orderList[1]++;
            set_1.Text = setMenu_orderList[1].ToString();
            set_1.Refresh();

            RefreshOrderList();
        }

        private void set2_m_btn_Click(object sender, EventArgs e)
        {
            if (setMenu_orderList[2] > 0)
                setMenu_orderList[2]--;
            set_2.Text = setMenu_orderList[2].ToString();
            set_2.Refresh();

            RefreshOrderList();
        }

        private void set2_p_btn_Click(object sender, EventArgs e)
        {

            setMenu_orderList[2]++;
            set_2.Text = setMenu_orderList[2].ToString();
            set_2.Refresh();

            RefreshOrderList();
        }

        private void set3_m_btn_Click(object sender, EventArgs e)
        {
            if (setMenu_orderList[3] > 0)
                setMenu_orderList[3]--;
            set_3.Text = setMenu_orderList[3].ToString();
            set_3.Refresh();

            RefreshOrderList();
        }

        private void set3_p_btn_Click(object sender, EventArgs e)
        {

            setMenu_orderList[3]++;
            set_3.Text = setMenu_orderList[3].ToString();
            set_3.Refresh();

            RefreshOrderList();
        }

        private void set4_m_btn_Click(object sender, EventArgs e)
        {
            if (setMenu_orderList[4] > 0)
                setMenu_orderList[4]--;
            set_4.Text = setMenu_orderList[4].ToString();
            set_4.Refresh();

            RefreshOrderList();
        }

        private void set4_p_btn_Click(object sender, EventArgs e)
        {

            setMenu_orderList[4]++;
            set_4.Text = setMenu_orderList[4].ToString();
            set_4.Refresh();

            RefreshOrderList();
        }

        private void set5_m_btn_Click(object sender, EventArgs e)
        {
            if (setMenu_orderList[5] > 0)
                setMenu_orderList[5]--;
            set_5.Text = setMenu_orderList[5].ToString();
            set_5.Refresh();

            RefreshOrderList();
        }

        private void set5_p_btn_Click(object sender, EventArgs e)
        {

            setMenu_orderList[5]++;
            set_5.Text = setMenu_orderList[5].ToString();
            set_5.Refresh();

            RefreshOrderList();
        }

        private void set6_m_btn_Click(object sender, EventArgs e)
        {
            if (setMenu_orderList[6] > 0)
                setMenu_orderList[6]--;
            set_6.Text = setMenu_orderList[6].ToString();
            set_6.Refresh();

            RefreshOrderList();
        }

        private void set6_p_btn_Click(object sender, EventArgs e)
        {

            setMenu_orderList[6]++;
            set_6.Text = setMenu_orderList[6].ToString();
            set_6.Refresh();

            RefreshOrderList();
        }

        private void set7_m_btn_Click(object sender, EventArgs e)
        {
            if (setMenu_orderList[7] > 0)
                setMenu_orderList[7]--;
            set_7.Text = setMenu_orderList[7].ToString();
            set_7.Refresh();

            RefreshOrderList();
        }

        private void set7_p_btn_Click(object sender, EventArgs e)
        {

            setMenu_orderList[7]++;
            set_7.Text = setMenu_orderList[7].ToString();
            set_7.Refresh();

            RefreshOrderList();
        }

        private void set8_m_btn_Click(object sender, EventArgs e)
        {
            if (setMenu_orderList[8] > 0)
                setMenu_orderList[8]--;
            set_8.Text = setMenu_orderList[8].ToString();
            set_8.Refresh();

            RefreshOrderList();
        }

        private void set8_p_btn_Click(object sender, EventArgs e)
        {

            setMenu_orderList[8]++;
            set_8.Text = setMenu_orderList[8].ToString();
            set_8.Refresh();

            RefreshOrderList();
        }

        private void set9_m_btn_Click(object sender, EventArgs e)
        {
            if (setMenu_orderList[9] > 0)
                setMenu_orderList[9]--;
            set_9.Text = setMenu_orderList[9].ToString();
            set_9.Refresh();

            RefreshOrderList();
        }

        private void set9_p_btn_Click(object sender, EventArgs e)
        {

            setMenu_orderList[9]++;
            set_9.Text = setMenu_orderList[9].ToString();
            set_9.Refresh(); RefreshOrderList();
        }

        private void drink1_m_btn_Click(object sender, EventArgs e)
        {
            if (drink_orderList[1] > 0)
                drink_orderList[1]--;
            drink_1.Text = drink_orderList[1].ToString();
            drink_1.Refresh(); RefreshOrderList();
        }

        private void drink1_p_btn_Click(object sender, EventArgs e)
        {

            drink_orderList[1]++;
            drink_1.Text = drink_orderList[1].ToString();
            drink_1.Refresh(); RefreshOrderList();
        }

        private void drink2_m_btn_Click(object sender, EventArgs e)
        {
            if (drink_orderList[2] > 0)
                drink_orderList[2]--;
            drink_2.Text = drink_orderList[2].ToString();
            drink_2.Refresh(); RefreshOrderList();
        }

        private void drink2_p_btn_Click(object sender, EventArgs e)
        {

            drink_orderList[2]++;
            drink_2.Text = drink_orderList[2].ToString();
            drink_2.Refresh(); RefreshOrderList();
        }

        private void drink3_m_btn_Click(object sender, EventArgs e)
        {
            if (drink_orderList[3] > 0)
                drink_orderList[3]--;
            drink_3.Text = drink_orderList[3].ToString();
            drink_3.Refresh(); RefreshOrderList();
        }

        private void drink3_p_btn_Click(object sender, EventArgs e)
        {

            drink_orderList[3]++;
            drink_3.Text = drink_orderList[3].ToString();
            drink_3.Refresh(); RefreshOrderList();
        }

        private void drink4_m_btn_Click(object sender, EventArgs e)
        {
            if (drink_orderList[4] > 0)
                drink_orderList[4]--;
            drink_4.Text = drink_orderList[4].ToString();
            drink_4.Refresh(); RefreshOrderList();
        }

        private void drink4_p_btn_Click(object sender, EventArgs e)
        {

            drink_orderList[4]++;
            drink_4.Text = drink_orderList[4].ToString();
            drink_4.Refresh(); RefreshOrderList();
        }

        private void drink5_m_btn_Click(object sender, EventArgs e)
        {
            if (drink_orderList[5] > 0)
                drink_orderList[5]--;
            drink_5.Text = drink_orderList[5].ToString();
            drink_5.Refresh(); RefreshOrderList();
        }

        private void drink5_p_btn_Click(object sender, EventArgs e)
        {

            drink_orderList[5]++;
            drink_5.Text = drink_orderList[5].ToString();
            drink_5.Refresh(); RefreshOrderList();
        }

        private void drink6_m_btn_Click(object sender, EventArgs e)
        {
            if (drink_orderList[6] > 0)
                drink_orderList[6]--;
            drink_6.Text = drink_orderList[6].ToString();
            drink_6.Refresh(); RefreshOrderList();
        }

        private void drink6_p_btn_Click(object sender, EventArgs e)
        {

            drink_orderList[6]++;
            drink_6.Text = drink_orderList[6].ToString();
            drink_6.Refresh(); RefreshOrderList();
        }

        private void drink7_m_btn_Click(object sender, EventArgs e)
        {
            if (drink_orderList[7] > 0)
                drink_orderList[7]--;
            drink_7.Text = drink_orderList[7].ToString();
            drink_7.Refresh(); RefreshOrderList();
        }

        private void drink7_p_btn_Click(object sender, EventArgs e)
        {

            drink_orderList[7]++;
            drink_7.Text = drink_orderList[7].ToString();
            drink_7.Refresh(); RefreshOrderList();
        }

        private void drink8_m_btn_Click(object sender, EventArgs e)
        {
            if (drink_orderList[8] > 0)
                drink_orderList[8]--;
            drink_8.Text = drink_orderList[8].ToString();
            drink_8.Refresh(); RefreshOrderList();
        }

        private void drink8_p_btn_Click(object sender, EventArgs e)
        {

            drink_orderList[8]++;
            drink_8.Text = drink_orderList[8].ToString();
            drink_8.Refresh(); RefreshOrderList();
        }

        private void drink9_m_btn_Click(object sender, EventArgs e)
        {
            if (drink_orderList[9] > 0)
                drink_orderList[9]--;
            drink_9.Text = drink_orderList[9].ToString();
            drink_9.Refresh(); RefreshOrderList();
        }

        private void drink9_p_btn_Click(object sender, EventArgs e)
        {

            drink_orderList[9]++;
            drink_9.Text = drink_orderList[9].ToString();
            drink_9.Refresh(); RefreshOrderList();
        }

        private void side1_m_btn_Click(object sender, EventArgs e)
        {
            if (sideMenu_orderList[1] > 0)
                sideMenu_orderList[1]--;
            side_1.Text = sideMenu_orderList[1].ToString();
            side_1.Refresh(); RefreshOrderList();
        }

        private void side1_p_btn_Click(object sender, EventArgs e)
        {

            sideMenu_orderList[1]++;
            side_1.Text = sideMenu_orderList[1].ToString();
            side_1.Refresh(); RefreshOrderList();
        }

        private void side2_m_btn_Click(object sender, EventArgs e)
        {
            if (sideMenu_orderList[2] > 0)
                sideMenu_orderList[2]--;
            side_2.Text = sideMenu_orderList[2].ToString();
            side_2.Refresh(); RefreshOrderList();
        }

        private void side2_p_btn_Click(object sender, EventArgs e)
        {

            sideMenu_orderList[2]++;
            side_2.Text = sideMenu_orderList[2].ToString();
            side_2.Refresh(); RefreshOrderList();
        }

        private void side3_m_btn_Click(object sender, EventArgs e)
        {
            if (sideMenu_orderList[3] > 0)
                sideMenu_orderList[3]--;
            side_3.Text = sideMenu_orderList[3].ToString();
            side_3.Refresh(); RefreshOrderList();
        }

        private void side3_p_btn_Click(object sender, EventArgs e)
        {

            sideMenu_orderList[3]++;
            side_3.Text = sideMenu_orderList[3].ToString();
            side_3.Refresh(); RefreshOrderList();
        }

        private void side4_m_btn_Click(object sender, EventArgs e)
        {
            if (sideMenu_orderList[4] > 0)
                sideMenu_orderList[4]--;
            side_4.Text = sideMenu_orderList[4].ToString();
            side_4.Refresh(); RefreshOrderList();
        }

        private void side4_p_btn_Click(object sender, EventArgs e)
        {

            sideMenu_orderList[4]++;
            side_4.Text = sideMenu_orderList[4].ToString();
            side_4.Refresh(); RefreshOrderList();
        }

        private void side5_m_btn_Click(object sender, EventArgs e)
        {
            if (sideMenu_orderList[5] > 0)
                sideMenu_orderList[5]--;
            side_5.Text = sideMenu_orderList[5].ToString();
            side_5.Refresh(); RefreshOrderList();
        }

        private void side5_p_btn_Click(object sender, EventArgs e)
        {

            sideMenu_orderList[5]++;
            side_5.Text = sideMenu_orderList[5].ToString();
            side_5.Refresh(); RefreshOrderList();
        }

        private void side6_m_btn_Click(object sender, EventArgs e)
        {
            if (sideMenu_orderList[6] > 0)
                sideMenu_orderList[6]--;
            side_6.Text = sideMenu_orderList[6].ToString();
            side_6.Refresh(); RefreshOrderList();
        }

        private void side6_p_btn_Click(object sender, EventArgs e)
        {

            sideMenu_orderList[6]++;
            side_6.Text = sideMenu_orderList[6].ToString();
            side_6.Refresh(); RefreshOrderList();
        }

        private void side7_m_btn_Click(object sender, EventArgs e)
        {
            if (sideMenu_orderList[7] > 0)
                sideMenu_orderList[7]--;
            side_7.Text = sideMenu_orderList[7].ToString();
            side_7.Refresh(); RefreshOrderList();
        }

        private void side7_p_btn_Click(object sender, EventArgs e)
        {

            sideMenu_orderList[7]++;
            side_7.Text = sideMenu_orderList[7].ToString();
            side_7.Refresh(); RefreshOrderList();
        }

        private void side8_m_btn_Click(object sender, EventArgs e)
        {
            if (sideMenu_orderList[8] > 0)
                sideMenu_orderList[8]--;
            side_8.Text = sideMenu_orderList[8].ToString();
            side_8.Refresh(); RefreshOrderList();
        }

        private void side8_p_btn_Click(object sender, EventArgs e)
        {

            sideMenu_orderList[8]++;
            side_8.Text = sideMenu_orderList[8].ToString();
            side_8.Refresh(); RefreshOrderList();
        }

        private void side9_m_btn_Click(object sender, EventArgs e)
        {
            if (sideMenu_orderList[9] > 0)
                sideMenu_orderList[9]--;
            side_9.Text = sideMenu_orderList[9].ToString();
            side_9.Refresh(); RefreshOrderList();
        }

        private void side9_p_btn_Click(object sender, EventArgs e)
        {

            sideMenu_orderList[9]++;
            side_9.Text = sideMenu_orderList[9].ToString();
            side_9.Refresh(); RefreshOrderList();
        }

        public void RefreshLabel()
        {
            single_1.Text = singleMenu_orderList[1].ToString();
            single_1.Refresh();
            single_2.Text = singleMenu_orderList[2].ToString();
            single_2.Refresh();
            single_3.Text = singleMenu_orderList[3].ToString();
            single_3.Refresh();
            single_4.Text = singleMenu_orderList[4].ToString();
            single_4.Refresh();
            single_5.Text = singleMenu_orderList[5].ToString();
            single_5.Refresh();
            single_6.Text = singleMenu_orderList[6].ToString();
            single_6.Refresh();
            single_7.Text = singleMenu_orderList[7].ToString();
            single_7.Refresh();
            single_8.Text = singleMenu_orderList[8].ToString();
            single_8.Refresh();
            single_9.Text = singleMenu_orderList[9].ToString();
            single_9.Refresh();

            set_1.Text = setMenu_orderList[1].ToString();
            set_1.Refresh();
            set_2.Text = setMenu_orderList[2].ToString();
            set_2.Refresh();
            set_3.Text = setMenu_orderList[3].ToString();
            set_3.Refresh();
            set_4.Text = setMenu_orderList[4].ToString();
            set_4.Refresh();
            set_5.Text = setMenu_orderList[5].ToString();
            set_5.Refresh();
            set_6.Text = setMenu_orderList[6].ToString();
            set_6.Refresh();
            set_7.Text = setMenu_orderList[7].ToString();
            set_7.Refresh();
            set_8.Text = setMenu_orderList[8].ToString();
            set_8.Refresh();
            set_9.Text = setMenu_orderList[9].ToString();
            set_9.Refresh();

            drink_1.Text = drink_orderList[1].ToString();
            drink_1.Refresh();
            drink_2.Text = drink_orderList[2].ToString();
            drink_2.Refresh();
            drink_3.Text = drink_orderList[3].ToString();
            drink_3.Refresh();
            drink_4.Text = drink_orderList[4].ToString();
            drink_4.Refresh();
            drink_5.Text = drink_orderList[5].ToString();
            drink_5.Refresh();
            drink_6.Text = drink_orderList[6].ToString();
            drink_6.Refresh();
            drink_7.Text = drink_orderList[7].ToString();
            drink_7.Refresh();
            drink_8.Text = drink_orderList[8].ToString();
            drink_8.Refresh();
            drink_9.Text = drink_orderList[9].ToString();
            drink_9.Refresh();

            side_1.Text = sideMenu_orderList[1].ToString();
            side_1.Refresh();
            side_2.Text = sideMenu_orderList[2].ToString();
            side_2.Refresh();
            side_3.Text = sideMenu_orderList[3].ToString();
            side_3.Refresh();
            side_4.Text = sideMenu_orderList[4].ToString();
            side_4.Refresh();
            side_5.Text = sideMenu_orderList[5].ToString();
            side_5.Refresh();
            side_6.Text = sideMenu_orderList[6].ToString();
            side_6.Refresh();
            side_7.Text = sideMenu_orderList[7].ToString();
            side_7.Refresh();
            side_8.Text = sideMenu_orderList[8].ToString();
            side_8.Refresh();
            side_9.Text = sideMenu_orderList[9].ToString();
            side_9.Refresh();
        }

        public void RefreshOrderList()
        {
            int price = orderList_refresh();
            this.order_richBox.Text = this.order + "\n 총 금액 : " + price + "원";
            this.order_richBox.Refresh();
        }

        private int orderList_refresh()
        {
            this.order = "";

            int all_price;
            int all_set_price = 0;
            int all_single_price = 0;
            int all_drink_price = 0;
            int all_side_price = 0;

            for (int i = 1; i < 10; i++)
            {
                if (setMenu_orderList[i] > 0)
                {
                    order += this.setMenu_list[i] + " ";
                    int p = this.set_price[i] * setMenu_orderList[i];
                    order += (setMenu_orderList[i] + "개 \n\n");

                    all_set_price += p;
                }
                if (singleMenu_orderList[i] > 0)
                {
                    order += this.singleMenu_list[i] + " ";
                    int p = this.single_price[i] * singleMenu_orderList[i];
                    order += (singleMenu_orderList[i] + "개 \n\n");

                    all_single_price += p;
                }
                if (sideMenu_orderList[i] > 0)
                {
                    order += this.sideMenu_list[i] + " ";
                    int p = this.side_price[i] * sideMenu_orderList[i];
                    order += (sideMenu_orderList[i] + "개 \n\n");

                    all_side_price += p;
                }
                if (drink_orderList[i] > 0)
                {
                    order += this.drink_list[i] + " ";
                    int p = this.drink_price[i] * drink_orderList[i];
                    order += (drink_orderList[i] + "개 \n\n");

                    all_drink_price += p;
                }
            }

            all_price = all_set_price + all_single_price + all_drink_price;
            return all_price;
        }

        private void notice_usage()
        {
            string temp = "\t\t <사용법>\n\n";
            temp += "+ 버튼을 누르면 추가되고,\n";
            temp += "- 버튼을 누르면 취소됩니다.\n\n";
            temp += "상단의 \n단품, 세트, 음료, 사이드 메뉴를 \n추가해주세요 \n";

            this.order_richBox.Text = temp;
            this.order_richBox.Refresh();
        }

        private void deleteOrder_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택했던 모든 주문이 지워집니다. 정말 지우시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("장바구니가 비워졌습니다!");

                for (int i = 0; i < 10; i++)
                {
                    setMenu_orderList[i] = 0;
                    singleMenu_orderList[i] = 0;
                    drink_orderList[i] = 0;
                    sideMenu_orderList[i] = 0;
                }

                RefreshOrderList();
                RefreshLabel();
                notice_usage();
            }
            else
            {
                MessageBox.Show("주문내역이 유지됩니다");
            }
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            //orderLayout orderList = new orderLayout(order + "\n" + "주문되었습니다\n\n" + "금액 : " + orderList_refresh() + "원\n");
            //orderList.Show();

            for (int i = 0; i < 10; i++)
            {
                setMenu_orderList[i] = 0;
                singleMenu_orderList[i] = 0;
                drink_orderList[i] = 0;
                sideMenu_orderList[i] = 0;
            }

            RefreshOrderList();
            RefreshLabel();
            notice_usage();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void drink_1_Click(object sender, EventArgs e)
        {

        }

        private void drink_2_Click(object sender, EventArgs e)
        {

        }

        private void drink_3_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void drink_4_Click(object sender, EventArgs e)
        {

        }

        private void drink_5_Click(object sender, EventArgs e)
        {

        }

        private void drink_6_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
