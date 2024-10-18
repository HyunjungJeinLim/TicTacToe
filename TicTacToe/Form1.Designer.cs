namespace TicTacToe
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
            customButton1 = new CustomButton();
            customButton2 = new CustomButton();
            customButton3 = new CustomButton();
            customButton4 = new CustomButton();
            customButton5 = new CustomButton();
            customButton6 = new CustomButton();
            customButton7 = new CustomButton();
            customButton8 = new CustomButton();
            customButton9 = new CustomButton();
            btnReset = new Button();
            SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Location = new Point(143, 38);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(112, 112);
            customButton1.TabIndex = 0;
            customButton1.UseVisualStyleBackColor = true;
            // 
            // customButton2
            // 
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Location = new Point(292, 38);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(112, 112);
            customButton2.TabIndex = 1;
            customButton2.UseVisualStyleBackColor = true;
            // 
            // customButton3
            // 
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Location = new Point(437, 38);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(112, 112);
            customButton3.TabIndex = 2;
            customButton3.UseVisualStyleBackColor = true;
            // 
            // customButton4
            // 
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Location = new Point(143, 168);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(112, 112);
            customButton4.TabIndex = 5;
            customButton4.UseVisualStyleBackColor = true;
            // 
            // customButton5
            // 
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.Location = new Point(292, 168);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(112, 112);
            customButton5.TabIndex = 4;
            customButton5.UseVisualStyleBackColor = true;
            // 
            // customButton6
            // 
            customButton6.FlatStyle = FlatStyle.Flat;
            customButton6.Location = new Point(437, 168);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(112, 112);
            customButton6.TabIndex = 3;
            customButton6.UseVisualStyleBackColor = true;
            // 
            // customButton7
            // 
            customButton7.FlatStyle = FlatStyle.Flat;
            customButton7.Location = new Point(143, 304);
            customButton7.Name = "customButton7";
            customButton7.Size = new Size(112, 112);
            customButton7.TabIndex = 8;
            customButton7.UseVisualStyleBackColor = true;
            // 
            // customButton8
            // 
            customButton8.FlatStyle = FlatStyle.Flat;
            customButton8.Location = new Point(292, 304);
            customButton8.Name = "customButton8";
            customButton8.Size = new Size(112, 112);
            customButton8.TabIndex = 7;
            customButton8.UseVisualStyleBackColor = true;
            // 
            // customButton9
            // 
            customButton9.FlatStyle = FlatStyle.Flat;
            customButton9.Location = new Point(437, 304);
            customButton9.Name = "customButton9";
            customButton9.Size = new Size(112, 112);
            customButton9.TabIndex = 6;
            customButton9.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.GradientInactiveCaption;
            btnReset.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.HotTrack;
            btnReset.Location = new Point(292, 451);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 58);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 590);
            Controls.Add(btnReset);
            Controls.Add(customButton7);
            Controls.Add(customButton8);
            Controls.Add(customButton9);
            Controls.Add(customButton4);
            Controls.Add(customButton5);
            Controls.Add(customButton6);
            Controls.Add(customButton3);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CustomButton customButton1;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private CustomButton customButton4;
        private CustomButton customButton5;
        private CustomButton customButton6;
        private CustomButton customButton7;
        private CustomButton customButton8;
        private CustomButton customButton9;
        private Button btnReset;
    }
}
