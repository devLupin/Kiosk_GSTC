namespace Kiosk_GSTC
{
    partial class numOfMenu
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
            this.select_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.sub_btn = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.Label();
            this.select_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // select_lbl
            // 
            this.select_lbl.AutoSize = true;
            this.select_lbl.Font = new System.Drawing.Font("휴먼둥근헤드라인", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.select_lbl.Location = new System.Drawing.Point(12, 30);
            this.select_lbl.Name = "select_lbl";
            this.select_lbl.Size = new System.Drawing.Size(0, 39);
            this.select_lbl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(25, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "\r\n+ 추가버튼과 - 감소버튼을 클릭하세요\r\n";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.DimGray;
            this.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.add_btn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(471, 98);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(43, 34);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // sub_btn
            // 
            this.sub_btn.BackColor = System.Drawing.Color.DimGray;
            this.sub_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sub_btn.FlatAppearance.BorderSize = 0;
            this.sub_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.sub_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.sub_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.sub_btn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sub_btn.ForeColor = System.Drawing.Color.White;
            this.sub_btn.Location = new System.Drawing.Point(311, 98);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(43, 34);
            this.sub_btn.TabIndex = 3;
            this.sub_btn.Text = "-";
            this.sub_btn.UseVisualStyleBackColor = false;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num.Location = new System.Drawing.Point(400, 103);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(30, 25);
            this.num.TabIndex = 4;
            this.num.Text = "0";
            // 
            // select_btn
            // 
            this.select_btn.BackColor = System.Drawing.Color.DimGray;
            this.select_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.select_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.select_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.select_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_btn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.select_btn.ForeColor = System.Drawing.Color.White;
            this.select_btn.Location = new System.Drawing.Point(427, 214);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(139, 47);
            this.select_btn.TabIndex = 5;
            this.select_btn.Text = "선택완료";
            this.select_btn.UseVisualStyleBackColor = false;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // numOfMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(578, 273);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.num);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.select_lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "numOfMenu";
            this.Text = "수량선택";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label select_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Button select_btn;
    }
}