namespace 購物金額
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
            textBoxAmount = new TextBox();
            buttonCalculate = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 73);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 0;
            label1.Text = "請輸入購物金額";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(216, 70);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(125, 27);
            textBoxAmount.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(81, 152);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(94, 29);
            buttonCalculate.TabIndex = 2;
            buttonCalculate.Text = "計算點數";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(216, 162);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 19);
            labelResult.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxAmount);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAmount;
        private Button buttonCalculate;
        private Label labelResult;
    }
}
