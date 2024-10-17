namespace Modul5
{
    partial class Calculator
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Subtract;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.Button button_Divide;
        private System.Windows.Forms.Button button_Equals;
        private System.Windows.Forms.Button button_Clear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Subtract = new System.Windows.Forms.Button();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.button_Equals = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // textBox_Result
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox_Result.Location = new System.Drawing.Point(12, 12);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(318, 38);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // button 1
            this.button_1.Location = new System.Drawing.Point(12, 56);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(60, 60);
            this.button_1.TabIndex = 1;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_Click);

            // button 2
            this.button_2.Location = new System.Drawing.Point(78, 56);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(60, 60);
            this.button_2.TabIndex = 2;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_Click);

            // button 3
            this.button_3.Location = new System.Drawing.Point(144, 56);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(60, 60);
            this.button_3.TabIndex = 3;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_Click);

            // button 4
            this.button_4.Location = new System.Drawing.Point(12, 122);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(60, 60);
            this.button_4.TabIndex = 4;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_Click);

            // button 5
            this.button_5.Location = new System.Drawing.Point(78, 122);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(60, 60);
            this.button_5.TabIndex = 5;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_Click);

            // button 6
            this.button_6.Location = new System.Drawing.Point(144, 122);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(60, 60);
            this.button_6.TabIndex = 6;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_Click);

            // button 7
            this.button_7.Location = new System.Drawing.Point(12, 188);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(60, 60);
            this.button_7.TabIndex = 7;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_Click);

            // button 8
            this.button_8.Location = new System.Drawing.Point(78, 188);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(60, 60);
            this.button_8.TabIndex = 8;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_Click);

            // button 9
            this.button_9.Location = new System.Drawing.Point(144, 188);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(60, 60);
            this.button_9.TabIndex = 9;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_Click);

            // button 0
            this.button_0.Location = new System.Drawing.Point(78, 254);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(60, 60);
            this.button_0.TabIndex = 10;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_Click);

            // button Add
            this.button_Add.Location = new System.Drawing.Point(210, 56);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(60, 60);
            this.button_Add.TabIndex = 11;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.operator_Click);

            // button Subtract
            this.button_Subtract.Location = new System.Drawing.Point(210, 122);
            this.button_Subtract.Name = "button_Subtract";
            this.button_Subtract.Size = new System.Drawing.Size(60, 60);
            this.button_Subtract.TabIndex = 12;
            this.button_Subtract.Text = "-";
            this.button_Subtract.UseVisualStyleBackColor = true;
            this.button_Subtract.Click += new System.EventHandler(this.operator_Click);

            // button Multiply
            this.button_Multiply.Location = new System.Drawing.Point(210, 188);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(60, 60);
            this.button_Multiply.TabIndex = 13;
            this.button_Multiply.Text = "*";
            this.button_Multiply.UseVisualStyleBackColor = true;
            this.button_Multiply.Click += new System.EventHandler(this.operator_Click);

            // button Divide
            this.button_Divide.Location = new System.Drawing.Point(210, 254);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(60, 60);
            this.button_Divide.TabIndex = 14;
            this.button_Divide.Text = "/";
            this.button_Divide.UseVisualStyleBackColor = true;
            this.button_Divide.Click += new System.EventHandler(this.operator_Click);

            // button Equals
            this.button_Equals.Location = new System.Drawing.Point(276, 188);
            this.button_Equals.Name = "button_Equals";
            this.button_Equals.Size = new System.Drawing.Size(60, 126);
            this.button_Equals.TabIndex = 15;
            this.button_Equals.Text = "=";
            this.button_Equals.UseVisualStyleBackColor = true;
            this.button_Equals.Click += new System.EventHandler(this.button_Equals_Click);

            // button Clear
            this.button_Clear.Location = new System.Drawing.Point(276, 56);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(60, 126);
            this.button_Clear.TabIndex = 16;
            this.button_Clear.Text = "C";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);

            // Calculator Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 326);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Equals);
            this.Controls.Add(this.button_Divide);
            this.Controls.Add(this.button_Multiply);
            this.Controls.Add(this.button_Subtract);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.textBox_Result);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
