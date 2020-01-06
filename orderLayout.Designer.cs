namespace Kiosk_GSTC
{
    partial class orderLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.takeIn_radio = new System.Windows.Forms.RadioButton();
            this.takeOut_radio = new System.Windows.Forms.RadioButton();
            this.price_richBox = new System.Windows.Forms.RichTextBox();
            this.num_richBox = new System.Windows.Forms.RichTextBox();
            this.name_richBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(578, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 114);
            this.button1.TabIndex = 1;
            this.button1.Text = "결제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // takeIn_radio
            // 
            this.takeIn_radio.AutoSize = true;
            this.takeIn_radio.Font = new System.Drawing.Font("휴먼둥근헤드라인", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.takeIn_radio.Location = new System.Drawing.Point(67, 690);
            this.takeIn_radio.Name = "takeIn_radio";
            this.takeIn_radio.Size = new System.Drawing.Size(241, 38);
            this.takeIn_radio.TabIndex = 3;
            this.takeIn_radio.TabStop = true;
            this.takeIn_radio.Text = "매장에서 식사";
            this.takeIn_radio.UseVisualStyleBackColor = true;
            // 
            // takeOut_radio
            // 
            this.takeOut_radio.AutoSize = true;
            this.takeOut_radio.Font = new System.Drawing.Font("휴먼둥근헤드라인", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.takeOut_radio.Location = new System.Drawing.Point(339, 690);
            this.takeOut_radio.Name = "takeOut_radio";
            this.takeOut_radio.Size = new System.Drawing.Size(161, 38);
            this.takeOut_radio.TabIndex = 4;
            this.takeOut_radio.TabStop = true;
            this.takeOut_radio.Text = "포장하기";
            this.takeOut_radio.UseVisualStyleBackColor = true;
            // 
            // price_richBox
            // 
            this.price_richBox.BackColor = System.Drawing.Color.White;
            this.price_richBox.Font = new System.Drawing.Font("휴먼둥근헤드라인", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price_richBox.ForeColor = System.Drawing.Color.Black;
            this.price_richBox.Location = new System.Drawing.Point(543, 25);
            this.price_richBox.Name = "price_richBox";
            this.price_richBox.Size = new System.Drawing.Size(248, 598);
            this.price_richBox.TabIndex = 17;
            this.price_richBox.Text = "";
            // 
            // num_richBox
            // 
            this.num_richBox.BackColor = System.Drawing.Color.White;
            this.num_richBox.Font = new System.Drawing.Font("휴먼둥근헤드라인", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num_richBox.ForeColor = System.Drawing.Color.Black;
            this.num_richBox.Location = new System.Drawing.Point(409, 25);
            this.num_richBox.Name = "num_richBox";
            this.num_richBox.Size = new System.Drawing.Size(116, 598);
            this.num_richBox.TabIndex = 16;
            this.num_richBox.Text = "";
            // 
            // name_richBox
            // 
            this.name_richBox.BackColor = System.Drawing.Color.White;
            this.name_richBox.Font = new System.Drawing.Font("휴먼둥근헤드라인", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_richBox.ForeColor = System.Drawing.Color.Black;
            this.name_richBox.Location = new System.Drawing.Point(20, 25);
            this.name_richBox.Name = "name_richBox";
            this.name_richBox.Size = new System.Drawing.Size(370, 598);
            this.name_richBox.TabIndex = 15;
            this.name_richBox.Text = "";
            // 
            // orderLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 784);
            this.Controls.Add(this.price_richBox);
            this.Controls.Add(this.num_richBox);
            this.Controls.Add(this.name_richBox);
            this.Controls.Add(this.takeOut_radio);
            this.Controls.Add(this.takeIn_radio);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "orderLayout";
            this.Text = "주문확인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton takeIn_radio;
        private System.Windows.Forms.RadioButton takeOut_radio;
        private System.Windows.Forms.RichTextBox price_richBox;
        private System.Windows.Forms.RichTextBox num_richBox;
        private System.Windows.Forms.RichTextBox name_richBox;
    }
}