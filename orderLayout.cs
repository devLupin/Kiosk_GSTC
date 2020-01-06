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
        public orderLayout(string name_list, string num_list, string price_list)
        {
            InitializeComponent();

            name_richBox.Text = name_list;
            num_richBox.Text = num_list;
            price_richBox.Text = price_list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!takeIn_radio.Checked && !takeOut_radio.Checked)
            {
                MessageBox.Show("식사하고 가시면 매장에서 식사하기에 체크해주세요");
            }
            else
            {
                if (MessageBox.Show("주문내역을 확인하셨습니까? 예를 누르시면 정상처리됩니다.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("주문이 정상처리 되었습니다.");
                }
                else
                {
                    MessageBox.Show("처음 상태로 돌아가 다시 주문해주세요.");
                }

                returnVal = true;
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }

        public bool returnVal { get; set; }
    }
}
