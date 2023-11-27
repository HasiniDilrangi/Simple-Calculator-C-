using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool is0operationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")||(is0operationPerformed))
                textBox1.Clear();
            is0operationPerformed = false;
            Button button = (Button)sender;
            if (button.Text==".")
            {
                if(!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;

            } else
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if(resultValue!=0)
            {
                button17.PerformClick();
                operationPerformed = button.Text;
                labelcurrentoperation.Text = resultValue + " " + operationPerformed;
                is0operationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                labelcurrentoperation.Text = resultValue + " " + operationPerformed;
                is0operationPerformed = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox1.Text);
            labelcurrentoperation.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       private void braket_operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }
        private void Button_backSpace(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        
    }
}

