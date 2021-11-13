namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addition = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.substruction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addition
            // 
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.addition.Location = new System.Drawing.Point(37, 180);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(80, 50);
            this.addition.TabIndex = 0;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.division.Location = new System.Drawing.Point(456, 180);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(80, 50);
            this.division.TabIndex = 1;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // substruction
            // 
            this.substruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.substruction.Location = new System.Drawing.Point(175, 180);
            this.substruction.Name = "substruction";
            this.substruction.Size = new System.Drawing.Size(80, 50);
            this.substruction.TabIndex = 2;
            this.substruction.Text = "-";
            this.substruction.UseVisualStyleBackColor = true;
            this.substruction.Click += new System.EventHandler(this.substruction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.multiplication.Location = new System.Drawing.Point(316, 180);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(80, 50);
            this.multiplication.TabIndex = 3;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.number1.Location = new System.Drawing.Point(44, 32);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(105, 25);
            this.number1.TabIndex = 4;
            this.number1.Text = "Number 1";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.result.Location = new System.Drawing.Point(60, 333);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(73, 25);
            this.result.TabIndex = 5;
            this.result.Text = "Result";
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.number2.Location = new System.Drawing.Point(44, 90);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(105, 25);
            this.number2.TabIndex = 6;
            this.number2.Text = "Number 2";
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.input1.Location = new System.Drawing.Point(175, 32);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 31);
            this.input1.TabIndex = 7;
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.input2.Location = new System.Drawing.Point(175, 90);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 31);
            this.input2.TabIndex = 8;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.output.Location = new System.Drawing.Point(175, 330);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(100, 31);
            this.output.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.substruction);
            this.Controls.Add(this.division);
            this.Controls.Add(this.addition);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button substruction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label number2;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox output;
    }
}

