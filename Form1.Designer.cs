namespace Calculator_Elijah
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
            txtDisplay = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnEquals = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            result = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(87, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 45);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDisplay
            // 
            txtDisplay.AutoSize = true;
            txtDisplay.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = SystemColors.Highlight;
            txtDisplay.Location = new Point(118, 82);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(0, 37);
            txtDisplay.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(12, 176);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 73);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(93, 176);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 73);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.Black;
            btn3.Location = new Point(174, 176);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 73);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(12, 255);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 73);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(93, 255);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 73);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(174, 255);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 73);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(12, 334);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 73);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(93, 334);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 73);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(174, 334);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 73);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button9_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.ForeColor = Color.Black;
            btn0.Location = new Point(12, 413);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 73);
            btn0.TabIndex = 11;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button0_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquals.ForeColor = Color.Black;
            btnEquals.Location = new Point(93, 413);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(156, 73);
            btnEquals.TabIndex = 12;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += Equals_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.IndianRed;
            btnClear.Location = new Point(255, 413);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 73);
            btnClear.TabIndex = 13;
            btnClear.Text = "AC";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += Clear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Window;
            btnAdd.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(255, 255);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 73);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += Add_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = SystemColors.Window;
            btnSubtract.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtract.ForeColor = Color.Black;
            btnSubtract.Location = new Point(255, 334);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 73);
            btnSubtract.TabIndex = 15;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += Subtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.Window;
            btnMultiply.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.ForeColor = Color.Black;
            btnMultiply.Location = new Point(255, 176);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 73);
            btnMultiply.TabIndex = 16;
            btnMultiply.Text = " ×";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += Multiply_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result.ForeColor = SystemColors.ControlText;
            result.Location = new Point(87, 74);
            result.Name = "result";
            result.Size = new Size(0, 45);
            result.TabIndex = 17;
            result.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(255, 97);
            button1.Name = "button1";
            button1.Size = new Size(75, 73);
            button1.TabIndex = 18;
            button1.Text = "÷";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Divide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 486);
            Controls.Add(button1);
            Controls.Add(result);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(btnEquals);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtDisplay);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtDisplay;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnEquals;
        private Button btnClear;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Label result;
        private Button button1;
    }
}
