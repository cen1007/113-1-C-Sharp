namespace tutorial2_5
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
            ptxfront = new PictureBox();
            ptxback = new PictureBox();
            btnShowBack = new Button();
            btnShowFront = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxfront).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxback).BeginInit();
            SuspendLayout();
            // 
            // ptxfront
            // 
            ptxfront.Image = Properties.Resources.Ace_Spades;
            ptxfront.Location = new Point(357, 21);
            ptxfront.Name = "ptxfront";
            ptxfront.Size = new Size(149, 210);
            ptxfront.SizeMode = PictureBoxSizeMode.Zoom;
            ptxfront.TabIndex = 0;
            ptxfront.TabStop = false;
            ptxfront.Visible = false;
            // 
            // ptxback
            // 
            ptxback.Image = Properties.Resources.Backface_Blue;
            ptxback.Location = new Point(127, 21);
            ptxback.Name = "ptxback";
            ptxback.Size = new Size(153, 210);
            ptxback.SizeMode = PictureBoxSizeMode.Zoom;
            ptxback.TabIndex = 1;
            ptxback.TabStop = false;
            ptxback.Visible = false;
            // 
            // btnShowBack
            // 
            btnShowBack.Font = new Font("Microsoft JhengHei UI", 24F);
            btnShowBack.Location = new Point(127, 266);
            btnShowBack.Name = "btnShowBack";
            btnShowBack.Size = new Size(141, 73);
            btnShowBack.TabIndex = 2;
            btnShowBack.Text = "背面";
            btnShowBack.UseVisualStyleBackColor = true;
            btnShowBack.Click += btnShowBack_Click;
            // 
            // btnShowFront
            // 
            btnShowFront.Font = new Font("Microsoft JhengHei UI", 24F);
            btnShowFront.Location = new Point(365, 266);
            btnShowFront.Name = "btnShowFront";
            btnShowFront.Size = new Size(141, 73);
            btnShowFront.TabIndex = 3;
            btnShowFront.Text = "正面";
            btnShowFront.UseVisualStyleBackColor = true;
            btnShowFront.Click += btnShowFront_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 24F);
            button1.Location = new Point(127, 374);
            button1.Name = "button1";
            button1.Size = new Size(379, 46);
            button1.TabIndex = 4;
            button1.Text = "離開";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnShowFront);
            Controls.Add(btnShowBack);
            Controls.Add(ptxback);
            Controls.Add(ptxfront);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxfront).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxback).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxfront;
        private PictureBox ptxback;
        private Button btnShowBack;
        private Button btnShowFront;
        private Button button1;
    }
}
