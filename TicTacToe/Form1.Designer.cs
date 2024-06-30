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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            CPUTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 0;
            label1.Text = "Player Wins:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(313, 9);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "CPU Wins:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1, 58);
            button1.Name = "button1";
            button1.Size = new Size(136, 113);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayerClickButton;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(143, 58);
            button2.Name = "button2";
            button2.Size = new Size(136, 113);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayerClickButton;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(285, 58);
            button3.Name = "button3";
            button3.Size = new Size(136, 113);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayerClickButton;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(1, 177);
            button4.Name = "button4";
            button4.Size = new Size(136, 113);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerClickButton;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(143, 177);
            button5.Name = "button5";
            button5.Size = new Size(136, 113);
            button5.TabIndex = 3;
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayerClickButton;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(285, 177);
            button6.Name = "button6";
            button6.Size = new Size(136, 113);
            button6.TabIndex = 4;
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayerClickButton;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(1, 296);
            button7.Name = "button7";
            button7.Size = new Size(136, 113);
            button7.TabIndex = 2;
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayerClickButton;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(143, 296);
            button8.Name = "button8";
            button8.Size = new Size(136, 113);
            button8.TabIndex = 3;
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayerClickButton;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(285, 296);
            button9.Name = "button9";
            button9.Size = new Size(136, 113);
            button9.TabIndex = 4;
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayerClickButton;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(1, 416);
            button10.Name = "button10";
            button10.Size = new Size(420, 51);
            button10.TabIndex = 5;
            button10.Text = "Restart";
            button10.UseVisualStyleBackColor = true;
            button10.Click += RestartButton;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1000;
            CPUTimer.Tick += CPUmove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 470);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer CPUTimer;
    }
}