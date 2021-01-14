using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkaiciuotuvasWinForm
{
    public partial class Calculator : Form
    {
        bool IsEnterSeen = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ScreenTop.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ScreenTop.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ScreenTop.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ScreenTop.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ScreenTop.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ScreenTop.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ScreenTop.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ScreenTop.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ScreenTop.Text += "9";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            ScreenTop.Text += "0";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            //Check if division is possible and add the appropriate symbol
            string topText = ScreenTop.Text;
            int topLen = topText.Length;
            if (topText != "" && topText[topLen - 1] != ' ' && topText[topLen - 1] != '.' && topText[topLen - 1] != '-')
            {
                ScreenTop.Text += " / ";
            }
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            //Check if multiplication is possible and add the appropriate symbol
            string topText = ScreenTop.Text;
            int topLen = topText.Length;
            if (topText != "" && topText[topLen - 1] != ' ' && topText[topLen - 1] != '.' && topText[topLen - 1] != '-')
            {
                ScreenTop.Text += " * ";
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //Check if addition is possible and add the appropriate symbol
            string topText = ScreenTop.Text;
            int topLen = topText.Length;
            if (topText != "" && topText[topLen - 1] != ' ' && topText[topLen - 1] != '.' && topText[topLen - 1] != '-')
            {
                ScreenTop.Text += " + ";
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            //Check if subtraction is possible and add the appropriate symbol
            string topText = ScreenTop.Text;
            int topLen = topText.Length;
            if (topText != "" && topText[topLen - 1] != ' ' && topText[topLen - 1] != '.' && topText[topLen - 1] != '-')
            {
                ScreenTop.Text += " - ";
            }
        }

        private void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            //Check if negative value is possible and add the appropriate symbol
            string topText = ScreenTop.Text;
            int topLen = topText.Length;
            if (topText == "" || topText[topLen - 1] == ' ' && topText[topLen - 1] != '.')
            {
                ScreenTop.Text += "-";
            }
        }

        private void ButtonComma_Click(object sender, EventArgs e)
        {
            //Check if adding comma is possible and add the appropriate symbol
            string topText =  ScreenTop.Text;
            if (topText == "" || topText[topText.Length - 1] == ' ' || topText[topText.Length - 1] == '-')
            {
                ScreenTop.Text += "0.";
            }
            else
            {
                List<string> split = topText.Split(' ').ToList();
                string lastItem = split[split.Count - 1];
                if (!lastItem.Contains('.'))
                {
                    ScreenTop.Text += ".";
                }
            }
        }

        private void Erase_Click(object sender, EventArgs e)
        {
            //Erase button that deletes the last symbol
            string text = ScreenTop.Text;
            if (text.Length > 0)
            {
                ScreenTop.Text = text.Remove(text.Length - 1);
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            //C button that clears all the fields
            ScreenTop.Clear();
            ScreenBottom.Clear();
        }

        private void CE_Click(object sender, EventArgs e)
        {
            //CE button that deletes the last number/symbol (can be a multi-digit number like 25, 36854, etc.)
            List<string> argList = ScreenTop.Text.Split(' ').ToList();
            argList.RemoveAt(argList.Count - 1);
            ScreenTop.Text = String.Join(" ", argList);
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void ButtonEquals_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Unsuccessful attempt to bing "enter" key to always return the answer
            if (e.KeyChar == (char)Keys.Enter)
            {
                Calculate();
            }
        }

        private static string EquationFixer(string input)
        {
            //Checks if the equation is valid (does not end with a symbol or contain a comma instead of dot for doubles)
            if(input.Length > 0)
            {
                char[] Operators = { '+', '-', '*', '/' };
                char lastElement = input[input.Length - 1];
                if (lastElement == ' ' || Operators.Contains(lastElement))
                {
                    input = input.Remove(input.Length - 1);
                    input = Calculator.EquationFixer(input);
                }
                input = input.Replace(',', '.');
                return input;
            }
            return "";
        }

        private void Calculate()
        {
            //Uses DataTable object to create a valid equation from a string
            //Catches errors in case of equation that was not properly pre-prepared and outputs the answer
            DataTable dt = new DataTable();
            string equation = Calculator.EquationFixer(ScreenTop.Text);
            string answer;
            try
            {
                answer = dt.Compute(equation, "").ToString();
            }
            catch (SyntaxErrorException)
            {
                answer = "Wrong input! Try again.";
            }            
            ScreenBottom.Text = answer;
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            //Another unsuccessful attempt at the "enter" key binding
            IsEnterSeen = e.KeyCode == Keys.Enter;
            if(IsEnterSeen)
            {
                Calculate();
            }
        }
    }
}
