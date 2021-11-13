using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void addition_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(input1.Text);
            double num2 = Convert.ToDouble(input2.Text);

            double res = num1 + num2;

            output.Text = res.ToString();
        }

        private void substruction_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(input1.Text);
            double num2 = Convert.ToDouble(input2.Text);

            double res = num1 - num2;

            output.Text = res.ToString();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(input1.Text);
            double num2 = Convert.ToDouble(input2.Text);

            double res = num1 * num2;

            output.Text = res.ToString();
        }

        private void division_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(input1.Text);
            double num2 = Convert.ToDouble(input2.Text);

            double res = num1 / num2;

            output.Text = res.ToString();
        }
    }
}
