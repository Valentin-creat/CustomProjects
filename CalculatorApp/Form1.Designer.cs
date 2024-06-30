namespace CalculatorApp
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
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            ClearEntry = new Button();
            button14 = new Button();
            button15 = new Button();
            Clear = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            labelCurrentOperation = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 42);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(467, 57);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 114);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 136);
            button2.Name = "button2";
            button2.Size = new Size(73, 72);
            button2.TabIndex = 3;
            button2.Text = "7";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonClick;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(91, 136);
            button3.Name = "button3";
            button3.Size = new Size(73, 72);
            button3.TabIndex = 4;
            button3.Text = "8";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ButtonClick;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(170, 136);
            button4.Name = "button4";
            button4.Size = new Size(73, 72);
            button4.TabIndex = 5;
            button4.Text = "9";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ButtonClick;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(13, 214);
            button5.Name = "button5";
            button5.Size = new Size(73, 72);
            button5.TabIndex = 6;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ButtonClick;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(13, 292);
            button6.Name = "button6";
            button6.Size = new Size(73, 72);
            button6.TabIndex = 7;
            button6.Text = "1";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ButtonClick;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(91, 214);
            button7.Name = "button7";
            button7.Size = new Size(73, 72);
            button7.TabIndex = 8;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += ButtonClick;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(170, 214);
            button8.Name = "button8";
            button8.Size = new Size(73, 72);
            button8.TabIndex = 9;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = true;
            button8.Click += ButtonClick;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(91, 292);
            button9.Name = "button9";
            button9.Size = new Size(73, 72);
            button9.TabIndex = 10;
            button9.Text = "2";
            button9.UseVisualStyleBackColor = true;
            button9.Click += ButtonClick;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(170, 292);
            button10.Name = "button10";
            button10.Size = new Size(73, 72);
            button10.TabIndex = 11;
            button10.Text = "3";
            button10.UseVisualStyleBackColor = true;
            button10.Click += ButtonClick;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(12, 370);
            button11.Name = "button11";
            button11.Size = new Size(152, 72);
            button11.TabIndex = 12;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += ButtonClick;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(170, 370);
            button12.Name = "button12";
            button12.Size = new Size(73, 72);
            button12.TabIndex = 13;
            button12.Text = ",";
            button12.UseVisualStyleBackColor = true;
            button12.Click += ButtonClick;
            // 
            // ClearEntry
            // 
            ClearEntry.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ClearEntry.Location = new Point(406, 136);
            ClearEntry.Name = "ClearEntry";
            ClearEntry.Size = new Size(73, 72);
            ClearEntry.TabIndex = 14;
            ClearEntry.Text = "CE";
            ClearEntry.UseVisualStyleBackColor = true;
            ClearEntry.Click += button13_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(327, 136);
            button14.Name = "button14";
            button14.Size = new Size(73, 72);
            button14.TabIndex = 15;
            button14.Text = "/";
            button14.UseVisualStyleBackColor = true;
            button14.AutoSizeChanged += OperatorClick;
            button14.Click += OperatorClick;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(327, 214);
            button15.Name = "button15";
            button15.Size = new Size(73, 72);
            button15.TabIndex = 16;
            button15.Text = "X";
            button15.UseVisualStyleBackColor = true;
            button15.AutoSizeChanged += OperatorClick;
            button15.Click += OperatorClick;
            // 
            // Clear
            // 
            Clear.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.Location = new Point(406, 214);
            Clear.Name = "Clear";
            Clear.Size = new Size(73, 72);
            Clear.TabIndex = 17;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += button16_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button17.Location = new Point(327, 292);
            button17.Name = "button17";
            button17.Size = new Size(73, 72);
            button17.TabIndex = 18;
            button17.Text = "-";
            button17.UseVisualStyleBackColor = true;
            button17.AutoSizeChanged += OperatorClick;
            button17.Click += OperatorClick;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button18.Location = new Point(327, 370);
            button18.Name = "button18";
            button18.Size = new Size(73, 72);
            button18.TabIndex = 19;
            button18.Text = "+";
            button18.UseVisualStyleBackColor = true;
            button18.AutoSizeChanged += OperatorClick;
            button18.Click += OperatorClick;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button19.Location = new Point(406, 292);
            button19.Name = "button19";
            button19.Size = new Size(73, 150);
            button19.TabIndex = 20;
            button19.Text = "=";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.Location = new Point(14, 27);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(0, 15);
            labelCurrentOperation.TabIndex = 21;
            labelCurrentOperation.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 443);
            Controls.Add(labelCurrentOperation);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(Clear);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(ClearEntry);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button ClearEntry;
        private Button button14;
        private Button button15;
        private Button Clear;
        private Button button17;
        private Button button18;
        private Button button19;
        private Label labelCurrentOperation;
    }
}