using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardCalculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operator;
        double SecondNumber;
        double Result;
        public Form1()
        {
            InitializeComponent();
        }

       private void ButtonNum_click(object sender, EventArgs e)
        {
        Button btn=(Button)sender;
            if (Result_Box.Text == "0")
                Result_Box.Text = btn.Text;
            else
                Result_Box.Text+=btn.Text;
        }

        private void Operator_click(object sender, EventArgs e)
        {
            FirstNumber = double.Parse(Result_Box.Text);
            Result_Box.Text = "0";
            Operator = "+";

        }

        private void Equal_click(object sender, EventArgs e)
        {
            SecondNumber = double.Parse(Result_Box.Text);
            if (Operator == "+")
            {
                Result = FirstNumber + SecondNumber;
                Result_Box.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }
    }
}


