namespace tutorial3_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtWeek = new TextBox();
            txtMonth = new TextBox();
            txtDate = new TextBox();
            txtYear = new TextBox();
            lblShow = new Label();
            btnShoeDate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(65, 65);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 0;
            label1.Text = "星期幾";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(65, 149);
            label2.Name = "label2";
            label2.Size = new Size(82, 41);
            label2.TabIndex = 1;
            label2.Text = "日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(65, 226);
            label3.Name = "label3";
            label3.Size = new Size(82, 41);
            label3.TabIndex = 2;
            label3.Text = "月份";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 24F);
            label4.Location = new Point(65, 308);
            label4.Name = "label4";
            label4.Size = new Size(82, 41);
            label4.TabIndex = 3;
            label4.Text = "年份";
            // 
            // txtWeek
            // 
            txtWeek.Font = new Font("Microsoft JhengHei UI", 24F);
            txtWeek.Location = new Point(268, 58);
            txtWeek.Name = "txtWeek";
            txtWeek.Size = new Size(244, 48);
            txtWeek.TabIndex = 4;
            // 
            // txtMonth
            // 
            txtMonth.Font = new Font("Microsoft JhengHei UI", 24F);
            txtMonth.Location = new Point(268, 219);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(244, 48);
            txtMonth.TabIndex = 5;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Microsoft JhengHei UI", 24F);
            txtDate.Location = new Point(268, 142);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(244, 48);
            txtDate.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Microsoft JhengHei UI", 24F);
            txtYear.Location = new Point(268, 301);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(244, 48);
            txtYear.TabIndex = 7;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Font = new Font("Microsoft JhengHei UI", 24F);
            lblShow.Location = new Point(65, 389);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(637, 93);
            lblShow.TabIndex = 8;
            lblShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnShoeDate
            // 
            btnShoeDate.Location = new Point(65, 532);
            btnShoeDate.Name = "btnShoeDate";
            btnShoeDate.Size = new Size(147, 66);
            btnShoeDate.TabIndex = 9;
            btnShoeDate.Text = "顯示完整日期";
            btnShoeDate.UseVisualStyleBackColor = true;
            btnShoeDate.Click += btnShoeDate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(310, 532);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 66);
            btnClear.TabIndex = 10;
            btnClear.Text = "清空內容";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(557, 532);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 66);
            btnExit.TabIndex = 11;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 656);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnShoeDate);
            Controls.Add(lblShow);
            Controls.Add(txtYear);
            Controls.Add(txtDate);
            Controls.Add(txtMonth);
            Controls.Add(txtWeek);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtWeek;
        private TextBox txtMonth;
        private TextBox txtDate;
        private TextBox txtYear;
        private Label lblShow;
        private Button btnShoeDate;
        private Button btnClear;
        private Button btnExit;
    }
}
