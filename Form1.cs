using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator_Elijah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += "1";
        }

        // 2
        private void button2_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += "2";
        }

        // 3
        private void button3_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += "3";
        }

        // 4
        private void button4_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += "4";
        }

        // 5
        private void button5_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += "5";
        }

        // 6
        private void button6_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += "6";
        }

        // 7
        private void button7_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += "7";
        }

        // 8
        private void button8_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += "8";
        }

        // 9
        private void button9_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += "9";
        }

        // 0
        private void button0_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += "0";
        }

        // +
        private void Add_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += "+";
        }

        // -
        private void Subtract_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += "-";
        }

        // *
        private void Multiply_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += "*";
        }

        // /
        private void Divide_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += "/";
        }

        // =
        private void Equals_Click(object sender, EventArgs e)
        {
            try
            {
                string equation = result.Text;

                object answer = new DataTable().Compute(equation, null);

                result.Text = answer.ToString();
            }
            catch
            {
                result.Text = "Error";
            }
        }

        // Clear
        private void Clear_Click(object sender, EventArgs e)
        {
            result.Text = "";
        }

        // Decimal
        private void Decimal_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error")
                result.Text = "";

            result.Text += ".";
        }
    }
}