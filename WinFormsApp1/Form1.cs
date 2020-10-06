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
            if (currentValue.Text == @"Error")
            {
                clearAll_Click(sender, e);
            } else if (currentValue.Text != "")
            {
                currentValue.Text = currentValue.Text.Remove(currentValue.Text.Length - 1);
            }
        }

        private void changeSign_Click(object sender, EventArgs e)
        {
            if (currentValue.Text != "" && currentValue.Text != @"," && currentValue.Text != @"Error")
            {
                currentValue.Text = (Convert.ToDouble(currentValue.Text) * -1).ToString();
            }
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
            var valid = currentValue.Text != "" && currentValue.Text != @"," && currentValue.Text != @"Error" &&
                        prevValue.Text != "";
            if (!valid) return;

            Calculate();
            prevValue.Text = "";
            operandValue.Text = "";
        }

        private void AddDigit(string digit)
        {
            if (!Validate(digit)) return;

            if (currentValue.Text == @"Error")
            {
                currentValue.Text = digit;
            }
            else if (currentValue.Text.Length < 16)
            {
                currentValue.Text += digit;
            }
        }

        private void AddOperand(string operand)
        {
            if (prevValue.Text != "" && currentValue.Text == "")
            {
                operandValue.Text = operand;
            }
            else if (prevValue.Text != "" && currentValue.Text != @",")
            {
                Calculate();
                prevValue.Text = currentValue.Text;
                operandValue.Text = operand;
                currentValue.Text = "";
            }
            else if (currentValue.Text != "" && currentValue.Text != @"Error" && currentValue.Text != @",")
            {
                prevValue.Text = currentValue.Text;
                currentValue.Text = "";
                operandValue.Text = operand;
            }
        }

        private bool Validate(string value)
        {
            if (prevValue.Text == @"Error")
            {
                currentValue.Text = @"Error";
                prevValue.Text = "";
                operandValue.Text = "";
                return false;
            }
            if (value == "," && currentValue.Text.Contains(",") || value != @"," && currentValue.Text == @"0")
            {
                return false;
            }

            return true;
        }


        private void Calculate()
        {
            
            var curVal = Convert.ToDouble(currentValue.Text);
            var prevVal = Convert.ToDouble(prevValue.Text);
            currentValue.Text = operandValue.Text switch
            {
                "+" => (curVal + prevVal).ToString(),
                "-" => (prevVal - curVal).ToString(),
                "x" => (prevVal * curVal).ToString(),
                "÷" => curVal != 0 ? (prevVal / curVal).ToString() : "Error",
                _ => @"Error"
            };
        }
    }
}