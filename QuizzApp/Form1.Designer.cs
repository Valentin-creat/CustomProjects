namespace QuizzApp
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
            fileSystemWatcher1 = new FileSystemWatcher();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            fileSystemWatcher1.Changed += fileSystemWatcher1_Changed;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(136, 9);
            label1.Name = "label1";
            label1.Size = new Size(592, 137);
            label1.TabIndex = 0;
            label1.Text = "Are you ready for a sports quizz?";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseCompatibleTextRendering = true;
            label1.UseMnemonic = false;
            label1.Click += Label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(253, 168);
            button1.Name = "button1";
            button1.Size = new Size(280, 99);
            button1.TabIndex = 1;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 334);
            button2.Name = "button2";
            button2.Size = new Size(378, 104);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonClick;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(410, 334);
            button3.Name = "button3";
            button3.Size = new Size(378, 104);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ButtonClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 306);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 4;
            label2.Text = "Current question:";
            label2.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 271);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Label label1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}