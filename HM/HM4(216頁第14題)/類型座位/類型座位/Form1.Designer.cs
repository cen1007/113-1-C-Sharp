namespace 類型座位
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
            txtClassA = new TextBox();
            txtClassB = new TextBox();
            txtClassC = new TextBox();
            button1 = new Button();
            txtRevenueA = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtRevenueB = new TextBox();
            txtRevenueC = new TextBox();
            txtTotalRevenue = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 65);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 0;
            label1.Text = "Class A Tickets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 118);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 1;
            label2.Text = "Class B Tickets";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 179);
            label3.Name = "label3";
            label3.Size = new Size(110, 19);
            label3.TabIndex = 2;
            label3.Text = "Class C Tickets";
            // 
            // txtClassA
            // 
            txtClassA.Location = new Point(202, 62);
            txtClassA.Name = "txtClassA";
            txtClassA.Size = new Size(125, 27);
            txtClassA.TabIndex = 3;
            // 
            // txtClassB
            // 
            txtClassB.Location = new Point(202, 118);
            txtClassB.Name = "txtClassB";
            txtClassB.Size = new Size(125, 27);
            txtClassB.TabIndex = 4;
            // 
            // txtClassC
            // 
            txtClassC.Location = new Point(202, 179);
            txtClassC.Name = "txtClassC";
            txtClassC.Size = new Size(125, 27);
            txtClassC.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(135, 266);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "計算收入";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtRevenueA
            // 
            txtRevenueA.Location = new Point(639, 57);
            txtRevenueA.Name = "txtRevenueA";
            txtRevenueA.Size = new Size(125, 27);
            txtRevenueA.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(412, 65);
            label4.Name = "label4";
            label4.Size = new Size(161, 19);
            label4.TabIndex = 8;
            label4.Text = "Revenue from Class A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(412, 126);
            label5.Name = "label5";
            label5.Size = new Size(160, 19);
            label5.TabIndex = 9;
            label5.Text = "Revenue from Class B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 187);
            label6.Name = "label6";
            label6.Size = new Size(161, 19);
            label6.TabIndex = 10;
            label6.Text = "Revenue from Class C";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(412, 244);
            label7.Name = "label7";
            label7.Size = new Size(107, 19);
            label7.TabIndex = 11;
            label7.Text = "Total Revenue";
            // 
            // txtRevenueB
            // 
            txtRevenueB.Location = new Point(639, 118);
            txtRevenueB.Name = "txtRevenueB";
            txtRevenueB.Size = new Size(125, 27);
            txtRevenueB.TabIndex = 12;
            // 
            // txtRevenueC
            // 
            txtRevenueC.Location = new Point(639, 184);
            txtRevenueC.Name = "txtRevenueC";
            txtRevenueC.Size = new Size(125, 27);
            txtRevenueC.TabIndex = 13;
            // 
            // txtTotalRevenue
            // 
            txtTotalRevenue.Location = new Point(639, 241);
            txtTotalRevenue.Name = "txtTotalRevenue";
            txtTotalRevenue.Size = new Size(125, 27);
            txtTotalRevenue.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotalRevenue);
            Controls.Add(txtRevenueC);
            Controls.Add(txtRevenueB);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtRevenueA);
            Controls.Add(button1);
            Controls.Add(txtClassC);
            Controls.Add(txtClassB);
            Controls.Add(txtClassA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtClassA;
        private TextBox txtClassB;
        private TextBox txtClassC;
        private Button button1;
        private TextBox txtRevenueA;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtRevenueB;
        private TextBox txtRevenueC;
        private TextBox txtTotalRevenue;
    }
}
