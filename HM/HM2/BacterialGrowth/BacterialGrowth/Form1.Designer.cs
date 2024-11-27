namespace BacterialGrowth
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
            txtInitialBacteria = new TextBox();
            txtDoublingTime = new TextBox();
            btnCalculate = new Button();
            lstBacterialGrowth = new ListBox();
            SuspendLayout();
            // 
            // txtInitialBacteria
            // 
            txtInitialBacteria.Location = new Point(52, 54);
            txtInitialBacteria.Name = "txtInitialBacteria";
            txtInitialBacteria.Size = new Size(183, 27);
            txtInitialBacteria.TabIndex = 0;
            txtInitialBacteria.Text = "初始細菌數量";
            // 
            // txtDoublingTime
            // 
            txtDoublingTime.Location = new Point(52, 116);
            txtDoublingTime.Name = "txtDoublingTime";
            txtDoublingTime.Size = new Size(183, 27);
            txtDoublingTime.TabIndex = 1;
            txtDoublingTime.Text = "倍增天數";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(141, 246);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "計算";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lstBacterialGrowth
            // 
            lstBacterialGrowth.FormattingEnabled = true;
            lstBacterialGrowth.ItemHeight = 19;
            lstBacterialGrowth.Location = new Point(287, 54);
            lstBacterialGrowth.Name = "lstBacterialGrowth";
            lstBacterialGrowth.Size = new Size(150, 118);
            lstBacterialGrowth.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstBacterialGrowth);
            Controls.Add(btnCalculate);
            Controls.Add(txtDoublingTime);
            Controls.Add(txtInitialBacteria);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInitialBacteria;
        private TextBox txtDoublingTime;
        private Button btnCalculate;
        private ListBox lstBacterialGrowth;
    }
}
