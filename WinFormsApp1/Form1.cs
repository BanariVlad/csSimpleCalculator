using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            currentValue.Text = "";
            prevValue.Text = "";
            operandValue.Text = "";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            AddDigit(zero.Text);
        }
        
        private void one_Click(object sender, EventArgs e)
        {
            AddDigit(one.Text);
        }

        private void two_Click(object sender, EventArgs e)
        {
            AddDigit(two.Text);
        }

        private void three_Click(object sender, EventArgs e)
        {
            AddDigit(three.Text);
        }

        private void four_Click(object sender, EventArgs e)
        {
            AddDigit(four.Text);
        }

        private void five_Click(object sender, EventArgs e)
        {
            AddDigit(five.Text);
        }

        private void six_Click(object sender, EventArgs e)
        {
            AddDigit(six.Text);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            AddDigit(seven.Text);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            AddDigit(eight.Text);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            AddDigit(nine.Text);
        }
        
        private void dot_Click(object sender, EventArgs e)
        {
            AddDigit(dot.Text);
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            operandValue.Text = "";
            currentValue.Text = "";
            prevValue.Text = "";
        }

        private void clearOne_Click(object sender, EventArgs e)
        {
            if (currentValue.Text != "")
            {
                currentValue.Text = currentValue.Text.Remove(currentValue.Text.Length - 1);
            }
        }

        private void changeSign_Click(object sender, EventArgs e)
        {
            currentValue.Text = (Convert.ToDouble(currentValue.Text) * -1).ToString();
        }

        private void division_Click(object sender, EventArgs e)
        {
            AddOperand(division.Text);
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            AddOperand(multiplication.Text);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            AddOperand(minus.Text);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            AddOperand(plus.Text);
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Calculate();
            prevValue.Text = "";
            operandValue.Text = "";
        }
        
        private void AddDigit(string digit)
        {
            if (digit == "." && currentValue.Text.Contains("."))
            {
                return;
            }
            if (currentValue.Text == "Error")
            {
                currentValue.Text = digit;
            } else if (currentValue.Text.Length < 16)
            {
                currentValue.Text += digit;
            }
        }

        private void AddOperand(string operand)
        {
            if (prevValue.Text != "")
            {
                Calculate();
                prevValue.Text = currentValue.Text;
                operandValue.Text = operand;
                currentValue.Text = "";
            } else if (currentValue.Text != "")
            {
                prevValue.Text = currentValue.Text;
                currentValue.Text = "";
                operandValue.Text = operand;
            }
            
        }

        private void Calculate()
        {
            var curVal = Convert.ToDouble(currentValue.Text);
            var prevVal = Convert.ToDouble(prevValue.Text);
            switch (operandValue.Text)
            {
                case "+":
                    currentValue.Text = (curVal + prevVal).ToString();
                    break;
                case "-":
                    currentValue.Text = (prevVal - curVal).ToString();
                    break;
                case "x":
                    currentValue.Text = (prevVal * curVal).ToString();
                    break;
                case "÷":
                    currentValue.Text = curVal != 0 ? (prevVal * curVal).ToString() : "Error";
                    break;
                default: currentValue.Text = @"Error";
                    break;
            }
        }
    }
}