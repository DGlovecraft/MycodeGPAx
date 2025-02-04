namespace GPAx
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
            score = new TextBox();
            label1 = new Label();
            GPAx = new TextBox();
            label2 = new Label();
            CalGPA = new Button();
            Max = new TextBox();
            Low = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // score
            // 
            score.Location = new Point(180, 88);
            score.Name = "score";
            score.Size = new Size(125, 27);
            score.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 95);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 1;
            label1.Text = "InputYourScore";
            // 
            // GPAx
            // 
            GPAx.Location = new Point(180, 209);
            GPAx.Name = "GPAx";
            GPAx.Size = new Size(125, 27);
            GPAx.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 212);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 4;
            label2.Text = "GPAx";
            // 
            // CalGPA
            // 
            CalGPA.Location = new Point(347, 86);
            CalGPA.Name = "CalGPA";
            CalGPA.Size = new Size(94, 75);
            CalGPA.TabIndex = 5;
            CalGPA.Text = "Cal";
            CalGPA.UseVisualStyleBackColor = true;
            CalGPA.Click += CalGPA_Click;
            // 
            // Max
            // 
            Max.Location = new Point(180, 124);
            Max.Name = "Max";
            Max.Size = new Size(125, 27);
            Max.TabIndex = 6;
            // 
            // Low
            // 
            Low.Location = new Point(180, 167);
            Low.Name = "Low";
            Low.Size = new Size(125, 27);
            Low.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 131);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 8;
            label3.Text = "HightScore";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 174);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 9;
            label4.Text = "LowScore";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 275);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Low);
            Controls.Add(Max);
            Controls.Add(CalGPA);
            Controls.Add(label2);
            Controls.Add(GPAx);
            Controls.Add(label1);
            Controls.Add(score);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox score;
        private Label label1;
        private TextBox GPAx;
        private Label label2;
        private Button CalGPA;
        private TextBox Max;
        private TextBox Low;
        private Label label3;
        private Label label4;
    }
}
